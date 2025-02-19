//21.12,2024

// tek satırlı açıklama satırı
/*
çok
satırlı
açıklama birimi
*/

int a = 10;
int b = 40;
int sum = a + b;
Console.WriteLine(sum);

// Değişkenler:


// String değişken türü
// karakter katarı
string name = "Ali";
string surname = "Bilmem";
string sparator = " - ";

string nameSurname = name + sparator + surname; // " - " ifadesini sparator adlı değişkene atadık direk bu satıra + " - " + şeklinde de
                                                // yazılabilirdi.. Dikkat bu satırda toplam 3 değişken vardır
Console.WriteLine(nameSurname);

string city = "İstanbul";
string area = "Marmara";
string cityArea = city + sparator + area;
Console.WriteLine(cityArea);

string stNumber1 = "100";
string stNumber2 = "50";
string nick = "a01";
string stStatus = "true";

string numbers = stNumber1 + stNumber2;
Console.WriteLine(numbers);
String stObj = "Erkan";   // String değeri string değerinden daha genel anlama sahiptir.

// int
// tam sayı değişkenleridir. int değeri max 2 milyar 147milyon.... değer alabilir
int num1 = 2147456445;
int num2 = 333;
int sumNumber = num1 + num2;
Console.WriteLine(sumNumber);

// byte
// int türlerine göre daha az yer kaplayan bir değişken max değeri 255 sayısına çıkar
byte b1 = 255;
byte b2 = 255;
int b3 = b1 + b2;
Console.WriteLine(b3);

// int ile byte arasında olan bir tam sayı türüdür.
short short1 = 32456;

// long -> int değerlerinden çok daha büyük tam sayılar için vardır.
long long1 = 99999999999999999;

// string id
string stringID = "a01ergrhtrytyrtyrtyrtyrtyrt235345";   // strig tanım itibariyle daha geniş değere sahip olduğu için
                                                         // ID lerde daha fazla ihtimal sunar


// ondalıklı değer türkleri
// büyük ondalıklı işlemler yapılmak istendiğinde kullanılmalıdır.
double double1 = 100;
double double2 = 67;
double div = double1 / double2;
Console.WriteLine(div);

int n1 = 100;
int n2 = 67;
int n3 = n1 / n2;
Console.WriteLine(n3);

// küçük ondalıklı işlemler sırasında kullanabilen ondalıklı değerler. f kullanma sebebimiz sistemin double den ayırt etmesini sağlamak
float f1 = 12.4f;
float f2 = 45.7f;
float float3 = f1 / f2;
Console.WriteLine(float3);

// karar kontrol yapılarında kullanılan değişkendir. bool boolean'a göre daha ilkel kalır haliyle az yer kaplar
// true - false değerler alırlar.
bool status1 = true;
status1 = a > b;
Console.WriteLine(status1);

// char veri türü
// içerisine tek bir karakter alanilen değişken türüdür.
char ca = 'A';
char cl = 'l';
char ci = 'i';
string nameString = "Ali";

