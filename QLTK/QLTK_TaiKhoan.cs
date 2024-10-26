using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamThuyHang_T7.QLTK
{
    internal class QLTK_TaiKhoan
    {
        private static QLTK_TaiKhoan instance;

        public static QLTK_TaiKhoan Instance
        {

            get { if (instance == null) instance = new QLTK_TaiKhoan(); return instance; }
            private set => instance
            =
            value;
        }

        private  QLTK_TaiKhoan() { }

        public DataTable DanhSach()
        {
            return QLTK_TaiKhoan.Instance.DanhSach();
        }

        public bool Them(string ten, string matkhau, string loai)
        {
            matkhau = HeThong.Hash(matkhau);
            return QLTK_TaiKhoan.Instance.Them(ten, matkhau, loai);

        }
    }
}

