using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_5
{
    public class Ogrenci
    {
        // Özellikler (Fields/Properties)
        public string AdSoyad;
        public int Yas;
        public double Fizik;
        public double Kimya;
        public double Matematik;

        public void OgrenciAdSoyad(string name, string surname)
        {
            this.AdSoyad = name + " " + surname; 
            Console.WriteLine($"Sn. {this.AdSoyad}");
        }

        public void OgrenciYas(int age)
        {
            this.Yas = age;
            Console.WriteLine($"Yaşınız: {this.Yas}");
        }

        public void NotlariKaydet(double fzk, double kmy, double mat)
        {
            Fizik = fzk;
            Kimya = kmy;
            Matematik = mat;
        }

        // Kaydedilen notlara göre ortalama hesaplayan fonksiyon
        public double OrtalamaHesapla()
        {
            return (double)(Fizik + Kimya + Matematik) / 3;
        }
    }
}
