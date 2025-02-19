using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// struct ile properties yapılarının farkı?? her ikiside veriyi depolar properties verileri
// deneteleme kabileti varrır get ve setler ile ancak struct da veri denetimi yoktur.
//properties de daha kapsamlıdır.
//ör: struct da daha önceden denetlenmiş yapıların alınıp depolanmasında tercih edilir

namespace Days_16.Models
{
    public struct Product
    {
        public string title;
        public string detail;
        public int price;
        public bool status;
    }
}
