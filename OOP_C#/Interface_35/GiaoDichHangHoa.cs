using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_35
{
    class GiaoDichHangHoa : GiaoDich
    {
        private string mahh;
        private string ngay;
        private double sl;
        public GiaoDichHangHoa()
        {
            mahh = " ";
            ngay = " ";
            sl = 0.0;
        }
        public GiaoDichHangHoa(string c, string d, double a)
        {
            mahh = c;
            ngay = d;
            sl = a;
        }
        public double laySoLuong()
        {
            return sl;
        }
        public void hienthiThongTinGiaoDich()
        {
            Console.WriteLine("Ma hang hoa: {0}", mahh);
            Console.WriteLine("Ngay giao dich: {0}", ngay);
            Console.WriteLine("So luong: {0}", laySoLuong());
        }
    }
}
