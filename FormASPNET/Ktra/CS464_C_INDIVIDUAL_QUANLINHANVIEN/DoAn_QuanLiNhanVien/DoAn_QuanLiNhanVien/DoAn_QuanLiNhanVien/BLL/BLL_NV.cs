using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLiNhanVien.BLL
{
    class BLL_NV
    {
        DAL.DAL_NV dalNV;
        FormNhanVien NV;
        public BLL_NV(FormNhanVien f_NV)
        {
            dalNV = new DAL.DAL_NV();
            NV = f_NV;
        }
        public void BLLLoadData()
        {
            NV.dataGridView1.DataSource = dalNV.DALNVLoadData();
        }
        public void BLLThem()
        {
            dalNV.DalNVThem ( NV.txt_manv.Text, NV.txt_tennv.Text, NV.dateTimePicker1.Value, int.Parse(NV.txt_tuoi.Text), NV.cb_chucvu.SelectedValue.ToString(), NV.QueQuan.SelectedValue.ToString(), NV.txt_hinhanh.Text );
        }
        public void BLLSua()
        {
            dalNV.DalNVSua( NV.txt_tennv.Text, NV.dateTimePicker1.Value, int.Parse(NV.txt_tuoi.Text), NV.cb_chucvu.SelectedValue.ToString(), NV.QueQuan.SelectedValue.ToString(), NV.txt_hinhanh.Text, NV.txt_manv.Text);
        }
        public void BLLXoa()
        {
            dalNV.DalNVXoa(NV.txt_manv.Text);
        }
    }
}
