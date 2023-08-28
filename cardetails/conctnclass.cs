using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cardetails
{
    internal class conctnclass
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;
        String sql;

        public SqlConnection connect()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sony\\source\\repos\\cardetails\\cardetails\\Database1.mdf;Integrated Security=True");
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

        public DataSet Grid(String sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, connect());
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;

        }
    }

}
