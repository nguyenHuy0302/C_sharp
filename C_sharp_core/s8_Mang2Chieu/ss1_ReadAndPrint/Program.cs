using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- read and print array");

            int[,] arr = new int[3,3];

            Console.WriteLine(" Nhapp cac phan phan vao trong mang 2 chieu :");
            for (int i = 0; i<3; i++)
            {
                for(int j = 0; j<3;j++)
                {
                    Console.Write("Phan tu [{0},{1}] ", i , j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write(" In mang :");
            for(int i = 0; i<3;i++)
            {
                Console.WriteLine();
                for(int j = 0; j<3; j++)
                {
                    Console.Write("{0} \t", arr[i, j]);
                }
            }
        }
    }
}
