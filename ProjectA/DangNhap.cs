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
    public partial class DangNhap : Form
    {
        bool isQuanLy = false;
        public DangNhap()
        {
            InitializeComponent();
            label2tk.Hide();
            label3mk.Hide();
            txtMatKhau.Hide();
            txtTaiKhoan.Hide();
            labelxinchao.Hide();
            btDangNhap.Hide();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
          
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                txtTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtMatKhau.Focus();
            }

            else
            {
                ketnoi data = new ketnoi();
                if (isQuanLy)
                {
                    try
                    {
                       
                        SqlDataReader reader = data.ExecuteReader("Select * From QuanLy Where TaiKhoan = '" + txtTaiKhoan.Text + "' And MatKhau = '" + txtMatKhau.Text + "'");

                        if (reader.Read())
                        {
                            Session.set(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(),true);
                            Main f = new Main();
                            f.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Thông tin quản lý không đúng, vui lòng kiểm tra lại");
                        }
                        reader.Close();
                        data.disconnect();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    try
                    {
                        
                        SqlDataReader reader = data.ExecuteReader("Select * From NhanVien Where TaiKhoan = '" + txtTaiKhoan.Text + "' And MatKhau = '" + txtMatKhau.Text + "'");

                        if (reader.Read())
                        {
                            Session.set(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(),false);
                            Main f = new Main();
                            f.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Thông tin nhân viên không đúng, vui lòng kiểm tra lại");
                        }
                        reader.Close();
                        data.disconnect();
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

        private void quanlybtn_Click(object sender, EventArgs e)
        {
            isQuanLy = true;

            label2tk.Show();
            label3mk.Show();
            txtMatKhau.Show();
            txtTaiKhoan.Show();

            labelxinchao.Text = "Mời quản lý đăng nhập";
            labelxinchao.Show();
            btDangNhap.Show();
            txtTaiKhoan.Focus();
           
        }

        private void nhanvienbtn_Click(object sender, EventArgs e)
        {
            isQuanLy = false;
            label2tk.Show();
            label3mk.Show();
            txtMatKhau.Show();
            txtTaiKhoan.Show();
            txtTaiKhoan.Focus();

            labelxinchao.Text = "Mời nhân viên đăng nhập";
            labelxinchao.Show();
            btDangNhap.Show();

        }
    }
}
