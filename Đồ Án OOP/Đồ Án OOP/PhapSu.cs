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

        public double DBaoPhepCB { get => dBaoPhepCB; set => dBaoPhepCB = value; }
        public double DBaoPhep { get => dBaoPhep; set => dBaoPhep = value; }

        public PhapSu() : base()
        {
            this.dBaoPhepCB = 0.01;
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
            Console.WriteLine("----------------------");
            Console.WriteLine("Kha nang Bao phep: " + this.dBaoPhep);
        }

        public override void Update()
        {
            base.Update();
            this.dBaoPhep = this.dBaoPhepCB + 0.01 * this.iLevel;

            if (this.dBaoPhep > 1.0)
                this.dBaoPhep = 1.0;
        }
    }
}
