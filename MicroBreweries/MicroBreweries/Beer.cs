using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBreweries
{
    class Beer
    {
        
        /// <summary>
        /// Class for handling individual beers.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="alcoholPercentage"></param>
        /// <param name="id"></param>
        /// <param name="price"></param>
        /// <param name="volume"></param>
        public Beer(string name, string description, double alcoholPercentage, int id, double price, double volume)
        {
            Name = name;
            Description = description;
            AlcoholPercentage = alcoholPercentage;
            Id = id;
            Price = price;
            Volume = volume;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double AlcoholPercentage { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public double Volume { get; set; }
    }
}
