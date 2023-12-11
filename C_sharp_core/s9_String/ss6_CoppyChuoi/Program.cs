using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--coppy chuoi--");

            string str1;
            Console.Write(" Nhap vao 1 chuoi :");
            str1 = Console.ReadLine();

            int l = str1.Length;

            string[] str2 = new string[l];// khai bao 1 chuoi khac

            // sao chep tung ki tu cua chuoi str1 vao chuoi str2
            int i = 0;
            while (i < l)
            {
                string term = str1[i].ToString();
                str2[i] = term;
                i++;
            }
            Console.Write("\nIn chuoi ban dau: {0}\n", str1);
            Console.Write("In chuoi sao: {0}\n", string.Join("", str2));
            Console.Write("So ky tu da duoc sao chep: {0}\n\n", i);
 
        }
    }
}
