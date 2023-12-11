using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****----- TIM MAX -----*****");
            int numa, numb, numc;
            Console.WriteLine("Nhap so thu nhat a= ");
            numa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu nhat b= ");
            numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu nhat c= ");
            numc = Convert.ToInt32(Console.ReadLine());

            if( numa > numb )
            {
                if( numa > numc )
                {
                    Console.WriteLine(" numa = {0} la so lon nhat ", numa);
                }
                else
                {
                    Console.WriteLine("numc = {0} la so lon nhat", numc);
                }
            }
            else if(numb > numc)
            {
                Console.WriteLine("numb = {0} la so lon nhat ", numb);
            }
            else
            {
                Console.WriteLine(" numc {0} la so lon nhat", numc);    
            }
        }
    }
}
