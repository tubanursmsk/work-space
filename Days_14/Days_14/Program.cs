using System;
using Days_14.models;
using Days_14.services;
using Days_14.users;

namespace Days_14
{
    public class Program
    {
        public static void Main(string[] args)
        {

            UserService userService = new UserService();
            UserModel? userModel = userService.UserLogin("ali@mail.com", "12345"); // neden UserModel'i nullable kıldık??
            
            if (userModel != null)
            {
                Console.WriteLine("Giriş başarılı..");   
            
            }
            else
            {
                Console.WriteLine("Hatalı giriş!");
            }



        }
    }
}