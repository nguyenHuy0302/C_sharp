using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinhvien.BLL
{
    class BLL_SV
    {
        DAL.DAL_SV dalsv;
        frm_SinhVien sv;
        public BLL_SV(frm_SinhVien f_sv)
        {
            dalsv = new DAL.DAL_SV();
            sv = f_sv;
        }
        public void BLLThem()
        {
            dalsv.DalSVThem(sv.txt_masv.Text,sv.txt_ten.Text, sv.dateTimePicker1.Value, int.Parse(sv.txt_tuoi.Text),
                sv.cb_khoa.SelectedValue , sv.lb_danhsach.SelectedValue.ToString(), sv.txt_hinhanh.Text);
        }

    }
}
