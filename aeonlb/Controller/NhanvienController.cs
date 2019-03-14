using aeonlb.Model;
using aeonlb.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aeonlb.Controller
{
    class NhanvienController
    {
        public String LayThongTinDangNhap(String username, String password)
        {
            String chucvu = "";
            try
            {
                using (var db = new Entities())
                {
                    var select = from s in db.tblNhanViens where s.sTenDangNhap.ToLower().CompareTo(username.ToLower()) == 0 && s.sMatKhau.ToLower().CompareTo(password.ToLower()) == 0 select s;
                    foreach (var data in select)
                    {
                        MessageBox.Show("Xin chào " + data.sHoTenNV + "!", "Đăng nhập thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chucvu = data.sChucVu;
                    }
                    if(select.Count() == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin đăng nhập!", "Đăng nhập không thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chucvu;
        }
        public void updateNhanVien(tblNhanVien nhanvien)
        {
            using (var db = new Entities())
            {
                var update = (from u in db.tblNhanViens where u.sMaNV == nhanvien.sMaNV select u).Single();
                update.sChucVu = nhanvien.sChucVu;
                update.sHoTenNV = nhanvien.sHoTenNV;
                update.sMatKhau = nhanvien.sMatKhau;
                db.SaveChanges();
            }
        }
    }
}
