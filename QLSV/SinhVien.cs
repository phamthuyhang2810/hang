using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamThuyHang_T7.QLSV
{
    public partial class SinhVien : Form
    {
        private List<QLSinhVien> danhSachSinhVien = new List<QLSinhVien>();

        public SinhVien()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quảnLýKhoa_Click(object sender, EventArgs e)
        {
            QLKhoa f = new QLKhoa();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }


        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QLKhoa f = new QLKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       

        

      

       

        

       

        private void quảnLýLớpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QLLop f = new QLLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýCốVấnHọcTậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CoVan f = new CoVan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QLMonHoc f = new QLMonHoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QLTaiKhoan f = new QLTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýDiểmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QLDiem f = new QLDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new ThongTin().ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new DoiMK().ShowDialog();
        }

      
            private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
            {
                // Hiển thị thông báo xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Đóng form hiện tại
                    this.Hide();

                    // Mở lại form đăng nhập (giả sử bạn có một form tên là Login)
                    DN loginForm = new DN();
                    loginForm.ShowDialog();

                    // Đóng form đăng xuất sau khi đăng nhập
                    this.Close();
                }
            

        }
        private void LoadData()
        {
            // Xóa tất cả các hàng hiện có trong DataGridView
            dgvSinhVien.Rows.Clear();

            // Thêm từng sinh viên từ danh sách vào DataGridView
            foreach (var sv in danhSachSinhVien)
            {
                dgvSinhVien.Rows.Add(sv.MaSV, sv.TenSV, sv.NgaySinh.ToShortDateString(), sv.GioiTinh, sv.QueQuan, sv.MaLop, sv.MaKhoa, sv.MaCoVan, sv.NgayNhapHoc.ToShortDateString());
            }
        }




        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin nhập vào
            if (string.IsNullOrWhiteSpace(txbMaSV.Text) || string.IsNullOrWhiteSpace(txbTenSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên và tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng sinh viên mới
            QLSinhVien sinhVien = new QLSinhVien
            {
                MaSV = txbMaSV.Text,
                TenSV = txbTenSV.Text,
                NgaySinh = dtpkNgaySinh.Value,
                GioiTinh = rdNam.Checked ? "Nam" : "Nữ",
                QueQuan = txbQueQuan.Text,
                MaLop = txbMaLop.Text,
                MaKhoa = txbMaKhoa.Text,
                MaCoVan = txbMaCoVan.Text,
                NgayNhapHoc = dtpkNgayNhapHoc.Value
            };

            // Thêm sinh viên vào danh sách
            danhSachSinhVien.Add(sinhVien);

            // Cập nhật DataGridView
            LoadData();

            // Thông báo
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txbMaSV.Text;
            string tenSV = txbTenSV.Text;

            if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(tenSV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!");
                return;
            }

            // Tìm sinh viên để sửa
            QLSinhVien sinhVien = danhSachSinhVien.Find(sv => sv.MaSV == maSV);
            if (sinhVien != null)
            {
                sinhVien.TenSV = tenSV; // Cập nhật tên sinh viên
                sinhVien.NgaySinh = dtpkNgaySinh.Value;
                sinhVien.GioiTinh = rdNam.Checked ? "Nam" : "Nữ";
                sinhVien.QueQuan = txbQueQuan.Text;
                sinhVien.MaLop = txbMaLop.Text;
                sinhVien.MaKhoa = txbMaKhoa.Text;
                sinhVien.MaCoVan = txbMaCoVan.Text;
                sinhVien.NgayNhapHoc = dtpkNgayNhapHoc.Value;

                MessageBox.Show("Sửa sinh viên thành công!");
                LoadData(); // Tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã sinh viên!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txbMaSV.Text;

            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để xóa!");
                return;
            }

            // Tìm sinh viên để xóa
            QLSinhVien sinhVien = danhSachSinhVien.Find(sv => sv.MaSV == maSV);
            if (sinhVien != null)
            {
                danhSachSinhVien.Remove(sinhVien); // Xóa sinh viên khỏi danh sách
                MessageBox.Show("Xóa sinh viên thành công!");
                LoadData(); // Tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã sinh viên!");
            }
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData(); // Tải lại dữ liệu
            MessageBox.Show("Tải lại dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public class QLSinhVien
        {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            public DateTime NgaySinh { get; set; }
            public string GioiTinh { get; set; }
            public string QueQuan { get; set; }
            public string MaLop { get; set; }
            public string MaKhoa { get; set; }
            public string MaCoVan { get; set; }
            public DateTime NgayNhapHoc { get; set; }
        }

        private void txbTenSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
