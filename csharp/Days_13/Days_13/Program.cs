using Days_13.users;

namespace Days_13
{
    public class Program
    {
        public static void Main(string[] args)
        {

            User user = new User();
            Customer customer = new Customer();
            Admin admin = new Admin();

            Console.WriteLine($"user -> {user.GetHashCode()}"); // GetHashCode() methodu, her nesne için
                                                                // benzersiz bir hash kodu döndürür. Bu kod,
                                                                // nesnenin bellekteki konumuna veya içeriğine
                                                                // bağlı olarak değişebilir. Polimorfizm
                                                                // sayesinde, user, customer ve admin nesneleri
                                                                // farklı türlerde olsalar da, her biri kendi
                                                                // hash kodunu alır. Bu da bize her nesnenin
                                                                // benzersiz olduğunu gösterir.
            Console.WriteLine($"customer -> {customer.GetHashCode()}");
            Console.WriteLine($"admin -> {admin.GetHashCode()}");

            call(user, "a", "a");
            call(customer, "c", "c");
            call(admin, "e", "e");
            /*
            bool userStatus = user.Login("a", "a");
            Console.WriteLine($"userStatus: {userStatus} - name: {user.nameSurname}");

            bool customerStatus = customer.Login("c", "c");
            Console.WriteLine($"customerStatus: {customerStatus} - name: {customer.nameSurname}");

            bool adminStatus = admin.Login("e", "e");
            Console.WriteLine($"adminStatus: {adminStatus} - name: {admin.nameSurname}");
            */
        }

        

        public static void call( Person person, string username, string password )
        {
            bool status = person.Login(username, password);
            Console.WriteLine($"Login Status: {status} - Name: {person.nameSurname}"); // bu aşamada polimorfizm sayesinde hangi türün login methodu override edilmişse o çalışır.
            
            if ( person is Customer) // person Customer türünde mi? true/false döner.
            {
                // person türünü Customer türüne dönüştür (casting).
                Customer c = (Customer) person;
                c.AddBasket(100);
                Console.WriteLine($"c -> {c.GetHashCode()}");
            }
        }

    }
}
/* Polimorfizm nedir? 

*** Polimorfizm, nesne yönelimli programlamada (OOP) bir nesnenin farklı türlerdeki davranışları
sergileyebilmesini sağlayan bir özelliktir. Aynı isimdeki bir metodun, farklı sınıflarda 
farklı şekilde çalışmasını mümkün kılar. Bu sayede, bir temel sınıf referansı ile türetilmiş
sınıfların kendi özel implementasyonları çağrılabilir. 

*** polimorfizm'in hyata geçmesi için miras yapısının olması gerekir.

*** Örneğin, aşağıdaki kodda Person sınıfının Login metodu virtual olarak tanımlanmıştır.
Türev sınıflar (User, Customer, Admin) bu metodu override ederek kendi giriş mantıklarını 
yazabilirler. Programda, call metodunda polimorfizm sayesinde hangi nesne türü gönderildiyse
onun Login metodu çalışır:

        public static void call(Person person, string username, string password)
        {
            bool status = person.Login(username, password); // Polimorfizm: doğru override çağrılır
            Console.WriteLine($"Login Status: {status} - Name: {person.nameSurname}");
        }


 *** Kısaca: bir nesnenin farklı sınıflarda farklı davranışlar gösterebilmesini sağlayan, 
 kodun daha esnek ve genişletilebilir olmasına yardımcı olan bir OOP kavramıdır.


 
 */
