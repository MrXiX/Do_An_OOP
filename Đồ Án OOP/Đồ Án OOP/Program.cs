using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Đồ_Án_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyNhanVat lienminh = new QuanLyNhanVat();

            lienminh.NhapfileTrangBi();
            lienminh.NhapfileKyNang();
            lienminh.NhapfileNhanVat();
            lienminh.NhapKyNangListNhanVat();
            lienminh.NhapTrangBiListNhanVat();
            Console.Clear();
            lienminh.SapXepNhanh();
            lienminh.XuatListNhanVat();
            Console.ReadKey();
        }


    }
}
