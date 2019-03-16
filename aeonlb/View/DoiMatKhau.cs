using aeonlb.Controller;
using aeonlb.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aeonlb.View
{
    public partial class DoiMatKhau : Form
    {
        private NhanvienController nvController = new NhanvienController();
        private string username;
        public DoiMatKhau(string username)
        {
            this.username = username;
            InitializeComponent();
            btnXacNhan.Enabled = false;
        }

        private void field_TextChanged(object sender, EventArgs e)
        {
            if (txtMKCu.Text.Trim().Length > 5 && txtMKMoi.Text.Length > 5 && txtNhapLai.Text.Length > 5)
            {
                btnXacNhan.Enabled = true;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            tblNhanVien nhanvien = nvController.LayThongTin(username, txtMKCu.Text);
            if (nhanvien.sMaNV != null && nhanvien.sMaNV.Length > 0)
            {
                string mkMoi = txtMKMoi.Text;
                string nhapLai = txtNhapLai.Text;
                if (mkMoi.Equals(nhapLai))
                {
                    nvController.doiMatKhau(username, mkMoi);
                    MessageBox.Show("Đổi mật khẩu cho tài khoản " + username +" thành công!", "Đổi mật khẩu thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không chính xác", "Đổi mật khẩu không thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Đổi mật khẩu không thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
