using System;
using System.Collections.Generic;
using System.Text;

namespace DaHinh_25
{
    class HienThiDuLieu
    {
        public void hienthiDuLieu(Shape sh)
        {
            int a;
            a = sh.tinhDienTich();
            Console.WriteLine("Dien tich: {0}", a);
        }
    }
}
