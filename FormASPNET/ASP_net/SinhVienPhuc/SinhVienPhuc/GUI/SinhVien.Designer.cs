
namespace SinhVienPhuc
{
    partial class SinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.MaSv = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.NgaySinh = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rd_tang = new System.Windows.Forms.RadioButton();
            this.rd_giam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_dem = new System.Windows.Forms.TextBox();
            this.btn_dem = new System.Windows.Forms.Button();
            this.cb_khoa = new System.Windows.Forms.ComboBox();
            this.QueQuan = new System.Windows.Forms.ListBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_hinhanh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(66, 12);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(100, 22);
            this.txt_masv.TabIndex = 0;
            // 
            // MaSv
            // 
            this.MaSv.AutoSize = true;
            this.MaSv.Location = new System.Drawing.Point(2, 15);
            this.MaSv.Name = "MaSv";
            this.MaSv.Size = new System.Drawing.Size(49, 17);
            this.MaSv.TabIndex = 1;
            this.MaSv.Text = "Mã SV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSize = true;
            this.HoTen.Location = new System.Drawing.Point(5, 53);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(55, 17);
            this.HoTen.TabIndex = 2;
            this.HoTen.Text = "Họ Tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(66, 50);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(100, 22);
            this.txt_hoten.TabIndex = 3;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.Location = new System.Drawing.Point(5, 101);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(73, 17);
            this.NgaySinh.TabIndex = 4;
            this.NgaySinh.Text = "Ngày Sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(8, 155);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(101, 155);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(193, 155);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(282, 155);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 9;
            this.btn_load.Text = "Load lại";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 204);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rd_tang
            // 
            this.rd_tang.AutoSize = true;
            this.rd_tang.Location = new System.Drawing.Point(8, 184);
            this.rd_tang.Name = "rd_tang";
            this.rd_tang.Size = new System.Drawing.Size(62, 21);
            this.rd_tang.TabIndex = 11;
            this.rd_tang.TabStop = true;
            this.rd_tang.Text = "Tăng";
            this.rd_tang.UseVisualStyleBackColor = true;
            this.rd_tang.CheckedChanged += new System.EventHandler(this.rd_tang_CheckedChanged);
            // 
            // rd_giam
            // 
            this.rd_giam.AutoSize = true;
            this.rd_giam.Location = new System.Drawing.Point(8, 218);
            this.rd_giam.Name = "rd_giam";
            this.rd_giam.Size = new System.Drawing.Size(62, 21);
            this.rd_giam.TabIndex = 12;
            this.rd_giam.TabStop = true;
            this.rd_giam.Text = "Giảm";
            this.rd_giam.UseVisualStyleBackColor = true;
            this.rd_giam.CheckedChanged += new System.EventHandler(this.rd_giam_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tuổi";
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Location = new System.Drawing.Point(57, 127);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(100, 22);
            this.txt_tuoi.TabIndex = 14;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(257, 123);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(100, 22);
            this.txt_timkiem.TabIndex = 16;
            // 
            // txt_dem
            // 
            this.txt_dem.Location = new System.Drawing.Point(454, 157);
            this.txt_dem.Name = "txt_dem";
            this.txt_dem.Size = new System.Drawing.Size(100, 22);
            this.txt_dem.TabIndex = 18;
            // 
            // btn_dem
            // 
            this.btn_dem.Location = new System.Drawing.Point(363, 156);
            this.btn_dem.Name = "btn_dem";
            this.btn_dem.Size = new System.Drawing.Size(75, 23);
            this.btn_dem.TabIndex = 19;
            this.btn_dem.Text = "Đếm";
            this.btn_dem.UseVisualStyleBackColor = true;
            this.btn_dem.Click += new System.EventHandler(this.btn_dem_Click);
            // 
            // cb_khoa
            // 
            this.cb_khoa.FormattingEnabled = true;
            this.cb_khoa.Location = new System.Drawing.Point(382, 121);
            this.cb_khoa.Name = "cb_khoa";
            this.cb_khoa.Size = new System.Drawing.Size(121, 24);
            this.cb_khoa.TabIndex = 20;
            this.cb_khoa.SelectedIndexChanged += new System.EventHandler(this.cb_khoa_SelectedIndexChanged);
            // 
            // QueQuan
            // 
            this.QueQuan.FormattingEnabled = true;
            this.QueQuan.ItemHeight = 16;
            this.QueQuan.Location = new System.Drawing.Point(510, 65);
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Size = new System.Drawing.Size(120, 84);
            this.QueQuan.TabIndex = 21;
            this.QueQuan.SelectedIndexChanged += new System.EventHandler(this.QueQuan_SelectedIndexChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(176, 123);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 22;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = global::SinhVienPhuc.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(636, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_hinhanh
            // 
            this.txt_hinhanh.Location = new System.Drawing.Point(655, 217);
            this.txt_hinhanh.Name = "txt_hinhanh";
            this.txt_hinhanh.Size = new System.Drawing.Size(107, 22);
            this.txt_hinhanh.TabIndex = 24;
            this.txt_hinhanh.Text = "TenHinhAnh.jpg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(257, 9);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(100, 22);
            this.txt_diachi.TabIndex = 26;
           //this.txt_diachi.TextChanged += new System.EventHandler(this.txt_diachi_TextChanged);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_hinhanh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.QueQuan);
            this.Controls.Add(this.cb_khoa);
            this.Controls.Add(this.btn_dem);
            this.Controls.Add(this.txt_dem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_tuoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rd_giam);
            this.Controls.Add(this.rd_tang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.MaSv);
            this.Controls.Add(this.txt_masv);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.Label MaSv;
        private System.Windows.Forms.Label HoTen;
        public System.Windows.Forms.TextBox txt_hoten;
        public System.Windows.Forms.Label NgaySinh;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_load;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rd_tang;
        private System.Windows.Forms.RadioButton rd_giam;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_dem;
        private System.Windows.Forms.Button btn_dem;
        public System.Windows.Forms.ComboBox cb_khoa;
        public System.Windows.Forms.ListBox QueQuan;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_hinhanh;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_diachi;
    }
}