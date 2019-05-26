using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowershop.Classes
{
    public class Admin
    {
        public string login = "admin";
        public string password = "admin";
        public static Admin admin;
        public static Admin GetInstance()
        {
          
                if (admin == null)
                    admin = new Admin();
                return admin;
            
        }
    }
}
