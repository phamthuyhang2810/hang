using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhamThuyHang_T7.QLSV
{
    public partial class QLKhoa : Form
    {
        // Danh sách lưu trữ các khoa
        private List<Khoa> danhSachKhoa = new List<Khoa>();

        public QLKhoa()
        {
            InitializeComponent();
        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu khi form khởi tạo
        }

        private void LoadData()
        {
            // Tải dữ liệu từ danh sách khoa lên DataGridView
            dgvKhoa.DataSource = null; // Xóa nguồn dữ liệu hiện tại
            dgvKhoa.DataSource = danhSachKhoa; // Cập nhật nguồn dữ liệu mới
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txbMaKhoa.Text;
            string tenKhoa = txbTenKhoa.Text;

            if (string.IsNullOrWhiteSpace(maKhoa) || string.IsNullOrWhiteSpace(tenKhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!");
                return;
            }

            Khoa khoa = new Khoa
            {
                MaKhoa = maKhoa,
                TenKhoa = tenKhoa
            };

            // Thêm khoa vào danh sách
            danhSachKhoa.Add(khoa);
            MessageBox.Show("Thêm khoa thành công!");
            LoadData(); // Tải lại dữ liệu
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txbMaKhoa.Text;
            string tenKhoa = txbTenKhoa.Text;

            if (string.IsNullOrWhiteSpace(maKhoa) || string.IsNullOrWhiteSpace(tenKhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!");
                return;
            }

            // Tìm khoa để sửa
            Khoa khoa = danhSachKhoa.Find(k => k.MaKhoa == maKhoa);
            if (khoa != null)
            {
                khoa.TenKhoa = tenKhoa; // Cập nhật tên khoa
                MessageBox.Show("Sửa khoa thành công!");
                LoadData(); // Tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã khoa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txbMaKhoa.Text;

            if (string.IsNullOrWhiteSpace(maKhoa))
            {
                MessageBox.Show("Vui lòng nhập mã khoa để xóa!");
                return;
            }

            // Tìm khoa để xóa
            Khoa khoa = danhSachKhoa.Find(k => k.MaKhoa == maKhoa);
            if (khoa != null)
            {
                danhSachKhoa.Remove(khoa); // Xóa khoa khỏi danh sách
                MessageBox.Show("Xóa khoa thành công!");
                LoadData(); // Tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã khoa!");
            }
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKhoa.Rows[e.RowIndex];
                txbMaKhoa.Text = row.Cells["MaKhoa"].Value.ToString();
                txbTenKhoa.Text = row.Cells["TenKhoa"].Value.ToString();
            }
        }
    }

    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
    }
}
