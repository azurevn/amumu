using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace DoAnB
{
    public partial class Main : Form
    {
        HoaDon hd = new HoaDon();
        SqlConnection cnn = new SqlConnection(@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");

        public Main()
        {
            InitializeComponent();
            if (!Session._isAdmin)
            {
                quanlyToolStripMenuItem.Visible = false;      
            }        
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nhanVienDS.NhanVien);
            // TODO: This line of code loads data into the 'nhanVienDS.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.nhanVienDS.NhanVien)
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
                TreeNode node = tvMenu.SelectedNode;

                if (node.Name.Equals("RootTA"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 11 and MaLoaiThucPham = 12 and MaLoaiThucPham = 13";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("RootTU"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 21 and MaLoaiThucPham = 22 and MaLoaiThucPham = 23 and MaLoaiThucPham = 24 and MaLoaiThucPham = 25 and MaLoaiThucPham = 26";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("NodeKhaiVi"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 11";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("NodeMonChinh"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 12";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("NodeTrangMieng"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 13";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("NodeGiaiKhat"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 21";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("NodeCafe"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 22";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("NodeNuocEp"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 23";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("NodeBia"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 24";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("NodeCocktails"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 25";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                else if (node.Name.Equals("RootThuocLa"))
                {
                    string selectCmd = "Select * from SanPham where MaLoaiThucPham = 26";
                    SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adap.Fill(table);
                    table.Columns["Ten"].ColumnName = "Tên";
                    table.Columns["Gia"].ColumnName = "Đơn Giá";
                    table.Columns["DonVi"].ColumnName = "Đơn Vị";
                    dgMatHang.DataSource = table;
                }
                dgMatHang.Columns[4].Visible = false;
                cnn.Close();
            }
            catch
            {
            }
        }

        private void btChuyenBan_Click(object sender, EventArgs e)
        {
            fchuyenban f = new fchuyenban();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.Show();
        }

        private void thựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLThucPham qltp = new QLThucPham();
            qltp.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon qlhd = new QuanLyHoaDon();
            qlhd.Show();
        }

        private void btGopBan_Click(object sender, EventArgs e)
        {

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
                SqlConnection cnn = new SqlConnection(connection);
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                DataGridView_ChiTietMH();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ArrayList load_ProductsID()
        {
            ArrayList productsId = new ArrayList();
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = cnn;
                command.CommandText = "Select ID from SanPham";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productsId.Add(reader[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "errors", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                cnn.Close();
            }
            return productsId;
        }

        public void createHoadon()
        {
            int employeeid = int.Parse(cbbTenNV.SelectedValue.ToString());
            String productid = dgMatHang.Rows[dgMatHang.CurrentRow.Index].Cells[0].Value.ToString();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cnn;
                com.CommandText = "Select * From SanPham where ID = " + "'" + productid + "'";
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    if (int.Parse(cbbSoLuong.Text) > 0)
                        hd.insert_item_toCart(reader[0].ToString(), reader[1].ToString(), int.Parse(cbbSoLuong.Text), decimal.Parse(reader[2].ToString()));
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Có lỗi sảy ra, bạn có chắc là đã thao tác đúng các bước không?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                cnn.Close();
            }
        }

        public void insert_Hoadon(int employeeId, decimal total)
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                SqlCommand com = new SqlCommand();
                String today = DateTime.Now.ToShortDateString();
                com.Connection = cnn;
                //Table INCOMPLETE!!!
                com.CommandText = "insert into HoaDon(NgayBan, GiaTri, MaNV) values(" + "'" + today + "'" + "," + "'" + total + "'" + "," + "'" + employeeId + "')";
                com.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                writeToFile();
                cnn.Close();
            }
        }

        private void writeToFile()
        {

        }

        public void insert_HoadonChitiet(int sellOrderId, String ProductId, int quantity)
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cnn;
                //Quantity of pax and table INCOMPLETE!!!
                com.CommandText = "insert into ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuongDoDung) values(" + "'" + sellOrderId + "'" + "," + "'" + ProductId + "'" + "," + "'" + quantity + "')";
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public int select_orderid()
        {
            int result = 0;
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cnn;
                com.CommandText = "Select max(MaHoaDon) id from HoaDon";
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    result = int.Parse(reader[0].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            createHoadon();

            foreach (Cart cart in hd._Cart)
            {
                list.Add(cart);
            }
            dgHoaDon.DataSource = list;
            lblTien.Text = hd.tong_HoaDon.ToString();
            int giamgia = int.Parse(lblTien.Text) * (int.Parse(txtGiamGia.Text) / 100);
            lblTongCong.Text = (int.Parse(lblTien.Text) + int.Parse(txtPhiDV.Text) - giamgia).ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                hd.remove_item(dgHoaDon.CurrentCell.FormattedValue.ToString());
                dgHoaDon.DataSource = hd._Cart;
                lblTien.Text = hd.tong_HoaDon.ToString();
                int giamgia = int.Parse(lblTien.Text) * (int.Parse(txtGiamGia.Text) / 100);
                lblTongCong.Text = (int.Parse(lblTien.Text) + int.Parse(txtPhiDV.Text) - giamgia).ToString();
                dgHoaDon.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
