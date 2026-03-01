using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_7
{
    public class Action
    {

        int age = 30;

        // bir fonksiyon parametresiz olabilir ..
        // parametreli ..
        // return'lü ..
        // return'süz ..

        // public -> master seviyesi dahil her yerden görün
        // internal -> modül seviyesinde görünme
        // private -> sadece mevcut class içinde görünme yeteneği

        // void -> fonksiyondan geri dönşün olmadığı durumda kullanılır.
        // return -> geriye dönecek yanıtın türünü ifade eder

        public void NoParams()
        {
            // fonksiyon tetiklenldiğinde çalışacak gövde
            string name = "Ali Bilmem";
            Console.WriteLine(name);
        }

        public void Params(string title, int price)
        {
            // string joinSt = title + " - " + price;
            price = price - ((price * 10) / 100); // %10 indirim yapıldı
            string join = $"{title} - {price}";
            Console.WriteLine(join);
        }

        public int sum(int num1, int num2)
        {
            int sm = num1 + num2;
            return sm;
        }

        public bool UserNamePasswordLogin(string username, string password)
        {
            bool status = false;
            if (username.Equals("kemal01") && password.Equals("12345"))
            {
                status = true;
            }
            return status;

            //console.WriteLine("Login status: " + status); // bu kod çalışmaz çünkü return'den sonra kalan kodlar çalışmaz. bu işlemi program.cs dosyasında yapmak daha sağlıklı olur. çünkü fonksiyonun tek bir görevi olması daha iyi olur. bu fonksiyonun görevi kullanıcı adı ve şifre kontrolü yapmak ve sonucu döndürmek olsun. login işlemiyle ilgili diğer işlemler program.cs dosyasında yapılabilir.
        }


    }
}
