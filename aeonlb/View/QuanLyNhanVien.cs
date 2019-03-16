using aeonlb.Controller;
using aeonlb.Model;
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

namespace aeonlb.View
{
    public partial class QuanLyNhanVien : Form
    {
        private string id = "";
        private string matkhau = "";
        private NhanvienController nhanvienController;
        private static Random random = new Random();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_cnpm_aeonlbDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this._cnpm_aeonlbDataSet.tblNhanVien);
            var objects = new List<Object>();
            cbbJob.Items.Clear();
            cbbJob.Items.Add("BANHANG");
            cbbJob.Items.Add("KHO");
            cbbJob.Items.Add("THUNGAN");
            cbbJob.Items.Add("ADMIN");

            btnLuu.Enabled = false;
            btnResetMatKhau.Enabled = false;
            btnXoa.Enabled = false;

            nhanvienController = new NhanvienController();
        }

        private void QuanLyNhanVien_Reload()
        {
            try
            {
                this.tblNhanVienTableAdapter.Fill(this._cnpm_aeonlbDataSet.tblNhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            tblNhanVien nhanvien = new Model.tblNhanVien();
            nhanvien.sChucVu = cbbJob.SelectedItem.ToString().Trim();
            nhanvien.sHoTenNV = txtName.Text;
            nhanvien.sMatKhau = matkhau;
            nhanvien.sTenDangNhap = txtUsername.Text;
            nhanvien.sMaNV = id;
            //MessageBox.Show("Xin chào " + data.sHoTenNV + "!", "Đăng nhập thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (id == "")
            {
                if (!Regex.IsMatch(txtUsername.Text, "^([a-zA-Z]{1}[\\w|\\.|\\|_|\\-]{4,18}\\w{1})$"))
                {
                    MessageBox.Show("Tên tài khoản:\n + Bắt đầu bằng 1 chữ cái \n + Chỉ chứa chữ cái, số hoặc các dấu ._- \n + Kết thúc bằng một chữ cái hoặc số \n + Phân biệt hoa thường", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                };
                id = Guid.NewGuid().ToString();
                _cnpm_aeonlbDataSet.tblNhanVienRow newRow= _cnpm_aeonlbDataSet.tblNhanVien.NewtblNhanVienRow();
                newRow.sMaNV = id;
                newRow.sHoTenNV = nhanvien.sHoTenNV;
                newRow.sChucVu = nhanvien.sChucVu;
                newRow.sMatKhau = RandomString(6);
                newRow.sTenDangNhap = nhanvien.sTenDangNhap;
                try
                {
                    this._cnpm_aeonlbDataSet.tblNhanVien.Rows.Add(newRow);
                    this.tblNhanVienTableAdapter.Update(this._cnpm_aeonlbDataSet.tblNhanVien);
                    MessageBox.Show("Tạo tài khoản thành công. \n     + Mật khẩu: \"" + newRow.sMatKhau + "\" \n     + Tên tài khoản: \"" + nhanvien.sTenDangNhap + "\"", "Tạo tài khoản thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tạo tài khoản không thành công. Liên hệ nhóm phát triển để được tư vấn!", "Tạo tài khoản thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                QuanLyNhanVien_Reload();

            }
            else
            {
                nhanvienController.updateNhanVien(nhanvien);
                QuanLyNhanVien_Load(sender, e);
            }
            btnHuy_Click(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            id = "";
            txtUsername.Text = "";
            txtName.Text = "";
            txtUsername.Enabled = true;
            cbbJob.SelectedIndex = -1;

            btnLuu.Enabled = false;
            btnResetMatKhau.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Xác nhập reset mật khẩu cho tài khoản " + txtUsername.Text + "?", "Reset mật khẩu!",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                string newPass = RandomString(6);
                MessageBox.Show("Mật khẩu mới cho tài khoản " + txtUsername.Text + " là : \"" + newPass, "Đặt lại khoản thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nhanvienController.doiMatKhau(txtUsername.Text, newPass);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString().Trim();
            txtName.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString().Trim();
            txtUsername.Text = dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString().Trim();
            string cbb = dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString().Trim();
            cbbJob.SelectedIndex = cbbJob.Items.IndexOf(cbb);
            matkhau = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString().Trim();

            txtUsername.Enabled = false;
            btnLuu.Enabled = true;
            btnResetMatKhau.Enabled = true;
            //btnXoa.Enabled = true;
        }

        private void field_TextChanged(object sender, EventArgs e)
        {
            if (cbbJob.SelectedIndex != -1 && txtName.Text.Trim().Length > 0 && txtUsername.Text.Length > 6)
            {
                btnLuu.Enabled = true;
            }
        }
    }
}
