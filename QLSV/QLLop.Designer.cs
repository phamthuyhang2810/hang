namespace PhamThuyHang_T7.QLSV
{
    partial class QLLop
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
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTenLop = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(816, 8);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(121, 24);
            this.cmbMaKhoa.TabIndex = 37;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(602, 10);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 22);
            this.numSoLuong.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mã Khoa:";
            // 
            // txbTenLop
            // 
            this.txbTenLop.Location = new System.Drawing.Point(366, 10);
            this.txbTenLop.MaxLength = 255;
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.Size = new System.Drawing.Size(130, 22);
            this.txbTenLop.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 341);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.Location = new System.Drawing.Point(0, 0);
            this.dgvLop.MultiSelect = false;
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 30;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLop.Size = new System.Drawing.Size(953, 341);
            this.dgvLop.TabIndex = 1;
            this.dgvLop.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MÃ LỚP";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 220;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TÊN lỚP";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 220;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SỐ LƯỢNG";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 220;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MÃ KHOA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 220;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbMaKhoa);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txbTenLop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbMaLop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 109);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Số Lượng:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(343, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(424, 66);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(505, 66);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 30);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(262, 66);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Lớp:";
            // 
            // txbMaLop
            // 
            this.txbMaLop.Location = new System.Drawing.Point(165, 10);
            this.txbMaLop.MaxLength = 255;
            this.txbMaLop.Name = "txbMaLop";
            this.txbMaLop.Size = new System.Drawing.Size(108, 22);
            this.txbMaLop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp:";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(36, 10);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(38, 22);
            this.txbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QLLop";
            this.Text = "QLLop";
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTenLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
    }
}