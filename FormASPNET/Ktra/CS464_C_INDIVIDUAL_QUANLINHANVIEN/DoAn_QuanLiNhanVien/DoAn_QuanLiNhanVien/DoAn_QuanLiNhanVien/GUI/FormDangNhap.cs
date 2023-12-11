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

namespace DoAn_QuanLiNhanVien
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\CS464_C_INDIVIDUAL_QUANLINHANVIEN\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\QUANLINHANVIEN.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ketnoi);
            string sqldn = "select count (*) from TAIKHOAN where TenDangNhap = '" + txt_dangnhap.Text + "' and MatKhau = '" + txt_matkhau.Text + "'";
            SqlCommand comm = new SqlCommand(sqldn, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            if (ketqua >= 1)
            {
                FormNhanVien nv = new FormNhanVien();
                nv.Show();


            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
