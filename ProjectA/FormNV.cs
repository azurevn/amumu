using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnB
{
    public partial class FormNV : Form
    {
        public FormNV()
        {
            InitializeComponent();
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nhanVienDS.NhanVien);
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

        private void DataGridView_ChiTietMH()
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                int ID = 0;
                TreeNode node = tvMenu.SelectedNode;
                if (node.Name.Equals("NodeKhaiVi"))
                    ID = 11;
                else if (node.Name.Equals("NodeMonChinh"))
                    ID = 12;
                else if (node.Name.Equals("NodeTrangMieng"))
                    ID = 13;
                else if (node.Name.Equals("NodeGiaiKhat"))
                    ID = 21;
                else if (node.Name.Equals("NodeCafe"))
                    ID = 22;
                else if (node.Name.Equals("NodeNuocEp"))
                    ID = 23;
                else if (node.Name.Equals("NodeBia"))
                    ID = 24;
                else if (node.Name.Equals("NodeCocktails"))
                    ID = 25;
                else if (node.Name.Equals("RootThuocLa"))
                    ID = 26;


                string selectCmd = "Select * from DoAn and DoUong where MaLoaiThucUong = " + ID + " and MaLoaiThucAn = " + ID + "";
                SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adap.Fill(table);
            }
            catch
            {
            }
        }
    }
}
