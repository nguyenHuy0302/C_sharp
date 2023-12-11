using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Find chan va le trong mang**");

            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];

            Console.Write(" Nhap so luong phan tu : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i< n; i++)
            {
                Console.Write(" Phan tu [{0}] :", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int j = 0;
            int k = 0;

            for(int i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.Write("Mang chua cac phan tu chan la : ");
            for (int i =0; i<j; i++)
            {
                Console.Write(" {0} ", arr2[i]);
            }
            Console.Write("\n Mang chua cac phan tu le la :");
            for(int i = 0; i <k; i++)
            {
                Console.Write(" {0} ", arr3[i]);
            }
        }
    }
}