using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace Employee.DataAcess
{
    public static class UtilityDB
    {
        //We dont need to create an object to access the class - We can directly access with the name of the class
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDb = new SqlConnection("data source= (local)\\SQLSERVER ; database=sample; Integrated Security=SSPI");
            connDb.Open();
            return connDb;
        }
    }
}
