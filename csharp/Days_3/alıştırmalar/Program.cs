//1. Soru: Bir öğrencinin adını, yaşını ve not ortalamasını tutan değişkenler tanımlayın ve bu bilgileri
//ekrana yazdırın. 

Console.WriteLine("Adınızı giriniz");
string name = Console.ReadLine();

Console.WriteLine("Soyadınızı giriniz?");
string surname = Console.ReadLine();

Console.WriteLine("Yaşınızı giriniz?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vize notunuzu giriniz?");
double vize = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Final notunuzu giriniz?");
double final = Convert.ToDouble(Console.ReadLine());

string nameSurname = name + " " + surname;
Console.WriteLine(nameSurname);
Console.WriteLine(age);

double notort = (vize * 0.3) + (final * 0.7);
Console.WriteLine("Ortalamnız:" + notort);


//2.	Soru: Bir dikdörtgenin uzunluğunu ve genişliğini kullanıcıdan alarak alanını hesaplayan bir program yazın. 

Console.WriteLine("Dikdörtgenin yatay uzunluğu?");
double yatay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Dikdörtgenin dikey uzunluğu?");
double dikey = Convert.ToDouble(Console.ReadLine());

double alan = yatay * dikey;
Console.WriteLine("Dikdörtgenin alanı:" + alan);


//3.Soru: Kullanıcıdan alınan bir string değeri integer'a çevirip, bu değeri 10 ile çarpan ve sonucu ekrana yazdıran bir program yazın. 

Console.WriteLine("Bir sayı giriniz?");
string sayı = Console.ReadLine();
int sayıint = Convert.ToInt32(sayı);
int sonuç = sayıint * 10;
Console.WriteLine(sonuç);


//4.Soru: Kullanıcıdan alınan bir double değeri integer'a çevirip, bu değeri ekrana yazdıran bir program yazın. 

Console.WriteLine("Lütfen ondalıklı bir sayı giriniz (Örn: 12,5):");
double ondalikliSayi = Convert.ToDouble(Console.ReadLine()); 
int tamSayi = Convert.ToInt32(ondalikliSayi);
Console.WriteLine("Girdiğiniz sayının tam sayı hali: " + tamSayi);


//5.Soru: Kullanıcıdan adını ve doğum yılını alarak, kullanıcının yaşını hesaplayan ve ekrana yazdıran bir program yazın. 

Console.WriteLine("Adınızı giriniz:");
string ad = Console.ReadLine();
Console.WriteLine("Doğum yılınızı giriniz:");
int dogumYili = Convert.ToInt32(Console.ReadLine());
int yas = DateTime.Now.Year - dogumYili;
Console.WriteLine(ad + ", yaşınız: " + yas);


//7.Soru: Kullanıcıdan alınan bir sayının pozitif, negatif veya sıfır olup olmadığını kontrol eden bir program yazın. 

Console.WriteLine("Bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi > 0)
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
else if (sayi < 0)
{
    Console.WriteLine("Girdiğiniz sayı negatiftir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı sıfırdır.");
}


//8.Soru: Kullanıcıdan alınan bir not değerine göre, notun "Geçti" veya "Kaldı" şeklinde olup olmadığını belirleyen bir program yazın. 

Console.WriteLine("Not ortalamasını giriniz:");
double not = Convert.ToDouble(Console.ReadLine());
if (not >= 65)
{
    Console.WriteLine("Geçtiniz.");
}
else
{
    Console.WriteLine("Kaldınız.");
}


//9.Soru: 1'den 100'e kadar olan sayıları ekrana yazdıran bir program yazın. 

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}


//11.Soru: Kullanıcıdan alınan iki sayının her ikisinin de pozitif olup olmadığını kontrol eden bir program yazın. 

Console.WriteLine("Birinci sayıyı giriniz:");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz:");
int sayi2 = Convert.ToInt32(Console.ReadLine());
if (sayi1 > 0 && sayi2 > 0)
{
    Console.WriteLine("Her iki sayı da pozitiftir.");
}
else
{
    Console.WriteLine("En az bir sayı pozitif değildir.");
}


//12.Soru: Kullanıcıdan alınan bir sayının 10 ile 20 arasında olup olmadığını kontrol eden bir program yazın. 

Console.WriteLine("Bir sayı giriniz:");
int sayi3 = Convert.ToInt32(Console.ReadLine());
if (sayi3 >= 10 && sayi3 <= 20)
{
    Console.WriteLine("Girdiğiniz sayı 10 ile 20 arasındadır.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı 10 ile 20 arasında değildir.");
}


//13.Soru: Kullanıcıdan alınan bir sayının faktoriel hesabını yapan bir program yazın.

Console.WriteLine("Faktoriyelini hesaplamak istediğiniz sayıyı giriniz:");
int sayi4 = Convert.ToInt32(Console.ReadLine());

int faktoriyel = 1;
for (int i = 1; i <= sayi4; i++)
{
    faktoriyel *= i; // 5! için hesap mantığı --->  1*2 =2  2*3=6  6*4=24  24*5=120
}
Console.WriteLine(faktoriyel);






