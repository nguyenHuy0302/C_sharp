
using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenDinhHuy_08312_CS464_C
{
    class DSNV
    {
        Dictionary<string, NHANVIEN> dsnv;
        internal Dictionary<string, NHANVIEN> dsnV1
        {
            get { return dsnv; }
            set { dsnv = value; }
        }

        internal void nhap()
        {
            throw new NotImplementedException();
        }

        public DSNV()
        {
            dsnv = new Dictionary<string, NHANVIEN>();
        }
        public Dictionary<string, NHANVIEN> GetdsnV1()
        {
            return dsnv;
        }
        public void nhap(Dictionary<string, NHANVIEN> dsnV1)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Nhap (B) de nhap nhan vien bien che, nhap (H) de nhap nhan vien hop dong, nhap 0 de thoat kho phuong thuc nhap");
                string luachon = Console.ReadLine().ToUpper();
                if (luachon == "0") break;
                if (luachon == "B")
                {
                    NHANVIEN NV = new NHANVIENBIENCHE();
                    NV.nhap();
                    dsnV1.Add(NV.Manv, NV);
                }
                if (luachon == "H")
                {
                    NHANVIEN NV = new NHANVIENHOPDONG();
                    NV.nhap();
                    dsnV1.Add(NV.Manv, NV);
                }
            }
        }
        public void xuat()
        {
            foreach (NHANVIEN item in dsnV1.Values)
                item.xuat();
        }
        public double TongQuyLuong()
        {
            double tongQuyLuong = 0;
            foreach (NHANVIEN item in dsnV1.Values)
            {
                if (item is NHANVIENBIENCHE)
                    tongQuyLuong = tongQuyLuong + ((NHANVIENBIENCHE)item).ThucLinh();
                else if (item is NHANVIENHOPDONG)
                    tongQuyLuong = tongQuyLuong + ((NHANVIENHOPDONG)item).ThucLinh();
            }
            return tongQuyLuong;
        }
        public void TimNVMayMan()
        {
            Console.Write("----------------------Nhập vào mã nhân viên cần tìm:");
            string maTim = Console.ReadLine();
            NHANVIEN NV = null;
            int p = 0;
            foreach (NHANVIEN item in dsnV1.Values)
            {
                if (item.Manv == maTim)
                {
                    p = 1; NV = item; break;
                }
                else
                    p = 0;
            }
            if (p == 1)
            {
                Console.WriteLine("----------------Có nhân viên cần tìm---------------------");
                NV.xuat();
            }
            else
            {
                Console.WriteLine("---------------------Không có nhân viên cần tìm--------------------");
            }
        }
        public double TinhTienThuong()
        {
            double tienThuong = 0;
            foreach (NHANVIEN item in dsnv.Values)
            {
                if (item is NHANVIENBIENCHE)
                {
                    if (((NHANVIENBIENCHE)item).TinhThamNien() < 3) tienThuong = 1000000;
                    else tienThuong = 200000;

                }
                else if (item is NHANVIENHOPDONG)
                {
                    if (((NHANVIENHOPDONG)item).TinhThamNien() > 10) tienThuong = 2000000;
                    else if (((NHANVIENHOPDONG)item).TinhThamNien() > 5) tienThuong = 1000000;
                    else tienThuong = 200000;
                }
            }

            return tienThuong;
        }
       
    }
}