using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Find Max and Min of Array !--");

            int[] arr = new int[100];

            Console.Write("Nhap so luong phan tu : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                Console.Write("Phan tu [{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Cac phan tu vua in ra la  :");
            // in cac phan tu vua nhap
            for(int i = 0; i<n; i++)
            {
                Console.Write(" {0} " , arr[i]);
            }

            int max = arr[0];
            int min = arr[0];

            for (int i =1; i< n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("\nPhan tu co gia tri lon nhat la :{0} ", max);
            Console.Write("Phan tu co gia tri nho nhat la : {0}", min);

        }
    }
}
