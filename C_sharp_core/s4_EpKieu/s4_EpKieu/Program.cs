using System;

namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B; //Bien chua gia tri 2 so vua nhap vao (kieu so)
            int Tong, Hieu, Tich;
            double Thuong;
            string strA  , strB; // Biến chứa giá trị 2 số nhập từ bàn phím (Kiểu chuỗi )

            Console.WriteLine(" ************************************************");
            Console.WriteLine(" *                                              *");
            Console.WriteLine("     Chuong trinh tong , hieu , thuong , tich ");
            Console.WriteLine(" *                                              *");
            Console.WriteLine(" ************************************************");

            Console.WriteLine(" Moi ban nhap So A :");
            strA = Console.ReadLine(); // Nhận giá trị nhập vào từ bàn phím cho số A
            Console.WriteLine(" Moi ban nhap so B :");
            strB = Console.ReadLine();

            A = int.Parse(strA); // Ep kieu gia tri nhap vao tu kieu chuoi --> kieu so nguyen
            B = int.Parse(strB);

            Thuong = (double)A / B;
            Console.WriteLine(" Tong  : " + A + " + " + B + " = " + (A + B));
            Console.WriteLine(" Hieu  : " + A + " - " + B + " = " + (A - B));
            Console.WriteLine(" Tich  : " + A + " * " + B + " = " + (A * B));
            Console.WriteLine("Thuong : " + A + " / " + B + " = " + Thuong);
        }
    }
}