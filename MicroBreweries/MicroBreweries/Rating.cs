using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBreweries
{
    class Rating
    {
        /// <summary>
        /// Class for structuring ratings
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="beerID"></param>
        /// <param name="microBreweryID"></param>
        /// <param name="value"></param>
        public Rating(int ID, int beerID, int microBreweryID, int value)
        {
            this.ID = ID;
            BeerID = beerID;
            MicroBreweryID = microBreweryID;
            Value = value;
        }

        public int ID { get; }
        public int BeerID { get; }
        public int MicroBreweryID { get; }
        public int Value { get; }
    }
}
