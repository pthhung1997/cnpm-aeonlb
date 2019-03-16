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
    public partial class ChiTietNhapHang : Form
    {
        public ChiTietNhapHang()
        {
            InitializeComponent();
        }

        private void ChiTietNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_cnpm_aeonlbDataSet.tblChiTietNhapKho' table. You can move, or remove it, as needed.
            this.tblChiTietNhapKhoTableAdapter.Fill(this._cnpm_aeonlbDataSet.tblChiTietNhapKho);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Entities())
                {
                    var ctnh = new tblChiTietNhapKho();
                    ctnh.sMaHang = txtMahang.ToString();
                    ctnh.sMaNhapKho = txtMakhonhap.ToString();
                    ctnh.fSoLuongThucNhap = float.Parse(txtSoluongthucnhap.ToString());
                    db.tblChiTietNhapKhoes.Add(ctnh);
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
                    var update = (from u in db.tblChiTietNhapKhoes where u.sMaNhapKho == txtMakhonhap.ToString() select u).Single();
                    update.sMaHang = txtMahang.ToString();
                    update.fSoLuongThucNhap = float.Parse(txtSoluongthucnhap.ToString());
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
                    var delete = (from d in db.tblChiTietNhapKhoes where d.sMaNhapKho == txtMakhonhap.ToString() select d).Single();
                    db.tblChiTietNhapKhoes.Remove(delete);
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
                    if (txtMakhonhap.Text != "")
                    {
                        string val = txtMakhonhap.Text.ToString();
                        var select = from s in db.tblChiTietNhapKhoes where s.sMaNhapKho.Contains(val) select s;
                        dgvCTNH.DataSource = select.ToList();
                    }
                    else
                    {
                        ChiTietNhapHang_Load(sender, e);
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
