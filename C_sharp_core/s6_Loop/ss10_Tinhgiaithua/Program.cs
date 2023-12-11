using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------");
            int giai_thua = 1;
            Console.WriteLine(" Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i =1; i<= num; i++)
            {
                giai_thua *= i;
            }
            Console.WriteLine("Giai thua cua {0} la {1}", num , giai_thua);
        }
    }
}
