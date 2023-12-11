using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Dem so ky tu trong 1 chuoi :");

            string name;
            int dem = 1, l = 0;
            Console.Write(" Nhap vao 1 chuoi :");
            name = Console.ReadLine();

            // lap toi phan cuoi cua chuoi
            while(l <= name.Length - 1)
            {
                // check kys tu la khoang trang or ky tu new line hay ky tu tab
                if (name[l] == ' ' || name[l] == '\n' || name[l] == '\t')
                {
                    dem++;
                }
             l++;
            }
            Console.Write("tong so tu co trong chuoi la {0} ", dem);
        }
    }
}
