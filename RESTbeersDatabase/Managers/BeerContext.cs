using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTbeersDatabase.Models;

namespace RESTbeersDatabase.Managers
{
    public class BeerContext : DbContext
    {
        public BeerContext(DbContextOptions<BeerContext> options) : base(options)
        {

        }

        public DbSet<Beer> Beers { get; set; }
    }
}
