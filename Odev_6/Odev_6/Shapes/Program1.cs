using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_6.Shapes
{

   
    public class Program1
    {
        public static void Main(string[] args)
        {

            Circle1 circle1 = new Circle1(11); 
            Rectangle rectangle = new Rectangle(6, 11); 

            
            Console.WriteLine("Dairenin Alanı: " + circle1.CalculateArea()); 
            Console.WriteLine("Dikdörtgenin Alanı: " + rectangle.CalculateArea()); 





            // Circle ve Square nesnelerini oluşturuyoruz.
            Circle circle = new Circle();
            Square square = new Square();

            // Her iki şekli çizdiriyoruz.
            circle.Draw();  
            square.Draw();  

        }
    }
}
