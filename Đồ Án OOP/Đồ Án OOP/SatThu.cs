using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    class SatThu : NhanVat
    {
        private double dBaoKichCB;

        private double dBaoKich;

        public string STenNV { get => base.STenNV; set => base.STenNV = value; }
        public int ILevel { get => base.ILevel; set => base.ILevel = value; }
        public int IHealthCB { get => iHealthCB; set => iHealthCB = value; }
        public int IHealth { get => iHealth; set => iHealth = value; }
        public int IManaCB { get => iManaCB; set => iManaCB = value; }
        public int IMana { get => iMana; set => iMana = value; }
        public int ISatThuongCB { get => iSatThuongCB; set => iSatThuongCB = value; }
        public int ISatThuong { get => iSatThuong; set => iSatThuong = value; }
        public int ISucManhPhepThuatCB { get => iSucManhPhepThuatCB; set => iSucManhPhepThuatCB = value; }
        public int ISucManhPhepThuat { get => iSucManhPhepThuat; set => iSucManhPhepThuat = value; }
        public int IGiapCB { get => iGiapCB; set => iGiapCB = value; }
        public int IGiap { get => iGiap; set => iGiap = value; }
        public double DTocDoDanhCB { get => dTocDoDanhCB; set => dTocDoDanhCB = value; }
        public double DTocDoDanh { get => dTocDoDanh; set => dTocDoDanh = value; }
        public int ITocDoDiChuyenCB { get => iTocDoDiChuyenCB; set => iTocDoDiChuyenCB = value; }
        public int ITocDoDiChuyen { get => iTocDoDiChuyen; set => iTocDoDiChuyen = value; }


        public double DBaoKichCB { get => dBaoKichCB; set => dBaoKichCB = value; }
        public double DBaoKich { get => dBaoKich; set => dBaoKich = value; }

        public SatThu() : base()
        {
            this.dBaoKichCB = 0.01;
        }

        public SatThu(SatThu a) : base(a)
        {

        }

        public SatThu(string tennv, int level, int health, int mana, int iXuyenGiapong,
                        int sucmanhpt, int giap, double tocdodanh, int tocdodichuyen, double baophep) :
            base(tennv, level, health, mana, iXuyenGiapong,
                        sucmanhpt, giap, tocdodanh, tocdodichuyen)

        {
            this.dBaoKichCB = baophep;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Kha nang Bao kich: " + this.dBaoKich * 100 + "%");
        }

        public override void Xuat()
        {
            base.Xuat();
        }

        public override void Update()
        {
            base.Update();
            this.dBaoKich = this.dBaoKichCB + 0.01 * this.ILevel;

            if (this.dBaoKich > 1.0)
                this.dBaoKich = 1.0;
        }
    }
}
