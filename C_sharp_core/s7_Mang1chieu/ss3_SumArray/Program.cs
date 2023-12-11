using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Sum array--");
            int sum = 0;
            int[] arr = new int[100];
            Console.Write("Nhap so phan tu :");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write(" Phan tu [{0}] :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i =0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.Write(" Tong cac phan tu trong mang : {0} ", sum);

        }
    }
}