namespace PhamThuyHang_T7
{
    partial class Form23
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Thêm dòng này
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(229, 349);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(56, 60);
            this.btLeft.TabIndex = 1;
            this.btLeft.Text = "<-";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(307, 349);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(56, 60);
            this.btRight.TabIndex = 2;
            this.btRight.Text = "->";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "File ....";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form23";
            this.Text = "Simple Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button button3;
    }
}