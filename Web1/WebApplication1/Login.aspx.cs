using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string us = txtUsername.Text, pwd = txtPassword.Text;
            if (us.Equals("admin") && pwd.Equals("123"))
            {
                Response.Redirect("ViewBook.aspx?data=" + us);
            }
        }
    }
}