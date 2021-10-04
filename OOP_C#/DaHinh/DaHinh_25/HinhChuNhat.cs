using System;
using System.Collections.Generic;
using System.Text;

namespace DaHinh_25
{
    class HinhChuNhat : Shape
    {
        public HinhChuNhat(int a = 0, int b = 0) : base (a, b)
        {
        }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class HinhChuNhat: ");
            return (rong * cao);
        }
    }
}
