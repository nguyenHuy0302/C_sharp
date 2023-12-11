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
    public partial class FormDangki : Form
    {
        public FormDangki()
        {
            InitializeComponent();
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\CS464_C_INDIVIDUAL_QUANLINHANVIEN\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\QUANLINHANVIEN.mdf;Integrated Security=True";
            string q = "insert into TAIKHOAN values('" + txt_dkdangnhap.Text + "', '" + txt_dkmatkhau.Text + "')";

            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            SqlCommand cm = new SqlCommand(q, con);
            if (txt_dkmatkhau.Text == txt_nhaplaimk.Text)
            {
                try
                {
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormDangNhap fdn = new FormDangNhap();
                    fdn.Show();
                    this.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_dkthoat_Click(object sender, EventArgs e)
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
