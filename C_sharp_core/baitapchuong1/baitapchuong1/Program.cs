using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = 0 , secondNumber = 0 ;
            Console.WriteLine(" Nhap so thu nhat ");
            firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap so thu hai");
            secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine(" Tong cua {0} va {1} la {2}", firstNumber , secondNumber , firstNumber + secondNumber);
            Console.WriteLine(" Hieu cua {0} va {1} la {2}", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine(" Tich cua {0} va {1} la {2}", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine(" Thuong cua {0} va {1} la {2}", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.ReadLine();
        }
    }
}
