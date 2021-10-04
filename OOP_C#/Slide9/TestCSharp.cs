using System;

namespace Slide9
{
    class TestCSharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HTinh ke thua trong C#");
            Console.WriteLine("Khoi tao lop co so");
            Console.WriteLine("-------------------------\n");

            //tao doi tuong ChiPhiXayDung
            ChiPhiXayDung t = new ChiPhiXayDung(4.5, 7.5);
            t.hienthiThongTin();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
