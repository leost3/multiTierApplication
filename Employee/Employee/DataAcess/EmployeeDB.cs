using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Employee.Business;

namespace Employee.DataAcess
{
    public static class EmployeeDB
    {
        // Open connection:

        public static SqlConnection connDB = UtilityDB.ConnectDB();
        public static SqlCommand cmd = new SqlCommand();
        
        public static DataTable ReadEmployee()
        {
            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
                cmd = new SqlCommand();
            }
            cmd.Connection = connDB;
            cmd.CommandText = "select * from employees";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            cmd.Dispose();
            connDB.Close();
            return dt;
        }

        public static void SaveRecord(EmployeeLayer emp)
        {
            // Open connection:

            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
                cmd = new SqlCommand();
            }
            cmd.Connection = connDB;
            cmd.CommandText = string.Format("insert into Employees values({0},'{1}','{2}','{3}')", emp.EmployeeId, emp.FirstName, emp.LastName, emp.JobTitle);
            cmd.ExecuteNonQuery();
            connDB.Close();
        }



    }
}
