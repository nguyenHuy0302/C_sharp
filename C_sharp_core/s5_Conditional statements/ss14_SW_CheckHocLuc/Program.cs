using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_-_Check hoc luc_-_");
            Console.WriteLine("Hang E --> Xuat Xac");
            Console.WriteLine("Hang V --> Rat Gioi");
            Console.WriteLine("Hang G --> Gioi");
            Console.WriteLine("Hang A --> Trung Binh");
            Console.WriteLine("Hang F --> Truot");

            string loai;
            char hang;

            Console.WriteLine(" Nhap hang hoc luc ");
            hang = Convert.ToChar(Console.ReadLine());

            switch (hang)
            {
                case 'E':
                    loai = " Xuat Xac";
                    break;
                case 'V':
                    loai = " Rat Gioi";
                    break;
                case 'G':
                    loai = " Gioi";
                    break;
                case 'A':
                    loai = " Trung Binh";
                    break;
                case 'F':
                    loai = "Truot";
                    break;
                default:
                    loai = "Vui long nhap lai hang hoc luc !";
                    break;       
            }
            Console.WriteLine(" Hoc luc cua ban la: {0} -> {1}",hang, loai);
        }
    }
}
