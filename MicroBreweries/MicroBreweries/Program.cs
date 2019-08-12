using MicroBreweries.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBreweries
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Configuration>());

            using (var db = new DatabaseContext())
            {
                PopulateDatabase();
                var query = from m in db.microBreweries
                            orderby m.Name
                            select m;

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }
        }

        private static void PopulateDatabase()
        {
            using (var db = new DatabaseContext())
            {
                List<MicroBrewery> initialBreweries = new List<MicroBrewery>()
                {
                    new MicroBrewery() { Name = "myBrewery" },
                    new MicroBrewery() { Name = "Ringes" },
                    new MicroBrewery() { Name = "Hamar Bryggeri" },
                    new MicroBrewery() { Name = "Heineken" },
                    new MicroBrewery() { Name = "Dahls" }
                };

                var databaseQuery = (from m in db.microBreweries
                                    select m.Name).ToList();

                initialBreweries.RemoveAll((x) => databaseQuery.Contains(x.Name));
                foreach (MicroBrewery microBrewery in initialBreweries)
                {
                    db.microBreweries.Add(microBrewery);
                }
                db.SaveChanges();
            }
        }
    }
}
