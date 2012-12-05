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
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void DataGridView_ChiTietHD()
        {
            string connection = (@"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe");
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            try
            {
                cnn.Open();
                int MaHD = int.Parse(listBoxMaHD.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand("Select Ten, Gia, SoLuongDoDung from HoaDon, DoAn, DoUong, ChiTietHoaDon, NhanVien where HoaDon.MaHoaDon = " + MaHD +
                    "and HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon and ChiTietHoaDon.MaDoDung = DoAn.ID and ChiTietHoaDon.MaDoDung = DoUong.ID and NhanVien.MaNV = HoaDon.MaNV", cnn);

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adap.Fill(table);
                table.Columns["TenSanPham"].ColumnName = "Tên Sản Phẩm";
                table.Columns["GiaBan"].ColumnName = "Giá Bán";
                table.Columns["SoLuong"].ColumnName = "Số Lượng";
                dgChiTietHD.DataSource = table;
                lblMaHD.Text = MaHD.ToString();

                SqlCommand com = new SqlCommand("Select MaNV, TenNV, Ban, SoLuongKhach, NgayBan, GiaTri from HoaDon, DoAn, DoUong, ChiTietHoaDon, NhanVien where HoaDon.MaHoaDon = " + MaHD +
                    "and HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon and ChiTietHoaDon.MaDoDung = DoAn.ID and ChiTietHoaDon.MaDoDung = DoUong.ID and NhanVien.MaNV = HoaDon.MaNV", cnn);
                SqlDataReader reader = com.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        lblMaNV.Text = reader["MaNV"].ToString();
                        lblTenNV.Text = (string)reader["Ten"];
                        lblNgay.Text = ((DateTime)reader["NgayBan"]).ToString();
                        lblGiaTri.Text = ((decimal)reader["GiaTri"]).ToString();
                        lblBan.Text = reader["Ban"].ToString();
                        lblSoKhach.Text = reader["SoLuongKhach"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
