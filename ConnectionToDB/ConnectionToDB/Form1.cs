using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectionToDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //connect to local database ccreate connection with windows authentication= Integrated Security = SSPI
                // SqlConnection con = new SqlConnection("data source= . ; database=sample ; Integrated Security = SSPI");
                //Connect to database with username and password
                SqlConnection con = new SqlConnection("data source= . ; database=sample ; user=sa; password=123");

                //create command
                SqlCommand cmd = new SqlCommand("select * from student", con);
                con.Open();
                //execute command
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                rd.Close();
                // remove any resources managed from memory for clean up 
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         
            }
            

        }
    }
}
