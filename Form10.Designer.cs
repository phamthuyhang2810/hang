using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    partial class Form10
    {
        private Button btMul;
        private Button btEquals;
        private Button btPlus;
        private Button btchia;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;

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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(216, 85);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(368, 22);
            this.tbDisplay.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 22);
            this.textBox1.TabIndex = 0;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(216, 147);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 23);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(216, 197);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(75, 23);
            this.btPlus.TabIndex = 2;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(319, 147);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button3_Click);
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(319, 197);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(75, 23);
            this.btMul.TabIndex = 4;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(417, 147);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 5;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(509, 147);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 7;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.button7_Click);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(509, 197);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(75, 23);
            this.btEquals.TabIndex = 8;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(417, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = ".";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.textBox1);
            this.Name = "Form10";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private Button button9;
    }
}