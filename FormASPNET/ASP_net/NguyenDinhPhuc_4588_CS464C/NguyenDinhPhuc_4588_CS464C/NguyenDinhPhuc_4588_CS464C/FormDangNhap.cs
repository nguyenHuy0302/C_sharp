using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDinhPhuc_4588_CS464C
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string user = "phuc";
            string pass = "123";
            if (user.Equals(txt_taikhoan.Text) && pass.Equals(txt_matkhau.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
                FormDanhMucHang danhMuc = new FormDanhMucHang();
                danhMuc.Show();
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
