using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLiNhanVien.DAL
{
    class DAL_NV
    {
        lopdungchung lopchung;
        public DAL_NV()
        {
            lopchung = new lopdungchung();
        }
        public DataTable DALNVLoadData()
        {
            string sqlLoadData = "select * from NHANVIEN";
            return lopchung.loadData(sqlLoadData);
        }
        public void DalNVThem(string maNV, string hoTen, DateTime ngaySinh , int tuoi, string chucVu, string queQuan, string hinhAnh )
        {
            string sqlThem = "insert into NHANVIEN values('" + maNV + "', N'" + hoTen + "', Convert(Datetime,'" + ngaySinh + "',103),'"+tuoi+"','"+chucVu+"','" + queQuan + "','" + hinhAnh + "')";
            lopchung.Noquery(sqlThem);
        }
        public void DalNVSua(string hoTen, DateTime ngaySinh, int tuoi, string chucVu, string queQuan, string hinhAnh, string maNV)
        {
            string sqlSua = "update NHANVIEN set HoTen = N'" + hoTen + "',NgaySinh =  Convert(Datetime,'" + ngaySinh + "',103),Tuoi = '" + tuoi + "', ChucVu = '"+chucVu+"', QueQuan = '"+queQuan+"', HinhAnh = '"+hinhAnh+"' where MaNhanVien = '"+maNV+"'";
            lopchung.Noquery(sqlSua);
        }
        public void DalNVXoa(string maNV)
        {
            string sqlXoa = "delete from NHANVIEN where MaNhanVien = '" + maNV + "'";
            lopchung.Noquery(sqlXoa);
        }
    }
}
