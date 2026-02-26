using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_5
{
    public class Daire
    {
        public double DaireAlan(double yaricap)
        {
            return Math.PI * yaricap * yaricap;
        }

        public double DaireCevre(double yaricap)
        {
            return 2 * Math.PI * yaricap;
        }

    }
}
