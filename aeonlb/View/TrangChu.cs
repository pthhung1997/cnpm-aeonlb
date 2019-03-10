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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void HangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham sanpham = new QuanLySanPham();
            sanpham.ShowDialog(this);
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien nhanvien = new QuanLyNhanVien();
            nhanvien.ShowDialog(this);
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang khachhang = new QuanLyKhachHang();
            khachhang.ShowDialog(this);
        }

        private void BanHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyBanHang banhang = new QuanLyBanHang();
            banhang.ShowDialog(this);
        }

        private void NhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhapHang nhaphang = new QuanLyNhapHang();
            nhaphang.ShowDialog(this);
        }

        private void BaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyBaoCao baocao = new QuanLyBaoCao();
            baocao.ShowDialog(this);
        }

        private void DoiMatkhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doimatkhau = new DoiMatKhau();
            doimatkhau.ShowDialog(this);
        }

        private void GioiThieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GioiThieu gioithieu = new GioiThieu();
            gioithieu.ShowDialog(this);
        }

        private void yeuCauNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyYCNH ycnh = new QuanLyYCNH();
            ycnh.ShowDialog(this);
        }
    }
}
