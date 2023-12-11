using System;
using System.Diagnostics.CodeAnalysis;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check");

            int goca, gocb, gocc , sum;
            Console.WriteLine("Nhap goc a ");
            goca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap goc b :");
            gocb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Nhap goc c !");
            gocc = Convert.ToInt32(Console.ReadLine());

             sum = goca + gocb + gocc;

            if(sum == 180)
            {
                Console.WriteLine(" Day la tam giac");
            }
            else
            {
                Console.WriteLine("Day khong phai la tam giac");
            }
        }
    }
}
