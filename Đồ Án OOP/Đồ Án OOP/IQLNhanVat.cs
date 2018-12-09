using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    interface IQLNhanVat
    {
        void Nhap();
        void XuatListNhanVat();
        void SapXep();
        void SapXepQuickSort();
        void TimTenNV(string s);
        void TimLevel(int level);
        void ThayDoiTen(int x, string s);
        void ThayDoiLevel(int x, int level);

    }
}
