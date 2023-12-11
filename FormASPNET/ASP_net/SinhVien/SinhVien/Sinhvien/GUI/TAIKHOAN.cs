using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinhvien
{
    public partial class TAIKHOAN : Form
    {
        LopDungChung lopchung;
        public TAIKHOAN()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
           
            string sqldn = "select count(*) from TAIKHOAN where(MatKhau='"+txt_mk.Text+"'and Tendangnhap='"+txt_dn.Text+"')";
            
            int ketqua = (int)lopchung.Scalar(sqldn);
            
            if (ketqua >= 1)
            {
                frm_SinhVien sv = new frm_SinhVien();
                sv.Show();


            }
            else
                MessageBox.Show("sai mat khau hoac tai khoan");

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dn = MessageBox.Show("ban co muon thoat?", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dn == DialogResult.Yes)
                Application.Exit();
        }
    }
}
