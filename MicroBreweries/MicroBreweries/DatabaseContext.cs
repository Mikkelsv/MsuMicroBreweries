using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBreweries
{
    class DatabaseContext : DbContext
    {
        public virtual IDbSet<MicroBrewery> microBreweries { get; set; }
        public virtual IDbSet<Beer> beers { get; set; }
        public virtual IDbSet<User> users { get; set; }
        public virtual IDbSet<Rating> rating { get; set; }
    }
}
