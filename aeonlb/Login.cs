using aeonlb.Controller;
using aeonlb.Model;
using aeonlb.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aeonlb
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanvienController nvController = new NhanvienController();
            if (!Regex.IsMatch(txtUsername.Text, "^([a-zA-Z]{1}[\\w|\\.|\\|_|\\-]{4,18}\\w{1})$"))
            {
                MessageBox.Show("Tên tài khoản:\n + Bắt đầu bằng 1 chữ cái \n + Chỉ chứa chữ cái, số hoặc các dấu ._- \n + Kết thúc bằng một chữ cái hoặc số \n + Phân biệt hoa thường", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
            tblNhanVien nhanvien = nvController.LayThongTin(txtUsername.Text, txtPassword.Text);
            if (nhanvien.sMaNV != null && nhanvien.sMaNV.Length > 0)
            {
                MessageBox.Show("Xin chào " + nhanvien.sHoTenNV + "!", "Đăng nhập thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TrangChu formTrangChu = new TrangChu(this, txtUsername.Text);
                txtPassword.Text = "";
                txtUsername.Text = "";
                this.Hide();
                formTrangChu.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin đăng nhập!", "Đăng nhập không thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }
    }
}
