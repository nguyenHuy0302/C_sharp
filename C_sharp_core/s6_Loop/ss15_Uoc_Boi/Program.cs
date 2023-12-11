using System;
namespace Input
{
    class Program
    {

        static int UCLN(int a , int b)
        {
            if (b == 0) return a;
            return UCLN(a, a % b);
        }

        static int BCNN(int a , int b)
        {
            return (a * b) / UCLN(a, b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Nhap so a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Nhap so b :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("UCLN cua {0} va {1} la: {2}", a, b, UCLN(a,b));
            Console.WriteLine("BCNN cua {0} va {1} la: {2}", a, b, BCNN(a,b));

        }
    }
}
