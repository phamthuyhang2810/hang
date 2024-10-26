using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PhamThuyHang_T7
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = dlg.FileName;
            }
        }


        private void pbImage_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.ImageLocation = @"d:\abc.jpg";
        }
    }
}
