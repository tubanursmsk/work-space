using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_15.car_fabric
    //abstract ile virtual arasındaki fark nedir?
    //abst. da ister istemez override zorunludur.
    //virtual de ise isteğe bağlı ezilir.
    //virtualde ki metodların hepsini ezersek abst. ile
    //aynı sonuca varırız. abstr. hata yapma oranını minimize eder.
{
    public abstract class Car
    {
        public abstract string Name();
        public abstract int Price();
        public abstract string Fuel();

        public virtual string Color()
        {
            return "White";
        }

        public string Move()
        {
            return "Move Call";
        }

        public void Report()
        {
            Console.WriteLine($"{Name()} - {Fuel()} - {Price()} - {Color()} - {Move()}");
        }

    }
}
