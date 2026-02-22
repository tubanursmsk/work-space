/* ---------------------------- Karar Kontrol Yapısı --------------------------- */

// if
/*
 
if (şart) {
    // şartlar sağlandıktan sonra çalışacak kodlar
}else {
    // şartlar sağlanmadığında çalışacak kodlar
}

 */
// kullanıcıdan yaşını girmesini istediniz
// age >= 18 olması durumunda üye olabilirsiniz
// age < 18 olması durumunda üye olamazsınız

Console.WriteLine("Lütfen yaşınızı giriniz!");
// string stAge = Console.ReadLine();
string stAge = "21";
int age = Convert.ToInt32(stAge);


if (age > 0)
{

    bool status = age >= 18;
    if (status)
    {
        Console.WriteLine("üye olabilirsiniz"); //if değeri true olduğu müddetçe çalışır
    }
    else
    {
        Console.WriteLine("üye olamazsınız");
    }

}
else
{
    Console.WriteLine("Lütfen pozitif değerler giriniz!");
}

string email = "ali@mail.com";
string password = "1234";
// logic -> &&
if (email == "ali@mail.com" && password == "12345")
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Kullanıcı adı yada şifre hatalı!");
}

if (email.Equals("ali@mail.com") && password.Equals("12345")) // string ifadelerde == kullanmak
                                                              // zekice değildir. == değikenin
                                                              // bellekteki adres kıyaslaması yaparak
                                                              // eşitliği sağlamaya çalışır ve her yeni
                                                              // bir değişken bellekte kensisne ayrı bir
                                                              // yertutacağı için maliyetlidir ancak
                                                              // equal ise adrese bakmaz adresin
                                                              // içindeki değerin eşit olup olmadığına
                                                              // bakar bu daha avantajlıdır!
{

}


// else - if
// doğruyu bulduğunda durma özelliğine sahiptir.
Console.WriteLine("==========================");
string name = "ali";
string surname = "bilmem";
string phone = "543";

if (name.Equals(""))  //(Eğer) - İlk Kontrol Noktası "İsim alanı boş mu?" diye kontrol eder. Eğer boşsa ekrana "Lütfen adınızı giriniz!" yazar ve aşağıdaki diğer hiçbir kodu (else if ve else kısımlarını) okumadan bu bloktan çıkar.
{
    Console.WriteLine("Lütfen adınızı giriniz!");
}
else if (surname.Equals("")) //(Değilse Eğer) - Alternatif Kontrol Noktaları Amacı: Yukarıdaki şart(lar) sağlanmadığında devreye giren alternatif kontrollerdir. İşlevi: Programın buraya gelmesi için üstteki şartın yanlış olması gerekir. Yani program soyadı kontrolüne gelmişse, ismin dolu olduğunu kesin olarak biliyoruz demektir.
{
    Console.WriteLine("Lütfen soyadınızı giriniz!");
}
else if (phone.Equals("")) //(Değilse Eğer) - Alternatif Kontrol Noktaları
{
    Console.WriteLine("Lütfen telefon no giriniz!");
}
else //(Hiçbiri Değilse) - Varsayılan / Başarı Durumu Amacı: Yukarıdaki if ve else if şartlarının hiçbirinin gerçekleşmediği durumda çalışacak olan "kurtarıcı" veya "sonuç" kodudur. İşlevi: Program bu satıra ulaştıysa şu anlama gelir: İsim boş değil, soyisim boş değil, telefon boş değil. Demek ki her şey eksiksiz doldurulmuş. Bu yüzden güvenle "Form Gönderiliyor.." mesajını verebiliriz.
{
    Console.WriteLine("Form Gönderiliyor..");
}

Console.WriteLine("==========================");
int dayNumber = 4;

if (dayNumber > 0 && dayNumber <= 7)
{
    if (dayNumber == 1)
    {
        Console.WriteLine("Gönderim Pazartesi");
    }
    else if (dayNumber == 2)
    {
        Console.WriteLine("Gönderim Salı");
    }
    else if (dayNumber == 3)
    {
        Console.WriteLine("Gönderim Çarşamba");
    }
    else
    {
        Console.WriteLine("Seçtiğiniz gün gönderimimiz bulunmamaktadır!");
    }
}
else
{
    Console.WriteLine("Lütfen 1-7 arasında bir değer giriniz!");
}

Console.WriteLine("==========================");
// switch
// şartın kesin olarak arandığı yer
string menu = "Haberler";
switch (menu)
{
    case "Haberler":
        Console.WriteLine("Haberler Tıklandı");
        break;
    case "Videolar":
        Console.WriteLine("Videolar Tıklandı");
        break;
    default:
        Console.WriteLine("Tümü Seçildi");
        break;
}

Console.WriteLine("==========================");
//  tek satırlı if
string gun = dayNumber == 2 ? "Salı" : "Çarşamba";
Console.WriteLine(gun);
if (dayNumber == 2)
{
    gun = "Salı";
    // ...
}
else
{
    gun = "Çarşamba";
    // ...
}

Console.WriteLine("==========================");

// diziler
// bir değişken içerisinde birden fazla değer barındırmaya yarar
string[] cities = { "İstanbul", "Ankara", "Bursa", "Adana", "Gaziantep" };
Console.WriteLine(cities);

// index -> 0 dan başlayıp dizinin elemanlarına erişim yoludur.
int index = -1;

// Length -> dizi içindeki toplam eleman sayısını verir
int size = cities.Length;
Console.WriteLine("Dizi Size : " + size);
if (index > -1 && size > index)
{
    Console.WriteLine(cities[index]);
}
else
{
    Console.WriteLine($"Lütfen 0-{size - 1} da bir değer giriniz");
}

// int dizi
int[] numbers = { 10, 44, 55, 66, 77, 33, 44 };
Console.WriteLine(numbers[2]);


// loop
// Tekrarlanan işlemler için loop kullanılır.
// for loop
Console.WriteLine("==========================");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"For Loop - {i}");
}

Console.WriteLine("==========================");
for (int i = 0; i < cities.Length; i++) // bu kodlar gayet dinamiktir!!!
{
    Console.WriteLine(cities[i]);
}

// dizilerde şöyele bir özellik vardır:
/*
 bir dizi bir kerek yazılır eleman sayısı sonrasında azaltılamaz çoğaltılamaz
mesela üniversitenin eğitim fak. de bölüm sayısı nettir 8 dönem 10 sonrada aynıdır bu gibi durumda dizi tercih
edilir. derste instagram örneği verdik. orada da bizim için sunulan postlar diziler saeyesinde önümüze sıralanır.
misal 10 tane post gösterilirken üsten 1 yeni gönderi yazısı belirdi (var olan dizi 1 arttı) veya bir postun içeriğini 
rahasız edici buldum ve sağ üst ... sekmesinden bir daha bu içeriği gösterme dedim (diziyi azalttım). az önce diziler
artmaz azalmaz demiştik bu ifade örnelk ile çelişiyor. işte burada dizilerin bir üst yapsısı kolleksiyonlar devreye girer.
bir sonraki ders bu konuyu işleyeceğiz...
 */