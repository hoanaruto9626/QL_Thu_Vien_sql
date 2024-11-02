using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Thu_Vien
{
    public partial class fMenu : Form
    {
        public fMenu(fDangNhap fDangNhap)
        {
            InitializeComponent();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            fDangNhap dangnhap = new fDangNhap();
            dangnhap.Show();

            this.Close();
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn xác nhận thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnSach_Click(object sender, EventArgs e)
        {
            fDauSach dausach = new fDauSach();
            dausach.FormClosed += (s, args) => this.Show();
            dausach.Show();
            this.Hide();
        }

        private void mnLop_Click(object sender, EventArgs e)
        {
            fLop lop = new fLop();
            lop.FormClosed += (s, args) => this.Show();
            lop.Show();
            this.Hide();
        }

        private void mnSinhVien_Click(object sender, EventArgs e)
        {
            fsinhvien sinhvien = new fsinhvien();
            sinhvien.FormClosed += (s, args) => this.Show();
            sinhvien.Show();
            this.Hide();
        }

        private void mnPhieuMuon_Click(object sender, EventArgs e)
        {
            fphieumuon phieumuon = new fphieumuon();
            phieumuon.FormClosed += (s, args) => this.Show();
            phieumuon.Show();
            this.Hide();
        }
    }
}
