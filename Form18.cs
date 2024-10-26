using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        public List<Song> GetData()
        {
            return new List<Song>
            {
                new Song { Id = 53418, Name = "Giấc mơ cha pi", Author = "Trần Tiến" },
                new Song { Id = 52616, Name = "Đôi mắt pleiku", Author = "Nguyễn Cường" },
                new Song { Id = 51172, Name = "Em muốn sống bên anh trọn đời", Author = "Nguyễn Cường" }
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {
            List<Song> lst = GetData();
            lbsong.DataSource = lst;
            lbsong.DisplayMember = "Name"; // Hiển thị tên bài hát
            lbsong.ValueMember = "Id"; // Nếu cần, lưu Id để sử dụng sau này
        }

        private void lbFavorite_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (lbFavorite.SelectedItem != null)
            {
                // Lấy mục được chọn (giả sử bạn lưu trữ đối tượng Song)
                Song selectedSong = (Song)lbFavorite.SelectedItem;

                // Hiển thị thông tin chi tiết về bài hát
                MessageBox.Show($"Bạn đã chọn: {selectedSong.Name} - Tác giả: {selectedSong.Author}");
            }
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (lbsong.SelectedItem != null)
            {
                // Ép kiểu mục được chọn thành đối tượng Song
                Song song = (Song)lbsong.SelectedItem;

                // Thêm bài hát vào danh sách yêu thích
                lbFavorite.Items.Add(song); // Thêm đối tượng Song

                // Xóa bài hát khỏi danh sách ban đầu
                lbsong.Items.Remove(song); // Xóa bài hát từ lbsong
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bài hát để thêm vào danh sách yêu thích.");
            }
        }
    }
}
