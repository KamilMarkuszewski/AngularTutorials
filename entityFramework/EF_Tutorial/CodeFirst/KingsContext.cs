using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Models;

namespace CodeFirst
{
    public class KingsContext : DbContext
    {
        public KingsContext() : base()
        {

        }

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Slave> Slaves { get; set; }
    }
}
