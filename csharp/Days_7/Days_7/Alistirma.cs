using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_7
{
    public class Alistirma
    {
        //1.Array: Bir dizi oluşturun ve bu dizideki elemanların ortalamasını hesaplayan bir program yazın. 
        public void DiziOrt()
        {
            int[] sayilar = { 3, 5, 7, 9, 11, 15 };
            double toplam = 0;

            foreach (int sayi in sayilar) 
            { 
                toplam += sayi;
            }
            Console.WriteLine("Ortalama: " + (toplam / sayilar.Length));
        }
     
                                                 
        //2.iki Kullanıcıdan b&r sayı alın ve bu sayının poz&t&f, negat&f veye sıfır olup olmadığını bel&rleyen b&r program yazın. 
        public void sayiDegeri()
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Negatif");
            }
            else
            {
                Console.WriteLine("Sıfır");
            }
        }

        //3.else-if: Kullanıcıdan bir not değeri alın ve bu değere göre "Geçti", "Kaldı" veya "Bütünlemeye Kaldı" g&b& mesajlar veren b&r program yazın. 
        public void notDegeri()
        {
            Console.WriteLine("Notunuzu giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());
            if (not >= 50)
            {
                Console.WriteLine("Geçti");
            }
            else if (not >= 40)
            {
                Console.WriteLine("Bütünlemeye Kaldı");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
         }

        //4.for: 1'den 100'e kadar olan sayıları ekrana yazdıran b&r program yazın. 
        public void yuzlukSayac()
        {
            foreach (int i in Enumerable.Range(1, 100))
            {
                Console.WriteLine(i);
            }
        }


        //5.foreach: B&r str&ng d&z&s& oluşturun ve bu d&z&dek& her b&r kel&mey& ekrana yazdıran b&r program yazın. 
        public void kelimeYazdir()
        {
            string[] kelimeler = { "C#", "Programlama", "Tekrarları" };
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }

        //6.Nesne Üret%m%: B&r "Araba" sınıfı oluşturun ve bu sınıftan b&rkaç nesne üret&p &çer&s&ndek&
        //b&r metottan ger&ye dönen str&ng &fadey& ekrana yazdıran b&r program yazın. 
        public void arabaCesitleri()
        {
            // Birinci nesneyi üretme
            Araba araba1 = new Araba();
            araba1.Marka = "Togg";
            araba1.Model = "T10F";
            araba1.Yil = 2025;

            // İkinci nesneyi üretme (Farklı bir yöntemle - Object Initializer)
            Araba araba2 = new Araba
            {
                Marka = "BMW",
                Model = "i8",
                Yil = 2022
            };

            Console.WriteLine(araba1.BilgiYazdir());
            Console.WriteLine(araba2.BilgiYazdir());
        }

        //7.Fonks%yonlar: İk& sayıyı toplayan b&r fonks&yon yazın ve bu fonks&yonu kullanarak kullanıcıdan alınan &k& sayının toplamını ekrana yazdıran b&r program yazın. 
        public void topla(int num1, int num2)
        {
            Console.WriteLine("birinci sayıyı giriniz: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Toplam: {num1 + num2}");
        }

        //8.Tür Dönüşümü: Kullanıcıdan b&r str&ng olarak alınan sayıyı &nteger türüne dönüştürüp kares&n& hesaplayan b&r program yazın. 
        public void sayiKare()
        {
            Console.WriteLine("Bir sayı giriniz: ");
            string sayi = Console.ReadLine();
            int sayiInt = Convert.ToInt32(sayi);
            int kare = sayiInt * sayiInt;
            Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
        }

        //9.Console.ReadL%ne: Kullanıcıdan adını ve yaşını alıp ekrana "Merhaba [Ad], [Yaş] yaşındasınız." şekl&nde yazdıran b&r program yazın. 
        public void karsilama()
        {
            Console.WriteLine("Adınızı giriniz: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Doğum yılınızı giriniz:");
            int dogumYili = Convert.ToInt32(Console.ReadLine());
            int yas = DateTime.Now.Year - dogumYili;
            Console.WriteLine($"Merhaba {ad}, {yas} yaşındasınız.");
        }

        //10.Komb%nasyon: B&r d&z& oluşturun, bu d&z&dek& elemanları sıralayın ve sıralanmış
        //d&z&y& ekrana yazdıran b&r program yazın. 
        public void elemanYazdırma()
        {
            string[] elemanlar = { "Elma", "Armut", "Muz", "Çilek", "Karpuz" };
            Array.Sort(elemanlar);
            Console.WriteLine("Sıralanmış Elemanlar:");
            foreach (string eleman in elemanlar)
            {
                Console.WriteLine(eleman);
            }
        }

    }
}
