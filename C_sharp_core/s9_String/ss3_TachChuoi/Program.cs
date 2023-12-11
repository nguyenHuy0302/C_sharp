using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -- Tac chuoi thanh cac ky tu rieng le ! --");

            string name; // khai bao 1 chuoi
            int l = 0;

            Console.Write("Nhap vao 1 chuoi :");
            name = Console.ReadLine();

            Console.Write("In ra chuoi sau khi tach :");
            while( l <= name.Length-1)
            {
                Console.Write("{0} ", name[l]);
                l++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
