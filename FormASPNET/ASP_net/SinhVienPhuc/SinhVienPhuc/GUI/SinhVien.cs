using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVienPhuc
{
    public partial class SinhVien : Form
    {
        lopdungchung lopchung;
        BLL.BLL_SV bllSV;
        public SinhVien()
        {
            InitializeComponent();
            lopchung = new lopdungchung();
            bllSV = new BLL.BLL_SV(this);


        }
        private void SinhVien_Load(object sender, EventArgs e)
        {
            LoadListBoxQQ();
            LoadComboKhoa();
            LoadData();
        }
        public void LoadData()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from SINHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";

        private void btn_them_Click(object sender, EventArgs e)
        {
            bllSV.BLLThem();
            //string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(chuoiketnoi);
            //string sqlThem = "insert into SINHVIEN values('" + txt_masv.Text + "', N'" + txt_hoten.Text + "', Convert(Datetime,'" + dateTimePicker1.Text + "',103), '" + txt_tuoi.Text + "','" + cb_khoa.SelectedValue + "','" + QueQuan.SelectedValue + "','"+txt_hinhanh.Text+"','"+txt_diachi.Text+"')";
            pictureBox1.Image.Save(duongdan + txt_hinhanh.Text);
            //SqlCommand comm = new SqlCommand(sqlThem, conn);
            //conn.Open();
            //try
            //{
            //    int ketqua = comm.ExecuteNonQuery();
            //    if (ketqua >= 1) MessageBox.Show("Thêm thành công");
            //    else MessageBox.Show("Lỗi catch");
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi trùng mã, Lỗi SQL...");
            //}

            //conn.Close();
            LoadData();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlSua = "update SINHVIEN set HoTen = '" + txt_hoten.Text + "', NgaySinh = Convert(Datetime,'" + dateTimePicker1.Text + "',103), Tuoi = '" + txt_tuoi.Text + "', MaKhoa = '" + cb_khoa.SelectedValue + "',QueQuan = '" + QueQuan.SelectedValue + "',TenHinhAnh = '" + txt_hinhanh.Text + "',DiaChi = '"+txt_diachi.Text+"' where MaSv = '" + txt_masv.Text + "'";
            pictureBox1.Image.Save(duongdan + txt_hinhanh.Text);
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
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlXoa = "delete from SINHVIEN where MaSv = '" + txt_masv.Text + "'";
            File.Delete(duongdan + txt_hinhanh.Text);
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


        string chonKhoa;
        int check = 0;
        public void LoadComboKhoa()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from KHOA";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_khoa.DataSource = dt;
            cb_khoa.DisplayMember = "TenKhoa";
            cb_khoa.ValueMember = "MaKhoa";

        }
        private void cb_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0)
            {
                string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                string chonKhoa = cb_khoa.SelectedValue.ToString();
                string sqlLoadGid = "select * from SINHVIEN where MaKhoa = '" + chonKhoa + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            check = 0;
        }
        public void LoadListBoxQQ()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from QUEQUAN";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            QueQuan.DataSource = dt;
            QueQuan.DisplayMember = "Ten_QQ";
            QueQuan.ValueMember = "Ma_QQ";
        }

        private void QueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0)
            {
                string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                string chonKhoa = QueQuan.SelectedValue.ToString();
                string sqlLoadGid = "select * from SINHVIEN where QueQuan = '" + chonKhoa + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            check = 0;
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int tuoi = DateTime.Now.Year - dateTimePicker1.Value.Year;
            txt_tuoi.Text = tuoi.ToString();
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlDem = "select count (*) from SINHVIEN";
            SqlCommand comm = new SqlCommand(sqlDem, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            txt_dem.Text = ketqua.ToString();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\SinhVienPhuc\SinhVienPhuc\SINHVIENPHUC.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from SINHVIEN where MaSv like '%" + txt_timkiem.Text + "%'or HoTen like N'%" + txt_timkiem.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rd_tang_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Tuoi"], ListSortDirection.Ascending);
        }

        private void rd_giam_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Tuoi"], ListSortDirection.Descending);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.Text = dataGridView1.CurrentRow.Cells["MaSv"].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_hinhanh.Text = dataGridView1.CurrentRow.Cells["TenHinhAnh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_hinhanh.Text;
            check = 1;
            cb_khoa.SelectedValue = dataGridView1.CurrentRow.Cells["MaKhoa"].Value.ToString();
            check = 1;
            QueQuan.SelectedValue = dataGridView1.CurrentRow.Cells["QueQuan"].Value.ToString();
            txt_diachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn đuôi ảnh";
            OFD.Filter = "Tất cả đuôi|*.*|Đuôi jpg|*.jpg|Đuôi png|*.png|Đuôi jpeg|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

        
    }
}
