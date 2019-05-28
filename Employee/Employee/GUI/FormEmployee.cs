using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Employee.Business;
using System.Data.SqlClient;


namespace Employee.GUI
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            // Read DB
            EmployeeLayer emp = new EmployeeLayer();
            dataGridView1.DataSource = emp.ReadEmployee();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxEmpId.Text == "" || textBoxFn.Text == "" || textBoxLn.Text == "" || textBoxJT.Text == "")
            {
                MessageBox.Show("Can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // create object
                EmployeeLayer emp = new EmployeeLayer();
                // fill the object with text input
                emp.EmployeeId = Convert.ToInt32(textBoxEmpId.Text);
                emp.FirstName = textBoxFn.Text;
                emp.LastName = textBoxLn.Text;
                emp.JobTitle = textBoxLn.Text;
                // call function to save employee in database 
                emp.saveRecord(emp);
            }
          

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Read again
            EmployeeLayer emp = new EmployeeLayer();
            dataGridView1.DataSource = emp.ReadEmployee();
            textBoxEmpId.Text = "";
            textBoxFn.Text = "";
            textBoxLn.Text = "";
            textBoxLn.Text = "";
        }
       
    }
}
 