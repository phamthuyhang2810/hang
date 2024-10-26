using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhamThuyHang_T7.QLSV
{
    public partial class QLDiem : Form
    {
        // Danh sách lưu trữ các điểm
        private List<Diem> danhSachDiem = new List<Diem>();

        public QLDiem()
        {
            InitializeComponent();
        }

        private void QLDiem_Load(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu khi form khởi tạo
        }

        private void LoadData()
        {
            // Cập nhật DataGridView với danh sách điểm
            dgvDiem.DataSource = null; // Xóa nguồn dữ liệu hiện tại
            dgvDiem.DataSource = danhSachDiem; // Cập nhật nguồn dữ liệu mới
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string id = txbID.Text;
            string maSV = cmbMaSV.SelectedItem?.ToString();
            string maMH = cmbMaMH.SelectedItem?.ToString();
            string loai = cmbLoai.SelectedItem?.ToString();
            decimal diemThi = numPhanTramThi.Value;
            decimal diemTrenLop = numPhanTramTrenLop.Value;

            // Kiểm tra thông tin hợp lệ
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Vui lòng nhập ID điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Vui lòng chọn Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaSV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(maMH))
            {
                MessageBox.Show("Vui lòng chọn Mã môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaMH.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(loai))
            {
                MessageBox.Show("Vui lòng chọn Loại điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoai.Focus();
                return;
            }

            Diem diem = new Diem
            {
                ID = id,
                MaSV = maSV,
                MaMH = maMH,
                Loai = loai,
                DiemThi = diemThi,
                DiemTrenLop = diemTrenLop
            };

            // Thêm điểm vào danh sách
            danhSachDiem.Add(diem);
            MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData(); // Tải lại dữ liệu
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string id = txbID.Text;

            // Kiểm tra ID có tồn tại không
            Diem diem = danhSachDiem.Find(d => d.ID == id);
            if (diem == null)
            {
                MessageBox.Show("Không tìm thấy ID điểm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin điểm
            diem.MaSV = cmbMaSV.SelectedItem?.ToString();
            diem.MaMH = cmbMaMH.SelectedItem?.ToString();
            diem.Loai = cmbLoai.SelectedItem?.ToString();
            diem.DiemThi = numPhanTramThi.Value;
            diem.DiemTrenLop = numPhanTramTrenLop.Value;

            MessageBox.Show("Sửa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData(); // Tải lại dữ liệu
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy ID từ trường nhập liệu
            string id = txbID.Text;

            // Kiểm tra ID có tồn tại không
            Diem diem = danhSachDiem.Find(d => d.ID == id);
            if (diem != null)
            {
                danhSachDiem.Remove(diem); // Xóa điểm khỏi danh sách
                MessageBox.Show("Xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Không tìm thấy ID điểm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Làm mới các trường nhập liệu
            txbID.Clear();
            cmbMaSV.SelectedItem = null;
            cmbMaMH.SelectedItem = null;
            cmbLoai.SelectedItem = null;
            numPhanTramThi.Value = 0;
            numPhanTramTrenLop.Value = 0;

            MessageBox.Show("Đã làm mới các trường nhập liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDiem.Rows[e.RowIndex];
                txbID.Text = row.Cells["ID"].Value.ToString();
                cmbMaSV.SelectedItem = row.Cells["MaSV"].Value.ToString();
                cmbMaMH.SelectedItem = row.Cells["MaMH"].Value.ToString();
                cmbLoai.SelectedItem = row.Cells["Loai"].Value.ToString();
                numPhanTramThi.Value = Convert.ToDecimal(row.Cells["DiemThi"].Value);
                numPhanTramTrenLop.Value = Convert.ToDecimal(row.Cells["DiemTrenLop"].Value);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbDiemThi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDiemTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDiemTrenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numPhanTramThi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numPhanTramTrenLop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDiem_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class Diem
    {
        public string ID { get; set; }
        public string MaSV { get; set; }
        public string MaMH { get; set; }
        public string Loai { get; set; }
        public decimal DiemThi { get; set; }
        public decimal DiemTrenLop { get; set; }
    }
}
