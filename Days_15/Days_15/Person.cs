using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_15
{
    public class Person : Customer
    {
        public override int GetCustomerID()
        {
            Console.WriteLine("GetCustomerID Call");
            return 200;
        }

        
    
    }
}
