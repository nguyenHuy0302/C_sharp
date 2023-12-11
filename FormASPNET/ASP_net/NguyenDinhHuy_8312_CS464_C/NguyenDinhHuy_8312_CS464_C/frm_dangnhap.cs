using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDinhHuy_8312_CS464_C
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = "huy";
            string pass = "123";
            if (user.Equals(txt_User.Text) && pass.Equals(txt_Pass.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
                frm_DanhMucHang danhMuc = new frm_DanhMucHang();
                danhMuc.Show();
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
