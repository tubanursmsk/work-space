/* 1. Kullanıcıdan adını, yaşını ve doğum yılını alarak, kullanıcının yaşını kontrol eden 
ve doğru olup olmadığını ekrana yazdıran b:r program yazın. */

Console.WriteLine("Lütfen doğum yılınızı yazınız:");
int convertDogumYili;
convertDogumYili = Convert.ToInt32(Console.ReadLine());

int yas = (2025 - convertDogumYili);
Console.WriteLine(yas);


/* 2. Kullanıcıdan b:r sayı alarak, bu sayının ç:ft m: tek m: olduğunu kontrol eden ve 
sonucu ekrana yazdıran b:r program yazın. */

Console.WriteLine("Lütfen bir sayı yazınız:");
int sayi;
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 2 == 0)
{
    Console.WriteLine("Çift sayıdır..");
}
else
{
    Console.WriteLine("Tek sayıdır..");
}

/* 3. Kullanıcıdan :k: sayı alarak, bu sayıların toplamını, farkını, çarpımını ve bölümünü 
hesaplayan ve sonuçları ekrana yazdıran b:r program yazın. Bölme :şlem: nde, 
bölen: n sıfır olup olmadığını kontrol ed:n ve sıfırsa hata mesajı ver:n.*/

Console.WriteLine("Lütfen iki tane sayı yazınız:");
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
string bolmeSonucu = "";
bolmeSonucu = sayi1 / sayi2 == split ? "İşlemler başarı ile tamamlandı." : "Bölme işleminde hatalı sayı kullanımı!";
Console.WriteLine(bolmeSonucu);


/* 4.Kullanıcıdan b: r ondalık sayı alarak, bu sayıyı tam sayıya dönüştürüp,
dönüştürülmüş değer: ve or:j: nal değer: ekrana yazdıran b:r program yazın.*/


Console.WriteLine("Ondalıklı bir sayı giriniz, örneğin 3.15 gibi");
double sayi3 = Convert.ToDouble(Console.ReadLine());
sayi3 = Convert.ToInt32(sayi3);
Console.WriteLine(sayi3);



/* 5. Kullanıcıdan b:r sayı alarak, bu sayının kares:n: ve küpünü hesaplayan ve 
sonuçları ekrana yazdıran b:r program yazın.*/

int sayi4 = 0;
Console.Write("Sayı giriniz:");
sayi4 = Convert.ToInt32(Console.ReadLine());
int kare = sayi4 * sayi4;
Console.WriteLine($"Karesi= {kare}");
int kup = sayi4 * sayi4 * sayi4;
Console.WriteLine($"Küpü= {kup}");


/* 6. Kullanıcıdan b:r met:n alarak, bu metn: büyük harfe çev:ren ve ekrana yazdıran b:r
program yazın. */

Console.WriteLine("Ekrana birkaç kelime yazınız..");
string metin = Console.ReadLine();
Console.WriteLine(metin.ToUpper());

/*7. Kullanıcıdan :k: sayı alarak, bu sayıların büyüklük karşılaştırmasını yapan ve 
büyük olan sayıyı ekrana yazdıran b:r program yazın. Sayılar eş:tse, eş:t olduklarını 
bel:rten b:r mesaj yazdırın. */

Console.WriteLine("Ekrana iki sayı yazınız..");
int sayi5;
int sayi6;
sayi5 = Convert.ToInt32(Console.ReadLine());
sayi6 = Convert.ToInt32(Console.ReadLine());

if (sayi5 > sayi6)
{
    Console.WriteLine("ilk girdiğiniz sayı büyük");
}
else if (sayi5 < sayi6)
{
    Console.WriteLine("ikinci girilen sayı büyük");
}
else if (sayi5 == sayi6)
{
    Console.WriteLine("iki sayı birbirine eşit");
}


/*8. Kullanıcıdan b:r sayı alarak, bu sayının poz:t: f m: negat: f m: olduğunu kontrol eden 
ve sonucu ekrana yazdıran b:r program yazın.*/

Console.WriteLine("Ekrana  bir sayı yazınız..");
int sayi7;
sayi7 = Convert.ToInt32(Console.ReadLine());
if (sayi7 % 2 == 0)
{
    Console.WriteLine($"{sayi7}: çift sayıdır");
}
else
{
    Console.WriteLine($"{sayi7}: tek sayı");
}
