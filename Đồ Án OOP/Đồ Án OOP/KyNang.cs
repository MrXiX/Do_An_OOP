using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    class KyNang : IKyNang
    {
        private string sTenKyNang;

        private string sLoaiKyNang;

        private string sMieuTa;

        public string STenKyNang { get => sTenKyNang; set => sTenKyNang = value; }
        public string SLoaiKyNang { get => sLoaiKyNang; set => sLoaiKyNang = value; }
        public string SMieuTa { get => sMieuTa; set => sMieuTa = value; }

        public KyNang()
        {
            this.sTenKyNang = "";
            this.SLoaiKyNang = "";
            this.sMieuTa = "";
        }

        public KyNang(string tenkn, string loaikn, string mieuta)
        {
            this.STenKyNang = tenkn;
            this.SLoaiKyNang = loaikn;
            this.SMieuTa = mieuta;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ten ky nang: ");
            this.STenKyNang = Console.ReadLine();
            int a;
            do
            {
                Console.WriteLine("Nhap loai ky nang: \n1: CHU DONG.\n2: BI DONG.\n");
                a = int.Parse(Console.ReadLine());
            } while (a != 1 && a != 2);
            if (a == 1)
                this.SLoaiKyNang = "Chu dong.";
            else
                this.SLoaiKyNang = "Bi dong.";

            Console.WriteLine("Mieu ta: ");
            this.SMieuTa = Console.ReadLine();
        }

        public void Nhap(string tenkn, int loaikn, string mieuta)
        {
            this.sTenKyNang = tenkn;

            if (loaikn == 2)
                this.SLoaiKyNang = "Bi dong";
            else
                this.SLoaiKyNang = "Chu dong";

            this.sMieuTa = mieuta;
        }

        public void DocFile()
        {
            string line = "";
            StreamReader file = new StreamReader("KyNang.txt");
            while ((line = file.ReadLine()) != null)
            {
                this.sTenKyNang = line;
                this.sLoaiKyNang = file.ReadLine();
                this.sMieuTa = file.ReadLine();
            }
            file.Close();
        }

        public void Xuat()
        {
            Console.WriteLine("- Ten ky nang:" + this.sTenKyNang);
            Console.WriteLine("- Loai ky nang: " + this.SLoaiKyNang);
            Console.WriteLine("- Mieu ta: " + this.sMieuTa);
        }
    }
}
