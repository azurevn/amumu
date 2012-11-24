using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class QuanLyThucPham : Form
    {
        public QuanLyThucPham()
        {
            InitializeComponent();
        }

        private void QuanLyThucAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThucPhamDS.LoaiThucUong' table. You can move, or remove it, as needed.
            this.loaiThucUongTableAdapter2.Fill(this.qLThucPhamDS.LoaiThucUong);
            // TODO: This line of code loads data into the 'qLThucPhamDS.LoaiThucAn' table. You can move, or remove it, as needed.
            this.loaiThucAnTableAdapter1.Fill(this.qLThucPhamDS.LoaiThucAn);
            // TODO: This line of code loads data into the 'qLThucPhamDS.LoaiThucUong' table. You can move, or remove it, as needed.
            this.loaiThucUongTableAdapter2.Fill(this.qLThucPhamDS.LoaiThucUong);
            // TODO: This line of code loads data into the 'qLThucPhamDS.LoaiThucAn' table. You can move, or remove it, as needed.
            this.loaiThucAnTableAdapter1.Fill(this.qLThucPhamDS.LoaiThucAn);

        }

        private void DataGridView_ChiTietThucAn()
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                int ID = int.Parse(cbbLoaiThucAn.SelectedValue.ToString());
                string selectCmd = "Select * from DoAn where MaLoaiThucAn = " + ID + "";
                SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adap.Fill(table);
                table.Columns["ID"].ColumnName = "Mã Món Ăn";
                table.Columns["Ten"].ColumnName = "Tên Món Ăn";
                table.Columns["Gia"].ColumnName = "Đơn Giá";
                table.Columns["DonVi"].ColumnName = "Đơn Vị";
                table.Columns["MaLoaiThucAn"].ColumnName = "Mã Loại Món Ăn";
                dgChiTietDoAn.DataSource = table;
                int i = dgChiTietDoAn.RowCount;
                lblSoMonAn.Text = i.ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void cbbLoaiThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
                SqlConnection cnn = new SqlConnection(connection);
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                DataGridView_ChiTietThucAn();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttXoaDA_Click(object sender, EventArgs e)
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            string MaDA = dgChiTietDoAn.CurrentCell.Value.ToString();
            try
            {
                DialogResult = MessageBox.Show("Bạn thật sự muốn xóa món ăn này chứ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand("delete from DoAn where ID = @MaDA", cnn);
                        cmd.Parameters.Add("@MaDA", SqlDbType.Int).Value = MaDA;
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        dgChiTietDoAn.Refresh();
                        DataGridView_ChiTietThucAn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa món ăn này", "Error!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rỗng");
            }
        }

        private void bttCapNhatDA_Click(object sender, EventArgs e)
        {
            dgChiTietDoAn.Refresh();
            DataGridView_ChiTietThucAn();
        }

        private void bttDongDA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttThemDA_Click(object sender, EventArgs e)
        {
            ThemThucAn tta = new ThemThucAn();
            tta.ShowDialog();
        }

        private void DataGridView_ChiTietTU()
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                int ID = int.Parse(cbbLoaiTU.SelectedValue.ToString());
                string selectCmd = "Select * from DoUong where MaLoaiThucUong = " + ID + "";
                SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adap.Fill(table);
                table.Columns["ID"].ColumnName = "Mã Thức Uống";
                table.Columns["Ten"].ColumnName = "Tên Thức Uống";
                table.Columns["Gia"].ColumnName = "Đơn Giá";
                table.Columns["DonVi"].ColumnName = "Đơn Vị";
                table.Columns["MaLoaiThucUong"].ColumnName = "Mã Loại Thức Uống";
                dgChiTietTU.DataSource = table;
                int i = dgChiTietTU.RowCount;
                lblSoTU.Text = i.ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void cbbLoaiTU_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
                SqlConnection cnn = new SqlConnection(connection);
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                DataGridView_ChiTietTU();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttThemTU_Click(object sender, EventArgs e)
        {
            ThemThucUong ttu = new ThemThucUong();
            ttu.ShowDialog();
        }

        private void bttXoaTU_Click(object sender, EventArgs e)
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            string MaTU = dgChiTietTU.CurrentCell.Value.ToString();
            try
            {
                DialogResult = MessageBox.Show("Bạn thật sự muốn xóa thức uống này chứ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand("delete from DoUong where ID = @MaTU", cnn);
                        cmd.Parameters.Add("@MaTU", SqlDbType.Int).Value = MaTU;
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        dgChiTietTU.Refresh();
                        DataGridView_ChiTietTU();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa thức uống này", "Error!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rỗng");
            }
        }

        private void bttDongTU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCapNhatTU_Click(object sender, EventArgs e)
        {
            dgChiTietTU.Refresh();
            DataGridView_ChiTietTU();
        }
    }
}
