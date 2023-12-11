using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVienPhuc.DAL
{
    class DAL_SV
    {
        lopdungchung lopchung;
        public DAL_SV()
        {
            lopchung = new lopdungchung();
        }
        public void DalSVThem(string maSV, string hoTen, DateTime ngaySinh, int tuoi, string maKhoa, string queQuan, string hinhAnh, string diaChi)
        {

            
            string sqlThem = "insert into SINHVIEN values('" + maSV + "', N'" + hoTen + "', Convert(Datetime,'" + ngaySinh + "',103), '" + tuoi + "','" + maKhoa + "','" + queQuan + "','" + hinhAnh + "','" + diaChi + "')";
            lopchung.Noquery(sqlThem);
        }
    }
}
