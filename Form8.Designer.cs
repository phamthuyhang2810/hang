using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    partial class Form8cs
    {
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private Button tbCong;
        private Button tbNhan;
        private Button tbThoat;
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
            // Khởi tạo TextBox và Button
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();

            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();

            // 
            // tbSoX
            // 
            this.tbSoX.Location = new System.Drawing.Point(140, 84);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(385, 22);

            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(140, 160);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(385, 22);

            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(140, 228);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(385, 22);
            this.tbKetQua.ReadOnly = true;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số x";

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số y";

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kết Quả";

            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cộng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(278, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Nhân";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);

            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(450, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);

            // Thêm các TextBox và Button vào form
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);

            this.Text = "Calculator";
            this.ClientSize = new System.Drawing.Size(737, 545);
        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        //private Label label4;
        //private Label label5;
        //private Label label6;
        //private Button button4;
        //private Button button5;
        //private Button button6;
        //private TextBox textBox4;
        //private TextBox textBox5;
        //private TextBox textBox6;
       
    }
}
