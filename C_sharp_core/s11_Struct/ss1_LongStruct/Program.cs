using System;
namespace Input
{
    class Program
    {
       
        struct NhanVien
        {
            public string Name;
            public int Day;
            public int Month;
            public int Year;  
        }
       
       static void NhapThongTinNhanVien(out NhanVien NV)
        {
            Console.Write("Ho ten :");
            NV.Name = Console.ReadLine();
            Console.Write("Ngay Sinh : ");
            NV.Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Thang :");
            NV.Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nam :");
            NV.Year = Convert.ToInt32(Console.ReadLine());
        }

        static void xuatThongTin(NhanVien NV)
        {
            Console.WriteLine(" Ho Ten :" + NV.Name);
            Console.WriteLine(" Ngay sinh :" + NV.Day);
            Console.WriteLine(" Thang :" + NV.Month);
            Console.WriteLine(" Nam :" + NV.Year);
        }

        static void Main(string[] args)
        {
            NhanVien NV1 = new NhanVien();
            NhapThongTinNhanVien(out NV1);
            Console.WriteLine("**********");
            Console.WriteLine("Nhan vien vua nhap la :");
            xuatThongTin(NV1 );
        }
    }
}
