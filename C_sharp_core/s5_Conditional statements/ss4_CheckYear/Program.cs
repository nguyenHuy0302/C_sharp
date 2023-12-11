using System;
namespace Input
{
    class Program
    {

        static void Check(int year)
        {
            bool isLeap = false;
            if(year % 4 ==0) // chia het cho 4 la nam nhuan
            {
                if(year % 100 == 0) // chia het cho 4 va chia het cho 100 --> ko nhuan
                {
                    if (year % 400 == 0) // chia het cho 400 --> nam nhuan
                    {
                        isLeap = true;
                    }
                    else
                    {
                        isLeap = false;
                    }
                }
                else
                {
                    isLeap = true;
                }
            }
            else
            {
                isLeap = false;
            }
            if(isLeap == true) 
            {
                Console.WriteLine(" {0} la nam nhuan", year);
            }
            else
            {
                Console.WriteLine(" {0} la nam khong nhuan", year);
            }
        }


        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("************************");
            Console.WriteLine(" Check Nam Nhuan");
            Console.WriteLine("************************");

            Console.WriteLine(" Nhap nam :");
            year = Convert.ToInt32(Console.ReadLine());
            Check(year);    
        }
    }
} 