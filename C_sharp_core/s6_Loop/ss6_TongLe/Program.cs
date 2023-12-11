using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Tinh tong cac so le ");
            int n, sum = 0;

            Console.WriteLine("Nhap so ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hien thi cac so le !");
            for(int i = 0; i <= n;i++)
            {
                Console.WriteLine("{0}", 2 * i -1);
                
                sum += 2 * -1; 
            }
            Console.WriteLine(" Tong cac so le la :", sum);

        }
    }
}

