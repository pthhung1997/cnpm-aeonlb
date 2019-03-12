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
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_cnpm_aeonlbDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this._cnpm_aeonlbDataSet.tblNhanVien);
            var objects = new List<Object>();
            cbbJob.Items.Add(new { key = "ADMIN", value = "ADMIN"});
            cbbJob.Items.Add("BANHANG");
            cbbJob.Items.Add("KHO");
            cbbJob.Items.Add("THUNGAN");

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            id = "";
            txtUsername.Text = "";
            txtName.Text = "";
            cbbJob.SelectedIndex = -1;
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtUsername.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string cbb = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cbbJob.SelectedIndex = cbbJob.FindString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
        }
    }
}
