using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn trong danh sách yêu thích không
            if (lbFavorite.SelectedItem != null)
            {
                // Lấy bài hát được chọn
                string song = lbFavorite.SelectedItem.ToString();

                // Thêm bài hát vào danh sách bài hát
                lbsong.Items.Add(song);

                // Xóa bài hát khỏi danh sách yêu thích
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bài hát trong danh sách yêu thích để bỏ chọn.");
            }

        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            string song = lbsong.SelectedItem.ToString();
            lbFavorite.Items.Add(song);
            lbsong.Items.RemoveAt(lbsong.SelectedIndex);
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbsong.Items.Count; i++)
            {
                string song = lbsong.Items[i].ToString();
                lbFavorite.Items.Add(song);
                lbsong.Items.RemoveAt(i);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            // Chuyển tất cả bài hát từ danh sách yêu thích về danh sách bài hát
            while (lbFavorite.Items.Count > 0)
            {
                // Lấy bài hát đầu tiên trong danh sách yêu thích
                string song = lbFavorite.Items[0].ToString();

                // Thêm bài hát vào danh sách bài hát
                lbsong.Items.Add(song);

                // Xóa bài hát khỏi danh sách yêu thích
                lbFavorite.Items.RemoveAt(0);
            }
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)

        {
            int index = this.lbsong.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)


            {

                string song = lbsong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbsong.Items.RemoveAt(lbsong.SelectedIndex);
            }

        }
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (lbFavorite.SelectedItem != null)
            {
                // Lấy mục được chọn
                string selectedSong = lbFavorite.SelectedItem.ToString();

                // Thực hiện hành động bạn muốn, ví dụ:
                MessageBox.Show($"Bạn đã chọn bài hát yêu thích: {selectedSong}");

                // Hoặc có thể xóa mục nếu bạn muốn
                // lbFavorite.Items.Remove(selectedSong);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bài hát trong danh sách yêu thích.");
            }
        }












    }
}
    
