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

namespace SinhVienPhuc
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ketnoi);
            string sqldn = "select count (*) from TAIKHOAN where TenDangNhap = '" + txt_dangnhap.Text + "' and MatKhau = '" + txt_matkhau.Text + "'";
            SqlCommand comm = new SqlCommand(sqldn, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            if (ketqua >= 1)
            {
                SinhVien sv = new SinhVien();
                sv.Show();


            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("bạn có muốn đóng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
                this.Close();
        }
    }
}

