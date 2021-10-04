using System;

namespace DaHinh_25
{
    class TestCSharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh da hinh trong C#");
            Console.WriteLine("Vi du minh hoa Da hinh dong");
            Console.WriteLine("---------------------------");

            HienThiDuLieu c = new HienThiDuLieu();
            HinhChuNhat r = new HinhChuNhat();
            TamGiac t = new TamGiac();
            c.hienthiDuLieu(r);
            c.hienthiDuLieu(t);

            Console.ReadKey();
        }
    }
}
