namespace PhamThuyHang_T7
{
    partial class Form18
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
            this.lbsong = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbsong
            // 
            this.lbsong.FormattingEnabled = true;
            this.lbsong.ItemHeight = 16;
            this.lbsong.Items.AddRange(new object[] {
            "Giấc Mơ Chapi",
            "Đôi mắt Pleku",
            "Em muốn sông bên anh trọn đời",
            "H\'Hen lên rẫy",
            "Ly cà phê Ban Mê",
            "Đi tìm lời ru mặt trời"});
            this.lbsong.Location = new System.Drawing.Point(12, 48);
            this.lbsong.Name = "lbsong";
            this.lbsong.Size = new System.Drawing.Size(241, 372);
            this.lbsong.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách bài hát";
            // 
            // lbFavorite
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 16;
            this.lbFavorite.Items.AddRange(new object[] {
            "Còn thương nhau thì về Buôn Mê"});
            this.lbFavorite.Location = new System.Drawing.Point(364, 48);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(241, 372);
            this.lbFavorite.TabIndex = 7;
            this.lbFavorite.SelectedIndexChanged += new System.EventHandler(this.lbFavorite_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh sách bài hát yêu thích";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btDeselect
            // 
            this.btDeselect.Location = new System.Drawing.Point(279, 233);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(58, 44);
            this.btDeselect.TabIndex = 9;
            this.btDeselect.Text = "<";
            this.btDeselect.UseVisualStyleBackColor = true;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(279, 183);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(58, 44);
            this.btSelect.TabIndex = 8;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbsong);
            this.Controls.Add(this.label1);
            this.Name = "Form18";
            this.Text = "Form18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbsong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btSelect;
    }
}