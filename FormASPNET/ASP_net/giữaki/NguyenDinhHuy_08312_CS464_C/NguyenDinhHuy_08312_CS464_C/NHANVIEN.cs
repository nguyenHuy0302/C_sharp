using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenDinhHuy_08312_CS464_C 
{
    abstract class NHANVIEN
    {
        string maNV;
        public string Manv
        {
            get { return maNV; }
            set { maNV = value; }
        }
        string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        string soCMND;
        public string SoCMND
        {
            get { return soCMND; }
            set
            {
                soCMND = value;
            }
        }
        DateTime ngayVaolam;
        public DateTime Ngayvaolam
        {
            get { return ngayVaolam; }
            set
            {
                ngayVaolam = value;
            }
        }
        public virtual void nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập mã nhân viên: "); this.Manv = Console.ReadLine();
            Console.WriteLine("Nhập họ tên nhân viên "); this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập số chứng minh nhân dân: "); this.SoCMND = Console.ReadLine();
            while (true)
                try
                {
                    Console.Write("Nhập ngày vào làm: "); this.Ngayvaolam = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                { Console.WriteLine("Nhập sai định dạng, mời nhập lại "); }
        }
        public virtual void xuat()
        {
            Console.WriteLine("Mã nhân viên là: {0}", this.Manv);
            Console.WriteLine("Họ tên nhân viên là: {0}", this.HoTen);
            Console.WriteLine("Số chứng minh nhân dân: {0}", this.SoCMND);
            Console.WriteLine(string.Format("Ngày vào làm là: {0: dd/MM/yyyy}", this.Ngayvaolam));
        }
        public abstract double TinhThamNien();
    }
}
