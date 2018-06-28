using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProductStore
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
    class ProductData
    {
        private string strConnection;
        public ProductData()
        {

        }
        private string getConnection() => ConfigurationManager.ConnectionStrings["SaleDB"].ConnectionString;

        public DataTable GetProducts()
        {
            SqlConnection con = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand("select * from Products", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(table);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                con.Close();
            }
            return table;
        }

        public bool AddProduct(Product product)
        {
            bool added;
            SqlConnection con = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand("insert Products values (@ID, @Name, @Price, @Quantity)", con);
            cmd.Parameters.AddWithValue("@ID", product.ProductID);
            cmd.Parameters.AddWithValue("@Name", product.ProductName);
            cmd.Parameters.AddWithValue("@Price", product.UnitPrice);
            cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                added = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException se)
            {
                if (se.Message.Contains("duplicate"))
                {
                    throw new Exception("ID already exited");
                }
                throw new Exception(se.Message);
            }
            finally
            {
                con.Close();
            }
            return added;
        }

        public bool UpdateProduct(Product p)
        {
            bool updated;
            SqlConnection con = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand("update Products set " +
                "ProductName = @name, " +
                "UnitPrice=@price, " +
                "Quantity=@quantity " +
                "where ProductID=@id", con);
            cmd.Parameters.AddWithValue("@name", p.ProductName);
            cmd.Parameters.AddWithValue("@price", p.UnitPrice);
            cmd.Parameters.AddWithValue("@quantity", p.Quantity);
            cmd.Parameters.AddWithValue("@id", p.ProductID);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                updated = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                con.Close();
            }
            return updated;
        }

        public bool DeleteProduct(int Id)
        {
            bool deleted;
            SqlConnection con = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand("Delete Products where ProductID = @id", con);
            cmd.Parameters.AddWithValue("@id", Id);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                deleted = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                con.Close();
            }
            return deleted;
        }
    }
}
