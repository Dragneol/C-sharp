using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Employee
    {
        public string EmpID { get; set; }
        public string EmpPassword { get; set; }
        public bool EmpRole { get; set; }

        public string ConnectionString { get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;
            }
        }

        public Employee()
        {

        }

        public Employee(string empID, string empPassword, bool empRole)
        {
            EmpID = empID;
            EmpPassword = empPassword;
            EmpRole = empRole;
        }

        public bool changePassword(string newpassword)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("UPDATE Employee SET EmpPassword = @password WHERE EmpID = @id", con);
            cmd.Parameters.AddWithValue("@password", newpassword);
            cmd.Parameters.AddWithValue("@id", this.EmpID);
            bool res = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return res;
        }
    }
}
