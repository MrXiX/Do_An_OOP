using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    class XaThu : NhanVat
    {
        private int iTamBanCB;

        private int iTamBan;

        public int ITamBanCB { get => iTamBanCB; set => iTamBanCB = value; }
        public int ITamBan { get => iTamBan; set => iTamBan = value; }

        public XaThu() : base()
        {
            this.iTamBanCB = 100;
        }

        public XaThu(string tennv, int level, int health, int mana, int satthuong,
                        int sucmanhpt, int giap, double tocdodanh, int tocdodichuyen, int tamban) :
            base(tennv, level, health, mana, satthuong,
                        sucmanhpt, giap, tocdodanh, tocdodichuyen)

        {
            this.iTamBanCB = tamban;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Tam ban: " + this.iTamBan);
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("----------------------");
            Console.WriteLine("Tam ban: " + this.iTamBan);
        }

        public override void Update()
        {
            base.Update();
            this.iTamBan = this.iTamBanCB + 5 * this.iLevel;

            if (this.ITamBan > 1000)
                this.ITamBan = 1000;
        }
    }
}
