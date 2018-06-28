using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment_4.BookStoreDataSet;

namespace Assignment_4
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookStoreDataSet);

        }

        private void employeeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookStoreDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bookStoreDataSet.Employee);

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.bookStoreDataSet.Reset();
            this.employeeTableAdapter.Fill(bookStoreDataSet.Employee);
            EmployeeRow er = this.bookStoreDataSet.Employee.Where(em => em.EmpID.Trim() == empIDTextBox.Text && em.EmpPassword.Trim() == empPasswordTextBox.Text).FirstOrDefault();
            if (er == null)
            {
                MessageBox.Show("Incorrect username or password!");
            } else
            {
                Employee emp = new Employee(er.EmpID, er.EmpPassword, er.EmpRole);
                if (emp?.EmpRole == true)
                {
                    this.Hide();
                    new FrmMaintainBooks(emp).ShowDialog();
                    this.Show();
                } else
                {
                    this.Hide();
                    new FrmChangeAccount(emp).ShowDialog();
                    this.Show();
                }
            }
        }
    }
}
