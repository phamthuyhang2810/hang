namespace PhamThuyHang_T7
{
    partial class Form7
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
            this.label = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(63, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Yaer";
            this.label.Click += new System.EventHandler(this.tbYear_Click);
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(178, 55);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(290, 22);
            this.tbYear.TabIndex = 1;
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Phone";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}