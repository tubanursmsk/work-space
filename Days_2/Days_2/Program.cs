// Kullanıcıdan veri alımı

Console.WriteLine("name?");
string name = Console.ReadLine();

Console.WriteLine("surname?");
string surname = Console.ReadLine();

string nameSurname = name + " " + surname;
Console.WriteLine(nameSurname);

// ***************************************************************************************
//Type casting - Tür dönüşümü
Console.WriteLine("age?");
string stAge = Console.ReadLine();
int age = Convert.ToInt32(stAge); //string değeri convert metodu ile int değere
                                  //dönüştüdük bunu diğer türlerde de yapabiliriz.
Console.WriteLine(age);

// ***************************************************************************************
double n1 = 50.7;
double n2 = 70.9;

int cN2 = (int)n2;  //bu da double değeri int değere dönüştürme yöntemidir. ama sadece int değerlerde iş yapar..
int cN1 = Convert.ToInt32(n1); // artık buradakı n1 yeni bir değer oldu yani 50.7 değil 50
Console.WriteLine(cN1);
Console.WriteLine(Convert.ToInt32(n1)); //üst satırdaki dönüştürme işlemi ile bu satırdaki işlem
                                        //aynı amaca hizmet ediyor kullanım açısından cN1 diye bir
                                        //değer atamak her zaman daha işlevseldir mesela if dögüsünde
                                        //kullanmak gerektiğinde bir sürü değer yazmak yerine cN1 yazmak yeterli
                                        //MİSAL
if (Convert.ToInt32(n1) > 50) //yazmak mı daha ergonomik? ekstra yük
{

}
if (cN1 > 50) // bu şekil yazamak tabi ki daha ergo.. çünkü işlemci fazladan işlem yapmamış oluyor

{

}

// ************************************************************************
int cN1 = Convert.ToInt32(n1); // 51
int cN2 = Convert.ToInt32(n2); // 71
int sm = cN1 + cN2;

Console.WriteLine("========================");
Console.WriteLine(cN1);
Console.WriteLine(cN2);
Console.WriteLine($"Double Toplam: {cdSum}");
Console.WriteLine($"Toplam : {sm}"); // 122



Console.WriteLine("========================");
// ****************************************************************************************************************************************************************
// Operatörler

// Aritmatik operatörler
// +, -, *, / , %
double a = 50;
double b = 24;
double end = 0;

end = a + b;
Console.WriteLine($"Toplam: {end}");

end = a - b;
Console.WriteLine($"Çıkarma: {end}");

end = a / b;
Console.WriteLine($"Bölme: {end}");

end = a * b;
Console.WriteLine($"Çarpma: {end}");

// mod alma
// bölümden kalan kısmı verir. Mesela sahibinden sayfasında ilanda kitap sayısı 24 olsun ve her sayfaya
// 10 kitap olacak şekilde litelensin 1.sf 10 2.sf 10 3.sfyada kalan 4 kitabı bu kalan formülü ile listeler. 
end = b % 10;
Console.WriteLine($"Mod b % 10: {end}");

// Artırma ve eksiltme operatörleri
// +1, -1
// ++, --
int x = 0;
x = x + 1;
Console.WriteLine($"x: {x}"); //1
x++;
Console.WriteLine($"x: {x}"); //2
Console.WriteLine($"x: {x++}"); //2
                                //ilk x sonra ++ geldiği için konsola x değerinin artırılmamış halini yazdırır
                                // sonra kendi içine 1 arttırıp bir sonraki x değerinde artırma işemini yazdırır
Console.WriteLine($"x: {x}");//3
Console.WriteLine($"x: {++x}");//4 burada da ilk arttırır sonra x i yazdırır

// 4
x++; ++x; x++; // her birerinde 1 arttırır yani sayı 7 olur.neden yukardaki x++ kavramı burada geçerli değil?
               // yazımdan kaynaklı yukarıda {x++} yazılmıştı parantez içinde olmazsa bu özelliği kaybeder!

Console.WriteLine($" -- x -- : {x++}"); //7
Console.WriteLine($" -- x -- : {x}"); //8


x += 3; //8+3=11
Console.WriteLine($"x: {x}");
x *= 2; //22
Console.WriteLine($"x: {x}");


Console.WriteLine("=========== Mantıksal operatörler =============");
// ****************************************************************************************************************************************************************
// Mantıksal operatörler
// işlemlerini yaptıktan sonra geriye(bool) true - false yanıtlar getirirler
// ==, !=, >, <, >=, <=

int q = 10;
int w = 11;
bool status = false;

// ==
// sol taraf ile sağ tarafın eşit olduğu durumlarda true döndürür
status = q == w;
Console.WriteLine($" == : {status}");
string username = "ali";
status = username.Equals("ali"); // username == "ali" demek ile username.equals ifadesi aynıdır
                                 // ancak string ifadelerde equals kullanmak daha kaliteli yazım sunar

Console.WriteLine($" == : {status}"); //????

Console.WriteLine("Lütfen kullanıcı adınızı giriniz!");
username = Console.ReadLine();

Console.WriteLine("Lütfen şifrenizi giriniz!");
string password = Console.ReadLine();

status = username.Equals("ali01");
Console.WriteLine($" username : {status}");

status = password.Equals("12345");
Console.WriteLine($" password : {status}");

// !=
// eşit değil ise
status = q != 0;
Console.WriteLine($" != : {status}");

// >
// sol tarafdaki değer sağ taraftaki değerden büyük ise
status = q > w;
Console.WriteLine($" > : {status}");

// <
// sol tarafdaki değer sağ taraftaki değerden küçük ise
status = q < w;
Console.WriteLine($" < : {status}");

// >=
// sol tarafdaki değer sağ taraftaki değere eşit yada büyük
status = q >= w;
Console.WriteLine($" >= : {status}");

// <=
// sol tarafdaki değer sağ taraftaki değere eşit yada küçük
status = q <= w;
Console.WriteLine($" <= : {status}");

// logic kapılar
// &&, ||
// && -> sol tarafdaki şart ile sağ taraftaki şart sağlanmış(true) olmuş ise
int ageX = 21;
// bool status1 = ageX >= 18;
// bool status2 = ageX <= 50;
status = ageX >= 18 && ageX <= 50;
Console.WriteLine($" && : {status}");

// || -> sol tarafdaki şart veya sağ taraftaki şart sağlanmış(true) ise
status = q > 9 || q < 8;
Console.WriteLine($" || : {status}");



