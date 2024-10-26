namespace PhamThuyHang_T7.QLSV
{
    partial class QLKhoa
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
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.txbMaKhoa = new System.Windows.Forms.TextBox();
            this.txbTenKhoa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Location = new System.Drawing.Point(12, 12);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Size = new System.Drawing.Size(776, 300);
            this.dgvKhoa.TabIndex = 0;
            this.dgvKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);

            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.Location = new System.Drawing.Point(100, 320);
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Size = new System.Drawing.Size(200, 20);
            this.txbMaKhoa.TabIndex = 1;

            // 
            // txbTenKhoa
            // 
            this.txbTenKhoa.Location = new System.Drawing.Point(100, 360);
            this.txbTenKhoa.Name = "txbTenKhoa";
            this.txbTenKhoa.Size = new System.Drawing.Size(200, 20);
            this.txbTenKhoa.TabIndex = 2;

            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(320, 320);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(320, 360);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(320, 400);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Khoa:";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Khoa:";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hành Động:";

            // 
            // QLKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbTenKhoa);
            this.Controls.Add(this.txbMaKhoa);
            this.Controls.Add(this.dgvKhoa);
            this.Name = "QLKhoa";
            this.Text = "Quản Lý Khoa";
            this.Load += new System.EventHandler(this.QLKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbTenKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}