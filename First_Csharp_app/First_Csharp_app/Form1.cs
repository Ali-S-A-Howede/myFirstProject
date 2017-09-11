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

namespace First_Csharp_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "Data Source=TESTSERVER\\sqlexpress;Initial Catalog=windowapp;Integrated Security=True";
                String query = "select * from data";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("connect with sql server");
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }
        }
    }
}
