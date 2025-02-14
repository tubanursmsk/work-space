using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_14.models;

namespace Days_14.users
{
    public interface IUser 
        
        // interface yazılımın tasarımıdır ve bu kurguyu yazılım mimarisi tasarlar. 
        // yani belli başlı metodları kurar alt birimdeki yazılımcılar bu interface'i implement
        // (interface den etrkilenen yer) eder.
        // proje başlamadan önce interface kararlaştırılır. Bu da dökümantasyonda kolaylıktır.
    {
        // interfaceler, nesne olarak üretilemezler.
        //Burada gövdeli metod yazılamaz. 
        // bir sınıfa mutlaka implement (yerine getirmek, uygulamak yazılım jargonunda olarak gövdelendirmek)
        // edilmedilidir.
        // sınıflar birden fazla interface alabilir (bkz.--> UserService.cs 11. kod satırı)



        public bool UserRegister(UserModel userModel);
        public UserModel? UserLogin(string email, string password);
        public string UserName(int uid);

        public void UserRegister(int uid);
        public UserModel UserUpdate(UserModel userModel ); // UserModel içinde tekrar UserModel neden gönderdik??
                 //eski UseModel dataları gelir bunları günceller ile değiştirir userModel üzerinde güncelleme yapıp
                 //tekrar gönderiyoruz. uptade uygulamalarında genel kullanım.








    }

}
