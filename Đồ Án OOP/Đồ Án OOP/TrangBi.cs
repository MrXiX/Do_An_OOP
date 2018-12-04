using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    class TrangBi : ITrangBi
    {
        private string sTenTrangBi;
        private int iGiaTien;
        private int iHealth;
        private int iMana;
        private int iSatThuong;
        private double dTocDoDanh;
        private int iTocDoDiChuyen;
        private int iGiap;
        private int iSucManhPhepThuat;

        public string STenTrangBi { get => sTenTrangBi; set => sTenTrangBi = value; }
        public int IGiaTien { get => iGiaTien; set => iGiaTien = value; }
        public int IHealth { get => iHealth; set => iHealth = value; }
        public int IMana { get => iMana; set => iMana = value; }
        public int ISatThuong { get => iSatThuong; set => iSatThuong = value; }
        public double DTocDoDanh { get => dTocDoDanh; set => dTocDoDanh = value; }
        public int ITocDoDiChuyen { get => iTocDoDiChuyen; set => iTocDoDiChuyen = value; }
        public int IGiap { get => iGiap; set => iGiap = value; }
        public int ISucManhPhepThuat { get => iSucManhPhepThuat; set => iSucManhPhepThuat = value; }

        public TrangBi()
        {
            this.STenTrangBi = "Trang Bi...";

            this.IGiaTien = 0;

            this.IHealth = 0;

            this.IMana = 0;

            this.ISatThuong = 0;

            this.DTocDoDanh = 0;

            this.ITocDoDiChuyen = 0;

            this.IGiap = 0;

            this.ISucManhPhepThuat = 0;
        }

        public TrangBi(string ten, int giatien, int mau, int mana, int satthuong,
            int sucmanhphepthuat, int giap, int tocdodichuyen, double tocdodanh)
        {
            this.STenTrangBi = ten;

            this.IGiaTien = giatien;

            this.IHealth = mau;

            this.IMana = mana;

            this.ISatThuong = satthuong;

            this.DTocDoDanh = tocdodanh;

            this.ITocDoDiChuyen = tocdodichuyen;

            this.IGiap = giap;

            this.ISucManhPhepThuat = sucmanhphepthuat;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ten trang bi: ");
            this.STenTrangBi = Console.ReadLine();

            Console.WriteLine("Nhap gia tien: ");
            this.IGiaTien = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Mau: ");
            this.IHealth = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Mana: ");
            this.IMana = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Sat thuong: ");
            this.ISatThuong = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Suc manh phep thuat: ");
            this.ISucManhPhepThuat = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Giap: ");
            this.IGiap = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Toc do danh: ");
            this.DTocDoDanh = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap toc do di chuyen: ");
            this.ITocDoDiChuyen = int.Parse(Console.ReadLine());
        }

        public void Nhap(string ten, int giatien, int mau, int mana, int satthuong, 
            int sucmanhphepthuat, int giap, int tocdodichuyen, double tocdodanh)
        {
            this.STenTrangBi = ten;

            this.IGiaTien = giatien;

            this.IHealth = mau;

            this.IMana = mana;

            this.ISatThuong = satthuong;

            this.DTocDoDanh = tocdodanh;

            this.ITocDoDiChuyen = tocdodichuyen;

            this.IGiap = giap;

            this.ISucManhPhepThuat = sucmanhphepthuat;
        }

        public void DocFile()
        {
            string line = "";
            StreamReader sr = new StreamReader("TrangBi.txt");
            while ((line = sr.ReadLine()) != null)
            {
                this.STenTrangBi = line;
                this.IGiaTien = int.Parse(sr.ReadLine());
                this.iHealth = int.Parse(sr.ReadLine());
                this.iMana = int.Parse(sr.ReadLine());
                this.ISatThuong = int.Parse(sr.ReadLine());
                this.DTocDoDanh = double.Parse(sr.ReadLine());
                this.iTocDoDiChuyen = int.Parse(sr.ReadLine());
                this.iMana = int.Parse(sr.ReadLine());
                this.iGiap = int.Parse(sr.ReadLine());
                this.iSucManhPhepThuat = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }


        public void Xuat()
        {
            Console.WriteLine("Ten TB: " + this.STenTrangBi);

            Console.WriteLine("Gia tien: " + this.IGiaTien);

            Console.WriteLine("+ Mau: " + this.IHealth);

            Console.WriteLine("+ Mana: " + this.IMana);

            Console.WriteLine("+ Sat thuong: " + this.ISatThuong);

            Console.WriteLine("+ Suc manh phep thuat: " + this.ISucManhPhepThuat);

            Console.WriteLine("+ Giap: " + this.IGiap);

            Console.WriteLine("+ Toc do danh: " + this.DTocDoDanh);

            Console.WriteLine("+ Toc do di chuyen: " + this.ITocDoDiChuyen);
        }
    }
}
