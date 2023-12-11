using System;
namespace Input
{
    class Program
    {
        public static int DemKhoangTrang(string str)
        {
            int dem = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                {
                    dem++;
                }
            }
            return dem;
        }

        static void Main(string[] args)
        {
            Console.Write(" Nhap vao 1 chuoi :");
            string str2 = Console.ReadLine();
            Console.WriteLine("Chuoi \"" + str2 + "\"" + " co chua {0} khoang trang", DemKhoangTrang(str2));


        }
    }
}
