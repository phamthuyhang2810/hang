using PhamThuyHang_T7.QLTK;
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
    public partial class QLTaiKhoan : Form
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // Thiết lập kiểu DropDownList để người dùng chỉ có thể chọn các mục
            cmbLoaiTaiKhoan.DropDownStyle = ComboBoxStyle.DropDownList;

            // Nạp dữ liệu vào ComboBox
            cmbLoaiTaiKhoan.Items.Add("Admin");
            cmbLoaiTaiKhoan.Items.Add("User");
            cmbLoaiTaiKhoan.Items.Add("Moderator");
            // Thêm các loại tài khoản khác nếu cần
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string LoaiTK = cmbLoaiTaiKhoan.SelectedItem?.ToString(); // Sử dụng toán tử điều kiện null

            if (tendangnhap.Length > 0 && matkhau.Length >= 6 && !string.IsNullOrEmpty(LoaiTK))
            {
                if (QLTK_TaiKhoan.Instance.Them(tendangnhap, matkhau, LoaiTK))
                    btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Mật khẩu không được dưới 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /* private void btnThem_Click(object sender, EventArgs e)
         {
             string tendangnhap = txbTenDangNhap.Text.Trim();
             string matkhau = txbMatKhau.Text.Trim();

             // Kiểm tra xem có mục nào được chọn trong ComboBox
             if (cmbLoaiTaiKhoan.SelectedItem != null)
             {
                 string LoaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();

                 if (tendangnhap.Length > 0 && matkhau.Length >= 6 && LoaiTK.Length > 0)
                 {
                     if (BLL_TaiKhoan.Instance.Them(tendangnhap, matkhau, LoaiTK)==true)
                         btnLamMoi.PerformClick();
                 }
                 else
                 {
                     MessageBox.Show("Mật khẩu không được dưới 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
             }
             else
             {
                 MessageBox.Show("Vui lòng chọn loại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
         }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Logic xử lý khi panel vẽ lại
            // Bạn có thể để trống nếu không cần xử lý gì đặc biệt
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = QLTK_TaiKhoan.Instance.DanhSach();
        }

        private void txbTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
