using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string us = Request.QueryString["data"];
            Label1.Text = "Hello" + us;
            if (IsPostBack == false) // web auto load after press button will not run
            {
            DataTable dtBook = GetBook();
            GridView1.DataSource = dtBook;
            GridView1.DataBind();
            }
        }

        private DataTable GetBook()
        {
            string con = "server=.;database=Manager;uid=sa;pwd=123";
            string sql = "select * from Books";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dtBook = new DataTable();
            da.Fill(dtBook);
            return dtBook;
        }
    }
}