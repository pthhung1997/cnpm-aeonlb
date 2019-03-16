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
    }
}
