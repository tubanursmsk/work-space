using System;
namespace Days_10
{
    public class Profile
    {
        // Kurucu methodlar
        // Bir sınıf kurulurken sınıf içine parametre göndermeye yarar.

        // Kurallar
        // Sınıf adı ile aynı isme sahip olmalıdır.
        // void - return anahtar kelimesi almazlar.
        // Yazılmadığında bile sınıfın içinde default kurucu method çalışmış olur.
        // Yazıldığında artık bizim yazdığımız geçer

        string name = "";
        string surname = "";
        public Profile() // parametresiz kurucu method. Sınıfın içinde default olarak çalışır. Biz yazdığımızda artık bu geçerli olur.
        {

        }

        public Profile(string name) //aynı ısimde kurucu metodlarolunca program kızar ama burada olduğu gibi metodu aşırı yüklyerek farklılaştırırz. overloading...
        {
            this.name = name; // this. ile sınıfın içindeki name özelliğine erişilir. parametre olarak gelen name ile sınıfın içindeki name birbirinden ayrılır.
        }

        public Profile(string name, string surname) // 2 parametreli contructur 
        {
            this.name = name;
            this.surname = surname;
        }

        public void Call()
        {
            if (!name.Equals(""))
            {
                Console.WriteLine(name);
            }
            if (!surname.Equals(""))
            {
                Console.WriteLine(surname);
            }
        }


        public string ProfileName()
        {
            return "Ali Bilmem";
        }

    }
}


/*
 
 Sorular:

1- Bir sınıftan (class) yeni bir nesne (instance) oluşturmak için hangi keyword kullanılır?
- new

2- Geriye değer döndürmeyen metotların dönüş tipi ne olmalıdır?
- void

3- Bir sınıfın içinde, sınıf adıyla aynı isme sahip ve geri dönüş tipi olmayan bir metot tanımlarsak, bu metoda ne ad verilir?
- Constructor (Kurucu Metot)

4- Bir sınıfın içinde birden fazla constructor tanımlamak mümkün müdür? Eğer mümkünse, bu duruma ne ad verilir?
- Evet, mümkün. Bu duruma "overloading" (aşırı yükleme) denir.

5- "this" keyword'ü, bir sınıfın içinde neyi ifade eder?
- "this" keyword'ü, bir sınıfın içinde o sınıfın kendisini ifade eder. Genellikle, sınıfın özelliklerine veya metotlarına erişmek için kullanılır.

6- OOP prensibi olan 'Encapsulation' (Kapsülleme) neyi sağlar?
- Veriye kontrollü erişimi (Data Hiding) -- Encapsulation, bir sınıfın içindeki verilerin ve metotların gizlenmesini ve sadece belirli bir arayüz üzerinden erişilmesini sağlar. Bu, veri güvenliğini artırır ve sınıfın iç yapısının dışarıdan değiştirilmesini önler.
 
7- Sadece tanımlandığı sınıf içerisinden erişilebilen üyeler hangi erişim belirleyiciye sahiptir?
- private

8- Bir sınıfın içinde tanımlanan ve sınıfın herhangi bir örneği (instance) tarafından erişilebilen üyeler hangi erişim belirleyiciye sahiptir?
- public

9- Bir sınıfın özelliklerini (field) dış dünyaya açarken kullanılan yapı nedir?
- Property (Özellik)
 
10- Sınıf oluşturulduğunda otomatik olarak çalışan ilk metoda ne ad verilir?
- Constructor (Kurucu Metot)

11- Hangi keyword bir sınıfın başka bir sınıftan miras (inheritance) almasını sağlar?
- : (iki nokta üst üste)
 
12- static' olarak işaretlenen bir metoda nasıl erişilir?
- Sınıf ismi üzerinden direkt

13- Dinamik olarak büyüyüp küçülebilen koleksiyon yapısı hangisidir?
- List<T>

14- Bir List koleksiyonuna eleman eklemek için hangi metot kullanılır?
- Add()

15- Try-Catch bloklarında 'finally' bloğunun görevi nedir?
- 'finally' bloğu, try-catch bloklarında hata oluşsa da oluşmasa da her zaman çalışacak olan kod bloğudur. Genellikle, kaynakların serbest bırakılması veya temizlenmesi gibi işlemler için kullanılır.

16- Key-Value (Anahtar-Değer) çiftleri saklayan koleksiyon hangisidir?
- Dictionary<TKey, TValue>
 
17- Foreach döngüsü ne üzerinde çalışır?
- IEnumerable (örneğin, List, Array gibi koleksiyonlar)

18- Bir string ifadenin karakter sayısını veren property hangisidir?
- Length

19- Hangi Exception türü bir nesnenin değeri 'null' olduğunda fırlatılır?
- NullReferenceException

20- Bir sınıfın içinde tanımlanan ve sadece o sınıfın içinde erişilebilen üyeler hangi erişim belirleyiciye sahiptir?
- private
 
 
 
 
 */
