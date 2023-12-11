using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVienPhuc.BLL
{
    class BLL_SV
    {
        DAL.DAL_SV dalSV;
        SinhVien SV;
        public BLL_SV(SinhVien f_SV)
        {
            dalSV = new DAL.DAL_SV();
            SV = f_SV;
        }
        public void BLLThem()
        {
            dalSV.DalSVThem(SV.txt_masv.Text,SV.txt_hoten.Text,SV.dateTimePicker1.Value,int.Parse(SV.txt_tuoi.Text),SV.cb_khoa.SelectedValue.ToString(),SV.QueQuan.SelectedValue.ToString(),SV.txt_hinhanh.Text,SV.txt_diachi.Text);
        }

        public void BllSua() {
            dalSV.Dal(SV.txt_masv.Text, SV.txt_hoten.Text, SV.dateTimePicker1.Value,
                int.Parse(SV.txt_tuoi.Text),
                SV.cb_khoa.SelectedValue.ToString(),
                SV.QueQuan.SelectedValue.ToString(),
                SV.txt_hinhanh.Text;
  

                );
                
        }
        
    }
}
