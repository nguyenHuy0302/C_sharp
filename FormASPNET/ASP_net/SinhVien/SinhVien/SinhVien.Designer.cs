
namespace SinhVien
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
            this.btn_them = new System.Windows.Forms.Button();
            this.MaSv = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.Label();
            this.btn_MaSv = new System.Windows.Forms.TextBox();
            this.btn_HoTen = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(103, 159);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(99, 30);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // MaSv
            // 
            this.MaSv.AutoSize = true;
            this.MaSv.Location = new System.Drawing.Point(100, 20);
            this.MaSv.Name = "MaSv";
            this.MaSv.Size = new System.Drawing.Size(49, 17);
            this.MaSv.TabIndex = 1;
            this.MaSv.Text = "Mã SV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSize = true;
            this.HoTen.Location = new System.Drawing.Point(100, 74);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(55, 17);
            this.HoTen.TabIndex = 2;
            this.HoTen.Text = "Họ Tên";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.Location = new System.Drawing.Point(100, 112);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(73, 17);
            this.NgaySinh.TabIndex = 3;
            this.NgaySinh.Text = "Ngày Sinh";
            // 
            // btn_MaSv
            // 
            this.btn_MaSv.Location = new System.Drawing.Point(240, 20);
            this.btn_MaSv.Name = "btn_MaSv";
            this.btn_MaSv.Size = new System.Drawing.Size(118, 22);
            this.btn_MaSv.TabIndex = 4;
            // 
            // btn_HoTen
            // 
            this.btn_HoTen.Location = new System.Drawing.Point(240, 69);
            this.btn_HoTen.Name = "btn_HoTen";
            this.btn_HoTen.Size = new System.Drawing.Size(118, 22);
            this.btn_HoTen.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 194);
            this.dataGridView1.TabIndex = 7;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(259, 159);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(99, 30);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(412, 159);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(99, 30);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dem
            // 
            this.btn_dem.Location = new System.Drawing.Point(531, 20);
            this.btn_dem.Name = "btn_dem";
            this.btn_dem.Size = new System.Drawing.Size(99, 30);
            this.btn_dem.TabIndex = 10;
            this.btn_dem.Text = "Đếm";
            this.btn_dem.UseVisualStyleBackColor = true;
            this.btn_dem.Click += new System.EventHandler(this.btn_dem_Click);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_HoTen);
            this.Controls.Add(this.btn_MaSv);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.MaSv);
            this.Controls.Add(this.btn_them);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label MaSv;
        private System.Windows.Forms.Label HoTen;
        private System.Windows.Forms.Label NgaySinh;
        private System.Windows.Forms.TextBox btn_MaSv;
        private System.Windows.Forms.TextBox btn_HoTen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_dem;
    }
}