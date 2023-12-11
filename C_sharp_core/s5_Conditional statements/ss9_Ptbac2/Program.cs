using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("---PHUONG TRINH BAC 2-----");
            Console.WriteLine("ax^2 + bx +c =0");

            int a, b, c;
            double d, x1, x2;

            Console.WriteLine(" Nhap he so a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Nhap he so b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Nhap he so c:");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;

            if(d == 0)
            {
                Console.WriteLine("Phuong trinh nghiem kep x1 = x2 = {0}",-b/(2*a));
            }
            else if (d > 0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1 va x2");
                x1 = (-b + Math.Sqrt(d))/ ( 2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(" x1 = {0}", x1);
                Console.WriteLine("x2 ={0}", x2);
            }
            else
            {
                Console.WriteLine("phuong trinh vo nghiem !");
            }
        }
    }
}
