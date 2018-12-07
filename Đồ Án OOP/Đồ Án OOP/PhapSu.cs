using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    class PhapSu : NhanVat
    {
        private double dBaoPhepCB;

        private double dBaoPhep;

        public string STenNV { get => base.STenNV; set => base.STenNV = value; }
        public int ILevel { get => iLevel; set => iLevel = value; }
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


        public double DBaoPhepCB { get => dBaoPhepCB; set => dBaoPhepCB = value; }
        public double DBaoPhep { get => dBaoPhep; set => dBaoPhep = value; }

        public PhapSu() : base()
        {
            this.dBaoPhepCB = 0.01;
        }

        public PhapSu(PhapSu a) : base(a)
        {

        }

        public PhapSu(string tennv, int level, int health, int mana, int satthuong,
                        int sucmanhpt, int giap, double tocdodanh, int tocdodichuyen, double baophep) :
            base(tennv, level, health, mana, satthuong,
                        sucmanhpt, giap, tocdodanh, tocdodichuyen)

        {
            this.dBaoPhepCB = baophep;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Kha nang Bao phep: " + this.dBaoPhep *100 +"%");
        }

        public override void Xuat()
        {
            base.Xuat();
        }

        public override void Update()
        {
            base.Update();
            this.dBaoPhep = this.dBaoPhepCB + 0.01 * this.ILevel;

            if (this.dBaoPhep > 1.0)
                this.dBaoPhep = 1.0;
        }
    }
}
