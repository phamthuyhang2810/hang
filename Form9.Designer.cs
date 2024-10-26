using System;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    partial class Form9 : Form
    {
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private Button tbCong;
        private Button tbNhan;
        private Button tbThoat;
        private Button tbLuu;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.tbCong = new System.Windows.Forms.Button();
            this.tbNhan = new System.Windows.Forms.Button();
            this.tbThoat = new System.Windows.Forms.Button();
            this.tbLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // tbSoX
            // 
            this.tbSoX.Location = new System.Drawing.Point(100, 50);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(100, 22);
            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(100, 100);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(100, 22);
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(100, 150);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.ReadOnly = true; // Chỉ đọc, không cho phép nhập
            this.tbKetQua.Size = new System.Drawing.Size(100, 22);
            // 
            // tbCong
            // 
            this.tbCong.Location = new System.Drawing.Point(50, 200);
            this.tbCong.Name = "tbCong";
            this.tbCong.Size = new System.Drawing.Size(75, 23);
            this.tbCong.Text = "Cộng";
            this.tbCong.UseVisualStyleBackColor = true;
            this.tbCong.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNhan
            // 
            this.tbNhan.Location = new System.Drawing.Point(150, 200);
            this.tbNhan.Name = "tbNhan";
            this.tbNhan.Size = new System.Drawing.Size(75, 23);
            this.tbNhan.Text = "Nhân";
            this.tbNhan.UseVisualStyleBackColor = true;
            this.tbNhan.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbLuu
            // 
            this.tbLuu.Location = new System.Drawing.Point(250, 200);
            this.tbLuu.Name = "tbLuu";
            this.tbLuu.Size = new System.Drawing.Size(75, 23);
            this.tbLuu.Text = "Lưu";
            this.tbLuu.UseVisualStyleBackColor = true;
            this.tbLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbThoat
            // 
            this.tbThoat.Location = new System.Drawing.Point(350, 200);
            this.tbThoat.Name = "tbThoat";
            this.tbThoat.Size = new System.Drawing.Size(75, 23);
            this.tbThoat.Text = "Thoát";
            this.tbThoat.UseVisualStyleBackColor = true;
            this.tbThoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLuu);
            this.Controls.Add(this.tbThoat);
            this.Controls.Add(this.tbNhan);
            this.Controls.Add(this.tbCong);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.tbSoX);
            this.Name = "Form9";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
