using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenDinhHuy_08312_CS464_C 
{
    internal class QLNHANVIEN
    {
        DSNV ds = new DSNV();
        Dictionary<string, NHANVIEN> nv = new Dictionary<string, NHANVIEN>();
        public void ThucHien()
        {
            Console.OutputEncoding = Encoding.UTF8;


            ds.nhap();
            ds.xuat();

        }
        public void TongQuyLuong()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("TỔNG QUỸ LƯƠNG: " + ds.TongQuyLuong());
        }
        public double TinhTienThuong()
        {
            double tienThuong = 0;
            foreach (NHANVIEN item in nv.Values)
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
