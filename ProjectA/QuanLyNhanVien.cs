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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemNV tnv = new ThemNV();
            tnv.ShowDialog();
        }

        public void loaddataNV_Listbox()
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                DataSet ds = new DataSet("NhanVien");
                SqlDataAdapter adap = new SqlDataAdapter("select MaNV, TenNV from NhanVien", cnn);
                adap.Fill(ds);
                listBoxNhanVien.DataSource = ds.Tables[0];
                listBoxNhanVien.DisplayMember = "TenNV";
                listBoxNhanVien.ValueMember = "MaNV";
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loaddataNV_Info()
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                int MaNV = Convert.ToInt32(listBoxNhanVien.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand("select * from NhanVien where MaNV = " + MaNV + " ", cnn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds, "NhanVien");
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    txtTen.Text = ds.Tables[0].Rows[i - 1]["TenNV"].ToString();
                    txtCMND.Text = ds.Tables[0].Rows[i - 1]["CMND"].ToString();
                    txtDiaChi.Text = ds.Tables[0].Rows[i - 1]["DiaChi"].ToString();
                    txtMatKhau.Text = ds.Tables[0].Rows[i - 1]["MatKhau"].ToString();
                    dtpNgayLam.Text = ds.Tables[0].Rows[i - 1]["NgayLam"].ToString();
                    dtpNgaySinh.Text = ds.Tables[0].Rows[i - 1]["NgaySinh"].ToString();
                    txtSDT.Text = ds.Tables[0].Rows[i - 1]["SoDienThoai"].ToString();
                    txtTaiKhoan.Text = ds.Tables[0].Rows[i - 1]["TaiKhoan"].ToString();
                    cbbSex.Text = ds.Tables[0].Rows[i - 1]["GioiTinh"].ToString();
                    lblMaNV.Text = ds.Tables[0].Rows[i - 1]["MaNV"].ToString();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void listBoxNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddataNV_Info();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loaddataNV_Listbox();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                DialogResult = MessageBox.Show("Bạn thật sự muốn xóa nhân viên này chứ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand("delete from NhanVien where MaNV = @nv", cnn);
                        cmd.Parameters.Add("@nv", SqlDbType.Int).Value = int.Parse(listBoxNhanVien.SelectedValue.ToString());
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        loaddataNV_Listbox();
                        listBoxNhanVien.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                int MaNV = int.Parse(listBoxNhanVien.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand("update NhanVien set TenNV = @p1, NgaySinh = @p2, DiaChi = @p3, CMND = @p4, GioiTinh = @p5, TaiKhoan = @p6, MatKhau = @p7, SoDienTHoai = @p8, NgayLam = @p9 where MaNV = @nv", cnn);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar, 50).Value = txtTen.Text;
                cmd.Parameters.Add("@p2", SqlDbType.Date).Value = dtpNgaySinh.Text;
                cmd.Parameters.Add("@p3", SqlDbType.NVarChar, 50).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@p4", SqlDbType.NVarChar, 20).Value = txtCMND.Text;
                cmd.Parameters.Add("@p5", SqlDbType.NVarChar, 10).Value = cbbSex.Text;
                cmd.Parameters.Add("@p6", SqlDbType.NVarChar, 50).Value = txtTaiKhoan.Text;
                cmd.Parameters.Add("@p7", SqlDbType.NVarChar, 50).Value = txtMatKhau.Text;
                cmd.Parameters.Add("@p8", SqlDbType.NVarChar, 20).Value = txtSDT.Text;
                cmd.Parameters.Add("@p9", SqlDbType.Date).Value = dtpNgayLam.Text;
                cmd.Parameters.Add("@nv", SqlDbType.Int).Value = MaNV;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                loaddataNV_Info();
                loaddataNV_Listbox();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
