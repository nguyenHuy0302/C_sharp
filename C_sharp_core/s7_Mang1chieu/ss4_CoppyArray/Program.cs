using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---COPPY ARRAY--");

            int[] arr1 = new int[100];
            int[] arr2 = new int[100];

            Console.Write("Nhap so luong phan tu can nhap : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i  = 0; i < n; i++)
            {
                Console.Write("Phan tu [{0}] : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            // sao chep cac phan tu trong mang arr1 vao trong mang arr2
             for(int i =0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }
             Console.Write(" cac phan tu trong mang ban dau la :");
            for(int i =0; i<n ; i++)
            {
                Console.Write(" {0} ", arr1[i]);
            }
            Console.Write(" \n cac phan tu trong mang sau khi coppy la :");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0} ", arr2[i]);
            }
            Console.WriteLine();
        }
    }
}
