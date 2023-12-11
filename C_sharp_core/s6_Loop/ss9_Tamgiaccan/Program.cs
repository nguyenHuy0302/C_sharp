using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Nhap hang !");
            int row = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= row; i++)
            {
                for(int j =i; j <= row; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1 ; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();   
                
            }
            for(int i = row -1 ; i >= 1; i--)
            {
                for(int j = 1; j >= row - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j =1; j <= 2 * i -1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
