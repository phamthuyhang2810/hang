namespace PhamThuyHang_T7.QLSV
{
    partial class ThongTin
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
            this.txbLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbLoaiTaiKhoan
            // 
            this.txbLoaiTaiKhoan.Location = new System.Drawing.Point(45, 239);
            this.txbLoaiTaiKhoan.Name = "txbLoaiTaiKhoan";
            this.txbLoaiTaiKhoan.Size = new System.Drawing.Size(248, 22);
            this.txbLoaiTaiKhoan.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Loại Tài Khoản:";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(45, 162);
            this.txbMatKhau.MaxLength = 255;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(248, 22);
            this.txbMatKhau.TabIndex = 14;
            this.txbMatKhau.Text = "********";
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu:";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Enabled = false;
            this.txbTenDangNhap.Location = new System.Drawing.Point(45, 78);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(248, 22);
            this.txbTenDangNhap.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 321);
            this.Controls.Add(this.txbLoaiTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.label1);
            this.Name = "ThongTin";
            this.Text = "ThongTin";
            this.Load += new System.EventHandler(this.ThongTin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLoaiTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label label1;
    }
}