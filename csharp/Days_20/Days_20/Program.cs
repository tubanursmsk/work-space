using System;
using MongoDB.Bson;
using MongoDB.Driver;
using Days_20.Models;
using Days_20.Services;

namespace Days_20
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonServices personServices = new();
            Console.WriteLine("$MongoDb Person Service {ObjectId.GenerateNewId()}");
            Person p1 = new ()
            {
                Name = "Zehra",
                Surname = "Bilsin",
                Email = "zehra@mail.com",
                Age = 28,
                Color = "Blue"
            };
            int p1Save = personServices.AddPerson(p1);
            Console.WriteLine($"Save Status: {p1Save}");
            
        }
    }
}