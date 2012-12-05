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
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }

        private bool KiemTraTrungNV()
        {
            bool kt = false;
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            SqlDataAdapter adap = new SqlDataAdapter("select * from NhanVien where TaiKhoan = '" + txtTaiKhoan.Text + "'", cnn);
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
            String sex = "";
            if (rbNam.Checked)
                sex = "Nam";
            else if (rbNu.Checked)
                sex = "Nữ";

            if (txtCMND.Text == "" || txtDiaChi.Text == "" || txtMatKhau.Text == "" || dtpNgaySinh.Text == "" ||
                txtSDT.Text == "" || txtTaiKhoan.Text == "" || txtTen.Text == "" || dtpNgayLam.Text == "" || sex == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
            else
            {
                string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
                SqlConnection cnn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                if (KiemTraTrungNV())
                    MessageBox.Show("Tên tài khoản này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {

                    string sql = string.Format("insert into NhanVien(TenNV, NgaySinh, DiaChi, CMND, GioiTinh, TaiKhoan, MatKhau, SoDienThoai, NgayLam) values (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}')",
                        txtTen.Text, dtpNgaySinh.Text, txtDiaChi.Text, txtCMND.Text, sex, txtTaiKhoan.Text, txtMatKhau.Text, txtSDT.Text, dtpNgayLam.Text);
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
                    MessageBox.Show("Thêm nhân viên thành công");
                    this.Close();
                }
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
