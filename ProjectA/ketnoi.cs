using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DoAnB
{
    class ketnoi
    {

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        DataTable dt;
        SqlDataReader dr;

        private string source = @"Server = .\SQLEXPRESS; Integrated Security = True; Database = QuanLyCafe";
        public void conncet()
        {
            if (con == null)
                con = new SqlConnection();
            con.ConnectionString = source;
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void disconnect()
        {
            if ((con != null) && (con.State == ConnectionState.Open))
                con.Close();
        }
        public DataSet get(string sql)
        {
            conncet();
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            disconnect();
            return ds;
        }
        public DataTable GetTB(string sql)
        {
            conncet();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            disconnect();
            return dt;
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            conncet();
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();

            return dr;


        }
        public void ExeCuteNonQuery(string sql)
        {
            conncet();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            disconnect();
        }
    }
}
