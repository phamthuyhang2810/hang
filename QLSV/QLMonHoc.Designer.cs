﻿namespace PhamThuyHang_T7.QLSV
{
    partial class QLMonHoc
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
            this.numTietTH = new System.Windows.Forms.NumericUpDown();
            this.numTietLT = new System.Windows.Forms.NumericUpDown();
            this.numSoTC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbTenMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numTietTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTC)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numTietTH
            // 
            this.numTietTH.Location = new System.Drawing.Point(96, 69);
            this.numTietTH.Name = "numTietTH";
            this.numTietTH.Size = new System.Drawing.Size(120, 30);
            this.numTietTH.TabIndex = 42;
            // 
            // numTietLT
            // 
            this.numTietLT.Location = new System.Drawing.Point(370, 68);
            this.numTietLT.Name = "numTietLT";
            this.numTietLT.Size = new System.Drawing.Size(120, 30);
            this.numTietLT.TabIndex = 41;
            // 
            // numSoTC
            // 
            this.numSoTC.Location = new System.Drawing.Point(770, 11);
            this.numSoTC.Name = "numSoTC";
            this.numSoTC.Size = new System.Drawing.Size(120, 30);
            this.numSoTC.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tiết TL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Số Tín Chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMonHoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 277);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 0);
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 30;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(971, 277);
            this.dgvMonHoc.TabIndex = 1;
            this.dgvMonHoc.TabStop = false;
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
            this.Column2.HeaderText = "MÃ MÔN HỌC";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TÊN MÔN HỌC";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SỐ TÍN CHỈ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TIẾT THỰC HÀNH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TIẾT LÝ THUYẾT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tiết TH:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(374, 128);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(455, 128);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(536, 128);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 30);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(293, 128);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txbTenMH
            // 
            this.txbTenMH.Location = new System.Drawing.Point(454, 10);
            this.txbTenMH.MaxLength = 255;
            this.txbTenMH.Name = "txbTenMH";
            this.txbTenMH.Size = new System.Drawing.Size(192, 30);
            this.txbTenMH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên MH:";
            // 
            // txbMaMH
            // 
            this.txbMaMH.Location = new System.Drawing.Point(197, 8);
            this.txbMaMH.MaxLength = 255;
            this.txbMaMH.Name = "txbMaMH";
            this.txbMaMH.Size = new System.Drawing.Size(157, 30);
            this.txbMaMH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Môn Học:";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(36, 10);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(38, 30);
            this.txbID.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numTietTH);
            this.panel1.Controls.Add(this.numTietLT);
            this.panel1.Controls.Add(this.numSoTC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txbTenMH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbMaMH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 173);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // QLMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QLMonHoc";
            this.Text = "QLMonHoc";
            ((System.ComponentModel.ISupportInitialize)(this.numTietTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTC)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTietTH;
        private System.Windows.Forms.NumericUpDown numTietLT;
        private System.Windows.Forms.NumericUpDown numSoTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbTenMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Panel panel1;
    }
}