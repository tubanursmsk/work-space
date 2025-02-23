using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_17
{
    public class UseSortedSet
    {
        public void Call()
        {
            SortedSet<string> sortedSet = new SortedSet<string>();

            // eleman nasıl eklenir?
            // item nasıl olmalıdır?
            // add item

            sortedSet.Add("Erkan");
            sortedSet.Add("Erkan");
            sortedSet.Add("Erkan");
            sortedSet.Add("Ali");
            sortedSet.Add("Ali");
            sortedSet.Add("Zehra");
            sortedSet.Add("Serkan");
            sortedSet.Add("Ayşe");
            sortedSet.Add("Ayşe");
            sortedSet.Add("Ayşe");

            foreach (string item in sortedSet)
            {
                Console.WriteLine(item); //isimleri karışık yazmamıza rağmen konsolda alfabetik
                                         //sıraya göre sıralayıp çıktı verdi
            }

            Console.WriteLine("--------------------------------");

            SortedSet<int> ints = new SortedSet<int>();

            ints.Add(13);
            ints.Add(-1);
            ints.Add(2);
            ints.Add(0);
            ints.Add(22);
            ints.Add(0);
            ints.Add(-99);
            ints.Add(99);
            ints.Add(10);
            ints.Add(13);
            ints.Add(13);
            ints.Add(0);

            foreach (int item in ints)
            {
                Console.WriteLine(item);   
            }
            Console.WriteLine("---------------------------------------------");

            foreach (int item in ints.Reverse())//büyükten küçüğe yazdırır
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------");
            if (ints.Count > 0)
            {
                for (int i = ints.Count - 1; i > 0; i--)//büyükten küçüğe yazdırmada başka bir yöntem
            {
                Console.WriteLine(ints.ElementAt(i));
            }
            }
            






        }
    }
}
