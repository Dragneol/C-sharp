using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BookStore
{
    class BookData
    {
        string strConnection;
        public BookData()
        {
            strConnection = getConnectionString();
        }
        //public string getConnectionString() => strConnection = "server=.;database=Manager;uid=sa;pwd=123";

        public string getConnectionString() => ConfigurationManager.ConnectionStrings["ManagerDB"].ConnectionString;

        public DataTable getBooks()
        {
            string Sql = "select * from Books";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(Sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtBook = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtBook);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtBook;
        }

        public bool AddNewBook(Books book)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string Sql = "Insert Books values(@ID, @Title,@Quantity,@Price)";
            SqlCommand cmd = new SqlCommand(Sql, cnn);
            cmd.Parameters.AddWithValue("@ID", book.ID);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Quantity", book.Quantity);
            cmd.Parameters.AddWithValue("@Price", book.Price);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return count > 0;
        }

        public bool updateBook(Books book)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string Sql = "Update Books set " +
                "BookTitle=@Title," +
                "BookQuantity=@Quantity," +
                "BookPrice=@Price" +
                " where BookID=@ID";
            SqlCommand cmd = new SqlCommand(Sql, cnn);
            cmd.Parameters.AddWithValue("@ID", book.ID);
            cmd.Parameters.AddWithValue("@Price", book.Price);
            cmd.Parameters.AddWithValue("@Quantity", book.Quantity);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return count > 0;
        }

        public bool deleteBook(int BookID)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string sql = "Delete Books where BookID=@ID";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", BookID);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return count > 0;
        }
    }
}
