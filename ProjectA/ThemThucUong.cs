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
    public partial class ThemThucUong : Form
    {
        public ThemThucUong()
        {
            InitializeComponent();
        }

        private bool KiemTraTrungTU()
        {
            bool kt = false;
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            SqlDataAdapter adap = new SqlDataAdapter("select * from DoUong where Ten = '" + txtTenThucUong.Text + "'", cnn);
            DataTable dttable = new DataTable();
            adap.Fill(dttable);

            if (dttable.Rows.Count > 0)
                kt = true;
            dttable.Dispose();
            cnn.Close();
            return kt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenThucUong.Text == "" || txtDonVi.Text == "" || txtGia.Text == "" || cbbLoai.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thức ăn");

            else
            {
                string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
                SqlConnection cnn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                if (KiemTraTrungTU())
                    MessageBox.Show("Món Ăn này đã có tên trong Menu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    int loai = int.Parse(cbbLoai.SelectedValue.ToString());

                    string sql = string.Format("insert into DoUong(Ten, Gia, DonVi, MaLoaiThucUong) values (N'{0}', N'{1}', N'{2}', N'{3}')",
                        txtTenThucUong.Text, txtGia.Text, txtDonVi.Text, loai);
                    cmd.CommandText = sql;
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        if (cnn.State != System.Data.ConnectionState.Open)
                            cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    cnn.Close();
                    MessageBox.Show("Thêm thức uống thành công");
                    this.Close();
                }
            }
        }

        private void ThemThucUong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThucPhamDS.LoaiThucUong' table. You can move, or remove it, as needed.
            this.loaiThucUongTableAdapter1.Fill(this.qLThucPhamDS.LoaiThucUong);
            // TODO: This line of code loads data into the 'qLThucPhamDS.LoaiThucUong' table. You can move, or remove it, as needed.
            this.loaiThucUongTableAdapter1.Fill(this.qLThucPhamDS.LoaiThucUong);

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
