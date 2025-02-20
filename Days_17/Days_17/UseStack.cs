using System;
namespace Days_17
{
	public class UseStack
	{
		public void Call()
		{

			Stack<string> users = new Stack<string>();

            // item add
            //Push(Nesne):Yeni bir nesne eklemek için kullanılır.
            //Bkz.
            //https://medium.com/kodcular/c-y%C4%B1%C4%9F%C4%B1n-y%C4%B1%C4%9F%C4%B1t-stack-kullan%C4%B1m%C4%B1-22c9724eb09d


            users.Push("Ali");
            users.Push("Veli");
            users.Push("Zehra");
            users.Push("Ahmet");
            users.Push("Zeki");

            // remove item - en son item
            //pop(): En Son eklenen nesneyi çıkarıp bütün elemanların tekrar döndürülmesi için kullanılır.
            users.Pop();

            // Copy To - boş diziyi doldurur
            string[] arr = new string[users.Count];
            users.CopyTo(arr, 0);
            Console.WriteLine(arr[0]);
            Console.WriteLine("-----------------");

            foreach (string item in users)
            {
                Console.WriteLine(item);
            }

        }
	}
}

