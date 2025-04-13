using System;
namespace Days_17
{
	public class UseQueue
	{
		public void Call()
		{

			Queue<string> users = new Queue<string>();

            // Add item 
            // Enqueue() Metodu; Parametre olarak girilen öğeyi kuyruğun sonuna eklemektedir.
			users.Enqueue("Ali");
            users.Enqueue("Veli");
            users.Enqueue("Zehra");
            users.Enqueue("Ahmet");
            users.Enqueue("Zeki");

            // Dequeue() Metodu; Kuyruğun başındaki öğeyi döndürür ve sonra öğe kuyruktan
            // çıkarılır/silinir. 
            // first item remove
            users.Dequeue();

			foreach(string item in users)
			{
				Console.WriteLine(item);
			}
        }
	}
}

