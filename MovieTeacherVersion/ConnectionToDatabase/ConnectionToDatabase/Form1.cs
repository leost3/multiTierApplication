using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Import database:
using System.Data.SqlClient;

namespace ConnectionToDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Create a connection // windows authentication, user name or pass word
        //Create your command // select * from student
        //Open connection //
        //Execute command
        //bind or load inside a tools like grid view or textbox etc...
        //Close connection


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {// FOR WINDOWS AUTH = data source=(local)\\SQLSERVER
                // Create Connection with windows form authentication
                SqlConnection con = new SqlConnection(" data source=(local)\\SQLSERVER ; database= DEMO ; user=demo_login; password = demo_login");
                SqlCommand cmd = new SqlCommand("select * from CUSTOMER", con);
                //Open the connection
                con.Open();
                //execute command
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                rd.Close();
                //remove any resources unmanaged from emmoty for cleanup
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }
    }
}
