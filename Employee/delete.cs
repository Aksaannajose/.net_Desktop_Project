using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class delete : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adp;
        String sql;

        cntnclass obj = new cntnclass();



        public delete()
        {
            InitializeComponent();
        }


        private void display()
        {
            comboBox1.Items.Clear();
            sql = "select Username from Registration";
            rdr = obj.Getdata(sql);

            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr.GetString(0));


            }
            rdr.Close();


        }

        private void delete_Load(object sender, EventArgs e)
        {
            display();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedItem.ToString()!=null)
                {
                    sql = "delete from Registration where Username='" + comboBox1.SelectedItem.ToString() + "'";
                    obj.insupdel(sql);

                    sql = "delete from Login where Username='" + comboBox1.SelectedItem.ToString() + "'";
                    obj.insupdel(sql);

                    MessageBox.Show("Deleted");



                }
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }

}
