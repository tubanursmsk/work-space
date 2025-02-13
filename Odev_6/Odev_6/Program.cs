using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev_6.AnimalShelter;
using Odev_6.Vehicle;

namespace Odev_6
    {
        public class Program
        {

            public static void Main(string[] args)
            {
                Cat cat = new Cat();
                Dog dog = new Dog();
                Bird bird = new Bird();

                cat.Report();
                dog.Report();
                bird.Report();
            }

        static void Main()
        {
            try
            {
                Employee emp = new Employee("John Doe", 5000);
                emp.DisplayInfo();

                // Geçersiz maaş ataması
                emp.Salary = -1000;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void Main()
        {
            Car1 car1 = new Car1("Togg", 6.5);
            Truck truck = new Truck("Volvo", 30, 10);

            Console.WriteLine($"{car1.Marka} Yakıt Verimliliği: {car1.FuelEfficiency():F2} km/l");
            Console.WriteLine($"{truck.Marka} Yakıt Verimliliği: {truck.FuelEfficiency():F2} km/l");
        }

    }
    }



