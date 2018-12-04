using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    interface ITrangBi
    {
        void Nhap();
        void Nhap(string ten, int giatien, int mau, int mana, int satthuong,
                    int sucmanhphepthuat, int giap, int tocdodichuyen, double tocdodanh);
        void Xuat();
    }
}
