using System;
using System.Collections.Generic;
using System.Text;

namespace DaHinh_25
{
    class TamGiac : Shape
    {
        public TamGiac(int a = 0, int b = 0) :base (a, b)
        {
        }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class TamGiac: ");
            return (cao * rong / 2);
        }
    }
}
