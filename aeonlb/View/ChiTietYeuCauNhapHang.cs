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
    public partial class ChiTietYeuCauNhapHang : Form
    {
        public ChiTietYeuCauNhapHang()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ChiTietYeuCauNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_cnpm_aeonlbDataSet.tblChiTietYeuCauNhap' table. You can move, or remove it, as needed.
            this.tblChiTietYeuCauNhapTableAdapter.Fill(this._cnpm_aeonlbDataSet.tblChiTietYeuCauNhap);

        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    var ctnh = new tblChiTietYeuCauNhap();
                    ctnh.sMaHang = txtMahang.ToString();
                    ctnh.sMaYeuCauNhapKho = txtMaYCN.ToString();
                    ctnh.fSoLuongYeuCau = Int32.Parse(txtSLYC.ToString());
                    db.tblChiTietYeuCauNhaps.Add(ctnh);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    var update = (from u in db.tblChiTietYeuCauNhaps where u.sMaYeuCauNhapKho == txtMaYCN.ToString() select u).Single();
                    update.sMaHang = txtMahang.ToString();
                    update.fSoLuongYeuCau = Int32.Parse(txtSLYC.ToString());
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    var delete = (from d in db.tblChiTietYeuCauNhaps where d.sMaYeuCauNhapKho == txtMaYCN.ToString() select d).Single();
                    db.tblChiTietYeuCauNhaps.Remove(delete);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (var db = new Entities())
                {
                    if (txtMaYCN.Text != "")
                    {
                        string val = txtMaYCN.Text.ToString();
                        var select = from s in db.tblChiTietYeuCauNhaps where s.sMaYeuCauNhapKho.Contains(val) select s;
                        dgvCTYCNH.DataSource = select.ToList();
                    }
                    else
                    {
                        ChiTietYeuCauNhapHang_Load(sender, e);
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
