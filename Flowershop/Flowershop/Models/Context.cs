using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Flowershop
{
   public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Template> Templates { get; set; }

    }
}
