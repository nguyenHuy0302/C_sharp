using System;
using System.Text;

namespace Bai1
{
    class Program
    {
        DateTime ngaysinh;
        ngaysinh = DateTime.Parse(Console.ReadLine());
            int tuoi = DateTime.Today.Year - ngaysinh.Year;
            if (ngaysinh.Day == DateTime.Today.Day && ngaysinh.Month == DateTime.Today.Month)  //Today hoac Now
                Console.WriteLine("\nChúc mừng sinh nhật lần thứ {0}", tuoi);
            }
        static void Main(string[] args)
        {
             Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập tên :");
            Console.WriteLine(Console.ReadLine());
            Console.Write("Nhập ngày sinh :");
            Console.WriteLine(Console.ReadLine());
           


        }
    }
}
