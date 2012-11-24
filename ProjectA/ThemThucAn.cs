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
    public partial class ThemThucAn : Form
    {
        public ThemThucAn()
        {
            InitializeComponent();
        }

        private bool KiemTraTrungDoAn()
        {
            bool kt = false;
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            SqlDataAdapter adap = new SqlDataAdapter("select * from DoAn where Ten = '" + txtTenThucAn.Text + "'", cnn);
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
            if(txtTenThucAn.Text == "" || txtDonVi.Text == "" || txtGia.Text == "" || cbbLoai.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thức ăn");

            else
            {
                string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
                SqlConnection cnn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                if (KiemTraTrungDoAn())
                    MessageBox.Show("Món Ăn này đã có tên trong Menu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    int loai = int.Parse(cbbLoai.SelectedValue.ToString());

                    string sql = string.Format("insert into DoAn(Ten, Gia, DonVi, MaLoaiThucAn) values (N'{0}', N'{1}', N'{2}', N'{3}')",
                        txtTenThucAn.Text, txtGia.Text, txtDonVi.Text, loai);
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
                    MessageBox.Show("Thêm món ăn thành công");
                    this.Close();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemThucAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThucPhamDS.LoaiThucAn' table. You can move, or remove it, as needed.
            this.loaiThucAnTableAdapter.Fill(this.qLThucPhamDS.LoaiThucAn);
            // TODO: This line of code loads data into the 'qLThucPhamDS.LoaiThucAn' table. You can move, or remove it, as needed.
            this.loaiThucAnTableAdapter.Fill(this.qLThucPhamDS.LoaiThucAn);

        }
    }
}
