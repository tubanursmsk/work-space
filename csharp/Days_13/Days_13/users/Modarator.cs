using System;
namespace Days_13.users
{
	public class Modarator : Person
	{
        public override bool Login(string username, string password)
        {
            return true;
        }


        public void getStatus( int uid )
        {
            if (uid > 100)
            {
                Login("a", "a");      // buradaki logine tıklayınca ise 6. kod satırındaki metoda gidersin 
            }else
            {
                base.Login("b", "b"); // base ile Person sınıfındaki Login methodunu çağırdık.
                                      // Polimorfizm sayesinde override edilmiş method yerine
                                      // base sınıfındaki method çalışır.
                                      // base anahtar kelimesi nereden gelir? base, bir sınıfın
                                      // kendi sınıfı dışında kalan üyelerine erişmek için
                                      // kullanılan bir anahtar kelimedir. base mirası işaret
                                      // eder ve onun içindeki default metodu tetikler.
                                      //  base.Login kısmında logine tıkladığında miras alınan
                                      // sınıfın login methodunu görürüz. O methodu çağırırız.
            }
        }

    }
}

