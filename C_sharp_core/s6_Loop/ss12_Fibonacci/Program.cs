using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-==-=-=-=");
            int fo = 0, f1 = 1, f2, n;
            Console.WriteLine("Enter a number !");
            n= Convert.ToInt32(Console.ReadLine());
            Console.Write(" day fibonacci la {0} {1} ", fo, f1);

            for(int i = 2; i < n; i++)
            {
                f2 = fo + f1;
                Console.Write(" {0} ", f2);
                fo = f1;
                f1 = f2;
            }
        }
    }
}
