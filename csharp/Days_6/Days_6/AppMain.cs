using System;
namespace Days_6
{
    public class AppMain
    {
        internal static void MainX(string[] args)
        {
            // Action -> Sınıf
            // action -> nesne
            // new -> aynısının kopyası - yani (ramde) bellek seviyesinde. new anahtar keimesi
                                        /* olmadan sınıfın nesnesi oluşturulamaz. nesne sayesinde sınıfın içindeki
                                         özelliklere ve methodlara erişebiliriz. mesela action.StringValid
                                         gibi bu bellek kullanımında tasarruf sağlar*/
            // Action(); -> kurucu method
            Action action = new Action();
            object action1 = new Action(); /* temelde her sınıf obje sınıfından türetildiği için
                                            böyle de tanımlanabilir ama bu şekilde tanımlamak
                                            pek tercih edilmez çünkü action1 üzerinden Action
                                            sınıfının özelliklerine ve methodlarına erişemeyiz
                                            yani action1. yazdığımızda sadece defaultta atanan
                                            obje değereleri gelir.*/
            string name = "34564564f45645";
            object surname = "Bilmem";
            action.Fibonacci(10);

            string[] users = { "Kemal", "Ali" };
            object[] arr = { action, action1, name, 100 };
            for (int i = 0; i < arr.Length; i++)
            {
                object item = arr[i];
                Console.WriteLine(item);
                if (item is Action) // item için tür Action sınıfından ise... koşulunu sağla
                {
                    Action itemAction = (Action)item;
                }

            }

            //
            bool statu = action.StringValid("Ali01");
            Console.WriteLine(statu);
        }
    }
}

