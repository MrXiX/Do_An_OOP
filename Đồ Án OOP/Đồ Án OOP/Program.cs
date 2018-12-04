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
            lienminh.NhapListKyNang();

            //lienminh.NhapListTrangBi();

            lienminh.NhapListNhanVat();

            //lienminh.XuatListTrangBi();

            //lienminh.XuatListKyNang();

            lienminh.NhapKyNangListNhanVat();

          
            lienminh.XuatListNhanVat();

            //NhanVat tanker = new DoDon();
            //tanker.NhapThongTin();
            //tanker.Update();
            //tanker.XuatThongTin();

            Console.ReadKey();
        }




    }
}
