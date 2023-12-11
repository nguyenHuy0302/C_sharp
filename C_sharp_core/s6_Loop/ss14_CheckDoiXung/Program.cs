using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--cHECK DOI XUNG--");

            int sum = 0, du;
            Console.WriteLine(" Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int term = num; // tao bien trung gian de so sanh vs so ban dau
            while (num > 0)
            {
                du = num % 10; //phần dư = lấy phần dư của num%10
                sum = sum*10 + du; // lấy tổng nhân cho 10 rồng cộng phần dư
                num = num / 10; // lấy phân nguyên của num cho 10 
            }
            if (term == sum)
            {
                Console.Write("Day la so doi xung ");
            }
            else
            {
                Console.WriteLine(" Khong phai la so doi xung");
            }
        }
    }
}
