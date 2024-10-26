using System.Drawing;

namespace PhamThuyHang_T7
{
    partial class Form13
    {
        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbDisplay;


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
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngoại Ngữ",
            "Quản Trị Kinh doanh",
            "Cơ Khí",
            "Điện",
            "Cơ khí Động lực"});
            this.cb_Faculty.Location = new System.Drawing.Point(34, 44);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(454, 24);
            this.cb_Faculty.TabIndex = 0;
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(34, 96);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(454, 22);
            this.tbDisplay.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 352);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_Faculty);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form13";
            this.Text = "ComboBox Article";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}