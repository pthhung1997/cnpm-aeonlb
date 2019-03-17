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
    public partial class QuanLyNhapHang : Form
    {
        public QuanLyNhapHang()
        {
            InitializeComponent();
        }

        private void QuanLyNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_cnpm_aeonlbDataSet.tblNhapKho' table. You can move, or remove it, as needed.
            this.tblNhapKhoTableAdapter.Fill(this._cnpm_aeonlbDataSet.tblNhapKho);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    var ctnh = new tblNhapKho();
                    ctnh.sMaNhapKho = txtManhapkho.ToString();
                    ctnh.dNgayNhapKho =DateTime.Parse(txtNgaynhapkho.ToString());
                    ctnh.sMaNV = txtManhanvien.ToString();
                    db.tblNhapKhoes.Add(ctnh);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    var update = (from u in db.tblNhapKhoes where u.sMaNhapKho == txtManhapkho.ToString() select u).Single();
                    update.dNgayNhapKho = DateTime.Parse(txtNgaynhapkho.ToString());
                    update.sMaNV = txtManhanvien.ToString();
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    var delete = (from d in db.tblNhapKhoes where d.sMaNhapKho == txtManhapkho.ToString() select d).Single();
                    db.tblNhapKhoes.Remove(delete);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    if (txtManhapkho.Text != "")
                    {
                        string val = txtManhapkho.Text.ToString();
                        var select = from s in db.tblNhapKhoes where s.sMaNhapKho.Contains(val) select s;
                        dgvQLNH.DataSource = select.ToList();
                    }
                    else
                    {
                        QuanLyNhapHang_Load(sender, e);
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
