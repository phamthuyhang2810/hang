namespace PhamThuyHang_T7
{
    partial class Form22
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
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.btDeleteNew = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(89, 262);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(134, 22);
            this.tbAge.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(89, 228);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 22);
            this.tbName.TabIndex = 13;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(89, 201);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(134, 22);
            this.tbId.TabIndex = 15;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(607, 313);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 25;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btDeleteNew
            // 
            this.btDeleteNew.Location = new System.Drawing.Point(485, 313);
            this.btDeleteNew.Name = "btDeleteNew";
            this.btDeleteNew.Size = new System.Drawing.Size(75, 23);
            this.btDeleteNew.TabIndex = 24;
            this.btDeleteNew.Text = "Xóa";
            this.btDeleteNew.UseVisualStyleBackColor = true;
            this.btDeleteNew.Click += new System.EventHandler(this.btDeleteNew_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(374, 313);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 23);
            this.btAddNew.TabIndex = 23;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // ckGender
            // 
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(89, 296);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(58, 20);
            this.ckGender.TabIndex = 19;
            this.ckGender.Text = "Nam";
            this.ckGender.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(33, 23);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(554, 149);
            this.dgvEmployee.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tuổi";
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btDeleteNew);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form22";
            this.Text = "Form22";
            this.Load += new System.EventHandler(this.Form22_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btDeleteNew;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}