using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenDinhHuy_08312_CS464_C 
{
    class NHANVIENHOPDONG : NHANVIEN, ILUONG
    {
        double mucLuong;
        public double MucLuong
        {
            get { return mucLuong; }
            set { mucLuong = value; }
        }
        public override void nhap()
        {
            Console.WriteLine("-----------NHập thông tin nhân viên hợp đồng------------");
            base.nhap();
            Console.WriteLine("Nhap muc luong la: "); this.MucLuong = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("----------Xuất thông tin nhân viên hợp đồng------------");
            base.xuat();
            Console.WriteLine("muc luong la: {0}", this.MucLuong);
        }

        public override double TinhThamNien()
        {
            int yearnow = DateTime.Today.Year;
            int yearvaolam = Ngayvaolam.Year;
            return yearnow - yearvaolam + 1;
        }
        public double TinhPhuCap()
        {
            return MucLuong / 10;
        }
        public double ThucLinh()
        {
            return MucLuong + TinhPhuCap();
        }
    }
}