using System;
using System.Text;

namespace NguyenDinhHuy_08312_CS464_C
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DSNV dsnv = new DSNV();
            while (true)
            {
                Console.WriteLine("Nhập 1 để nhập, nhập 2 để xuất,nhập 3 để tìm kiếm, nhập 4 xuất tổng quỹ lương,nhập 5 để tính tiền thưởng ,nhập 0 để thoát");
                string chon = Console.ReadLine();
                if (chon == "1") dsnv.nhap(dsnv.GetdsnV1());
                if (chon == "2") dsnv.xuat();
                if (chon == "3") dsnv.TimNVMayMan();
                if (chon == "4") Console.WriteLine("---------Tổng quỹ lương là: {0}", dsnv.TongQuyLuong());
                if (chon == "5") Console.WriteLine("Tiền thưởng là: {0}", dsnv.TinhTienThuong());
                if (chon == "0") break;
            }
            
            Console.WriteLine("------end------");
            Console.ReadLine();
        }
    }
}