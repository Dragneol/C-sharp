using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class FrmChangeAccount : Form
    {
        private Employee loggedEmployee;

        public FrmChangeAccount(Employee employee)
        {
            this.loggedEmployee = employee;
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookStoreDataSet);

        }

        private void loadInfo()
        {
            empIDTextBox.Text = loggedEmployee.EmpID;
            empPasswordTextBox.Text = loggedEmployee.EmpPassword;
            empRoleCheckBox.Checked = loggedEmployee.EmpRole;
        }

        private void FrmChangeAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bookStoreDataSet.Employee);
            loadInfo();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (this.loggedEmployee.changePassword(empPasswordTextBox.Text))
            {
                MessageBox.Show("Password successfully updated!");
            } else
            {
                MessageBox.Show("Error while changing password!");
            }
        }
    }
}
