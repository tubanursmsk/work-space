using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev_6.Vehicle;

namespace Odev_6.Vehicle
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Bike bike = new Bike();

            car.StartEngine();
            car.StopEngine();

            bike.StartEngine();
            bike.StopEngine();
            
        }
    }
}
