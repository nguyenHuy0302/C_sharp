using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Ve Tam giac sao--");

            int row;
            Console.WriteLine(" Nhap so hang !");
            row = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= row; i++)
            {
                for(int j =1 ; j <= i ; j++)
                {
                    Console.Write("*");
                    
                }
                Console.Write("\n");
            }
        }
    }
}
