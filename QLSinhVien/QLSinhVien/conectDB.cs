using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;
namespace QLSinhVienDB
{
    
    class conectDB
    {

        public string Stringconnect = "";
        static SqlConnection cnn;
        static SqlDataAdapter da;
        static DataSet ds;
        static SqlCommand cmd;
        static string source;
        public static void openConnection()
        {
            //string connect = SystemInformation.UserDomainName.ToString();
            //source = "Data Source=" + connect + "\\SQLEXPRESS;Initial Catalog=QuanLyDiem;Integrated Security=True";
            source = @"Data Source=LAPTOP-GGCF1S0L\;Initial Catalog=QLSinhVien;Integrated Security=True";
            cnn = new SqlConnection(source);
            try
            {
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không thể kết nối đến cơ sở dữ liệu!!");
                return;
            }
        }
        public static void executeQuery(String sql)
        {
            cmd = new SqlCommand();
            //openConnection();
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cnn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex.Message);
                return;
            }

        }

        public static DataSet getDataSet(String sql)
        {

            openConnection();
            da = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            da.Fill(ds);
            cnn.Close();
            return ds;
        }

        public static DataTable getDataTable(String sql)
        {
            openConnection();
            da = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            da.Fill(ds);
            cnn.Close();
            return ds.Tables[0];
        }




    }
}
