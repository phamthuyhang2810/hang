namespace PhamThuyHang_T7
{
    partial class Form21
    {
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.CheckBox ckGender;


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

            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbAge.Location = new System.Drawing.Point(80, 251); // Đặt vị trí của tbAge
            this.tbAge.Name = "tbAge"; // Đặt tên cho điều khiển
            this.tbAge.Size = new System.Drawing.Size(134, 22); // Đặt kích thước cho điều khiển
            this.Controls.Add(this.tbAge); // Thêm điều khiển vào form

            this.tbName = new System.Windows.Forms.TextBox();
            this.tbName.Location = new System.Drawing.Point(80, 217); // Đặt vị trí của tbName
            this.tbName.Name = "tbName"; // Đặt tên cho điều khiển
            this.tbName.Size = new System.Drawing.Size(196, 22); // Đặt kích thước cho điều khiển
            this.Controls.Add(this.tbName); // Thêm điều khiển vào form

            this.tbId = new System.Windows.Forms.TextBox();
            this.tbId.Location = new System.Drawing.Point(80, 190); // Đặt vị trí của tbId
            this.tbId.Name = "tbId"; // Đặt tên cho điều khiển
            this.tbId.Size = new System.Drawing.Size(134, 22); // Đặt kích thước cho điều khiển
            this.Controls.Add(this.tbId); // Thêm điều khiển vào form


            this.ckGender = new System.Windows.Forms.CheckBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDeleteNew = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // ckGender
            // 
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(80, 285);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(54, 20);
            this.ckGender.TabIndex = 4;
            this.ckGender.Text = "Nam";
            this.ckGender.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvEmployee.Location = new System.Drawing.Point(24, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(554, 149);
            this.dgvEmployee.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tuổi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới Tính(nam)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tuổi";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(62, 285);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 22);
            this.textBox3.TabIndex = 7;
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(365, 302);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 23);
            this.btAddNew.TabIndex = 8;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDeleteNew
            // 
            this.btDeleteNew.Location = new System.Drawing.Point(476, 302);
            this.btDeleteNew.Name = "btDeleteNew";
            this.btDeleteNew.Size = new System.Drawing.Size(75, 23);
            this.btDeleteNew.TabIndex = 9;
            this.btDeleteNew.Text = "Xóa";
            this.btDeleteNew.UseVisualStyleBackColor = true;
            this.btDeleteNew.Click += new System.EventHandler(this.btDeleteNew_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(598, 302);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 10;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 363);
            this.Controls.Add(this.tbId);

            this.Controls.Add(this.exit);
            this.Controls.Add(this.btDeleteNew);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form21";
            this.Text = "Form21";
            this.Load += new System.EventHandler(this.Form21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDeleteNew;
        private System.Windows.Forms.Button exit;
    }
}