using System;
namespace Input
{
    class Program
    {
           static void Main(string[] args)
        {
            Console.WriteLine("--Insert element--");

            int[] arr = new int[100];
            Console.WriteLine(" Nhap so luong phan tu :");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i =0; i<n; i++)
            {
                Console.Write("Phan tu [{0}] :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Mang vua in la :");
            for(int i =0; i<n; i++)
            {
                Console.Write(" {0}" , arr[i]);
            }
            Console.Write(" Nhap gia tri x can chen :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri p can chen :");
            int p = Convert.ToInt32(Console.ReadLine());
            // di chuyen vi tri cac phan tu sang ben phai cua mang
            for(int i =n; i>= p; i--)
            {
                arr[i] = arr[i - 1];
                arr[p - 1] = x;
            }
            Console.Write("Sau khi chen :");
            for (int i =0; i <= n; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
