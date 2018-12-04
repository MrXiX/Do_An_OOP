using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_OOP
{
    class DauSi : NhanVat
    {
        private int iXuyenGiapCB;

        private int iXuyenGiap;

        public int IXuyenGiapCB { get => iXuyenGiapCB; set => iXuyenGiapCB = value; }
        public int IXuyenGiap { get => iXuyenGiap; set => iXuyenGiap = value; }

        public DauSi() : base()
        {
            this.iXuyenGiapCB = 5;
        }

        public DauSi(string tennv, int level, int health, int mana, int satthuong,
                        int sucmanhpt, int giap, double tocdodanh, int tocdodichuyen, int xuyengiap) :
            base(tennv, level, health, mana, satthuong,
                        sucmanhpt, giap, tocdodanh, tocdodichuyen)

        {
            this.iXuyenGiapCB = xuyengiap;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Xuyen giap: " + this.iXuyenGiap);
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("----------------------");
            Console.WriteLine("Xuyen giap: " + this.iXuyenGiap);
        }

        public override void Update()
        {
            base.Update();
            this.iXuyenGiap = this.iXuyenGiapCB + 5 * this.iLevel;
        }
    }
}
