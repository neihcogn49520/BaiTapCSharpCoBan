using System;

namespace Slide13
{
    class TestCSharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh ke thua trong C#");
            Console.WriteLine("Vi du minh hoa Da ke thua");
            Console.WriteLine("---------------------------\n");

            //tao doi tuong HinhChuNhat
            HinhChuNhat hcn = new HinhChuNhat();
            int dientich;
            hcn.setChieuRong(5);
            hcn.setChieuCao(7);
            dientich = hcn.tinhDienTich();

            //in ra dien tich va chi phi
            Console.WriteLine("Tong dien tich: {0}", hcn.tinhDienTich());
            Console.WriteLine("Tong chi phi son: {0}", hcn.tinhChiPhi(dientich));
            Console.ReadLine();
        }
    }
}
