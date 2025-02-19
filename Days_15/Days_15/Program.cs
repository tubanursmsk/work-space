using Days_15.car_fabric;
using Days_15.properties;

namespace Days_15
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // 100 - 200 - 300
            Person person = new Person(200);
            Console.WriteLine(person.GetName());
            Console.WriteLine(person.GetTotal());


            Console.WriteLine("=================================");
            /* Merdeces merdeces = new Merdeces();
               Console.WriteLine(mercedes.name());
               Console.WriteLine(mercedes.price());
               Console.WriteLine(mercedes.color());
               Console.WriteLine(mercedes.move());

            Bmw bmw = new Bmw();
               Console.WriteLine(bmv.name());
               Console.WriteLine(bmv.price());
               Console.WriteLine(bmv.color());
               Console.WriteLine(bmv.move());

            Togg togg = new Togg();
               Console.WriteLine(togg.name());
               Console.WriteLine(togg.price());
               Console.WriteLine(togg.color());
               Console.WriteLine(togg.move()); */

            // yukardaki uzun kod kümesi yerine aşağıdaki yazım daha yalın ve kullanışlı oldu
            // car sınıfında Report() metodu kurduk ve miras yöntemi ile tek tek mercedes bmv
            // ve togg sınıflarını tetikledi..

            Merdeces merdeces = new Merdeces();
            Bmw bmw = new Bmw();
            Togg togg = new Togg();

            merdeces.Report();
            bmw.Report();
            togg.Report();

            Console.WriteLine("================================");
            ProductModel p1;// *** struct da böyle bir durum yok
            p1.pid = 100;
            p1.title = "TV";
            p1.detail = "TV Detail";
            p1.price = 30000;

            Console.WriteLine("===================");
            Product pr1 = new Product();// properties de new anahtar kelimesine(kurucu metod)
                                        // gitmek zorunludur ***
            pr1.pid = 10;
            pr1.title = "su";
            Console.WriteLine(pr1.pid);

        }

    }
}