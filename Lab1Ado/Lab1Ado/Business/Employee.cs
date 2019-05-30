using Lab1Ado.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ado.Business
{
   public class Employee
    {
        private int employeeId;
        public int EmployeeId { get=>employeeId; set=>employeeId=value; }
        private string firstName;
        public string FirstName { get=>firstName; set=>firstName=value; }
        private string lastName;
        public string LastName { get=>lastName; set=>lastName=value; }
        private string jobTitle;
        public string  JobTitle { get=>jobTitle; set=>jobTitle=value; }
        public DataTable ReadEmployee()
        {
          return  EmployeeDB.ReadEmployee();
        }
        public bool SaveEmployee(Employee emp)
        {
           return EmployeeDB.SaveRecord(emp);
        }
    }
}
