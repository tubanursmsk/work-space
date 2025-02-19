using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* struct da properties de bir dizinin n. ... elemanın elekte tutulmasına yarar mesela:

UserModel{
id, name, surname, email }
 UserModel[] user = {u1, u2, u3};
string userx = {"ali","veli","ayşe","gül"}

 srtuct ın dez. avantajı değişkenlerin boyutuna sınırlama getiremez misal string 
değişkenin max. değerine kadar kullaınıcıya yazım hakkı sunar. name kısmı max 20 
karakter olsun dedirtemeyiz. properties kullanımının bu konuda avantajı vardır.
*/

namespace Days_15.properties
{
    public struct ProductModel
    {

        public int pid;
        public string title;
        public string detail;
        public int price;

    }
}