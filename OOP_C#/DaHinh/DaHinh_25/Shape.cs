using System;
using System.Collections.Generic;
using System.Text;

namespace DaHinh_25
{
    class Shape
    {
        protected int rong, cao;
        public Shape(int a = 0, int b = 0)
        {
            rong = a;
            cao = b;
        }
        public virtual int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class cha: ");
            return 0;
        }
    }
}
