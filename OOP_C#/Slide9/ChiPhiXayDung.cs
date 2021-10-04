using System;
using System.Collections.Generic;
using System.Text;

namespace Slide9
{
    class ChiPhiXayDung : HinhChuNhat
    {
        private double cost;
        public ChiPhiXayDung(double l, double w) : base(l, w) { }
        public double tinhChiPhi()
        {
            double chiphi;
            chiphi = tinhDienTich() * 70;
            return chiphi;
        }
        public void hienthiThongTin()
        {
            base.Display();
            Console.WriteLine("Chi phi: {0}", tinhChiPhi());
        }
    }
    
}
