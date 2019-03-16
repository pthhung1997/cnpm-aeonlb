using aeonlb.Model;
using aeonlb.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aeonlb.Controller
{
    class NhanvienController
    {
        public tblNhanVien LayThongTin(String username, String password)
        {
            tblNhanVien nhanVien = new tblNhanVien();
            try
            {
                using (var db = new Entities())
                {
                    var select = from s in db.tblNhanViens where s.sTenDangNhap.ToLower().CompareTo(username.ToLower()) == 0 && s.sMatKhau.ToLower().CompareTo(password.ToLower()) == 0 select s;
                    foreach (var data in select)
                    { 
                        nhanVien.sMaNV = data.sMaNV;
                        nhanVien.sChucVu = data.sChucVu;
                        nhanVien.sHoTenNV = data.sHoTenNV;
                        nhanVien.sTenDangNhap = data.sTenDangNhap;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nhanVien;
        }
        public void updateNhanVien(tblNhanVien nhanvien)
        {
            using (var db = new Entities())
            {
                var update = (from u in db.tblNhanViens where u.sMaNV == nhanvien.sMaNV select u).Single();
                update.sChucVu = nhanvien.sChucVu;
                update.sHoTenNV = nhanvien.sHoTenNV;
                db.SaveChanges();

            }
        }

        public void doiMatKhau(string username, string password)
        {
            using (var db = new Entities())
            {
                var update = (from u in db.tblNhanViens where u.sTenDangNhap == username select u).Single();
                update.sMatKhau = password;
                db.SaveChanges();

            }
        }
    }
}
