using System;
using System.Globalization;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bang cuu chuong cua 1 so bat ky !");

            int n;
            Console.WriteLine(" Nhap 1 so bat ki");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
            }
        }
    }
}

