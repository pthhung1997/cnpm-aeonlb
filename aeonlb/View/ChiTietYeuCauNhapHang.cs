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
    }
}
