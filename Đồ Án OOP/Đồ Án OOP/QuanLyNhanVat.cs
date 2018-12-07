using System;
using System.Collections.Generic;
using System.IO;
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
                Console.WriteLine("+ Ky nang {0}: ", i);
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
                Console.WriteLine("+ Trang bi {0}: ", i);
                TrangBi a = new TrangBi();
                a.Nhap();
                this.LTrangBi.Add(a);
            }
        }

        public void NhapListNhanVat()
        {
            int j = 0;
            Console.WriteLine("Nhap so luong do don: ");
            this.iSoLuongDoDon = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongDoDon; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
                NhanVat a = new DoDon();
                a.NhapThongTin();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong xa thu: ");
            this.iSoLuongXaThu = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongXaThu; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
                NhanVat a = new XaThu();
                a.NhapThongTin();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong phap su: ");
            this.iSoLuongPhapSu = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongPhapSu; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
                NhanVat a = new PhapSu();
                a.NhapThongTin();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong dau si: ");
            this.iSoLuongDauSi = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongDauSi; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
                NhanVat a = new DauSi();
                a.NhapThongTin();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong sat thu: ");
            this.iSoLuongSatThu = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongSatThu; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
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

                try
                {
                    a.AddKyNang(lKyNang[chon]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ban chon sai!");
                }

            }
        }

        public void NhapKyNangListNhanVat()
        {
            for (int i = 0; i < LNhanVat.Count; i++)
            {
                Console.WriteLine("Nhan vat {0}: ", lNhanVat[i].STenNV);
                NhapKyNangNhanVat(LNhanVat[i]);
            }
        }

        public void NhapTrangBiNhanVat(NhanVat a)
        {
            Console.WriteLine("Nhap so luong trang bi: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Chon trang bi: ");
                XuatListTrangBi();
                int chontb = int.Parse(Console.ReadLine());
                try
                {
                    a.AddTrangBi(LTrangBi[chontb]);

                }
                catch (Exception)
                {
                    Console.WriteLine("Ban chon sai!");
                }
            }
        }

        public void NhapTrangBiListNhanVat()
        {
            for (int i = 0; i < LNhanVat.Count; i++)
            {
                Console.WriteLine("Nhan vat {0}: ", lNhanVat[i].STenNV);
                NhapTrangBiNhanVat(LNhanVat[i]);
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

        public void XuatListNhanVat()
        {
            for(int i=0;i<LNhanVat.Count;i++)
            {
                Console.WriteLine("+Nhan vat {0}: ", i);
                LNhanVat[i].Update();
                LNhanVat[i].Xuat();
            }
        }

        public void Nhap()
        {
            int j = 0;
            Console.WriteLine("Nhap so luong do don: ");
            this.iSoLuongDoDon = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongDoDon; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
                NhanVat a = new DoDon();
                a.Nhap();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong xa thu: ");
            this.iSoLuongXaThu = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongXaThu; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
                NhanVat a = new XaThu();
                a.Nhap();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong phap su: ");
            this.iSoLuongPhapSu = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongPhapSu; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
                NhanVat a = new PhapSu();
                a.Nhap();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong dau si: ");
            this.iSoLuongDauSi = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongDauSi; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
                NhanVat a = new DauSi();
                a.Nhap();
                LNhanVat.Add(a);
            }

            Console.WriteLine("Nhap so luong sat thu: ");
            this.iSoLuongSatThu = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.iSoLuongSatThu; i++)
            {
                Console.WriteLine("Nhan vat thu {0}: ", j);
                j++;
                NhanVat a = new SatThu();
                a.Nhap();
                LNhanVat.Add(a);
            }

        }

        public void NhapfileTrangBi()
        {
            using (StreamReader sr = new StreamReader("TrangBi.txt"))
            {
                int n;
                n = Convert.ToInt32(sr.ReadLine());
                int i = 0;
                try
                {
                    while (i < n)
                    {
                        TrangBi a = new TrangBi();
                        a.STenTrangBi = sr.ReadLine();
                        a.IGiaTien = Convert.ToInt32(sr.ReadLine());
                        a.IHealth = Convert.ToInt32(sr.ReadLine());
                        a.IMana = Convert.ToInt32(sr.ReadLine());
                        a.ISatThuong = Convert.ToInt32(sr.ReadLine());
                        a.ISucManhPhepThuat = Convert.ToInt32(sr.ReadLine());
                        a.IGiap = Convert.ToInt32(sr.ReadLine());
                        a.DTocDoDanh = Convert.ToDouble(sr.ReadLine());
                        a.ITocDoDiChuyen = Convert.ToInt32(sr.ReadLine());
                        this.lTrangBi.Add(a);
                        i++;
                    }
                    sr.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Loi nhap File!");
                }
            }

        }

        public void NhapfileKyNang()
        {
            using (StreamReader sr = new StreamReader("KyNang.txt"))
            {
                //string line;
                int n;
                n = Convert.ToInt32(sr.ReadLine());
                int i = 0;
                try
                {
                    while (i < n)
                    {
                        KyNang a = new KyNang();
                        a.STenKyNang = sr.ReadLine();
                        a.SLoaiKyNang = sr.ReadLine();
                        a.SMieuTa = sr.ReadLine();
                        i++;
                        this.lKyNang.Add(a);
                    }
                    sr.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Loi nhap File!");
                }
            }

        }

        public void NhapfileNhanVat()
        {
            using (StreamReader sr = new StreamReader("NhanVat.txt"))
            {
                //string line;
                int n;
                n = Convert.ToInt32(sr.ReadLine());
                int i = 0;
                try
                {
                    while (i < n)
                    {
                        i++;
                        string loai;
                        loai = sr.ReadLine();
                        switch(loai)
                        {
                            case "Do don":
                                DoDon a = new DoDon();
                                a.STenNV = sr.ReadLine();
                                a.ILevel = Convert.ToInt32(sr.ReadLine());
                                a.IHealthCB = Convert.ToInt32(sr.ReadLine());
                                a.IManaCB = Convert.ToInt32(sr.ReadLine());
                                a.ISatThuongCB = Convert.ToInt32(sr.ReadLine());
                                a.ISucManhPhepThuatCB = Convert.ToInt32(sr.ReadLine());
                                a.IGiapCB = Convert.ToInt32(sr.ReadLine());
                                a.DTocDoDanhCB = Convert.ToDouble(sr.ReadLine());
                                a.ITocDoDiChuyenCB = Convert.ToInt32(sr.ReadLine());
                                LNhanVat.Add(a);
                                break;

                            case "Xa thu":
                                XaThu b = new XaThu();
                                b.STenNV = sr.ReadLine();
                                b.ILevel = Convert.ToInt32(sr.ReadLine());
                                b.IHealthCB = Convert.ToInt32(sr.ReadLine());
                                b.IManaCB = Convert.ToInt32(sr.ReadLine());
                                b.ISatThuongCB = Convert.ToInt32(sr.ReadLine());
                                b.ISucManhPhepThuatCB = Convert.ToInt32(sr.ReadLine());
                                b.IGiapCB = Convert.ToInt32(sr.ReadLine());
                                b.DTocDoDanhCB = Convert.ToDouble(sr.ReadLine());
                                b.ITocDoDiChuyenCB = Convert.ToInt32(sr.ReadLine());
                                LNhanVat.Add(b);
                                break;
                            case "Sat thu":
                                SatThu c = new SatThu();
                                c.STenNV = sr.ReadLine();
                                c.ILevel = Convert.ToInt32(sr.ReadLine());
                                c.IHealthCB = Convert.ToInt32(sr.ReadLine());
                                c.IManaCB = Convert.ToInt32(sr.ReadLine());
                                c.ISatThuongCB = Convert.ToInt32(sr.ReadLine());
                                c.ISucManhPhepThuatCB = Convert.ToInt32(sr.ReadLine());
                                c.IGiapCB = Convert.ToInt32(sr.ReadLine());
                                c.DTocDoDanhCB = Convert.ToDouble(sr.ReadLine());
                                c.ITocDoDiChuyenCB = Convert.ToInt32(sr.ReadLine());
                                LNhanVat.Add(c);
                                break;
                            case "Dau si":
                                DauSi d = new DauSi();
                                d.STenNV = sr.ReadLine();
                                d.ILevel = Convert.ToInt32(sr.ReadLine());
                                d.IHealthCB = Convert.ToInt32(sr.ReadLine());
                                d.IManaCB = Convert.ToInt32(sr.ReadLine());
                                d.ISatThuongCB = Convert.ToInt32(sr.ReadLine());
                                d.ISucManhPhepThuatCB = Convert.ToInt32(sr.ReadLine());
                                d.IGiapCB = Convert.ToInt32(sr.ReadLine());
                                d.DTocDoDanhCB = Convert.ToDouble(sr.ReadLine());
                                d.ITocDoDiChuyenCB = Convert.ToInt32(sr.ReadLine());
                                LNhanVat.Add(d);
                                break;
                            case "Phap su":
                                PhapSu e = new PhapSu();
                                e.STenNV = sr.ReadLine();
                                e.ILevel = Convert.ToInt32(sr.ReadLine());
                                e.IHealthCB = Convert.ToInt32(sr.ReadLine());
                                e.IManaCB = Convert.ToInt32(sr.ReadLine());
                                e.ISatThuongCB = Convert.ToInt32(sr.ReadLine());
                                e.ISucManhPhepThuatCB = Convert.ToInt32(sr.ReadLine());
                                e.IGiapCB = Convert.ToInt32(sr.ReadLine());
                                e.DTocDoDanhCB = Convert.ToDouble(sr.ReadLine());
                                e.ITocDoDiChuyenCB = Convert.ToInt32(sr.ReadLine());
                                LNhanVat.Add(e);
                                break;

                            default:
                                Console.WriteLine("File loi!");
                                break;
                        }

                    }
                    sr.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Loi nhap File!");
                }
            }

        }

        public void SapXep()
        {
            GenericSwap<NhanVat> hoanvi = new GenericSwap<NhanVat>();
            NhanVat[] A = new NhanVat[100];
            A = this.LNhanVat.ToArray();

            for (int i = 0; i < A.Length - 1; i++)
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                        hoanvi.Swap(ref A[i], ref A[j]);
                }
            this.lNhanVat.Clear();
            for (int i = 0; i < A.Length; i++)
                lNhanVat.Add(A[i]);
        }

        private void QuickSort(NhanVat[] a, int l, int r)
        {
            GenericSwap<NhanVat> hoanvi = new GenericSwap<NhanVat>();
            int t;
            int mid = (l + r) / 2;
            int i = l, j = r;

            while (i <= j)
            {
                while (a[i] < a[mid])
                    i++;

                while (a[mid] < a[j])
                    j--;

                if (i <= j)
                {
                    hoanvi.Swap(ref a[i], ref a[j]);
                    i++;
                    j--;
                }
            }

            if (j > l) QuickSort(a, l, j);
            if (i < r) QuickSort(a, i, r);
        }

        public void SapXepNhanh()
        {
            NhanVat[] A = new NhanVat[100];
            A = this.LNhanVat.ToArray();
            int r = A.Length;
            QuickSort(A, 0, r - 1);

            this.lNhanVat.Clear();
            for (int i = 0; i < A.Length; i++)
                lNhanVat.Add(A[i]);
        }

    }

}
