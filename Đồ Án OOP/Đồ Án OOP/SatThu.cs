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

        public double DBaoKichCB { get => dBaoKichCB; set => dBaoKichCB = value; }
        public double DBaoKich { get => dBaoKich; set => dBaoKich = value; }

        public SatThu() : base()
        {
            this.dBaoKichCB = 0.01;
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
            Console.WriteLine("----------------------");
            Console.WriteLine("Kha nang Bao kich: " + this.dBaoKich);
        }

        public override void Update()
        {
            base.Update();
            this.dBaoKich = this.dBaoKichCB + 0.01 * this.iLevel;

            if (this.dBaoKich > 1.0)
                this.dBaoKich = 1.0;
        }
    }
}
