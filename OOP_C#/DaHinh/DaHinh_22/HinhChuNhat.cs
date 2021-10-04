using System;
using System.Collections.Generic;
using System.Text;

namespace DaHinh_22
{
    class HinhChuNhat : Shape
    {
        private int dai;
        private int rong;
        public HinhChuNhat(int a = 0, int b = 0)
        {
            dai = a;
            rong = b;
        }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich hinh chu nhat: ");
            return (rong * dai);
        }
    }
}
