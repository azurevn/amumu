using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class FormNV : Form
    {
        public FormNV()
        {
            InitializeComponent();
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            lvTable.LargeImageList = imageList1;

            ListViewItem b1 = new ListViewItem("Bàn 1", 0);
            lvTable.Items.Add(b1);
            ListViewItem b2 = new ListViewItem("Bàn 2", 0);
            lvTable.Items.Add(b2);
            ListViewItem b3 = new ListViewItem("Bàn 3", 0);
            lvTable.Items.Add(b3);
            ListViewItem b4 = new ListViewItem("Bàn 4", 0);
            lvTable.Items.Add(b4);
            ListViewItem b5 = new ListViewItem("Bàn 5", 0);
            lvTable.Items.Add(b5);
            ListViewItem b6 = new ListViewItem("Bàn 6", 0);
            lvTable.Items.Add(b6);
            ListViewItem b7 = new ListViewItem("Bàn 7", 0);
            lvTable.Items.Add(b7);
            ListViewItem b8 = new ListViewItem("Bàn 8", 0);
            lvTable.Items.Add(b8);
            ListViewItem b9 = new ListViewItem("Bàn 9", 0);
            lvTable.Items.Add(b9);
            ListViewItem b10 = new ListViewItem("Bàn 10", 0);
            lvTable.Items.Add(b10);
            ListViewItem b11 = new ListViewItem("Bàn 11", 0);
            lvTable.Items.Add(b11);
            ListViewItem b12 = new ListViewItem("Bàn 12", 0);
            lvTable.Items.Add(b12);

            sttTenNV.Text = "Nhân Viên: " + Session._EmployeeName;
            sttMaNV.Text = "Mã Nhân Viên: " + Session._EmployeeId;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn thật sự muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
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
    }
}
