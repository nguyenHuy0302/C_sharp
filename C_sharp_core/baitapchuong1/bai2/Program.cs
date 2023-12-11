using System;
namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber , secondNumber ;
            Console.WriteLine(" Nhap so thu nhat ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap so thu hai");
            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("phan nguyen {0} / {1} la {2}" , firstNumber , secondNumber , firstNumber / secondNumber);
            Console.WriteLine("phan du khi {0} / {1} la {2}", firstNumber, secondNumber , firstNumber % secondNumber);
            Console.ReadLine();
        }
    }
}
