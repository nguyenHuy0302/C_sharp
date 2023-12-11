using System;
namespace Input
{
    class Program
    {
       /* static void Main(string[] args)
        {
            Console.WriteLine(" In dao nguoc ");

            string name; // khai bao chuoi
            int l = 0;
            Console.Write("Nhap vao 1 chuoi :");
            name = Console.ReadLine();

            l = name.Length - 1;
            Console.Write(" Sau khi dao nguoc cac ki tu la :");
            while (l > 0)
            {
                Console.Write(" {0} ", name[l]);
                l--;
            }
            Console.Write("\n");
        } */

        static void Main(string[] args)
        {
            Console.WriteLine(" In dao nguoc bang for");
            string name; // khai bao 1 chuoi
            Console.Write(" Nhap vao 1 chuoi :");
            name = Console.ReadLine();  
            string reverse = string.Empty;

            
            for(int i = name.Length - 1; i >= 0; i--)
            {
               reverse += name[i];
            }
            Console.Write(" Chuoi dao nguoc cua {0} la : \n {1} ", name, reverse);
        }
    }
}