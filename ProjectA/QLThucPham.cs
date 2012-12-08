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
    public partial class QLThucPham : Form
    {
        public QLThucPham()
        {
            InitializeComponent();
        }

        private void QLThucPham_Load(object sender, EventArgs e)
        {

        }

        private void bttThemDA_Click(object sender, EventArgs e)
        {
            QLThucPham qltp = new QLThucPham();
            qltp.ShowDialog();
        }

        private void DataGridView_ChiTietThucPham()
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                int ID = int.Parse(cbbLoaiThucPham.SelectedValue.ToString());
                string selectCmd = "Select * from SanPham where MaLoaiThucPham = " + ID + "";
                SqlDataAdapter adap = new SqlDataAdapter(selectCmd, cnn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adap.Fill(table);
                table.Columns["ID"].ColumnName = "Mã Sản Phẩm";
                table.Columns["Ten"].ColumnName = "Tên Sản Phẩm";
                table.Columns["Gia"].ColumnName = "Đơn Giá";
                table.Columns["DonVi"].ColumnName = "Đơn Vị";
                table.Columns["MaLoaiThucAn"].ColumnName = "Mã Loại Sản Phẩm";
                dgChiTiet.DataSource = table;
                int i = dgChiTiet.RowCount;
                lblSoTP.Text = i.ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void bttXoaDA_Click(object sender, EventArgs e)
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            string MaDA = dgChiTiet.CurrentCell.Value.ToString();
            try
            {
                DialogResult = MessageBox.Show("Bạn thật sự muốn xóa món này chứ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand("delete from SanPham where ID = @MaDA", cnn);
                        cmd.Parameters.Add("@MaDA", SqlDbType.Int).Value = MaDA;
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        dgChiTiet.Refresh();
                        DataGridView_ChiTietThucPham();
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
            dgChiTiet.Refresh();
            DataGridView_ChiTietThucPham();
        }

        private void bttDongDA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
