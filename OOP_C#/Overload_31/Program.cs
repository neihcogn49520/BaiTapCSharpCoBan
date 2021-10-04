using System;

namespace Overload_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nap chong toan tu trong C#");
            Console.WriteLine("---------------------------");

            //tao doi tuong Box1, Box2, Box3
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double thetich = 0.0;

            //nhap thong tin cho Box1
            Box1.setChieuDai(6.0);
            Box1.setChieuRong(7.0);
            Box1.setChieuCao(5.0);

            //nhap thong tin cho Box2
            Box2.setChieuDai(12.0);
            Box2.setChieuRong(13.0);
            Box2.setChieuCao(10.0);

            //tinh va hien thi the tich Box1
            thetich = Box1.tinhTheTich();
            Console.WriteLine("The tich cua Box1 la: {0}", thetich);

            //tinh va hien thi the tich cua Box2
            thetich = Box2.tinhTheTich();
            Console.WriteLine("The tich cua Box2 la: {0}", thetich);

            //cong hai doi tuong Box
            Box3 = Box1 + Box2;

            //tinh va hien thi the tich Box3
            thetich = Box3.tinhTheTich();
            Console.WriteLine("The tich cua Box3 la: {0}", thetich);

            Console.ReadKey();
        }
    }
}
