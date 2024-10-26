using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    public partial class Form23 : Form
    {
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;

        public Form23()
        {
            InitializeComponent();
            pb.SizeMode = PictureBoxSizeMode.StretchImage; // Corrected syntax
            pb.Size = new Size(100, 100); // Initialize PictureBox size
            this.Controls.Add(pb); // Add PictureBox to the form
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10; // Move left
            pictureBox1.Location = new Point(x, y);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10; // Move right
            pictureBox1.Location = new Point(x, y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Chỉ cho phép hình ảnh
                openFileDialog.Title = "Chọn hình ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.ImageLocation = openFileDialog.FileName; // Lấy đường dẫn tệp hình ảnh đã chọn
                        pictureBox1.Load(); // Tải hình ảnh
                    }
                    catch (System.IO.FileNotFoundException ex)
                    {
                        MessageBox.Show($"Không tìm thấy tệp: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}");
                    }
                }
            }
        }


    }
}
