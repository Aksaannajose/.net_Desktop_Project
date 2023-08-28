using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Employee
{
    internal class cntnclass
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adp;
        String sql;


        public SqlConnection connect()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sony\\source\\repos\\Employee\\Employee\\Database1.mdf;Integrated Security=True");
            con.Open();
            return con;

        }
        public void insupdel(string sql)
        {
            cmd = new SqlCommand(sql, connect());
            cmd.ExecuteNonQuery();

        }
        public SqlDataReader Getdata(string sql)
        {
            cmd = new SqlCommand(sql, connect());
            rdr = cmd.ExecuteReader();
            return rdr;

        }
        public DataSet Grid(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, connect());
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;

        }
    }
}
