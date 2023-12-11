using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---KIEM TRA LOI NHUAN KINH DOANH !");
            int chi_phi, doanh_thu, loi_nhuan;
            Console.WriteLine(" Nhap chi phi (VND) ");
            chi_phi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap doanh thu (VND)");
            doanh_thu = Convert.ToInt32(Console.ReadLine());

            if(chi_phi < doanh_thu)
            {
                loi_nhuan = doanh_thu - chi_phi;
                Console.WriteLine(" Ban loi nhuan dc {0} VND ", loi_nhuan);
            }
            else if (chi_phi > doanh_thu)
            {
                loi_nhuan = chi_phi - doanh_thu;
                Console.WriteLine(" Ban bi lo {0} VND ", loi_nhuan);
            }
            else
            {
                Console.WriteLine(" Ban hoa von");
            }
        }
    }
}

