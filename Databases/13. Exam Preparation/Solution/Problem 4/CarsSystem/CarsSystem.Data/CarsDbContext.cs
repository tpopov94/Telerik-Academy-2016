using CarsSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Data
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext()
            :base("CarsSystemDb")
        {
        }

        public virtual IDbSet<Car> Cars { get; set; }

        public virtual IDbSet<City> Cities { get; set; }

        public virtual IDbSet<Dealer> Dealers { get; set; }

        public virtual IDbSet<Manufacturer> Manufacturers { get; set; }
    }
}
