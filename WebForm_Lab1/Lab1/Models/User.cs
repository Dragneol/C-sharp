using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab1.Models
{
    public class UserInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
    public class UserInfoData
    {
        private static string strCon = "server=.;database=Manager;uid=sa;pwd=123";

        public void InsertUserInfo(UserInfo newUser)
        {
            SqlConnection cnn = new SqlConnection(strCon);
            String SqlINSERT = "Insert UserInfo values" +
                "(@user, @pass, @dob, @address, @email)";
            SqlCommand cmd = new SqlCommand(SqlINSERT, cnn);
            cmd.Parameters.AddWithValue("@user", newUser.Username);
            cmd.Parameters.AddWithValue("@pass", newUser.Password);
            cmd.Parameters.AddWithValue("@dob", newUser.BirthDate);
            cmd.Parameters.AddWithValue("@address", newUser.Address);
            cmd.Parameters.AddWithValue("@email", newUser.Email);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public void UpdateUserInfo(UserInfo user)
        {
            SqlConnection cnn = new SqlConnection(strCon);
            String SqlUPDATE = "Update UserInfo set " +
                "[Password]=@pass, " +
                "BirthDate = @dob, " +
                "[Address] = @address, " +
                "Email = @email " +
                "Where Username =@user";
            SqlCommand cmd = new SqlCommand(SqlUPDATE, cnn);
            cmd.Parameters.AddWithValue("@pass", user.Password);
            cmd.Parameters.AddWithValue("@dob", user.BirthDate);
            cmd.Parameters.AddWithValue("@address", user.Address);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@user", user.Username);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public void DeleteUserInfo(UserInfo u)
        {
            SqlConnection cnn = new SqlConnection(strCon);
            String sql = "Delete UserInfo where Username=@user";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@user", u.Username);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<UserInfo> GetUserList()
        {
            List<UserInfo> data = new List<UserInfo>();
            string sql = "select * from UserInfo";
            SqlConnection cnn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    dynamic u = new UserInfo()
                    {
                        Username = dataReader["Username"].ToString(),
                        Password = dataReader["Password"].ToString(),
                        BirthDate = DateTime.Parse(dataReader["BirthDate"].ToString()),
                        Address = dataReader["Address"].ToString(),
                        Email = dataReader["Email"].ToString()
                    };
                    data.Add(u);
                }
            }
            return data;
        }
    }
}