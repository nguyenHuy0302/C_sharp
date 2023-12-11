using System;
namespace Input
{
    class Program
    {
        static decimal TinhGiaiThua(int n1)
        {
            if(n1 == 0)
            {
                return 1;
            }
            else
            {
                return n1 *TinhGiaiThua(n1 -1);
            }
        }
        static void Main(string[] args)
        {
            decimal f;
            
            Console.Write(" Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            f = TinhGiaiThua(num);
            Console.Write(" Giai thua cua {0} la {1}", num, f);
        }
    }
}
