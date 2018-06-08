using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace GetData_Multi_Table
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        DataSet dsBookStore = new DataSet();
        public DataSet GetAllData()
        {
            string strConnection =
                //"server=.;database=manager;uid=sa;pwd=123";
                ConfigurationManager.ConnectionStrings["ManagerDB"].ConnectionString;
            string SQL = "select * from Books;select * from Publishers";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dsBookStore = new DataSet();
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            da.Fill(dsBookStore);
            cnn.Close();
            return dsBookStore;
        }
     
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsBookStore = GetAllData();
        }
        private void btnGetBooks_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(sender,e);
            DataTable dtBooks = dsBookStore.Tables[0];
            dgvViewData.DataSource = dtBooks;
        }
        private void btnGetPublisher_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(sender,e);
            DataTable dtPublishers = dsBookStore.Tables[1];
            dgvViewData.DataSource = dtPublishers;
        }
    }
}
