namespace Days_7;

public class Program
{
    internal static void Main(string[] args)
    {
        //immutable --> sayesinde bellekte aş. beş elemanlık yer ayrıldı bu 6 çıkmaz 4 inmez. 
        //array
        string[] users = { "Ahmet", "Erkan", "Zehra", "Serkan", "Ayşe", "Hasan"};
        Console.WriteLine(users[1]);
        users[1] = "Mehmet";
        Console.WriteLine(users[1]);

        Console.WriteLine("************************");
        for(int i= 0; i < users.Length; i++)
        {
            string item= users[i];
            Console.WriteLine(item);
        }

        Console.WriteLine("************************");
        foreach (string item in users)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("************************");
        foreach (string item in users)
        {
            Console.WriteLine(item);
            if (item.Equals("Serkan"))
            {
                break; // loop davranışını tamamlar.
            }

        }

        Console.WriteLine("************************");
        foreach (string item in users)
        {
            if (item.Equals("Zehra") || item.Equals("Kemal"))
            {
                continue; // bu adımı gördüğünde işlem yapma
            }
            Console.WriteLine(item);
        }

        //nesne üretimi
        // Action -> sınıfın adı (sınıfın adında özgür değilsin yani sınıfın ismi ne ise o)
        // action -> nesnenin adı  (nesnenin adında özgürsün istediğini yaz)
        // new -> new ile bellekte nesne için yer açma işlemi. aynısının kopyasını oluşturur.
        // Action() -> constructor (kurucu) fonksiyonu. sınıfın adıyla aynı olan fonksiyonlara denir. nesne üretildiğinde otomatik olarak çalışan fonksiyonlardır.
        Action action = new Action();

        // nesne altındaki özelliklere (.) operatörü ile erişilir

        action.NoParams(); // params fonksiyona gönderilen değerlerdir. parametresiz fonksiyonlarda parantez içi boş olur.
        action.NoParams();
        action.NoParams();

        action.Params("TV", 10000);
        action.Params("iPhone", 65000);
        action.Params("Samsung", 45000);

        Console.WriteLine("1. Sayıyı giriniz");
        int num1 = Convert.ToInt32(Console.ReadLine()); // Console.ReadLine() kullanıcıdan yanıtı string olarak alır . Convert.ToInt32() ile string ifadeyi int'e çeviririz. eğer kullanıcı sayı yerine harf girerse hata verir. bu yüzden try catch bloklarıyla hataları yakalayarak kullanıcıya bilgi vermek daha sağlıklı olur.

        Console.WriteLine("2. Sayıyı giriniz");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = action.sum(num1, num2);
        Console.WriteLine("Sum :" + sum);

        // kullanıcıadı ve şifre ile giriş yapan bir fonksyion yaz.
        // bool bir yanıt geriye dönsün
        // örn: kemal01 - 12345
        Console.WriteLine("Username?");
        string username = Console.ReadLine();

        Console.WriteLine("Password?");
        string password = Console.ReadLine();

        bool loginStatus = action.UserNamePasswordLogin(username, password);
        Console.WriteLine($"Login Status: {loginStatus}");

    }


}
