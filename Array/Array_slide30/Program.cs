using System;

namespace Array_slide30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mang trong C#");
            Console.WriteLine("------------------------\n");
            int[] arr = new int[10]; //arr la mang gom 10 phan tu so nguyen
            //khoi tao cac phan tu cua mang
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i + 100;
            }
            //hien thi gia tri cac phan tu cua mang
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Phan tu thu [{0}] = {1}", j, arr[j]);
            }
        }
    }
}
