using System;
namespace Input
{
    class Program
    {

        public  static void doivi(ref int n1 , ref int n2)
        {
            int term ;
            term = n1;
            n1 = n2;
            n2 = term;
        }
        static void Main(string[] args)
        {
            Console.Write(" Nhap vao so thu nhat :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so thu hai :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            // goi ham
            doivi(ref num1, ref num2);
            Console.WriteLine(" Sau khi doi gia tri :");
            Console.WriteLine("gia tri cua so thu nhat la : {0} \n gia tri so thu hai la : ", num1 , num2);
            
        }
    }
}