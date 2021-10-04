using System;

namespace Interface_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface trong C#");
            Console.WriteLine("------------------");

            //tao doi tuong GiaoDichHangHoa
            GiaoDichHangHoa t1 = new GiaoDichHangHoa();
            GiaoDichHangHoa t2 = new GiaoDichHangHoa();
            t1.hienthiThongTinGiaoDich();
            t2.hienthiThongTinGiaoDich();

            Console.ReadKey();
        }
    }
}
