using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Flowershop
{
   public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public Color ITColor { get; set; }
      
    }
}
