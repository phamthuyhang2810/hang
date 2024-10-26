using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamThuyHang_T7.KN
{
    internal class KN_TaiKhoan
    {
        private static KN_TaiKhoan instance;
       

        public static KN_TaiKhoan Instance
        {

            get { if (instance == null) instance = new KN_TaiKhoan(); return instance; }
            private set => instance
            =
            value;
        }

        private KN_TaiKhoan() { }
        public bool Them(string ten, string matkhau, string loai)
        {
            string sql = "INSERT INTO TaiKhoan (ten, matkhau, loai) VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai });
        }

        public bool Sua(string ten, string matkhau, string loai, int id)
        {
            string sql = "UPDATE Taikhoan SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, LoaiTaiKhoan = @LoaiTaiKhoan WHERE Id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai, id });
        }

        public bool Xoa(int id)
        {
            string sql = "DELETE FROM Taikhoan WHERE Id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("SELECT * FROM TaiKhoan");
        }
    
}
}
