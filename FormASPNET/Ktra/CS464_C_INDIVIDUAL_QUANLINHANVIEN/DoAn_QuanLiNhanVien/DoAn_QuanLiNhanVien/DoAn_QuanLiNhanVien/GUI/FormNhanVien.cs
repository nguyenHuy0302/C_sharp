using DoAn_QuanLiNhanVien.DAL;
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

namespace DoAn_QuanLiNhanVien
{
    public partial class FormNhanVien : Form
    {
        lopdungchung lopchung;
        BLL.BLL_NV bllNV;
        public FormNhanVien()
        {
            InitializeComponent();
            lopchung = new lopdungchung();
            bllNV = new BLL.BLL_NV(this);
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("bạn có muốn đóng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
                this.Close();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadListBoxQQ();
            LoadComboChucVu();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        public void LoadData()
        {
            bllNV.BLLLoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\CS464_C_INDIVIDUAL_QUANLINHANVIEN\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\QUANLINHANVIEN.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlThem = "insert into NHANVIEN values('" + txt_manv.Text + "', N'" + txt_tennv.Text + "', Convert(Datetime,'" + dateTimePicker1.Text + "',103), '" + txt_tuoi.Text + "','" + cb_chucvu.SelectedValue+ "','" + QueQuan.SelectedValue + "','" + txt_hinhanh.Text + "')";
            pictureBox1.Image.Save(duongdan + txt_hinhanh.Text);
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
        private void btn_sua_Click(object sender, EventArgs e)
        {
             string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\CS464_C_INDIVIDUAL_QUANLINHANVIEN\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\QUANLINHANVIEN.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlSua = "update NHANVIEN set HoTen = '" + txt_tennv.Text + "', NgaySinh = Convert(Datetime,'" + dateTimePicker1.Text + "',103), Tuoi = '" + txt_tuoi.Text + "', ChucVu = '" + cb_chucvu.SelectedValue + "',QueQuan = '" + QueQuan.SelectedValue + "',HinhAnh = '" + txt_hinhanh.Text + "' where MaNhanVien = '" + txt_manv.Text + "'";
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
            bllNV.BLLXoa();
            File.Delete(duongdan + txt_hinhanh.Text);
            LoadData();
        }
        public void LoadComboChucVu()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\CS464_C_INDIVIDUAL_QUANLINHANVIEN\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\QUANLINHANVIEN.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from CHUCVU";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_chucvu.DataSource = dt;
            cb_chucvu.DisplayMember = "TenChucVu";
            cb_chucvu.ValueMember = "MaChucVu";

        }
        string chonChucVu;
        int check = 0;
        private void cb_chucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0)
            {
                string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\CS464_C_INDIVIDUAL_QUANLINHANVIEN\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\QUANLINHANVIEN.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                string chonChucVu = cb_chucvu.SelectedValue.ToString();
                string sqlLoadGid = "select * from NHANVIEN where ChucVu = '" + chonChucVu + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            check = 0;
        }
        public void LoadListBoxQQ()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\CS464_C_INDIVIDUAL_QUANLINHANVIEN\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\QUANLINHANVIEN.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from QUEQUAN";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            QueQuan.DataSource = dt;
            QueQuan.DisplayMember = "TenQueQuan";
            QueQuan.ValueMember = "MaQueQuan";
        }
        
        private void QueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0)
            {
                string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\CS464_C_INDIVIDUAL_QUANLINHANVIEN\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\QUANLINHANVIEN.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                string chonQQ = QueQuan.SelectedValue.ToString();
                string sqlLoadGid = "select * from NHANVIEN where QueQuan = '" + chonQQ + "'";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn đuôi ảnh";
            OFD.Filter = "Tất cả đuôi|*.*|Đuôi jpg|*.jpg|Đuôi png|*.png|Đuôi jpeg|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Text = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_tennv.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_tuoi.Text = dataGridView1.CurrentRow.Cells["Tuoi"].Value.ToString();
            txt_hinhanh.Text = dataGridView1.CurrentRow.Cells["HinhAnh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_hinhanh.Text;
            check = 1;
            cb_chucvu.SelectedValue = dataGridView1.CurrentRow.Cells["ChucVu"].Value.ToString();
            check = 1;
            QueQuan.SelectedValue = dataGridView1.CurrentRow.Cells["QueQuan"].Value.ToString();


        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\CS464_C_INDIVIDUAL_QUANLINHANVIEN\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\DoAn_QuanLiNhanVien\QUANLINHANVIEN.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlDem = "select count (*) from NHANVIEN";
            SqlCommand comm = new SqlCommand(sqlDem, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            txt_dem.Text = ketqua.ToString();
        }
    }
}
