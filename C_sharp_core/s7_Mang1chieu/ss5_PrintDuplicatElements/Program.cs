using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -PRINT DUPLICATE ELEMENTS-");

            int[] arr = new int[100];
            int dem = 0;
            Console.Write(" Nhap so luong phan tu : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write(" Phan tu [{0}] :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i =0; i < n;i++)
            {
                for (int j = i + 1; j < n; j++)//
                {
                    if (arr[i] == arr[j])
                    {
                        dem++;
                        break;
                    }
                }
            }
            Console.WriteLine("so phan tu giong nhau trong mang la {0}",dem);
        }
    }
}
