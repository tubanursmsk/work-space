using System;
using Days_14.models;
using Days_14.services;
using Days_14.users;

namespace Days_14
{
    public class Program
    {
        public static void Main(string[] args)
        {

            UserService userService = new UserService();
            UserModel? userModel = userService.UserLogin("ali@mail.com", "12345"); //neden UserModel'i nullable kıldık??

            if (userModel != null)
            {
                Console.WriteLine("Giriş başarılı..");

            }
            else
            {
                Console.WriteLine("Hatalı giriş!");
            }



        }
    }
}


/*              ****************   SORULAR   ******************
 

 1- Bir sınıfın miras alınmasını engellemek için hangi keyword kullanılır?
 - sealed (mühürlü)

2- Bir sınıfın birden fazla sınıftan miras alması mümkün müdür?
- Hayır, C# dilinde bir sınıf sadece tek bir sınıftan miras alabilir. Ancak, bir sınıf
  birden fazla arayüzü (interface) uygulayabilir.

3- Base class'taki bir metodun türetilen sınıfta değiştirilebilmesi için hangi keyword ile işaretlenmesi gerekir?
- virtual (sanal)

4- Bir sınıfın başka bir sınıftan miras alması için hangi keyword kullanılır?
- : (iki nokta üst üste)

5- Base anahtar kelimesi ne iş yapar?
- Base anahtar kelimesi, türetilen sınıfın base (temel) sınıfına erişmek için kullanılır. 
  Bu, base sınıfın üyelerine erişmek veya base sınıfın yapıcı metodunu çağırmak için kullanılabilir.

6- Interface içerisindeki metotların varsayılan erişim belirleyicisi nedir (C# 8.0 öncesi)?
- public (her zaman public olarak kabul edilirler)

7- Türetilmiş sınıfta (Derived Class), Base Class'ın constructor'ını çağırmak için ne kullanılır?
- Base anahtar kelimesi kullanılır. Örneğin: 
  public DerivedClass() : base() 
  {
      // Constructor içeriği
  }

8- Abstract Class ile Interface arasındaki en temel farklardan biri nedir?
- Abstract class'lar hem soyut (abstract) hem de somut (concrete) üyeler içerebilirken, interface'ler
  sadece soyut üyeler içerir. Ayrıca, bir sınıf birden fazla interface'i uygulayabilirken, sadece bir 
  abstract class'tan miras alabilir.


9- Tip dönüşümü yaparken hata almamak için güvenli dönüşüm operatörü hangisidir?
- as operatörü (örneğin: object obj = "Hello"; string str = obj as string;)

10- Override edilen bir metodun orijinal (base) halini çağırmak için ne kullanılır?

- Base anahtar kelimesi kullanılır. Örneğin: 
  public override void SomeMethod() 
  {
      base.SomeMethod(); // Base sınıfın SomeMethod'unu çağırır
      // Ek kodlar
  }


11-Çok biçimlilik (Polymorphism) hangi kavramla doğrudan ilişkilidir?
- Virtual/Override mekanizması
- Kalıtım (Inheritance) ve soyutlama (Abstraction) kavramlarıyla doğrudan ilişkilidir. Polymorphism, 
  bir nesnenin farklı şekillerde davranabilmesini sağlar ve bu genellikle kalıtım yoluyla gerçekleştirilir.

12- Hangi tip hem Class hem de Interface özelliklerini taşıyan bir yapıya benzer ancak sadece metot imzaları içerir?
- Abstract class (Soyut sınıf)

  *** abstract nedir? Abstract, bir sınıfın veya metodun soyut olduğunu belirtmek için kullanılan
  bir anahtar kelimedir. Soyut sınıflar, doğrudan örneklenemezler ve genellikle diğer sınıflar tarafından
  miras alınmak üzere tasarlanırlar. Örnek vermek gerekirse, bir "Hayvan" sınıfı soyut olabilir ve "Kedi" 
  ve "Köpek" gibi sınıflar bu "Hayvan" sınıfından miras alarak kendi özelliklerini ve davranışlarını
  tanımlayabilirler. Soyut metodlar, ise, soyut sınıflar içinde tanımlanan ve alt sınıflar tarafından 
  mutlaka override edilmesi gereken metodlardır. Bu sayede, alt sınıflar kendi özel davranışlarını tanımlarken,
  temel bir sözleşmeye de uymak zorunda kalırlar.


13- Bir metodun mutlaka override edilmesini zorunlu kılan keyword hangisidir?
- abstract (Zorunlu override için abstract kullanılır.)

14- Hangi tip hem Class hem de Interface özelliklerini taşıyan bir yapıya benzer ancak sadece metot imzaları içerir?
- Interface sadece sözleşmeleri (imzaları) içerir.
*/