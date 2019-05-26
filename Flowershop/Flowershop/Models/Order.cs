using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Flowershop
{
   public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public virtual ICollection<Flower>  Flowers { get; set; }

        public Order()
        {
            Flowers = new List<Flower>();
        }
    }
}
