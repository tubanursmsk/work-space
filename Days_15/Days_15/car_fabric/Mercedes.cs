using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_15.car_fabric
{
    public class Merdeces : Car
    {
        public override string Fuel()
        {
            return "Oil";
        }

        public override int Price()
        {
            return 4000000;
        }

        public override string Color()
        {
            return "Black";
        }

        public override string Name()
        {
            return "Mercedes";
        }
    }
}

