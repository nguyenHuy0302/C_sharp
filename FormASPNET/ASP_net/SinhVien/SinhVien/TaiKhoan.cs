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

namespace SinhVien
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ASP_net\SinhVien\SinhVien\sinhvien.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ketnoi);
            string sqldn = "select count (*) from TAIKHOAN where taikhoan = '"+txt_user.Text+"' and matkhau = '"+txt_pass.Text+"'";
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

        private void TaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
