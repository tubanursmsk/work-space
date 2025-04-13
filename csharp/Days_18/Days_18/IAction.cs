using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_18
{
    public interface IAction
    {
        int Minus(int num1, int num2);
        string UserName(int uid);
    }
}
