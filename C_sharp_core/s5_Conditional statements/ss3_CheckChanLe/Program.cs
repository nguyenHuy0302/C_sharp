using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine(" Nhap vao 1 so :");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", a);
            }
            else if (a % 2 != 0)
            {
                Console.WriteLine("{0} la so le", a);
            }
            else if(a == 0)
                Console.WriteLine("{0} la so khong chan khong le");
        }
    }
}