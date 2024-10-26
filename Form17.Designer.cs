using System.Runtime.CompilerServices;
using System;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    partial class Form17
    {
        private ListBox listBoxSongs; // Đổi tên


        //private Button btSelect;
        //private Button btDeselect;
        //private Button btSelectAll;
        //private Button btDeselectAll;
        //private ListBox lbsong;
        //private ListBox lbFavorite;

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
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbsong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btSelect = new System.Windows.Forms.Button();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(0, 0);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(120, 84);
            this.listBoxSongs.TabIndex = 0;
            this.listBoxSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách bài hát";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách bài hát yêu thích";
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
            this.lbsong.Location = new System.Drawing.Point(22, 56);
            this.lbsong.Name = "lbsong";
            this.lbsong.Size = new System.Drawing.Size(241, 372);
            this.lbsong.TabIndex = 3;
            // 
            // lbFavorite
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 16;
            this.lbFavorite.Items.AddRange(new object[] {
            "Còn thương nhau thì về Buôn Mê"});
            this.lbFavorite.Location = new System.Drawing.Point(429, 56);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(241, 372);
            this.lbFavorite.TabIndex = 4;
            this.lbFavorite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorite_MouseDoubleClick);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(312, 95);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(58, 44);
            this.btSelect.TabIndex = 6;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btDeselect
            // 
            this.btDeselect.Location = new System.Drawing.Point(312, 145);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(58, 44);
            this.btDeselect.TabIndex = 7;
            this.btDeselect.Text = "<";
            this.btDeselect.UseVisualStyleBackColor = true;
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);
            // 
            // btDeselectAll
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(312, 261);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(58, 44);
            this.btDeselectAll.TabIndex = 8;
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);
            // 
            // btSelectAll
            // 
            this.btSelectAll.Location = new System.Drawing.Point(312, 195);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(58, 44);
            this.btSelectAll.TabIndex = 9;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btDeselectAll);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbsong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form17";
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbsong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btDeselectAll;
        private System.Windows.Forms.Button btSelectAll;
    }
}