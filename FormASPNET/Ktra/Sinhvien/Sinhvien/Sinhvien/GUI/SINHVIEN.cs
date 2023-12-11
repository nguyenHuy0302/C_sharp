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

namespace Sinhvien
{
    public partial class frm_SinhVien : Form
    {
        LopDungChung lopchung;
        BLL.BLL_SV bllsv;

        public frm_SinhVien()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bllsv = new BLL.BLL_SV(this);
        }
        public void loadComboboxkhoa()
        {
           
            string sqlloadComboboxkhoa = "select * from KHOA";
            
            cb_khoa.DataSource = lopchung.loadData(sqlloadComboboxkhoa);
            cb_khoa.DisplayMember = "TENKHOA";
            cb_khoa.ValueMember = "MAKHOA";
        }
        public void loaddata()
        {

            string sqlLoadGrid = "select * from sinhvien";
            dataGridView1.DataSource = lopchung.loadData(sqlLoadGrid);
        }
        private void SINHVIEN_Load(object sender, EventArgs e)
        {
            Loadlistbox();
            loadComboboxkhoa();
            loaddata();
        }
        public void Loadlistbox()
        {
            string sqllistbox = "select * from QUEQUAN";
            lb_danhsach.DataSource = lopchung.loadData(sqllistbox);
            lb_danhsach.DisplayMember = "TENQUEQUAN";
            lb_danhsach.ValueMember = "MAQUEQUAN";
        }
        //string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\";
       // string duongdan = @"E:\cv\5\Sinhvien\Sinhvien\img\";
        private void btn_them_Click(object sender, EventArgs e)
        {
            bllsv.BLLThem();
            pictureBox1.Image.Save(@"E:\Ktra\Sinhvien\Sinhvien\Sinhvien\img\" + txt_hinhanh.Text);
            
            loaddata();
        }
        int check=0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.Text = dataGridView1.CurrentRow.Cells["MASV"].Value.ToString();
            txt_ten.Text = dataGridView1.CurrentRow.Cells["TEN"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_hinhanh.Text = dataGridView1.CurrentRow.Cells["HINHANH"].Value.ToString();
            pictureBox1.ImageLocation = @"C:\Users\Administrator\Downloads\Sinhvien\Sinhvien\Sinhvien\img\" + txt_hinhanh.Text;
            check = 1;
            cb_khoa.SelectedValue = dataGridView1.CurrentRow.Cells["MAKHOA"].Value.ToString();
            check = 1;
            lb_danhsach.SelectedValue = dataGridView1.CurrentRow.Cells["MAQUEQUAN"].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            string sqlXoa = "delete from SINHVIEN where MASV = '" + txt_masv.Text + "'";
            File.Delete(@"E:\Ktra\Sinhvien\Sinhvien\Sinhvien\img\" + txt_hinhanh.Text);
            lopchung.Noquery(sqlXoa);
            loaddata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            string sqlsua = "update SINHVIEN set TEN ='" + txt_ten.Text + "', NGAYSINH = Convert(Datetime,'" + dateTimePicker1.Text + "',103), TUOI = '"+txt_tuoi.Text+"', MAKHOA='"+cb_khoa.SelectedValue+"', MAQUEQUAN ='"+lb_danhsach.SelectedValue+"',HINHANH='"+txt_hinhanh.Text+"' where MASV='"+txt_masv.Text+"'";
            pictureBox1.Image.Save(@"E:\Ktra\Sinhvien\Sinhvien\Sinhvien\img\" + txt_hinhanh.Text);
            lopchung.Noquery(sqlsua);
            loaddata();
        }

        

        private void btn_dem_Click(object sender, EventArgs e)
        {
            
            string sqlDem = "select count (*) from SINHVIEN";

            int ketqua = (int)lopchung.Scalar(sqlDem);
           
            txt_dem.Text = ketqua.ToString();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            
            string sqlLoadGrid = "select * from sinhvien where MASV like '%"+txt_timkiem.Text+"%' or TEN like'%"+txt_timkiem.Text+"%'";
            
            dataGridView1.DataSource = lopchung.loadData(sqlLoadGrid);
        }

        private void btn_loadGrid_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int tuoi = DateTime.Now.Year - dateTimePicker1.Value.Year;
            txt_tuoi.Text = tuoi.ToString();

        }

        private void rdo_tang_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["TUOI"], ListSortDirection.Ascending);

        }

        private void rdo_giam_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["TUOI"], ListSortDirection.Descending);
        }
      
        private void cb_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0) {
                string chonkhoa = cb_khoa.SelectedValue.ToString();
                string sqlchonKhoa = "select * from SINHVIEN where MAKHOA= '" + chonkhoa + "'";

                dataGridView1.DataSource = lopchung.loadData(sqlchonKhoa);
            }
            check = 0;
        }

        private void lb_danhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0)
            {
                string chondanhsach = lb_danhsach.SelectedValue.ToString();
                string sqlchonDANHSACH = "select * from SINHVIEN where MAQUEQUAN= '" + chondanhsach + "'";

                dataGridView1.DataSource = lopchung.loadData(sqlchonDANHSACH);
            }
            check = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn đuôi ảnh";
            OFD.Filter = "Tất cả đuôi |*.*|Đuôi jpg|*.png|Đuôi jpeg|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }
    }
}
