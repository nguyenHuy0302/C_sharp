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

namespace NguyenDinhPhuc_4588_CS464C
{
    public partial class FormDanhMucHang : Form
    {
        public FormDanhMucHang()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("bạn có muốn đóng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
                this.Close();
        }

        private void FormDanhMucHang_Load(object sender, EventArgs e)
        {
            LoadComboDonVi();
            LoadComboNhaCungCap();
            LoadData();
        }
        public void LoadData()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\QUANLIHANG.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from DANHMUCHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void LoadComboNhaCungCap()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\QUANLIHANG.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from NHACUNGCAP";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbb_nhacc.DataSource = dt;
            cbb_nhacc.DisplayMember = "ten_nhacc";
            cbb_nhacc.ValueMember = "ma_nhacc";
        }
        public void LoadComboDonVi()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\QUANLIHANG.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from DONVITINH";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbb_donvi.DataSource = dt;
            cbb_donvi.DisplayMember = "don_vi_tinh";
            cbb_donvi.ValueMember = "don_vi_tinh";
        }
        string chonNhacc;
        int check = 0;
        private void cbb_nhacc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0)
            {
                string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\QUANLIHANG.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                string chonKhoa = cbb_nhacc.SelectedValue.ToString();
                string sqlLoadGid = "select * from DANHMUCHANG where ma_nhacc = '" + chonNhacc + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            check= 0;
        }
        string chonDonVi;
        private void cbb_donvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0)
            {
                string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\QUANLIHANG.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                string chonKhoa = cbb_donvi.SelectedValue.ToString();
                string sqlLoadGid = "select * from DANHMUCHANG where don_vi_tinh = '" + chonDonVi + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            check = 0;
        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\QUANLIHANG.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlThem = "insert into DANHMUCHANG values('" + txt_mahang.Text + "', N'" + txt_tenhang.Text + "','"+cbb_nhacc.SelectedValue+"','"+cbb_donvi.SelectedValue+"')";
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
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\QUANLIHANG.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlSua = "update DANHMUCHANG set ten_hang = '" + txt_tenhang.Text + "', ma_nhacc = '"+cbb_nhacc.SelectedValue+"', don_vi_tinh = '"+cbb_donvi.SelectedValue+"'  where ma_hang = '" + txt_mahang.Text + "'";
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
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\NguyenDinhPhuc_4588_CS464C\QUANLIHANG.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlXoa = "delete from DANHMUCHANG where ma_hang = '" + txt_mahang.Text + "'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahang.Text = dataGridView1.CurrentRow.Cells["ma_hang"].Value.ToString();
            txt_tenhang.Text = dataGridView1.CurrentRow.Cells["ten_hang"].Value.ToString();
            check = 1;
            cbb_nhacc.SelectedValue = dataGridView1.CurrentRow.Cells["ma_nhacc"].Value.ToString();
            check = 1;
            cbb_donvi.SelectedValue = dataGridView1.CurrentRow.Cells["don_vi_tinh"].Value.ToString();

        }
    }
}