using System;
using Days_16.models;

namespace Days_17
{
    //HashSet, benzersiz değerlerin koleksiyonunu temsil eden bir veri yapısıdır.
    //HashSet, bir değeri sadece bir kez saklar ve aynı değeri birden fazla kez
    //eklemeye izin vermez. HashSet yapısı, verilerin benzersiz olması gerektiği
    //senaryolarda kullanılır.
    //https://medium.com/@Kolay.Zeka/c-dilinde-dictionary-ve-hashset-kullan%C4%B1m%C4%B1-ve-farklar%C4%B1-4048d7d5e#:~:text=HashSet%2C%20benzersiz%20de%C4%9Ferlerin%20koleksiyonunu%20temsil,benzersiz%20olmas%C4%B1%20gerekti%C4%9Fi%20senaryolarda%20kullan%C4%B1l%C4%B1r.
   
    public class UseHashSet
	{
		public void Call()
		{

			HashSet<string> cities = new HashSet<string>();

            // add item
            cities.Add("Antalya");
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("İstanbul");
            cities.Add("İstanbul");
            cities.Add("İzmir");
            cities.Add("Adana");
            cities.Add("Ankara");
            cities.Add("Samsun");
            

            foreach(string item in cities)
            {
                Console.WriteLine(item);//konsolda hashset sayesinde her şehirden bir adet aldı
            }

            Console.WriteLine("-----------------");
            HashSet<Product> products = new HashSet<Product>();

            Product p1 = new Product("TV", "Tv Detail", 34555);
            Product p2 = new Product("Tablet", "Tablet Detail", 765432);
            Product p3 = new Product("iPad", "iPad Detail", 234567);
            Product p4 = new Product("iPadx", "iPad Detail", 234567);
            //struct yapıları yapının içindeki değerin farklılığına göre hash kod üretirler. yine bir başka durum da p4 den 
            //**Product p4 = new Product("iPadx", "iPad Detail", 234567); **1000 tane yazssak bile
            //aynı veri türü old. için bellekte 1000 tane p4 değil bir tane p4 yer kaplar..

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            Console.WriteLine(p4.GetHashCode());

            products.Add(p1);
            products.Add(p1);
            products.Add(p1);
            products.Add(p2);
            products.Add(p2);
            products.Add(p3);
            products.Add(p3);
            products.Add(p3);
            products.Add(p3);
            products.Add(p4);
            products.Add(p4);

            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");
            User u1 = new User("Ali", "Bilmem", "ali@mail.com", "12345");
            User u2 = new User("Veli", "Bil", "veli@mail.com", "12345");
            User u3 = new User("Zehra", "Bilirim", "zehra@mail.com", "12345");//***
            User u4 = new User("Zehrax", "Bilirim", "zehra@mail.com", "12345");//***

            Console.WriteLine(u1.GetHashCode());// struck içindeki atribute elemanlarının farklı olması farklı bir hash koda
                                                // götürürken aynı olması aynı hash koda götürüyordu. get ve set metodları
                                                // kullanıldığında ise durum farklılaşır. *** user zehra'nın u3 ve u4'de değeri
                                                // birebir aynı olmasına rağmen hash kodu farklı çıkar.

            Console.WriteLine(u2.GetHashCode());
            Console.WriteLine(u3.GetHashCode());
            Console.WriteLine(u4.GetHashCode());

            HashSet<User> users = new HashSet<User>(); //yine hashsette de aynı değerlerin kopyasını sunar

            users.Add(u1);
            users.Add(u1);
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u3);
            users.Add(u4);
            users.Add(u4);
            users.Add(u4);

            foreach(User item in users)
            {
                Console.WriteLine(item);
            }
        }
	}
}

