using Lab1.Models;
using System;
using System.Web.UI.WebControls;
namespace Lab1
{
    public partial class MaintainUser : System.Web.UI.Page
    {
        UserInfoData data = new UserInfoData();

        private void LoadData()
        {
            grUserInfoList.DataSource = data.GetUserList();
            grUserInfoList.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                LoadData();
            }
        }

        protected void grUserInfoList_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow selectedRow = grUserInfoList.Rows[e.NewSelectedIndex];
            txtAddress.Text = selectedRow.Cells[4].Text;
            txtDOB.Text = selectedRow.Cells[3].Text;
            txtEmail.Text = selectedRow.Cells[5].Text;
            txtPassword.Text = selectedRow.Cells[2].Text;
            txtUsername.Text = selectedRow.Cells[1].Text;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dob;
            DateTime.TryParse(txtDOB.Text, out dob);
            dynamic u = new UserInfo {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Address = txtAddress.Text,
                BirthDate = dob,
                Email = txtEmail.Text,
            };
            data.InsertUserInfo(u);
            LoadData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime dob;
            DateTime.TryParse(txtDOB.Text, out dob);
            dynamic u = new UserInfo
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Address = txtAddress.Text,
                BirthDate = dob,
                Email = txtEmail.Text,
            };
            data.UpdateUserInfo(u);
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dynamic u = new UserInfo
            {
                Username = txtUsername.Text
            };
            data.DeleteUserInfo(u);
            LoadData();
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}