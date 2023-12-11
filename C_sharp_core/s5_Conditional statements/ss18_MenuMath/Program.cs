using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, chose;
            Console.WriteLine("--Menu calculate--");
            Console.WriteLine("1. Calculate addition ");
            Console.WriteLine("2. Calculate subtraction");
            Console.WriteLine("3. Calculate multiplication");
            Console.WriteLine("4. Calculate division");
             Console.WriteLine(" Enter your selection !");
             chose = Convert.ToInt32(Console.ReadLine());

            switch(chose)
            {
                case 1:
                    Console.WriteLine(" Enter a num1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a num2 ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Total : {0} + {1} = {2}", num1, num2, num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(" Enter a num1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a num2 ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Total : {0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(" Enter a num1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a num2 ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Total : {0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case 4:
                    Console.WriteLine(" Enter a num1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a num2 ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if(num2 ==0)
                    {
                        Console.WriteLine("illegal !!");
                    }
                    else
                    {
                        Console.WriteLine("Total: {0} / {1} = {2}", num1, num2, num1 / num2);
                    }
                    break;
                default: Console.WriteLine("Illegal !! Please re-enter");
                    break;
            }
            Console.ReadKey();
        }
    }
}
