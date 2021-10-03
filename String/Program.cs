using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cac cach tao chuoi trong C#");
            Console.WriteLine("---------------------------");

            //su dung phep gan hang chuoi va toan tu noi chuoi
            string fname, lname;
            fname = "Nguyen Thi Ngoc";
            lname = "Hien";

            string fullname = fname + " " + lname;
            Console.WriteLine("Ho va ten: {0}", fullname);

            //su dung constructor cua lop string
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("\nLoi chao bang tieng Anh: {0}", greetings);

            //tu cac phuong thuc tra ve mot chuoi
            string[] sarray = { "C#", "xin", "chao", "cac", "ban" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("\nThong diep: {0}", message);
        }
    }
}
