using System;
namespace Input
{
    class Program
    {
        struct SinhVien
        {
            public int MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemLy;
            public double DiemVan;
        }
        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma So :");
            SV.MaSo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ho ten :");
            SV.HoTen = Console.ReadLine();
            Console.Write("Diem Toan :");
            SV.DiemToan =Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem Ly :");
            SV.DiemLy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem Van :");
            SV.DiemVan = Convert.ToDouble(Console.ReadLine());
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSo);
            Console.WriteLine(" Ho ten: " + SV.HoTen);
            Console.WriteLine(" Diem toan: " + SV.DiemToan);
            Console.WriteLine(" Diem ly: " + SV.DiemLy);
            Console.WriteLine(" Diem van: " + SV.DiemVan);
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemLy + SV.DiemVan)/3;
        }
        static void Main(string[] args)
        {
            // khai bao 1 kieu du lieu SinhVien vs cac truonwg thong tin 
            // khai bao va khoi tao 1 doi tuong sv1 kieu SInhVien
            SinhVien SV1 = new SinhVien();
            Console.WriteLine(" Nhap thong tin sinh vien :");

            //Day la ham ho tro nhap thong tin sinh vien
            // su dung tu khoa out  de co the cap nhat gia tri nhap dc ra bien sv1 ben ngoai
            // khi ket thuc goi ham
            NhapThongTinSinhVien(out SV1);
            Console.WriteLine("********");
            Console.WriteLine("Thong tin sinh vien vua nhap la :");
            XuatThongTinSinhVien(SV1);
            Console.WriteLine("Diem trung binh sinh vien la :" + DiemTBSinhVien(SV1));
        }
    }
}
