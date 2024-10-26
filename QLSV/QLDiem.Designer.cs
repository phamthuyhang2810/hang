namespace PhamThuyHang_T7.QLSV
{
    partial class QLDiem
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
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txbDiemThi = new System.Windows.Forms.TextBox();
            this.txbDiemTB = new System.Windows.Forms.TextBox();
            this.txbDiemTrenLop = new System.Windows.Forms.TextBox();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numPhanTramThi = new System.Windows.Forms.NumericUpDown();
            this.numPhanTramTrenLop = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramTrenLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cmbLoai.Location = new System.Drawing.Point(344, 78);
            this.cmbLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(108, 30);
            this.cmbLoai.TabIndex = 8;
            this.cmbLoai.SelectedIndexChanged += new System.EventHandler(this.cmbLoai_SelectedIndexChanged);
            // 
            // txbDiemThi
            // 
            this.txbDiemThi.Location = new System.Drawing.Point(859, 47);
            this.txbDiemThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDiemThi.Name = "txbDiemThi";
            this.txbDiemThi.Size = new System.Drawing.Size(89, 30);
            this.txbDiemThi.TabIndex = 6;
            this.txbDiemThi.TextChanged += new System.EventHandler(this.txbDiemThi_TextChanged);
            // 
            // txbDiemTB
            // 
            this.txbDiemTB.Location = new System.Drawing.Point(87, 85);
            this.txbDiemTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDiemTB.Name = "txbDiemTB";
            this.txbDiemTB.Size = new System.Drawing.Size(89, 30);
            this.txbDiemTB.TabIndex = 7;
            this.txbDiemTB.TextChanged += new System.EventHandler(this.txbDiemTB_TextChanged);
            // 
            // txbDiemTrenLop
            // 
            this.txbDiemTrenLop.Location = new System.Drawing.Point(484, 47);
            this.txbDiemTrenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDiemTrenLop.Name = "txbDiemTrenLop";
            this.txbDiemTrenLop.Size = new System.Drawing.Size(89, 30);
            this.txbDiemTrenLop.TabIndex = 5;
            this.txbDiemTrenLop.TextChanged += new System.EventHandler(this.txbDiemTrenLop_TextChanged);
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Items.AddRange(new object[] {
            "CNTT",
            "Điện",
            "Quản Trị Kinh Doanh",
            "Kế Toán"});
            this.cmbMaMH.Location = new System.Drawing.Point(639, 8);
            this.cmbMaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(108, 30);
            this.cmbMaMH.TabIndex = 2;
            this.cmbMaMH.SelectedIndexChanged += new System.EventHandler(this.cmbMaMH_SelectedIndexChanged);
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbMaSV.Location = new System.Drawing.Point(344, 0);
            this.cmbMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(108, 30);
            this.cmbMaSV.TabIndex = 1;
            this.cmbMaSV.SelectedIndexChanged += new System.EventHandler(this.cmbMaSV_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 47;
            this.label9.Text = "Điểm TB:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(762, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Điểm Thi:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbLoai);
            this.panel1.Controls.Add(this.txbDiemThi);
            this.panel1.Controls.Add(this.txbDiemTB);
            this.panel1.Controls.Add(this.txbDiemTrenLop);
            this.panel1.Controls.Add(this.cmbMaMH);
            this.panel1.Controls.Add(this.cmbMaSV);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numPhanTramThi);
            this.panel1.Controls.Add(this.numPhanTramTrenLop);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 126);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 45;
            this.label8.Text = "Loại:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // numPhanTramThi
            // 
            this.numPhanTramThi.Location = new System.Drawing.Point(193, 42);
            this.numPhanTramThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPhanTramThi.Name = "numPhanTramThi";
            this.numPhanTramThi.Size = new System.Drawing.Size(107, 30);
            this.numPhanTramThi.TabIndex = 4;
            this.numPhanTramThi.ValueChanged += new System.EventHandler(this.numPhanTramThi_ValueChanged);
            // 
            // numPhanTramTrenLop
            // 
            this.numPhanTramTrenLop.Location = new System.Drawing.Point(859, 9);
            this.numPhanTramTrenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPhanTramTrenLop.Name = "numPhanTramTrenLop";
            this.numPhanTramTrenLop.Size = new System.Drawing.Size(107, 30);
            this.numPhanTramTrenLop.TabIndex = 3;
            this.numPhanTramTrenLop.ValueChanged += new System.EventHandler(this.numPhanTramTrenLop_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Điểm Trên Lớp:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(753, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Phần Trăm:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Phần Trăm Thi:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(675, 84);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 24);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(748, 84);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 24);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(557, 85);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(112, 24);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(484, 85);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 24);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã Sinh Viên:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã Môn Học:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(87, 8);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(108, 30);
            this.txbID.TabIndex = 0;
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDiem.Location = new System.Drawing.Point(0, -14);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.Size = new System.Drawing.Size(1044, 310);
            this.dgvDiem.TabIndex = 0;
            this.dgvDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellContentClick_1);
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
            this.Column2.HeaderText = "Mã SV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã MH";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm Thi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điểm Trên Lớp";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Điểm TB";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phần Trăm Thi";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Phần Trăm Trên Lớp";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Loại";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 362);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // QLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLDiem";
            this.Text = "Quản Lý Điểm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramTrenLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.TextBox txbDiemThi;
        private System.Windows.Forms.TextBox txbDiemTB;
        private System.Windows.Forms.TextBox txbDiemTrenLop;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPhanTramThi;
        private System.Windows.Forms.NumericUpDown numPhanTramTrenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel panel2;

    }

#endregion


}