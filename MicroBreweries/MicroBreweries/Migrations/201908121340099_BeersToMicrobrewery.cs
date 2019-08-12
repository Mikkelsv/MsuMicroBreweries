namespace MicroBreweries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BeersToMicrobrewery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        AlcoholPercentage = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Volume = c.Double(nullable: false),
                        MicroBrewery_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MicroBreweries", t => t.MicroBrewery_ID)
                .Index(t => t.MicroBrewery_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Beers", "MicroBrewery_ID", "dbo.MicroBreweries");
            DropIndex("dbo.Beers", new[] { "MicroBrewery_ID" });
            DropTable("dbo.Beers");
        }
    }
}
