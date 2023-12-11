using System;
namespace Input
{
    class TienIch
    {
        // khai bao va dinhj nghia  phuong thuc tinh  luy thua  2 so nguyen 
        public static long LuyThua( int So , int SoMu)
        {
            long total = 1;
            for(int i = 0; i < SoMu; i++)
            {
                total *= So;
            }
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TienIch.LuyThua(3, 3));
        }
    }
}
