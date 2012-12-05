using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnB
{
    public partial class FormQL : Form
    {
        public FormQL()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nhanVienDS.NhanVien);

            sttTenNV.Text = "Quản Lý: " + Session._EmployeeName;
            sttMaNV.Text = "Mã Quản Lý: " + Session._EmployeeId;
            
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn thật sự muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Session._EmployeeId = 0;
                Session._EmployeeName = "";
                Session._Username = "";            
                this.Close();
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn thật sự muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.Show();
        }

        private void ThucAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThucPham qlta = new QuanLyThucPham();
            qlta.Show();
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon qlhd = new QuanLyHoaDon();
            qlhd.Show();
        }

        private void TKThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKThang tkt = new TKThang();
            tkt.Show();
        }

        private void TKNamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKNam tkn = new TKNam();
            tkn.Show();
        }

        private void LienHeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LienHe lh = new LienHe();
            lh.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void lvMenuDoAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
