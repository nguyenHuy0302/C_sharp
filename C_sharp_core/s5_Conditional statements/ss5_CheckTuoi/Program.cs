using System;
using System.Security.Cryptography;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("        Check tuoi di bau cu         ");
            Console.WriteLine("*************************************");

            int age;
            Console.WriteLine(" Nhap so tuoi :");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine(" ban chua du tuoi de bau cu !!");
                Console.WriteLine(" Vui long bau cu sau {0} nam", 18 - age );
            }
            else
            {
                Console.WriteLine(" Ban da bau cu thanh cong !!");
            }
        }
    }
}
