using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_7
{
    internal class Araba
    {
        //6.Nesne Üretimi: Bir "Araba" sınıfı oluşturun ve bu sınıftan birkaç nesne üretip
        //içerisindeki bir metottan geriye dönen string ifadeyi ekrana yazdıran bir program yazın. 
        public string Marka;
        public string Model;
        public int Yil;

        // Metot: Geriye string döndüren fonksiyon
        public string BilgiYazdir()
        {
            return $"Araba Bilgisi: {Yil} model {Marka} {Model}.";
        }

        
    }

}
    

