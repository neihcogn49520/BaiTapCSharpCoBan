using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_31
{
    class Box
    {
        private double dai;
        private double rong;
        private double cao;
        public double tinhTheTich()
        {
            return dai * rong * cao;
        }
        public void setChieuDai(double len)
        {
            dai = len;
        }
        public void setChieuRong(double bre)
        {
            rong = bre;
        }
        public void setChieuCao(double hei)
        {
            cao = hei;
        }
        //nap chong toan tu + de cong hai doi tuong Box
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.dai = b.dai + c.dai;
            box.rong = b.rong + c.rong;
            box.cao = b.cao + c.cao;
            return box;
        }
    }
}
