using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_17.Models;
using System.Xml.Linq;

namespace Days_17
{
    public class UseLinkedList
    {
        public void Call()
        {
            LinkedList<User> users = new LinkedList<User>();

            User u1 = new User("Ali", "Bilmem", "ali@mail.com", "12345");
            User u2 = new User("Veli", "Bil", "veli@mail.com", "12345");
            User u3 = new User("Zehra", "Bilirim", "zehra@mail.com", "12345");
            User u4 = new User("Ayşe", "Bilsin", "ayse@mail.com", "12345");

           

            users.AddFirst(u1);
            users.AddAfter(users.First,u3);
            users.AddBefore(users.Last, u2);
            users.AddLast(u4);// normalde ayşe en başta iken addlast ile sona çekildi


            foreach (User item in users)
            {
                Console.WriteLine(item);
            }

        }

    }
}
