using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Check Prime--");
            int num;
            bool IsPrime = true;

            Console.WriteLine(" Enter a number !");
            num = Convert.ToInt32(Console.ReadLine());

            if(num < 2 )
            {
                IsPrime = false;
            }
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    IsPrime = true;
                }
            }
            if(IsPrime==true)
            {
                Console.WriteLine("{0} la so nguyen to ", num);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so nguyen to ", num);

            }
        }
    }
}