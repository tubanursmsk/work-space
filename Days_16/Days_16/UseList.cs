using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_16.Models;

namespace Days_16
{
    public class UseList
    {
        public void Call()
        {
            //List
            // 1-Belirili bir tür için çalışmasını istediğimiz koleksiyonlardır
            // 2-generic - farklı türlerin bir sınıfa aktarılarak o sınıf
            // içindeki metodların hangi tür için çalışması gerektiğine karar verir.

            /* arraylist ve list farkı
            https://kancerezeroglu.wordpress.com/2016/05/02/list-arraylist-array-arasindaki-fark-nedir/
            https://www.reitix.com/merak/c-ile-list-kullanimi-ve-ornekleri/b6ea4f73
            https://www.reitix.com/merak/c-list-arraylist-ve-dizi-arasindaki-farklar-nelerdir/1fc3583e
            https://www.reitix.com/merak/c-arraylist-kullanimi-ve-ornekleri/975a52b0
            */


            List<string> ls = new List<string>();
            ls.Add("Ali");
            ls.Add("Kemal");
            ls.Add("Ayşe");
            ls.Add("Zehra");



            // to array ile mutable olan yapıyı immutable ye dönüşümünü sağlar
            string[] arr = ls.ToArray<string>(); // ToArray metoduna generic typtan string ekledik


            for (; ; )
            {
                Console.WriteLine("lütfen bir isim giriniz, kapatmak için x");
                string name = Console.ReadLine();
                if (name.Equals("X"))
                {
                    break;
                }
                ls.Add(name);
            }


            foreach (string item in ls)
            {
                Console.WriteLine(ls);
            }

            Console.WriteLine("================");
            List<Product> products = new List<Product>();//  List<Product>  --> listin türü product demek

            Product p1;
            p1.title = "iPad";
            p1.detail = "iPad Detail";
            p1.price = 3000;
            p1.status = true;
            
            // runtime
            //ürün ekleme 
            // itenen ürünün silinmesi
            products.Add(p1);
            

            for (; ; )
            {
                Product p;
                Console.WriteLine("Title giriniz");
                p.title = Console.ReadLine();

                Console.WriteLine("Detail giriniz");
                p.detail = Console.ReadLine();

                Console.WriteLine("Price giriniz");
                p.price = Convert.ToInt32(Console.ReadLine());
                
                p.status = true;
                products.Add(p);

                Console.WriteLine("Durdurmak için x giriniz");
                string status = Console.ReadLine();
                if (status.Equals("X"))
                {
                    break;

                }
                    
            }

            Console.WriteLine("===================================");
            // ÖDEV: kullanıcıdan index değeri iste bu indexin var olup olmadığını kıyasla
            // eğer silinmek istenen index yoksa uyarı ver.

            Console.WriteLine("Silme için 'X'");
            string deleteStatus = Console.ReadLine();
            if (deleteStatus.Equals("X"))
            {
                for (; ; )
                {
                    Console.WriteLine($"Silmek istediğiniz sırayı giriniz, 1 - {products.Count}");
                    string stIndex = Console.ReadLine();
                    try
                    {
                        int index = Convert.ToInt32(stIndex);
                        if (index > 0)
                        {
                            index = index - 1;
                            if (index < products.Count) // max. productsın son veri sayısı kadar değer yaz sınırlama getirdik
                            {
                                products.RemoveAt(index);
                                Console.WriteLine("Silme işlemi devam etsin mi?, 'D'");
                                string delete = Console.ReadLine();
                                if (!delete.Equals("D"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Silmek istediğiniz ürün bulunumadı!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lüfen sadece pozitif değerler giriniz!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lütfen sadece sayısal değer giriniz!");
                    }
                }
            }

           


            Console.WriteLine("=====================================");

            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }



            }
    }
}
