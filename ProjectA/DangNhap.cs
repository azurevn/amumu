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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            bool check;
            if (rbQuanLy.Checked || rbNhanVien.Checked)
                check = true;
            else
                check = false;

            if (check == false)
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
            }
            else if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }

            else
            {
                string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
                SqlConnection con = new SqlConnection(connection);
                if (con.State == ConnectionState.Closed)
                    con.Open();

                if (rbQuanLy.Checked)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select * From QuanLy Where TaiKhoan = '" + txtTaiKhoan.Text + "' And MatKhau = '" + txtMatKhau.Text + "'", con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            Session.set(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString());
                            FormQL ql = new FormQL();
                            ql.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Thông tin quản lý không đúng, vui lòng kiểm tra lại");
                        }
                        reader.Close();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else if (rbNhanVien.Checked)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select * From NhanVien Where TaiKhoan = '" + txtTaiKhoan.Text + "' And MatKhau = '" + txtMatKhau.Text + "'", con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            Session.set(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString());
                            FormNV nv = new FormNV();
                            nv.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Thông tin nhân viên không đúng, vui lòng kiểm tra lại");
                        }
                        reader.Close();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
