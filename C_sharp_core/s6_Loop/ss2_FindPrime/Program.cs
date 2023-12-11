using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--FIND PRIME--");
            int start, end;
            Console.WriteLine("Enter a start number !");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a end number !");
            end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac so nguyen to tu {0} den {1}", start , end);

            for(int i = start ; i <= end ;i++)
            {
                int count = 0;
                for(int j = 2; j <= i/2; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i != 1)
                {
                    Console.Write(" {0} ", i);
                }
            }

        }
    }
}