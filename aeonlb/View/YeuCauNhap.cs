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
    }
}
