using aeonlb.Controller;
using aeonlb.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aeonlb
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanvienController nvController = new NhanvienController();
            String chucvu = nvController.LayThongTinDangNhap(txtUsername.Text, txtPassword.Text);
            if(chucvu.Length > 0)
            {
                TrangChu formTrangChu = new TrangChu();
                this.Hide();
                formTrangChu.Show();
            }else
            {
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }
    }
}
