using System;
namespace Input
{
    class Program
    {

        static void Main(string[] args)
        {
            string str; //khai bao mot chuoi
            

            Console.Write("\nDem so nguyen am, phu am trong chuoi C#:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();

           int nguyen_am = 0;
           int phu_am = 0;
            

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' ||
                    str[i] == 'O' || str[i] == 'U')
                {
                    nguyen_am++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    phu_am++;
                }
            }
            Console.Write("\nSo nguyen am co trong chuoi la: {0}\n", nguyen_am);
            Console.Write("So phu am co trong chuoi la: {0}\n\n", phu_am);

            Console.ReadKey();
        }
    }
}