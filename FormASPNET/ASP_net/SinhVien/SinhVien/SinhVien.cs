using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVien\SinhVien\SINHVIENN.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlThem = "insert into SINHVIENN values('" + btn_MaSv.Text + "', N'" +btn_HoTen.Text + "', Convert(Datetime,'" + dateTimePicker1.Text + "',103))";
            SqlCommand comm = new SqlCommand(sqlThem, conn);
            conn.Open();
            try
            {
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1) MessageBox.Show("Thêm thành công");
                else MessageBox.Show("Lỗi catch");
            }
            catch
            {
                MessageBox.Show("Lỗi trùng mã, Lỗi SQL...");
            }

            conn.Close();
            LoadData();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ASP_net\SinhVien\SinhVien\sinhvien.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from SINHVIENN";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ASP_net\SinhVien\SinhVien\sinhvien.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlSua = "update SINHVIENN set HoTen = '" + btn_HoTen.Text + "', NgaySinh = Convert(Datetime,'" + dateTimePicker1.Text + "',103) where MaSv = '" + btn_MaSv.Text + "'";
            SqlCommand comm = new SqlCommand(sqlSua, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
            conn.Close();
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ASP_net\SinhVien\SinhVien\sinhvien.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlXoa = "delete from SINHVIENN where MaSv = '" + btn_MaSv.Text + "'";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            conn.Open();
            try
            {
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1) MessageBox.Show("Xóa thành công");
                else MessageBox.Show("Lỗi try, Chưa có mã");
            }
            catch
            {
                MessageBox.Show("Lỗi catch, sai SQL");
            }
            conn.Close();
            LoadData();
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ASP_net\SinhVien\SinhVien\sinhvien.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlDem = "select count (*) from SINHVIENN";
            SqlCommand comm = new SqlCommand(sqlDem, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            btn_dem.Text = ketqua.ToString();
        }

        
    }
}
