using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace baibaocao
{
    class connect
    {
        public string strcon = "Data Source =ADMIN\\SQLEXPRESS;Database =QLSV;Integrated Security=true";
        public DataSet ds;
        public SqlCommand cmd;
        SqlDataAdapter sda;
        SqlConnection conn;

        public DataSet truyvan(string sql)
        {
            conn = new SqlConnection(strcon);
            conn.Open();

            cmd = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            return ds;

        }
        public bool capnhatdb(string sql)
        {
            bool ck = false;
            conn = new SqlConnection(strcon);
            conn.Open();

            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                ck = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("lỗi");
            }

            conn.Close();
            return ck;
        }
    }
}
