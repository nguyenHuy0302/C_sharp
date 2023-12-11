using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 chuoi :");
            string name = Console.ReadLine();
            int length = 0;

            foreach( char chr in name)
            {
                length = length + 1;
            }
            Console.WriteLine("Do dai cua chuoi la :{0} ", length);
        }

    }
}
