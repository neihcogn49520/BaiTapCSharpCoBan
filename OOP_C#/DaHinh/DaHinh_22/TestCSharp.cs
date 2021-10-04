using System;

namespace DaHinh_22
{
    class TestCSharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh da hinh trong C#");
            Console.WriteLine("Vi du minh hoa Da hinh dong");
            Console.WriteLine("----------------------------");

            HinhChuNhat r = new HinhChuNhat(10, 7);
            double a = r.tinhDienTich();
            Console.WriteLine("Dien tich: {0}", a);
            Console.ReadKey();
        }
    }
}
