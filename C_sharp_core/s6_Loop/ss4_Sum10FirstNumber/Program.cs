using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-TONG 1O SO DAU TIEN-");
            int i;
            int sum = 0;

            Console.WriteLine(" 10 so dau tien la ");

            for(i = 0; i < 10; i++)
            {
                sum += i;
                Console.Write(" {0} ", i);
            }
            Console.WriteLine(" tong 10 so dau tien la {0} ", sum);

        }
    }
}