namespace PhamThuyHang_T7.QLSV
{
    partial class QLTaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTenDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbMatKhau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbLoaiTaiKhoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 200);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(150, 10);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(250, 22);
            this.txbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(150, 40);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(250, 22);
            this.txbTenDangNhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(150, 70);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(250, 22);
            this.txbMatKhau.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // cmbLoaiTaiKhoan
            // 
            this.cmbLoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiTaiKhoan.FormattingEnabled = true;
            this.cmbLoaiTaiKhoan.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Moderator"});
            this.cmbLoaiTaiKhoan.Location = new System.Drawing.Point(150, 100);
            this.cmbLoaiTaiKhoan.Name = "cmbLoaiTaiKhoan";
            this.cmbLoaiTaiKhoan.Size = new System.Drawing.Size(250, 24);
            this.cmbLoaiTaiKhoan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại tài khoản";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 150);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(150, 150);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(250, 150);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(350, 150);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(12, 220);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(450, 150);
            this.dgvTaiKhoan.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên đăng nhập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Loại tài khoản";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 150);
            this.panel2.TabIndex = 2;
            // 
            // QLTaiKhoan
            // 
            this.ClientSize = new System.Drawing.Size(474, 384);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.panel1);
            this.Name = "QLTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.QLTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cmbLoaiTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}