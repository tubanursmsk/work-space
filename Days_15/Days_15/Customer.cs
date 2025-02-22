using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Abstract sınıf nedir?
// (https://medium.com/@yigitcanolmez/c-abstract-class-soyut-s%C4%B1n%C4%B1f-nedir-interface-ile-fark%C4%B1-ne-e250fdee3a72)
// https://medium.com/@srhtayata/c-abstraction-soyutlama-bb1a8f3dddd6
// 1-Abstraction (Soyutlama) detayları saklama ve sadece gösterilmesi istenen bilgileri
// kullanıcıya göstermek amacıyla kullanılır. Abstraction(Soyutlama)
// hem Abstract class(soyutlama sınıfları) ile hem de interfaces (arayüzler) ile yapılır.

// 2- Abstract classların en önemli detaylarından biri new keyword’ü ile nesne türetemez.
//Türeyememe nedeni, base class olmasından kaynaklıdır.Nesne oluşturamıyoruz ama kalıtım
//özelliğini kullanabiliriz, kod tekrarını azaltmış oluruz.

// 3-abstract class kalıtım sağladığı sınıflara nasıl olmaları gerektiğini anlatır. Bir base
// class(temel sınıf) işlevi görmektedir.

// ***Neden soyut sınıf(abstract class) ve metotlarını kullanırız?
//Güvenliği sağlamak ve nesnenin önemli detaylarını göstermek amacıyla kullanılır.
//Soyutlama ayrıca interface(arayüz) ile de uygulanabilir. Şimdi onun üzerinde duralım.

//soyut metod = gövdesiz metod..

namespace Days_15
{
    public abstract class Customer 
    {
        public abstract int GetCustomeId(); // bu satırda soyut sınıfın içinde soyut metod yazdık
                                            // ***abstract sınıfı, sınıfın içindeki metodların yazılımcıya zorunlu olarak doldurulmasını sağlar böylece programın hata oranını azaltır.
                                            // Peki interface neden kullanmadık onda da altındaki metodları doldurmak zorunluydu..?
                                            // Interface de gövdesis metod yazabiliriz ama gövdeli yazamayız. Bu açıdan abstract hem gövdesiz hem gövdeli metod kulannımı ile daha maharetlidir.
        
        // total
        // name

        public string GetName()
        {
            int customerID = GetCustomeId();
            if (customerID == 100)
            {
                return "Ali Bilmem";
            }
            else if (customerID == 200)
            {
                return "Zehra Bilirim";
            }
            return "";
        }

        public int GetTotal()
        {
            int customerID = GetCustomeId();
            if (customerID == 100)
            {
                return 1000000;
            }
            else if (customerID == 200)
            {
                return 2000000;
            }
            return 0;
        }


    }
}

