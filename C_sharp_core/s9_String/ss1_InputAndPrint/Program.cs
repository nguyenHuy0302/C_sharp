using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Nhap va in chuoi");
            Console.Write("Nhap vao 1 chuoi :");
            string str = Console.ReadLine();// khai bao 1 chuoi va nhan gia tri dau vao
            Console.WriteLine(" ban vua nhap chuoi {0} ", str);

            Console.ReadKey();
        }
    }


}