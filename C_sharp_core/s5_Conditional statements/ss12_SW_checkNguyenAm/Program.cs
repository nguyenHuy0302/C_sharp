using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiem tra chu cai nguyen am phu am");
            Console.WriteLine("--------------------");

            char ch;
            Console.WriteLine("Vui long nhap chu cai :");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("{0} la chu cai nguyen am", ch);
                    break;
                case 'u':
                    Console.WriteLine("{0} la chu cai nguyen am", ch);
                    break;
                case 'e':
                    Console.WriteLine("{0} la chu cai nguyen am", ch);
                    break;
                case 'i':
                    Console.WriteLine("{0} la chu cai nguyen am", ch);
                    break;
                case 'o':
                    Console.WriteLine("{0} la chu cai nguyen am", ch);
                    break;
                default: Console.WriteLine("{0} day la chu cai phu am",ch);
                    break;
            }
            Console.ReadKey();

        }
    }
}
