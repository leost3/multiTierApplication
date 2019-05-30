using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1Ado.Business;

namespace Lab1Ado.Gui
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            dataGridView1.DataSource = emp.ReadEmployee();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text=="" || txtFname.Text=="" || txtLname.Text=="" || txtJobTitle.Text=="")
            {
                MessageBox.Show("Can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //create object
                Employee emp = new Employee();
                //fill the object with textbox input
                emp.EmployeeId = Convert.ToInt16(txtEmployeeId.Text);
                emp.FirstName = txtFname.Text;
                emp.LastName = txtLname.Text;
                emp.JobTitle = txtJobTitle.Text;
                //call function to save employee in database
                if ( emp.SaveEmployee(emp) )
                {
                    MessageBox.Show("Employees saved correctly");
                } else
                {
                    MessageBox.Show("Employees can not save");
                    txtEmployeeId.Text = "";
                    txtFname.Text = "";
                    txtJobTitle.Text = "";
                    txtLname.Text = "";

                }
            }
            

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            dataGridView1.DataSource = emp.ReadEmployee();
            txtEmployeeId.Text = "";
            txtFname.Text = "";
            txtJobTitle.Text = "";
            txtLname.Text = "";


        }
    }
}
