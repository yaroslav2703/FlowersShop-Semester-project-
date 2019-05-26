using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Flowershop
{
   public class Template
    {
        public int Id { get; set; }
        public virtual ICollection<Flower> TemplateFlower { get; set; }
        public Template()
        {
            TemplateFlower = new List<Flower>();
          
        }
    }
}
