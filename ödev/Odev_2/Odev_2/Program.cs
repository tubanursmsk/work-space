/* --------------------------- Ödev – 2 -----------------------------------------------*/

/* 1. Soru: Bir öğrencinin adını, yaşını ve not ortalamasını tutan değişkenler tanımlayın 
         ve bu b%lg%ler% ekrana yazdırın. */

Console.WriteLine("Öğrenci Ad & Soyad:");
            string ogrenciAd = Console.ReadLine();
        
            int ogrenciYas;
            Console.WriteLine("Yaşınızı Giriniz:");
            ogrenciYas = Convert.ToInt32(Console.ReadLine());     

            Console.WriteLine("Vize Notunuzu Giriniz:");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Notu Giriniz:");
            int final = Convert.ToInt32(Console.ReadLine());

            int notOrtalama = Convert.ToInt32((vize * 0.3) + (final * 0.7));
            Console.WriteLine("Öğrenci Bilgileri:");
            Console.WriteLine($"Öğrenci Ad & Soyad:{ogrenciAd}");
            Console.WriteLine($"Öğrenci Yaşı:{ogrenciYas}");
            Console.WriteLine($"Not ortalamanız:{notOrtalama}");



         
            /*2. Soru: Bir dikdörtgenin uzunluğunu ve gen%şl%ğ%n% kullanıcıdan alarak alanını 
            hesaplayan bir program yazın. */

            int yatay;
            Console.WriteLine("Dikdörtgenin alanını hesaplamak için yatay uzunluğunu metre cinsinden giriniz:");
            yatay = Convert.ToInt32(Console.ReadLine());

            int dikey;
            Console.WriteLine("Dikdörtgenin dikey uzunluğunu metre cinsinden giriniz:");
            dikey = Convert.ToInt32(Console.ReadLine());

            int alan = yatay * dikey;
            Console.WriteLine(alan);



            /*3. Soru: Kullanıcıdan alınan b%r str%ng değer% %nteger'a çev%r%p, bu değer% 10 %le 
            çarpan ve sonucu ekrana yazdıran b%r program yazın. */

            Console.WriteLine("Bir sayı giriniz:");
            int stNumber;
            stNumber = Convert.ToInt32(Console.ReadLine());
            int capma = stNumber * 10;
            Console.WriteLine(capma);



/* 4. Soru: Kullanıcıdan alınan b%r double değer% %nteger'a çev%r%p, bu değer% ekrana 
yazdıran b%r program yazın. */


double x = 1234.7;
Console.WriteLine(x);
int a;
a = (int)x;
Console.WriteLine(a);



/* 5. Soru: Kullanıcıdan adını ve doğum yılını alarak, kullanıcının yaşını hesaplayan ve 
 ekrana yazdıran bir program yazın. */

Console.WriteLine("Lütfen doğum yılınızı yazınız:");
int convertDogumYili;
convertDogumYili = Convert.ToInt32(Console.ReadLine());

int yas = (2025 - convertDogumYili);
Console.WriteLine(yas);


/*6. Soru: Kullanıcıdan iki sayı alarak bu sayıların toplamını, farkını, çarpımını ve 
bölümünü hesaplayan bir program yazın. */

Console.WriteLine("Lütfen iki sayı yazınız:");
int sayi1;
int sayi2;

sayi1 = Convert.ToInt32(Console.ReadLine());
sayi2 = Convert.ToInt32(Console.ReadLine());

int sum = sayi1 + sayi2;

Console.WriteLine($"Toplama: {sum}");
int extraction = sayi1 - sayi2;
Console.WriteLine($"Çıkarma: {extraction}");
int carpma = sayi1 * sayi2;
Console.WriteLine($"Çarpma: {carpma}");
int split = sayi1 / sayi2;
Console.WriteLine($"Bölme: {split}");



/*7. Soru: Kullanıcıdan alınan b%r sayının pozitiff, negatif veya sıfır olup olmadığını 
kontrol eden b%r program yazın. */

Console.WriteLine("Lütfen bir sayı yazınız:");
int sayi;
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi > 0)
{
    Console.WriteLine("Pozitif sayı..");
}
else if (sayi == 0)
{
    Console.WriteLine("Girilen sayı sıfırdır!");
}
else
{
    Console.WriteLine("Negatif sayı..");
}


/*8. Soru: Kullanıcıdan alınan bir not değerine göre, notun "Geçti" veya "Kaldı" 
şeklinde olup olmadığını belirleyen bir program yazın. */

int sayi4;
Console.WriteLine("Notunuzu giriniz:");
sayi4 = Convert.ToInt32(Console.ReadLine());

string sonuc = sayi4 >= 65 ? "Geçer not aldınız." : "Kaldınız!";
Console.WriteLine(sonuc);



/*9. Soru: 1'den 100'e kadar olan sayıları ekrana yazdıran bir program yazın. */


for (int i = 0; i < 101; i++)
{
    Console.WriteLine(i);
}


/*10. Soru: Kullanıcıdan alınan br sayının faktöriyelini hesaplayan bir program yazın. */

Console.Write("Sayıyı Girin:");
double sayi8 = Convert.ToInt32(Console.ReadLine());
int faktoriyel = 1;

for (int i = 1; i <= sayi8; i++)
{

    faktoriyel = faktoriyel * i;
}

Console.WriteLine("{0} sayısının faktöriyeli={1}", sayi8, faktoriyel);


/*11. Soru: Kullanıcıdan alınan iki sayının her ikisinide de pozitif olup olmadığını kontrol 
eden bir program yazın. */

Console.WriteLine("Lütfen ekrana iki sayı yazınız:");
int sayi5;
int sayi6;
sayi5 = Convert.ToInt32(Console.ReadLine());
sayi6 = Convert.ToInt32(Console.ReadLine());
if (sayi5 > 0 && sayi6 > 0)
{
    Console.WriteLine("Pozitif sayı..");
}
else
{
    Console.WriteLine("Negatif sayı..");
}


/*12. Soru: Kullanıcıdan alınan bir sayının 10 ile 20 arasında olup olmadığını kontrol 
eden bir program yazın. */

Console.WriteLine("Lütfen bir sayı yazınız:");
int sayi7;
sayi7 = Convert.ToInt32(Console.ReadLine());

if ( sayi7 > 10 && sayi7 <20)
{
    Console.WriteLine($"{sayi7}: 10 ile 20 arasındadır.");
}
else
{
    Console.WriteLine($"{sayi7}: 10 ile 20 arasında bir sayı değildir.");
}





