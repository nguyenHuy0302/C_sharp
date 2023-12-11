using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args) 
        {
            int hang, cot;

            Console.Write("\n");
            Console.Write("Ve chu cai H bang dau sao trong C#:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");

            for (hang = 0; hang <= 6; hang++)
            {
                for (cot = 0; cot <= 6; cot++)
                {
                    if ((cot == 1 || cot == 5) || (hang == 3 && cot > 1
                        && cot < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (hang = 0; hang <= 6; hang++)
            {
                for (cot = 0; cot <= 6; cot++)
                {
                    if ((cot == 1 || cot == 5) || (hang == 6 && cot > 1
                        && cot < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (hang = 0; hang <= 6; hang++)
            {
                for (cot = 0; cot <= 6; cot++)
                {
                    if (((cot == 1 || cot == 5) && hang < 2) || hang == cot &&
                        cot > 0 && cot < 4 || (cot == 4 && hang == 2) ||
                        ((cot == 3) && hang > 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

        }
    }
}
