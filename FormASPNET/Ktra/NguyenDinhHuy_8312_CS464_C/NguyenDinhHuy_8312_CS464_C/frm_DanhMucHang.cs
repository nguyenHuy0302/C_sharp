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

namespace NguyenDinhHuy_8312_CS464_C
{
    public partial class frm_DanhMucHang : Form
    {
        public frm_DanhMucHang()
        {
            InitializeComponent();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_MaHang_TextChanged(object sender, EventArgs e)
        {

        }

        

       

        private void Frm_DanhMucHang_Load(object sender, EventArgs e)
        {
            
        }
       
       
        int check = 0;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHang.Text = dataGridView1.CurrentRow.Cells["ma_hang"].Value.ToString();
            txt_TenHang.Text = dataGridView1.CurrentRow.Cells["ten_hang"].Value.ToString();
            check = 1;
            cb_TenNCC.SelectedValue = dataGridView1.CurrentRow.Cells["ma_nhacc"].Value.ToString();
            check = 1;
            cb_DVT.SelectedValue = dataGridView1.CurrentRow.Cells["don_vi_tinh"].Value.ToString();
        }

        private void frm_DanhMucHang_Load_1(object sender, EventArgs e)
        {
            LoadComboDonVi();
            LoadComboNhaCungCap();
            Loaddata();
        }
       public void Loaddata()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\NguyenDinhHuy_8312_CS464_C\NguyenDinhHuy_8312_CS464_C\QLHH.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from DANHMUCHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void LoadComboNhaCungCap()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\NguyenDinhHuy_8312_CS464_C\NguyenDinhHuy_8312_CS464_C\QLHH.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from NHACUNGCAP";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_TenNCC.DataSource = dt;
            cb_TenNCC.DisplayMember = "ten_nhacc";
            cb_TenNCC.ValueMember = "ma_nhacc";
        }
        public void LoadComboDonVi()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\NguyenDinhHuy_8312_CS464_C\NguyenDinhHuy_8312_CS464_C\QLHH.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoadGid = "select * from DONVITINH";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadGid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_DVT.DataSource = dt;
            cb_DVT.DisplayMember = "don_vi_tinh";
            cb_DVT.ValueMember = "don_vi_tinh";
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {

            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\NguyenDinhHuy_8312_CS464_C\NguyenDinhHuy_8312_CS464_C\QLHH.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlThem = "insert into DANHMUCHANG values('" + txt_MaHang.Text + "', N'" + txt_TenHang.Text + "','" + cb_TenNCC.SelectedValue + "','" + cb_DVT.SelectedValue + "')";
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
            Loaddata();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\NguyenDinhHuy_8312_CS464_C\NguyenDinhHuy_8312_CS464_C\QLHH.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlXoa = "delete from DANHMUCHANG where ma_hang = '" + txt_MaHang.Text + "'";
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
            Loaddata();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\NguyenDinhHuy_8312_CS464_C\NguyenDinhHuy_8312_CS464_C\QLHH.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlSua = "update DANHMUCHANG set ten_hang = '" + txt_TenHang.Text + "', ma_nhacc = '" + cb_TenNCC.SelectedValue + "', don_vi_tinh = '" + cb_DVT.SelectedValue + "'  where ma_hang = '" + txt_MaHang.Text + "'";
            SqlCommand comm = new SqlCommand(sqlSua, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
            conn.Close();
            Loaddata();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("bạn có muốn đóng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
                this.Close();
        }
    }
}

