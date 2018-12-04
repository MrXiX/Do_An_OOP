using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    class DoDon: NhanVat
    {
        private int iTocDoHoiPhucCB;

        private int iTocDoHoiPhuc;

        public int ITocDoHoiPhucCB { get => iTocDoHoiPhucCB; set => iTocDoHoiPhucCB = value; }
        public int ITocDoHoiPhuc { get => iTocDoHoiPhuc; set => iTocDoHoiPhuc = value; }

        public DoDon() : base()
        {
            this.iTocDoHoiPhucCB = 5;
        }

        public DoDon(string tennv, int level, int health, int mana, int satthuong,
                        int sucmanhpt, int giap, double tocdodanh, int tocdodichuyen, int tocdohoiphuc) : 
            base(tennv, level, health, mana, satthuong,
                        sucmanhpt, giap, tocdodanh, tocdodichuyen)

        {
            this.iTocDoHoiPhucCB = tocdohoiphuc;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Toc do hoi phuc: " + this.iTocDoHoiPhuc + "/s");
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("----------------------");
            Console.WriteLine("Toc do hoi phuc: " + this.iTocDoHoiPhuc + "/s");
        }

        public override void Update()
        {
            base.Update();
            this.ITocDoHoiPhuc = this.iTocDoHoiPhucCB + 5 * this.iLevel;
        }
    }
}
