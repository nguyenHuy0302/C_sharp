using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, r;
            while (num > 0)
            {
                r = num % 10;
                sum = sum * 10 + r;
                num = num / 10;
            }
            Console.WriteLine("so {0} sau khi dao nguoc la {1} ", num, sum);
        }
    }
}