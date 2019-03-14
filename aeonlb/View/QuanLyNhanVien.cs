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
    public partial class QuanLyNhanVien : Form
    {
        private string id = "";
<<<<<<< HEAD
        private string matkhau = "";
        private NhanvienController nhanvienController;
=======
>>>>>>> cfef86948d8936a6ab30c66a43fcf7690afe7f4b
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_cnpm_aeonlbDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this._cnpm_aeonlbDataSet.tblNhanVien);
            var objects = new List<Object>();
<<<<<<< HEAD
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

        private void QuanLyNhanVien_Reload(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    var select = from s in db.tblHangs select s;
                    dgvNhanVien.DataSource = select.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
=======
            cbbJob.Items.Add(new { key = "ADMIN", value = "ADMIN"});
            cbbJob.Items.Add("BANHANG");
            cbbJob.Items.Add("KHO");
            cbbJob.Items.Add("THUNGAN");

>>>>>>> cfef86948d8936a6ab30c66a43fcf7690afe7f4b
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            tblNhanVien nhanvien = new Model.tblNhanVien();
            nhanvien.sChucVu = cbbJob.SelectedItem.ToString().Trim();
            nhanvien.sHoTenNV = txtName.Text;
            nhanvien.sMatKhau = matkhau;
            nhanvien.sTenDangNhap = txtUsername.Text;
            nhanvien.sMaNV = id;
            
            if (id == "")
            {

            }else
            {
                nhanvienController.updateNhanVien(nhanvien);
                QuanLyNhanVien_Load(sender, e);
            }
            btnHuy_Click(sender, e);
=======

>>>>>>> cfef86948d8936a6ab30c66a43fcf7690afe7f4b
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            id = "";
            txtUsername.Text = "";
            txtName.Text = "";
            cbbJob.SelectedIndex = -1;
<<<<<<< HEAD

            btnLuu.Enabled = false;
            btnResetMatKhau.Enabled = false;
            btnXoa.Enabled = false;
=======
>>>>>>> cfef86948d8936a6ab30c66a43fcf7690afe7f4b
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
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

            btnLuu.Enabled = true;
            btnResetMatKhau.Enabled = true;
            btnXoa.Enabled = true;
=======
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtUsername.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string cbb = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cbbJob.SelectedIndex = cbbJob.FindString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
>>>>>>> cfef86948d8936a6ab30c66a43fcf7690afe7f4b
        }
    }
}
