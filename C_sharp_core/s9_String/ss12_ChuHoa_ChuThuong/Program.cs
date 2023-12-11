using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            string str; //Khai bao 2 chuoi
            char[] arr;
            char ch;
            Console.Write("Nhap vao 1 chuoi :");
            str = Console.ReadLine();
            arr = str.ToCharArray(0, 1);// chuyen chuoi thanh mang ky tu
            Console.WriteLine("Sau khi chuyen chuoi mang co dang :");

            for (int i = 0; i< str.Length;i ++)
            {
                ch = str[i];
                if (Char.IsLower(ch))// kiem tra ki tu thuong
                {
                    Console.Write(Char.ToUpper(ch));
                }
                else
                {
                    Console.Write(Char.ToLower(ch));
                }
            }

        }
    }
}
