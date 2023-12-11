
namespace Sinhvien
{
    partial class frm_SinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_dem = new System.Windows.Forms.TextBox();
            this.btn_dem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_loadGrid = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.rdo_tang = new System.Windows.Forms.RadioButton();
            this.rdo_giam = new System.Windows.Forms.RadioButton();
            this.cb_khoa = new System.Windows.Forms.ComboBox();
            this.lb_danhsach = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_hinhanh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HoTen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(158, 43);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(183, 22);
            this.txt_masv.TabIndex = 3;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(158, 94);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(183, 22);
            this.txt_ten.TabIndex = 4;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(75, 322);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 29);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(180, 322);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 29);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(267, 319);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 29);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_dem
            // 
            this.txt_dem.Location = new System.Drawing.Point(438, 43);
            this.txt_dem.Name = "txt_dem";
            this.txt_dem.Size = new System.Drawing.Size(65, 22);
            this.txt_dem.TabIndex = 12;
            // 
            // btn_dem
            // 
            this.btn_dem.Location = new System.Drawing.Point(357, 41);
            this.btn_dem.Name = "btn_dem";
            this.btn_dem.Size = new System.Drawing.Size(75, 25);
            this.btn_dem.TabIndex = 13;
            this.btn_dem.Text = "Đếm";
            this.btn_dem.UseVisualStyleBackColor = true;
            this.btn_dem.Click += new System.EventHandler(this.btn_dem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 14;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(557, 106);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(183, 22);
            this.txt_timkiem.TabIndex = 15;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(665, 71);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 29);
            this.btn_timkiem.TabIndex = 16;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_loadGrid
            // 
            this.btn_loadGrid.Location = new System.Drawing.Point(548, 40);
            this.btn_loadGrid.Name = "btn_loadGrid";
            this.btn_loadGrid.Size = new System.Drawing.Size(192, 25);
            this.btn_loadGrid.TabIndex = 17;
            this.btn_loadGrid.Text = "Load lại GridViewiew";
            this.btn_loadGrid.UseVisualStyleBackColor = true;
            this.btn_loadGrid.Click += new System.EventHandler(this.btn_loadGrid_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tuổi";
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Location = new System.Drawing.Point(158, 184);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(71, 22);
            this.txt_tuoi.TabIndex = 19;
            // 
            // rdo_tang
            // 
            this.rdo_tang.AutoSize = true;
            this.rdo_tang.Location = new System.Drawing.Point(75, 260);
            this.rdo_tang.Name = "rdo_tang";
            this.rdo_tang.Size = new System.Drawing.Size(62, 21);
            this.rdo_tang.TabIndex = 20;
            this.rdo_tang.TabStop = true;
            this.rdo_tang.Text = "Tăng";
            this.rdo_tang.UseVisualStyleBackColor = true;
            this.rdo_tang.CheckedChanged += new System.EventHandler(this.rdo_tang_CheckedChanged);
            // 
            // rdo_giam
            // 
            this.rdo_giam.AutoSize = true;
            this.rdo_giam.Location = new System.Drawing.Point(75, 296);
            this.rdo_giam.Name = "rdo_giam";
            this.rdo_giam.Size = new System.Drawing.Size(62, 21);
            this.rdo_giam.TabIndex = 21;
            this.rdo_giam.TabStop = true;
            this.rdo_giam.Text = "Giảm";
            this.rdo_giam.UseVisualStyleBackColor = true;
            this.rdo_giam.CheckedChanged += new System.EventHandler(this.rdo_giam_CheckedChanged);
            // 
            // cb_khoa
            // 
            this.cb_khoa.FormattingEnabled = true;
            this.cb_khoa.Location = new System.Drawing.Point(367, 92);
            this.cb_khoa.Name = "cb_khoa";
            this.cb_khoa.Size = new System.Drawing.Size(121, 24);
            this.cb_khoa.TabIndex = 22;
            this.cb_khoa.SelectedIndexChanged += new System.EventHandler(this.cb_khoa_SelectedIndexChanged);
            // 
            // lb_danhsach
            // 
            this.lb_danhsach.FormattingEnabled = true;
            this.lb_danhsach.ItemHeight = 16;
            this.lb_danhsach.Location = new System.Drawing.Point(620, 145);
            this.lb_danhsach.Name = "lb_danhsach";
            this.lb_danhsach.Size = new System.Drawing.Size(120, 84);
            this.lb_danhsach.TabIndex = 23;
            this.lb_danhsach.SelectedIndexChanged += new System.EventHandler(this.lb_danhsach_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinhvien.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(746, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_hinhanh
            // 
            this.txt_hinhanh.Location = new System.Drawing.Point(872, 496);
            this.txt_hinhanh.Name = "txt_hinhanh";
            this.txt_hinhanh.Size = new System.Drawing.Size(183, 22);
            this.txt_hinhanh.TabIndex = 25;
            // 
            // frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 609);
            this.Controls.Add(this.txt_hinhanh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_danhsach);
            this.Controls.Add(this.cb_khoa);
            this.Controls.Add(this.rdo_giam);
            this.Controls.Add(this.rdo_tang);
            this.Controls.Add(this.txt_tuoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_loadGrid);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dem);
            this.Controls.Add(this.txt_dem);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_masv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_SinhVien";
            this.Text = "SINHVIEN";
            this.Load += new System.EventHandler(this.SINHVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_masv;
        public System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Button btn_them;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        public System.Windows.Forms.TextBox txt_dem;
        private System.Windows.Forms.Button btn_dem;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_loadGrid;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.RadioButton rdo_tang;
        private System.Windows.Forms.RadioButton rdo_giam;
        public System.Windows.Forms.ComboBox cb_khoa;
        public System.Windows.Forms.ListBox lb_danhsach;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_hinhanh;
    }
}

