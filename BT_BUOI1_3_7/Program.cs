using System;

namespace BT_BUOI1_3_7
{
    class Program
    {

        public static void bai1()
        {
            Console.WriteLine("\nIn cac chu cai da nhap theo chieu nguoc lai");
            Console.WriteLine("\n-------------------------------------------");

            //khai bao bien chuoi chua cac chu cai
            string a, x = "";
            Console.WriteLine("\nNhap 3 chu cai bat ki: ");
            a = Console.ReadLine();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                x += a[i];
            }

            Console.WriteLine("\nDao nguoc cac chu cai ban dau: {0}", x);
            Console.ReadKey();
        }

        public static void bai2()
        {

        }

        public static void bai3()
        {
            int a, b, c;
            double d, x1, x2, x;
            Console.WriteLine("\nNhap gia tri cua a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNhap gia tri cua b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNhap gia tri cua c: ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                x = -b / (2.0 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: {0}", x);
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Phuong trinh co hai nghiem phan biet la: {0} va {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("\nPhuong trinh vo nghiem!");
            }
            Console.ReadKey();
        }

        public static void bai4()
        {
            const double pi = 3.14;
            double s; //dien tich
            int a;
            Console.WriteLine("\nNhap lua chon de tinh dien tich: ");
            a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("\nTinh dien tich hinh tron: ");
                    Console.WriteLine("\n---------------------------");
                    Console.WriteLine("\nNhap ban kinh: ");
                    double r;
                    r = Convert.ToDouble(Console.ReadLine());
                    s = pi * r * r;
                    Console.WriteLine("\nDien tich hinh tron voi ban kinh {0} la: {1}", r, s);
                    break;
                case 2:
                    Console.WriteLine("\nTinh dien tich hinh chu nhat: ");
                    Console.WriteLine("\n---------------------------");
                    Console.WriteLine("\nNhap chieu dai va chieu rong: ");
                    double dai, rong; //chieu dai d, chieu rong r
                    dai = Convert.ToDouble(Console.ReadLine());
                    rong = Convert.ToDouble(Console.ReadLine());
                    s = dai * rong;
                    Console.WriteLine("\nDien tich hinh chu nhat la: {0}", s);
                    break;
            }
            Console.ReadKey();
        }

        public static void bai5()
        {
            int a, b;
            Console.WriteLine("\nNhap hai so: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            char c;
            Console.WriteLine("\nNhap phep tinh: ");
            c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine("\nTong hai so la: a + b = {0}", a + b);
                    break;
                case '-':
                    Console.WriteLine("\nHieu hai so la: a - b = {0}", a - b);
                    break;
                case '*':
                    Console.WriteLine("\nTich hai so la: a * b = {0}", a * b);
                    break;
                case '/':
                    Console.WriteLine("\nThuong hai so la: a / b = {0}", a / b);
                    break;
            }
            Console.ReadKey();
        }

        public static void bai6()
        {
            int a;
            Console.WriteLine("\nNhap so muon in ra bang cuu chuong: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBANG CUU CHUONG CUA {0}", a);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n{0} x {1} = {2}", a, i, a * i);
            }
            Console.ReadKey();
        }

        public static void bai7()
        {
            int a, sum = 0;
            Console.WriteLine("\nNhap so toi da cac so le: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nCac so le la: ");
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("\n{0}", i);
                sum = sum + i;
            }
            Console.WriteLine("\nTong cac so le la: {0}", sum);
        }

        public static void bai8()
        {
            int a, f = 1;
            Console.WriteLine("\nNhap so can tinh giai thua: ");
            a = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= a; i++)
            {
                f = f * i;
            }

            Console.WriteLine("\nGiai thua cua {0} la: {1}", a, f);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap bai tap so: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    bai1();
                    break;
                case 2:
                    bai2();
                    break;
                case 3:
                    bai3();
                    break;
                case 4:
                    bai4();
                    break;
                case 5:
                    bai5();
                    break;
                case 6:
                    bai6();
                    break;
                case 7:
                    bai7();
                    break;
                case 8:
                    bai8();
                    break;
                default:
                    Console.WriteLine("\nGia tri khong hop le!");
                    break;
            }
        }
    }
}
