using System;

namespace Slide
{
    class Shape
    {
        protected int rong;
        protected int cao;
        public void setChieuRong(int w)
        {
            rong = w;
        }
        public void setChieuCao(int h)
        {
            cao = h;
        }
    }
    class Rectangle : Shape
    {
        public int tinhDienTich()
        {
            return (cao * rong);
        }
    }
    class TestCSharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh ke thua trong C#");
            Console.WriteLine("---------------------\n");

            //tao doi tuong Hinh chu nhat Rectangle
            Rectangle hcn = new Rectangle();

            hcn.setChieuRong(5);
            hcn.setChieuCao(7);

            //in ra dien tich cua doi tuong
            Console.WriteLine("Dien tich hinh chu nhat: {0}", hcn.tinhDienTich());

            Console.ReadKey();
        }
    }
}
