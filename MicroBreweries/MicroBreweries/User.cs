using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBreweries
{
    class User : IUpdateable<User>
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Rating> Ratings { get; set; }
        public int ID { get; set; }
        public User()
        {

        }

        public void AddRating(Rating rating)
        {
            Ratings.Add(rating);
        }

        public void Update(User newInstance)
        {
            this.Name = newInstance.Name;
            this.Password = newInstance.Password;
            this.Ratings = newInstance.Ratings;
        }
    }
}
