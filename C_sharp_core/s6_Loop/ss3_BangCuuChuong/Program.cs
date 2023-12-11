using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--BANG CUU CHUONG--");
            int num = 2;

            do
            {
                int count = 1;
                do
                {
                    Console.WriteLine(" {0} x {1} = {2} ", num, count, num * count);
                    count++;
                }
                while (count <= 10);
                Console.WriteLine("--");
                num++;    
                

            } while (num <=9);
        }
    }
}
