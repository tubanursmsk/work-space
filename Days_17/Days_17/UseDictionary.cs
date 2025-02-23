using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_17
{
    public class UseDictionary
    {
        public void Call()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            //add item
            users.Add("ali", "Ali Bilmem");
            users.Add("ahmet", "Ahmet Bil");
            users.Add("zehra", "Zehra Bilir");
            //users.Add("ali", "Ali Bilsin"); başka dillerde yeni eklenen Ali önceki ali üzerine
            //replace edilirken c# de bu olmaz hata verir

            Console.WriteLine(users["zehra"]);

            Console.WriteLine(users.Count);//3 toplam üç veri var 
                                           //Console.WriteLine(users[0]); 


            Console.WriteLine("-------------------------------------");
            //all keys
            Dictionary<string, string>.KeyCollection userKeys = users.Keys;

            foreach (string key in users.Keys)
            {
                string value = users[key];
                Console.WriteLine($"key {key} - value {value}");
            }

            //Console.WriteLine("kemal"); // olmayan değerin çağrılması sonucu prog. patlar


            Console.WriteLine("-------------------------------------");
            string data = users.GetValueOrDefault("kemal", "");// data yoksa default olarak çalıştır
            Console.WriteLine(data);


            Console.WriteLine("-------------------------------------");
            bool statusKey = users.ContainsKey("kemal");// kemal var mıı?? buna bakar
            Console.WriteLine(statusKey);


            Console.WriteLine("-------------------------------------");
            //delete item
            users.Remove("ali");//siler


            Console.WriteLine("-------------------------------------");
            // all values
            Dictionary<string, string>.ValueCollection values = users.Values;
            foreach (string item in values)
            {
                Console.WriteLine(item);
            }


        }


    }
}
    

