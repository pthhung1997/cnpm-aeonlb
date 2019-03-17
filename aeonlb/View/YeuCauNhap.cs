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
    public partial class YeuCauNhap : Form
    {
        public YeuCauNhap()
        {
            InitializeComponent();
        }

        private void YeuCauNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_cnpm_aeonlbDataSet.tblYeuCauNhapKho' table. You can move, or remove it, as needed.
            this.tblYeuCauNhapKhoTableAdapter.Fill(this._cnpm_aeonlbDataSet.tblYeuCauNhapKho);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    var ctnh = new tblYeuCauNhapKho();
                    ctnh.sMaYeuCauNhapKho = txtMaYCN.ToString();
                    ctnh.dThoiGianYeuCau = DateTime.Parse(txtTGYC.ToString());
                    ctnh.sMaNV = txtMaNV.ToString();
                    ctnh.sTrangThaiYeuCau = txtTrangThai.ToString();
                    db.tblYeuCauNhapKhoes.Add(ctnh);
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
                    var update = (from u in db.tblYeuCauNhapKhoes where u.sMaYeuCauNhapKho == txtMaYCN.ToString() select u).Single();
                    update.dThoiGianYeuCau = DateTime.Parse(txtTGYC.ToString());
                    update.sMaNV = txtMaNV.ToString();
                    update.sTrangThaiYeuCau = txtTrangThai.ToString();
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
                    var delete = (from d in db.tblYeuCauNhapKhoes where d.sMaYeuCauNhapKho == txtMaYCN.ToString() select d).Single();
                    db.tblYeuCauNhapKhoes.Remove(delete);
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
                    if (txtMaYCN.Text != "")
                    {
                        string val = txtMaYCN.Text.ToString();
                        var select = from s in db.tblYeuCauNhapKhoes where s.sMaYeuCauNhapKho.Contains(val) select s;
                        dgvYCN.DataSource = select.ToList();
                    }
                    else
                    {
                        YeuCauNhap_Load(sender, e);
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
