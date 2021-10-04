using System;
using System.Collections.Generic;
using System.Text;

namespace Slide9
{
    class HinhChuNhat
    {
        //cac bien
        protected double dai;
        protected double rong;
        //constructor
        public HinhChuNhat(double l, double w)
        {
            dai = l;
            rong = w;
        }
        //phuong thuc
        public double tinhDienTich()
        {
            return dai * rong;
        }

        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}", dai);
            Console.WriteLine("Chieu rong: {0}", rong);
            Console.WriteLine("Dien tich: {0}", tinhDienTich());
        }
    }
}
