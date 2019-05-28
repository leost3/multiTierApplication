using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Employee.DataAcess;

namespace Employee.Business
{
    public class EmployeeLayer
    {
        private int employeeId;
        public int EmployeeId { get => employeeId; set => employeeId = value; } //Shortcut : prop
        private string firstName;
        public string FirstName { get => firstName; set => firstName=value; }
        private string lastName;
        public string LastName{ get => lastName; set => lastName = value; }
        private string jobTitle;
        public string JobTitle { get => jobTitle; set => jobTitle=value; }

        public DataTable ReadEmployee()
        {
           return EmployeeDB.ReadEmployee();
        }

        public void saveRecord(EmployeeLayer emp)
        {
            EmployeeDB.SaveRecord(emp);
        }
    }
}
