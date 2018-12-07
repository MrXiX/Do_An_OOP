using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    class GenericSwap<T>
    {
      public void Swap(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
