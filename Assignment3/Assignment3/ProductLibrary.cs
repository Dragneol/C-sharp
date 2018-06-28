using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Assignment3
{
    /// <summary>
    /// class Book
    /// </summary>
    class Product
    {
        private int BookID;

        public int ID
        {
            get { return BookID; }
            set { BookID = value; }
        }
        private int BookQuantity;

        public int Quantity
        {
            get { return BookQuantity; }
            set { BookQuantity = value; }
        }

        private decimal UnitPrice;

        public decimal Price
        {
            get { return UnitPrice; }
            set { UnitPrice = value; }
        }

        private string BookName;

        public string Name
        {
            get { return BookName; }
            set { BookName = value; }
        }

    }

    /// <summary>
    /// class BookDB
    /// </summary>
    class ProductDB
    {
        private string strConnection;
        public ProductDB()
        {
            strConnection = getConnection();
        }
        public string getConnection() => ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        public bool AddNewProduct(Product p)
        {
            if (p == null)
            {
                return false;
            }
            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Products VALUES(@id, @name, @quantity, @price)", con);
            cmd.Parameters.AddWithValue("@id", p.ID);
            cmd.Parameters.AddWithValue("@name", p.Name);
            cmd.Parameters.AddWithValue("@quantity", p.Quantity);
            cmd.Parameters.AddWithValue("@price", p.Price);
            bool res = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return res;
        }

        public bool RemoveProduct(Product p)
        {
            if (p == null)
            {
                return false;
            }
            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Products WHERE ProductID = @id", con);
            cmd.Parameters.AddWithValue("@id", p.ID);
            bool res = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return res;
        }

        public bool UpdateProduct(Product p)
        {
            if (p == null)
            {
                return false;
            }
            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName=@name, UnitPrice=@price, Quantity=@quantity WHERE ProductID=@id", con);
            cmd.Parameters.AddWithValue("@id", p.ID);
            cmd.Parameters.AddWithValue("@name", p.Name);
            cmd.Parameters.AddWithValue("@quantity", p.Quantity);
            cmd.Parameters.AddWithValue("@price", p.Price);
            bool res = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return res;
        }
        public Product FindProduct(int ProductID)
        {
            #region temp error code
            //string sql = "select * from Products where ProductID = @ID";
            //SqlConnection cnn = new SqlConnection(strConnection);
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            //cmd.Parameters.AddWithValue("@ID", ProductID);
            //cnn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    //string name = (string)reader["ProductName"];
            //    //int price = (int)reader["UnitPrice"];
            //    //int quantity = (int)reader["Quantity"];
            //    string name = reader.GetString(1);
            //    decimal price = reader.GetDecimal(2);
            //    int quantity = reader.GetInt32(3);
            //    return new Product { ID = ProductID, Name = name, Price = price, Quantity = quantity };
            //}
            //else return null;
            #endregion

            #region temp worked code
            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE ProductID=@id", con);
            cmd.Parameters.AddWithValue("@id", ProductID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string name = dr.GetString(1);
                    decimal price = dr.GetDecimal(2);
                    int quantity = dr.GetInt32(3);
                    return new Product { ID = ProductID, Name = name, Price = price, Quantity = quantity };
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            #endregion
        }
        public List<Product> GetProductList()
        {
            List<Product> list = new List<Product>();
            string sql = "select * from Products";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int ID = (int)reader["ProductID"];
                    string name = (string)reader["ProductName"];
                    decimal price = (decimal)reader["UnitPrice"];
                    int quantity = (int)reader["Quantity"];
                    list.Add(new Product { ID = ID, Name = name, Price = price, Quantity = quantity });
                }
            }
            cnn.Close();
            return list;
        }

    }
}
