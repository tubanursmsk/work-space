using System;
using System.Reflection;
using System.Security.Claims;
namespace Days_5;
class Program
{
    static void Main(string[] args)
    {

        // nesne üretimi
        Users users = new Users();
        // "." -> ile nesne içindeki özellikler kullanıma uygun olur.

        users.UserNameWrite();

        users.UserNameConcatSurname("Zehra", "Bilirim");
        users.UserNameConcatSurname("Ali", "Bilmem");

        users.UserLogin("ali@mail.com", "12345");

        int sm = users.Sum(100, 555);
        Console.WriteLine($"Sum: {sm}");

        // dizideki her bir elemanın başına şehir plakasını ekle
        string[] cities = { "İstanbul", "Ankara", "Adana", "İzmir" };
        string[] plakas = { "34", "06", "01", "35" };
        cities = users.CitiesPlaka(cities, plakas);
        foreach (string item in cities)
        {
            Console.WriteLine(item);
        }


        int stSum = users.StringConvertSum("25", "77");
        if (stSum > 50)
        {
            Console.WriteLine("stSum > 50");
        }
        else
        {
            Console.WriteLine("stSum < 50");
        }

        Action action = new Action();
        users.ComputerCall("Macbook Pro", 50, action);

        users.call();
        users.call("Merhaba");
        users.call(100);


        Console.WriteLine("------Alıştırmlar-------");

        //1. soru
        CalculadeMachine cal = new CalculadeMachine();

        Console.WriteLine("birinci sayıyı giriniz:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ikinci sayıyı giriniz:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        /*
        // tüm işlemler için
        Console.WriteLine("--- İşlem Sonuçları ---");
        // Toplama işlemi
        int toplamaSonuc = cal.Topla(num1, num2);
        Console.WriteLine("Toplama: " + toplamaSonuc);

        // Çıkarma işlemi
        int cikarmaSonuc = cal.Cikar(num1, num2);
        Console.WriteLine("Çıkarma: " + cikarmaSonuc);

        // Çarpma işlemi
        int carpmaSonuc = cal.Carp(num1, num2);
        Console.WriteLine("Çarpma: " + carpmaSonuc);

        // Bölme işlemi
        double bolmeSonuc = cal.Bol(num1, num2);
        Console.WriteLine("Bölme: " + bolmeSonuc);
        */
        
        // tam olarak hesap makinesi mantığı)

    Console.WriteLine("işlem türünü giriniz: (topla, çıkart, çarp, böl)");
    string islem = Console.ReadLine();

    double sonuc = 0;

        // Kullanıcının girdiği metne göre karar veriyoruz
        switch (islem.ToLower())
        {
            case "topla":
                sonuc = cal.Topla(num1, num2);
                Console.WriteLine($"Sonuç: {sonuc}");
                break;

            case "cikar":
                sonuc = cal.Cikar(num1, num2);
                Console.WriteLine($"Sonuç: {sonuc}");
                break;

            case "carp":
                sonuc = cal.Carp(num1, num2);
                Console.WriteLine($"Sonuç: {sonuc}");
                break;

            case "bol":
                sonuc = cal.Bol(num1, num2);
                // Bölme işleminde hata kontrolünü zaten class içinde yapmıştın
                if (!double.IsNaN(sonuc))
                {
                    Console.WriteLine($"Sonuç: {sonuc}");
                }
                break;

            default:
                Console.WriteLine("Geçersiz bir işlem türü girdiniz!");
                break;
        }


        //2. soru
        AlanHesaplama alan = new AlanHesaplama();

        Console.WriteLine("birinci sayıyı giriniz:");
        int uzunluk = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ikinci sayıyı giriniz:");
        int genislik = Convert.ToInt32(Console.ReadLine());

        int Alan = alan.AlanHesapla(uzunluk, genislik);
        Console.WriteLine($"Dikdörtgen Alanı: {Alan}");


        //3. soru
        Kare kare = new Kare();

        Console.WriteLine("Karenin kenar uzunluğunu giriniz:");
        int kenar = Convert.ToInt32(Console.ReadLine());

        int kareAlan = kare.KareAlan(kenar);
        Console.WriteLine($"Karenin Alanı: {kareAlan}");
        int kareCevre = kare.KareCevre(kenar);
        Console.WriteLine($"Karenin Çevresi: {kareCevre}");


        //4. soru
        Daire daire = new Daire();

        Console.WriteLine("Dairenin yarıçapını giriniz:");
        double yaricap = Convert.ToInt32(Console.ReadLine());
        
        double daireAlan = daire.DaireAlan(yaricap);
        Console.WriteLine($"Dairenin Alanı: {daireAlan}");
        double daireCevre = daire.DaireCevre(yaricap);
        Console.WriteLine($"Dairenin Çevresi: {daireCevre}");


        //5. soru
        Ogrenci ogrenci = new Ogrenci();

        ogrenci.OgrenciAdSoyad("Ali", "Bil");
        ogrenci.OgrenciYas(20);

        Console.WriteLine("Fizik notunuzu giriniz:");
        double fzk = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Kimya notunuzu giriniz:");
        double kmy = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Matematik notunuzu giriniz:");
        double mat = Convert.ToInt32(Console.ReadLine());

        ogrenci.NotlariKaydet(fzk, kmy, mat); //notları metoda göndererek öğrenci nesnesinin içine kayıtlıyoruz

        double ortalama = ogrenci.OrtalamaHesapla();
        Console.WriteLine($"Dönem Sonu Not Ortalamanız: {ortalama}");
        if (ortalama >= 65)
        {
            Console.WriteLine("Tebrikler, geçtiniz!");
        }
        else
        {
            Console.WriteLine("Maalesef, kaldınız.");
        }


        //6. soru

        Console.WriteLine("Faktoriyelini hesaplamak istediğiniz sayıyı giriniz:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        int faktoriyel = 1;
        for (int i = 1; i <= sayi1; i++)
        {
            faktoriyel *= i; // 5! için hesap mantığı --->  1*2 =2  2*3=6  6*4=24  24*5=120
        }
        Console.WriteLine(faktoriyel);


        // 7. Soru ---> Fibonacci
        Console.WriteLine("Kaçıncı Fibonacci sayısını görmek istersiniz?");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0; // önceki değer
        int b = 1; // şimdiki değer
        int fibonnaciSonuc = 0;

        if (n == 0) fibonnaciSonuc = 0; 
        else if (n == 1) fibonnaciSonuc = 1;
        else
        {
            for (int i = 2; i <= n; i++)
            {
                fibonnaciSonuc = a + b;
                a = b;         
                b = fibonnaciSonuc;     
            }
        }

        Console.WriteLine($"{n}. Fibonacci sayısı: {fibonnaciSonuc}");



        //8.Soru
        Console.WriteLine("Bir sayı giriniz?");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        if (sayi2 < 2)
        {

            Console.WriteLine("Asal sayı 2'den büyük olmalıdır.");
        }
        else
        {
            bool asalSayi = true;
            for (int i = 2; i <= Math.Sqrt(sayi2); i++) // sayının kareköküne kadar olan sayılarla bölünebilirliğini kontrol ediyoruz. Çünkü bir sayının asal olup olmadığını kontrol etmek için, o sayının kareköküne kadar olan sayılarla bölünebilirliğini kontrol etmek yeterlidir. sqrt burada karekök alma işlemi yapar. Örneğin, 29 sayısının karekökü yaklaşık 5.39'dur, bu nedenle 2, 3, 4 ve 5 gibi sayılarla bölünebilirliğini kontrol etmek yeterlidir. Eğer 29 bu sayılardan herhangi biriyle tam bölünüyorsa, asal değildir. Ancak 29 hiçbirisiyle tam bölünmüyorsa, asal bir sayıdır. Bu yöntem, asal sayı kontrolünü daha verimli hale getirir çünkü gereksiz bölme işlemlerini azaltır.
            {
                if (sayi2 % i == 0)
                {
                    asalSayi = false;
                    break;
                }
            }
            if (asalSayi)
            {
                Console.WriteLine($"{sayi2} bir asal sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi2} bir asal sayı değildir.");
            }

        }


        //9.Soru: B+r EnBuyukOrtakBolen fonks+yonu yazın. Bu fonks+yon, ver+len +k+ sayının en büyük ortak bölen+n+ hesaplasın.
        Console.WriteLine("Bir sayı giriniz?");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bir sayı daha giriniz?");
        int sayi4 = Convert.ToInt32(Console.ReadLine());

        int ebob = 1; // En büyük ortak bölen

        for (int i = 1; i <= Math.Min(sayi3, sayi4); i++) // iki sayıdan küçük olanına kadar olan sayılarla bölünebilirliğini kontrol ediyoruz.
        {
            if (sayi3 % i == 0 && sayi4 % i == 0) // her iki sayı da i'ye tam bölünüyorsa
            {
                ebob = i; // ebob'u güncelliyoruz
            }
        }
        Console.WriteLine($"En büyük ortak bölen: {ebob}");


        //10. soru 
        int[] sayilar = { 5, 2, 9, 1, 5, 6 };
        users.KucuktenBuyugeSirala(sayilar);


    }
}


