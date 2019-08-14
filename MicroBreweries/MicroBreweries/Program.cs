using MicroBreweries.Migrations;
using System;
using System.Collections;
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
                    new MicroBrewery() { Name = "SS-Brewery", Description = "A naughty brewery", Latitude=59.9, Longitude = 10.7, Location="Oslo", Openinghours="07:00-23:30"},
                    new MicroBrewery() { Name = "Ringes", Description = "One Ring to Rule them All", Latitude=59.5922, Longitude = 10.57, Location="Gjelleraasen", Openinghours="07:00-23:30"},
                    new MicroBrewery() { Name = "Hamar Bryggeri", Description="Heia Nissen", Location="Hamar", Openinghours="07:00-23:30"},
                    new MicroBrewery() { Name = "Heineken" , Description ="Best of the Dutches", Location = "Amsterdam", Openinghours="07:00-23:30"},
                    new MicroBrewery() { Name = "Dahls" , Description = "Bra sus", Location="Trondheim", Openinghours="07:00-23:30"}
                };

                var databaseBreweries = (from m in db.microBreweries
                                         select m).ToList();

                foreach (MicroBrewery ib in initialBreweries)
                {
                    bool exists = false;
                    foreach (MicroBrewery m in databaseBreweries)
                    {
                        if (m.Name != ib.Name)
                        {
                            continue;
                        }
                        m.UpdateBrewery(ib);
                        exists = true;
                    }
                    if (!exists)
                        db.microBreweries.Add(ib);
                }
                db.SaveChanges();
            }
        }
    }
}
