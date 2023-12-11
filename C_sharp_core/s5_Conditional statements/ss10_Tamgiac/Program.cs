using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--KIEM TRA TAM GIAC CAN , DEU , LECH");
            int canha, canhb, canhc;

            Console.WriteLine(" Nhap canh a :");
            canha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh b :");
            canhb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh c:");
            canhc = Convert.ToInt32(Console.ReadLine());

            if((canha == canhb) && (canhb == canhc))
            {
                Console.WriteLine(" Day la tam giac deu !");
            }
            else if((canha == canhb) || (canha == canhb) || (canhb == canhc))
            {
                Console.WriteLine("Day la tam giac can");
            }
            else
            {
                Console.WriteLine("Day la tam giac lech !");
            }
        }
    }
}

