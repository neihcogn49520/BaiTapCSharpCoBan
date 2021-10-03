using System;

namespace Array_slide31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mang trong C#");
            Console.WriteLine("------------------------\n");
            int[] arr = new int[10];

            //khoi tao cac phan tu cua mang
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i + 100;
            }

            //hien thi gia tri cac phan tu cua mang
            foreach (int j in arr)
            {
                int i = j - 100;
                Console.WriteLine("Phan tu thu [{0}] = {1}", i, j);
            }
        }
    }
}
