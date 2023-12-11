using System;
namespace Input
{
    class Program
    {
        public static int Sum(int n1 , int n2)
        {
            int total = 0;
            total = n1 + n2;
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai :;");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" tong cua hai so {0} + {1} = {2}",num1,num2,Sum(num1,num2));

        }
    }
}
