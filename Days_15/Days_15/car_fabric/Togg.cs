﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_15.car_fabric
{
    public class Togg : Car
    {
        public override string Fuel()
        {
            return "Electric";
        }

        public override int Price()
        {
            return 1950000;
        }

        public override string Color()
        {
            return "Red";
        }

        public override string Name()
        {
            return "Togg";
        }
    }
}

