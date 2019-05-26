using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Flowershop
{
   public class User
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
      
        public virtual ICollection<Order> All_Orders { get; set; }


        public User()
        {
          
            All_Orders = new List<Order>();
        }
    }
}
