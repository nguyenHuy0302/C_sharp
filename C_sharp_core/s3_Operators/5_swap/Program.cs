using System;

namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a =b; b = c;
            Console.WriteLine(" after swapping, a = " + a + " , b = " + b );
        }
    }
}

