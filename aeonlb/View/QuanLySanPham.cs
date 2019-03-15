using System;
using System.Data;
using System.Linq;
using aeonlb.Model;
using System.Windows.Forms;
using System.Drawing;

namespace aeonlb.View
{
    public partial class QuanLySanPham : Form
    {
		public string MaHang;
        public QuanLySanPham()
        {
            InitializeComponent();
        }

		private void QuanLySanPham_Load(object sender, EventArgs e)
		{
			try
			{
				using (var db = new Entities())
				{
					var select = from s in db.tblHangs select s;
					dgvSanPham.DataSource = select.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			DataGridViewRow selectRow = dgvSanPham.Rows[index];
			txtTenHang.Text = selectRow.Cells[0].Value.ToString();
			txtMoTa.Text = selectRow.Cells[1].Value.ToString();
			txtGiaBan.Text = selectRow.Cells[4].Value.ToString();
		}

		private void bthuy_Click(object sender, EventArgs e)
		{
			txtTenHang.Text = "";
			txtMoTa.Text = "";
			txtGiaBan.Text = "";
		}

		private void dgvSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dgvSanPham.ClearSelection();
		}

		private void btupdate_Click(object sender, EventArgs e)
		{
			try
			{
				using (var db = new Entities())
				{
					MaHang = dgvSanPham.SelectedCells[5].Value.ToString();
					var update = (from u in db.tblHangs where u.sMaHang == MaHang select u).Single();
					update.sTenHang = txtTenHang.Text;
					update.sMotaHang = txtMoTa.Text;
					update.fGiaBan = (float)Convert.ToDouble(txtGiaBan.Text.ToString());
					db.SaveChanges();
					QuanLySanPham_Load(sender,e);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			try
			{
				using (var db = new Entities())
				{
					if(txtTimKiem.Text != "")
					{
						string val = txtTimKiem.Text.ToString();
						var select = from s in db.tblHangs where s.sTenHang.Contains(val) select s;
						dgvSanPham.DataSource = select.ToList();
					}
					else
					{
						QuanLySanPham_Load(sender, e);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
