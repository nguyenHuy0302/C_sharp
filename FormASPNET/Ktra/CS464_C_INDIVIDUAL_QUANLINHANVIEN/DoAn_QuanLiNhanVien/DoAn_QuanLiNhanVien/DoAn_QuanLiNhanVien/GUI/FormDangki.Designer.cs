
namespace DoAn_QuanLiNhanVien
{
    partial class FormDangki
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
            this.txt_dkdangnhap = new System.Windows.Forms.TextBox();
            this.txt_dkmatkhau = new System.Windows.Forms.TextBox();
            this.txt_nhaplaimk = new System.Windows.Forms.TextBox();
            this.btn_dangki = new System.Windows.Forms.Button();
            this.btn_dkthoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(84, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(84, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(84, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txt_dkdangnhap
            // 
            this.txt_dkdangnhap.Location = new System.Drawing.Point(240, 110);
            this.txt_dkdangnhap.Name = "txt_dkdangnhap";
            this.txt_dkdangnhap.Size = new System.Drawing.Size(168, 22);
            this.txt_dkdangnhap.TabIndex = 3;
            // 
            // txt_dkmatkhau
            // 
            this.txt_dkmatkhau.Location = new System.Drawing.Point(240, 177);
            this.txt_dkmatkhau.Name = "txt_dkmatkhau";
            this.txt_dkmatkhau.Size = new System.Drawing.Size(168, 22);
            this.txt_dkmatkhau.TabIndex = 4;
            // 
            // txt_nhaplaimk
            // 
            this.txt_nhaplaimk.Location = new System.Drawing.Point(240, 244);
            this.txt_nhaplaimk.Name = "txt_nhaplaimk";
            this.txt_nhaplaimk.Size = new System.Drawing.Size(168, 22);
            this.txt_nhaplaimk.TabIndex = 5;
            // 
            // btn_dangki
            // 
            this.btn_dangki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangki.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dangki.Location = new System.Drawing.Point(151, 328);
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.Size = new System.Drawing.Size(152, 56);
            this.btn_dangki.TabIndex = 6;
            this.btn_dangki.Text = "Đăng kí";
            this.btn_dangki.UseVisualStyleBackColor = false;
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // btn_dkthoat
            // 
            this.btn_dkthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_dkthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dkthoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dkthoat.Location = new System.Drawing.Point(360, 328);
            this.btn_dkthoat.Name = "btn_dkthoat";
            this.btn_dkthoat.Size = new System.Drawing.Size(150, 56);
            this.btn_dkthoat.TabIndex = 7;
            this.btn_dkthoat.Text = "Thoát";
            this.btn_dkthoat.UseVisualStyleBackColor = false;
            this.btn_dkthoat.Click += new System.EventHandler(this.btn_dkthoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(214, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đăng kí tài khoản";
            // 
            // FormDangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dkthoat);
            this.Controls.Add(this.btn_dangki);
            this.Controls.Add(this.txt_nhaplaimk);
            this.Controls.Add(this.txt_dkmatkhau);
            this.Controls.Add(this.txt_dkdangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangki";
            this.Text = "FormDangki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dkdangnhap;
        private System.Windows.Forms.TextBox txt_dkmatkhau;
        private System.Windows.Forms.TextBox txt_nhaplaimk;
        private System.Windows.Forms.Button btn_dangki;
        private System.Windows.Forms.Button btn_dkthoat;
        private System.Windows.Forms.Label label4;
    }
}