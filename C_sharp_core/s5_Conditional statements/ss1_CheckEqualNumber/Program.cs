using System;

namespace Input // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");
            Console.WriteLine("Kiem tra 2 so bang nhau");
            Console.WriteLine("************************");

            int num1 , num2 ;
            Console.WriteLine("Nhap so thu nhat :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai :");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("{0} , {1} bang nhau :", num1 , num2);
            }
            else
            {
                Console.WriteLine("{0} , {1} khong bang nhau:", num1 , num2);
            }


        }
    }
}
