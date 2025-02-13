using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_15
{
    public abstract class Customer()
    {
        public abstract int GetCustomerID();
        public string GetName()
        {
            int customerID = GetCustomerID();
            if (customerID == 100)
            {
                return "Ali Bilmem";
            }
            else if (customerID == 200)
            {
                return "Zehra Bilirim";
            }
                return "";
            
        }


             public int GetTotal()
        {
            int customerID = GetCustomerID();
            if (customerID == 100)
            {
                return 100000000;
            }
            else if (customerID == 200)
            {
                return 200000000;
            }
            return 0;
            
        }





        

    }
}
