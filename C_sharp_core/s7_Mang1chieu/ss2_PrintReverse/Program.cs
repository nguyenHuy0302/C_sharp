using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Print array reverse--");
            
            int[] arr = new int[100];
            Console.Write("Nhap so phan tu trong mang :");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i =0 ; i < n; i++)
            {
                Console.Write("Phan tu [{0}]: ", i);

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Cac phan tu sau khi In:");
            for(int i =0; i < n; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }
            Console.Write(" \n Cac phan tu sau khi dao nguoc :");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(" {0}", arr[i]);
            }

            //cach su dung VL while


            Console.WriteLine();
            
        }
    }
}
