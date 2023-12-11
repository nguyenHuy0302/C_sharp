using System;

namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine(" Area = "+ length * width);
        }
    }
}
