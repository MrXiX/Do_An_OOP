using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Đồ_Án_OOP
{
    class NhanVat: IComparable 
    {
        protected string sTenNV;

        protected int iLevel;

        protected int iHealthCB;

        protected int iHealth;

        protected int iManaCB;

        protected int iMana;

        protected int iSatThuongCB;

        protected int iSatThuong;

        protected int iSucManhPhepThuatCB;

        protected int iSucManhPhepThuat;

        protected int iGiapCB;

        protected int iGiap;

        protected double dTocDoDanhCB;

        protected double dTocDoDanh;

        protected int iTocDoDiChuyenCB;

        protected int iTocDoDiChuyen;

        protected List<TrangBi> DanhSachTrangBi;

        protected List<KyNang> DanhSachKyNang;

        public string STenNV { get => sTenNV; set => sTenNV = value; }

        public NhanVat()
        {
            this.DanhSachKyNang = new List<KyNang>();
            this.DanhSachTrangBi = new List<TrangBi>();
        }

        public NhanVat(NhanVat a)
        {
            this.STenNV = a.STenNV;
            this.iLevel = a.iLevel;
            this.iHealthCB = a.iHealthCB;
            this.iManaCB = a.iManaCB;
            this.iSatThuongCB = a.iSatThuongCB;
            this.iSucManhPhepThuatCB = a.iSucManhPhepThuatCB;
            this.iGiapCB = a.iGiapCB;
            this.dTocDoDanhCB = a.dTocDoDanhCB;
            this.iTocDoDiChuyenCB = a.iTocDoDiChuyenCB;
            this.DanhSachKyNang = new List<KyNang>(a.DanhSachKyNang);
            this.DanhSachTrangBi = new List<TrangBi>(a.DanhSachTrangBi);

        }

        public NhanVat(string tennv)
        {
            this.STenNV = tennv;
            this.iLevel = 1;
            this.iHealthCB = this.iHealth = 100;
            this.iManaCB = this.iMana = 50;
            this.iSatThuongCB = this.iSatThuong = 10;
            this.iGiapCB = this.iGiap = 5;
            this.iSucManhPhepThuatCB = this.iSucManhPhepThuat = 10;
            this.dTocDoDanhCB = this.dTocDoDanh = 1.0;
            this.iTocDoDiChuyenCB = this.iTocDoDiChuyen = 100;
            DanhSachTrangBi = new List<TrangBi>();
            DanhSachKyNang = new List<KyNang>();
        }

        public NhanVat(string tennv, int level, int health, int mana, int satthuong,
                        int sucmanhpt, int giap, double tocdodanh, int tocdodichuyen)
        {
            this.STenNV = tennv;
            this.iLevel = level;
            this.iHealthCB = health;
            this.iManaCB = mana;
            this.iSatThuongCB = satthuong;
            this.iSucManhPhepThuatCB = sucmanhpt;
            this.iGiapCB = giap;
            this.dTocDoDanhCB = tocdodanh;
            this.iTocDoDiChuyenCB = tocdodichuyen;
        }

        public void Nhap()
        {
            NhapThongTin();
            NhapKyNang();
            NhapTrangBi();
        }

        public void NhapThongTin()
        {
            try
            {
                Console.WriteLine("Nhap ten nhan vat: ");
                this.STenNV = Console.ReadLine();

                Console.WriteLine("Nhap Level: ");
                this.iLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhap Health: ");
                this.iHealthCB = this.iHealth = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhap Mana: ");
                this.iManaCB = this.iMana = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhap Sat thuong: ");
                this.iSatThuongCB = this.iSatThuong = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhap Suc manh phep thuat: ");
                this.iSucManhPhepThuatCB = this.iSucManhPhepThuat = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhap Giap: ");
                this.iGiapCB = this.iGiap = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhap Toc do danh: ");
                this.dTocDoDanhCB = this.dTocDoDanh = double.Parse(Console.ReadLine());

                Console.WriteLine("Nhap Toc do di chuyen: ");
                this.iTocDoDiChuyenCB = this.iTocDoDiChuyen = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Kieu du lieu sai!!!");
            }
        }

        public void NhapKyNang()
        {
            int sl;

            Console.WriteLine("Nhap so luong ky nang: ");
            sl = int.Parse(Console.ReadLine());

            for(int i =0;i<sl;i++)
            {
                Console.WriteLine("+ Ky nang " + i);
                KyNang skill = new KyNang();
                skill.Nhap();
                this.DanhSachKyNang.Add(skill);
            }

        }

        public void NhapTrangBi()
        {
            Console.Write("Nhap so luong trang bi: ");
            int sl;
            sl = int.Parse(Console.ReadLine());

            for (int i = 0; i < sl; i++)
            {
                Console.WriteLine("+ Trang bi " + i);
                TrangBi TB = new TrangBi();
                TB.Nhap();
                this.DanhSachTrangBi.Add(TB);
            }
        }

        public void XuatTrangBi()
        {
            try
            {
                Console.WriteLine("Danh sach trang bi:\n");
                for (int i = 0; i < DanhSachTrangBi.Count(); i++)
                {
                    Console.WriteLine("{0}.-------------------------", i);
                    DanhSachTrangBi[i].Xuat();
                }
            }catch(Exception)
            {
                Console.WriteLine("NULL!");
            }
        }

        public void XuatKyNang()
        {
            try
            {
                Console.WriteLine("Danh sach ky nang:\n");
                for (int i = 0; i < DanhSachKyNang.Count; i++)
                {
                    Console.WriteLine("{0}.-------------------------", i);
                    DanhSachKyNang[i].Xuat();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("NULL!");
            }
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Name: " + this.STenNV);
            Console.WriteLine("Level: " + this.iLevel);
            Console.WriteLine("Health: " + this.iHealth);
            Console.WriteLine("Mana: " + this.iMana);
            Console.WriteLine("Magic: " + this.iSucManhPhepThuat);
            Console.WriteLine("Armor: " + this.iGiap);
            Console.WriteLine("Hit speed: " + this.dTocDoDanh);
            Console.WriteLine("Run speed: " + this.iTocDoDiChuyen);
        }

        public virtual void Xuat()
        {
            XuatThongTin(); 
            XuatKyNang();
            XuatTrangBi();
        }

        public virtual void Update()
        {
            try
            {
                this.iHealth = this.iHealthCB;
                this.iMana = this.iManaCB;
                this.iSatThuong = this.iSatThuongCB;
                this.iSucManhPhepThuat = this.iSucManhPhepThuatCB;
                this.iGiap = this.iGiapCB;
                this.iTocDoDiChuyen = this.iTocDoDiChuyenCB;
                this.dTocDoDanh = this.dTocDoDanhCB;

                for (int i = 0; i < this.DanhSachTrangBi.Count; i++)
                {
                    this.iHealth = this.iHealthCB + DanhSachTrangBi[i].IHealth;
                    this.iMana = this.iManaCB + DanhSachTrangBi[i].IMana;
                    this.iSatThuong = this.iSatThuongCB + DanhSachTrangBi[i].ISatThuong;
                    this.iSucManhPhepThuat = this.iSucManhPhepThuatCB + DanhSachTrangBi[i].ISucManhPhepThuat;
                    this.iGiap = this.iGiapCB + DanhSachTrangBi[i].IGiap;
                    this.iTocDoDiChuyen = this.iTocDoDiChuyenCB + DanhSachTrangBi[i].ITocDoDiChuyen;
                    this.dTocDoDanh = this.dTocDoDanhCB + DanhSachTrangBi[i].DTocDoDanh;
                }

                this.iHealth += 100 * this.iLevel;
                this.iMana += 50 * this.iLevel;
                this.iSatThuong += 10 * this.iLevel;
                this.iSucManhPhepThuat += 10 * this.iLevel;
                this.iGiap += 5 * this.iLevel;
            }
            catch(Exception)
            { }
        }

        public void AddKyNang(KyNang a)
        {
            this.DanhSachKyNang.Add(a);
        }

        public void AddTrangBi(TrangBi a)
        {
            this.DanhSachTrangBi.Add(a);
        }



        public static bool operator ==(NhanVat a, NhanVat b)
        {
            return (a.iLevel == b.iLevel);
        }
        public static bool operator !=(NhanVat a, NhanVat b)
        {
            return (a.iLevel != b.iLevel);
        }

        public static NhanVat operator ++(NhanVat a)
        {
            a.iLevel++;
            a.Update();
            return a;
        }

        public static NhanVat operator --(NhanVat a)
        {
             a.iLevel--;
            a.Update();
            return a;
        }

        public static NhanVat operator +(NhanVat a,int b)
        {
            a.iLevel += b;
            a.Update();
            return a;
        }

        public static NhanVat operator -(NhanVat a, int b)
        {
            a.iLevel -= b;
            a.Update();
            return a;
        }

        public static bool operator >=(NhanVat a, NhanVat b)
        {
            return a.iLevel >= b.iLevel;
        }

        public static bool operator <=(NhanVat a, NhanVat b)
        {
            return a.iLevel <= b.iLevel;
        }

        public static bool operator >(NhanVat a, NhanVat b)
        {
            return a.iLevel > b.iLevel;
        }

        public static bool operator <(NhanVat a, NhanVat b)
        {
            return a.iLevel < b.iLevel;
        }

        public int CompareTo(object nvat)
        {
            NhanVat nv = nvat as NhanVat;
            if (this.iLevel > nv.iLevel)
                return 1;
            if (this.iLevel < nv.iLevel)
                return 0;
            return -1;
        }

        public void Gan(NhanVat a)
        {
            this.STenNV = a.STenNV;
            this.iLevel = a.iLevel;
            this.iHealthCB = a.iHealthCB;
            this.iManaCB = a.iManaCB;
            this.iSatThuongCB = a.iSatThuongCB;
            this.iSucManhPhepThuatCB = a.iSucManhPhepThuatCB;
            this.iGiapCB = a.iGiapCB;
            this.dTocDoDanhCB = a.dTocDoDanhCB;
            this.iTocDoDiChuyenCB = a.iTocDoDiChuyenCB;
            this.DanhSachKyNang = new List<KyNang>(a.DanhSachKyNang);
            this.DanhSachTrangBi = new List<TrangBi>(a.DanhSachTrangBi);
        }
    }
}
