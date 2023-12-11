using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinhvien.DAL
{
    class DAL_SV
    {
        LopDungChung lopchung;
        public DAL_SV()
        {
            lopchung = new LopDungChung();
        }
        public void DalSVThem(String masv, string ten, DateTime ngaysinh, int tuoi , object makhoa, string maquequan, string hinhanh)
        {
            string sqlthem = "insert into SINHVIEN values('" + masv + "', N'" + ten + "', Convert(Datetime,'" + ngaysinh + "',103), '" + tuoi + "','" + makhoa + "','" + maquequan+ "','" + hinhanh + "')";
            lopchung.Noquery(sqlthem);
        }
    }
}
