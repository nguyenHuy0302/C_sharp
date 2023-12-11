using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Dem cac chu so or so or ky tu dac biet--");
            Console.WriteLine("----------------------------------------");

            string str;
            Console.Write("Nhap vao 1 chuoi :");
            str = Console.ReadLine();

            int chu = 0 , so = 0 , ktu = 0;

            for(int i =0; i<str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    chu++;
                }
                else if (str[i] >= '0' & str[i] <= '9')
                {
                    so++;
                }
                else
                {
                    ktu++;
                }
            }
            Console.WriteLine(" So chu cai xuat hien trong chuoi la : {0}",chu);
            Console.WriteLine(" So chu so xuat hien trong chuoi  la : {0}",so);
            Console.WriteLine(" So ky tu xuat hien trong  chuoi  la : {0}",ktu);

        }
    }
}
