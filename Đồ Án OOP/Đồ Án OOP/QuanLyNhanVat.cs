using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    class QuanLyNhanVat
    {
        private List<NhanVat> lNhanVat;

        private List<TrangBi> lTrangBi;

        private List<KyNang> lKyNang;

        private int iSoLuongNhanVat;

        private int iSoLuongDoDon;

        private int iSoLuongXaThu;

        private int iSoLuongPhapSu;

        private int iSoLuongDauSi;

        private int iSoLuongSatThu;

        private int iSoLuongKyNang;

        private int iSoLuongTrangBi;

        public List<NhanVat> LNhanVat { get => lNhanVat; set => lNhanVat = value; }
        public int ISoLuongNhanVat { get => iSoLuongNhanVat; set => iSoLuongNhanVat = value; }
        public int ISoLuongKyNang { get => iSoLuongKyNang; set => iSoLuongKyNang = value; }
        public int ISoLuongTrangBi { get => iSoLuongTrangBi; set => iSoLuongTrangBi = value; }
        public List<TrangBi> LTrangBi { get => lTrangBi; set => lTrangBi = value; }
        public List<KyNang> LKyNang { get => lKyNang; set => lKyNang = value; }

        public QuanLyNhanVat()
        {
            LNhanVat = new List<NhanVat>();

            LKyNang = new List<KyNang>();

            LTrangBi = new List<TrangBi>();

            this.iSoLuongNhanVat = 0;

            this.iSoLuongKyNang = 0;

            this.iSoLuongTrangBi = 0;
        }

        public QuanLyNhanVat(List<NhanVat> listnv, int soluongnv, List<KyNang> listkn, List<TrangBi> listtb)
        {
            this.lNhanVat = listnv;
            this.iSoLuongNhanVat = soluongnv;
            this.lKyNang = listkn;
            this.lTrangBi = listtb;
        }

        public void NhapListKyNang()
        {
            Console.WriteLine("Nhap so luong ky nang: ");
            this.iSoLuongKyNang = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongKyNang; i++)
            {
                KyNang a = new KyNang();
                a.Nhap();
                this.LKyNang.Add(a);
            }
        }

        public void NhapListTrangBi()
        {
            Console.WriteLine("Nhap so luong trang bi: ");
            this.ISoLuongTrangBi = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.ISoLuongTrangBi; i++)
            {
                TrangBi a = new TrangBi();
                a.Nhap();
                this.LTrangBi.Add(a);
            }
        }

        public void XuatListTrangBi()
        {
            Console.WriteLine("Danh sach trang bi:\n");
            for (int i = 0; i < this.lTrangBi.Count(); i++)
            {
                Console.WriteLine("{0}>>-------------------------", i);
                lTrangBi[i].Xuat();
            }

        }

        public void XuatListKyNang()
        {
            Console.WriteLine("Danh sach ky nang:\n");
            for (int i = 0; i < this.lKyNang.Count(); i++)
            {
                Console.WriteLine("{0}>>-------------------------", i);
                lKyNang[i].Xuat();
            }

        }
        public void NhapListNhanVat()
        {
            Console.WriteLine("Nhap so luong do don: ");
            this.iSoLuongDoDon = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongDoDon; i++)
            {
                NhanVat a = new DoDon();
                a.NhapThongTin();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong xa thu: ");
            this.iSoLuongXaThu = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongXaThu; i++)
            {
                NhanVat a = new XaThu();
                a.NhapThongTin();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong phap su: ");
            this.iSoLuongPhapSu = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongPhapSu; i++)
            {
                NhanVat a = new PhapSu();
                a.NhapThongTin();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong dau si: ");
            this.iSoLuongDauSi = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongDauSi; i++)
            {
                NhanVat a = new DauSi();
                a.NhapThongTin();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong sat thu: ");
            this.iSoLuongSatThu = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongSatThu; i++)
            {
                NhanVat a = new SatThu();
                a.NhapThongTin();
                LNhanVat.Add(a);
            }

        }

        public void NhapKyNangNhanVat(NhanVat a)
        {
            Console.WriteLine("Nhap so luong ky nang: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Chon ky nang: ");
                XuatListKyNang();
                int chon = int.Parse(Console.ReadLine());
                a.AddKyNang(lKyNang[chon]);
            }
        }

        public void NhapKyNangListNhanVat()
        {
            for (int i = 0; i < LNhanVat.Count; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", i);
                NhapKyNangNhanVat(LNhanVat[i]);
            }
        }

        public void XuatListNhanVat()
        {
            for(int i=0;i<LNhanVat.Count;i++)
            {
                Console.WriteLine("+Nhan vat {0}: ", i);
                //LNhanVat[i].Update();
                LNhanVat[i].Xuat();
            }
        }

    }
}
