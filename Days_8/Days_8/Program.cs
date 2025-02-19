namespace Days_8 {
    public class Program
    {
        internal static void Main(string[] args)
        {
            // nesne üretimi
            Customer customer = new Customer();
            customer.Call();

            Customer? customer1 = null;
            //customer1 = new Customer();
            //Console.WriteLine(customer1.age);
            //customer1.Call();

            // nullables
            // bir değişkenin yada nesnenin ilk değerinin null olabileceğini ifade eder.
            int? number = null;
            Console.WriteLine(number);
            if (number == null)
            {
                Console.WriteLine("Lütfen yaşınızı giriniz!");
                number = 20;
            }

            string? name = null;
            Console.WriteLine(name);

            // ? fonksiyon parametreleri
            customer.Params("Erkan", 20, "erkan@mail.com");
            customer.Params("Serkan", null, null);

            // string class
            string data = new string("");
            string text = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.";

            // string to char[]
            char[] chars = text.ToArray();
            foreach(char c in chars)
            {
                Console.WriteLine(c);
            }

            char[] words = { 'B', 'u', 'g', 'ü', 'n' };
            string newWords = new string(words);
            Console.WriteLine(newWords);

            Console.WriteLine("=====================");
            int size = text.Length;
            Console.WriteLine(size);

            Console.WriteLine("=====================");
            // join
            string ad = "Serkan";
            string soyad = "Bilirim";
            string concat = ad + " " + soyad;
            Console.WriteLine(concat);

            concat = string.Concat(ad, " " ,soyad);
            concat = $"{ad} {soyad}";
            Console.WriteLine(concat);

            Console.WriteLine("=====================");
            string st1 = "this line 1";
            string st2 = "dhis line 2";
            int compare = string.Compare(st1, st2);
            Console.WriteLine(compare);

            Console.WriteLine("=====================");
            string username = "ali@mail.com";
            string password = "12345";
            
            if (username.Equals("ali@mail.com") && password.Equals("12345"))
            {
                Console.WriteLine("Login Success");
            }else
            {
                Console.WriteLine("Login Fail");
            }

            Console.WriteLine("=====================");
            bool statusContains = text.Contains("diz");
            Console.WriteLine(statusContains);

            string[] kelimeler = { "xdiz", "xlor", "xkul" };
            bool status = false;
            foreach ( string word in kelimeler )
            {
                status = text.Contains(word);
                if(status)
                {
                    break;
                }
            }

            if (status)
            {
                Console.WriteLine("Yorum yayınlanamaz!");
            }
            else
            {
                Console.WriteLine("Yorum yayınlanabilir!");
            }

            Console.WriteLine("=====================");
            string sub1 = text.Substring(13);// baştan asındaki karakterleri siler.
            sub1 = text.Substring(6, 12);
            sub1 = text.Substring(text.Length - 22, 6);// / -22 de sondan başlar silmeye
            Console.WriteLine(sub1);

            Console.WriteLine("=====================");
            string insertIndex = text.Insert(12, " yazı");// 12. indexten sonra yazı ekledi
            Console.WriteLine(insertIndex);

            Console.WriteLine("=====================");
            string removeIndex = text.Remove(11, 10);// 11. indexten geriye 10 karakter sil/kaldır demek
            Console.WriteLine(removeIndex);

            Console.WriteLine("=====================");
            string newString = text.Replace("Lorem", "***"); // loremi gördüğün her yere *** yaz
            Console.WriteLine(newString);

            Console.WriteLine("=====================");
            string[] arr = text.Split(" ");// split, elimdeki text değerindeki kelimelerin " " boşlukları hesaplayıp önce ve sonrasını bir dizi haline getirir
            foreach (string word in arr)
            {
                //Console.WriteLine(word);
            }
            string[] arrCumle = text.Split("."); // burada da . ya göre ayrıştırır
            Console.WriteLine($"Kelime Sayısı: {arr.Length-1}");// 33 kelime
            Console.WriteLine($"Cümle Sayısı: {arrCumle.Length-1}");
            string userData = "19-25-Ali Bilmem-ali@mail.com";
            string[] stArr = userData.Split("-");
            Console.WriteLine(stArr[0]);
            Console.WriteLine(stArr[1]);
            Console.WriteLine(stArr[2]);
            Console.WriteLine(stArr[3]);

            Console.WriteLine("=====================");
            string lowerCase = text.ToLower();// tüm karakterleri küçültür
            Console.WriteLine(lowerCase);
            string upperCase = text.ToUpper();
            Console.WriteLine(upperCase);// büyütür

            Console.WriteLine("=====================");
            string email = "  ali @mail.com   ";
            email = email.Trim().Replace(" ", "");//sağlı sollu boşlukta sistemede bir karakterdir
                                                  //trim bu boşlukları kırpar ama --> ali @mail.com
                                                  //buradaki boşluğa etki edememez!
          
            Console.WriteLine(email);

            string userName = "   Zehra    ";
            Console.WriteLine(userName.TrimStart());// sadece baştaki boşlukları temizle
            Console.WriteLine(userName.TrimEnd());// sadece sondaki boşlukları temizle

            Console.WriteLine("=====================");
            string title = "Fenerbahçe Şampiyon";//19 karakter var
            title = title.PadRight(22,'*'); //22 karakere tamamlanıncaya kadar sonuna *** koyar

            Console.WriteLine(title);

            Console.WriteLine("=====================");
            int indexOf = text.IndexOf("dizgi");//dizgi ifadesi hangi indexten başalar onu gösterir d-->13 de
            Console.WriteLine(indexOf);

        }
    }
}