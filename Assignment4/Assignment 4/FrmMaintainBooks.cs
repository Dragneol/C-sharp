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
    public partial class FrmMaintainBooks : Form
    {
        private Employee loggedEmployee;

        public FrmMaintainBooks(Employee emp)
        {
            this.loggedEmployee = emp;
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookStoreDataSet);

        }

        private void FrmMaintainBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.bookStoreDataSet.Books);
            calculatingTotalPrice();
        }

        private void calculatingTotalPrice()
        {
            float sum = 0;
            foreach (DataGridViewRow row in booksDataGridView.Rows)
            {
                float t = 0;
                float.TryParse(row.Cells[2].Value + "", out t);
                sum += t;
            }
            totalPrice.Text = "Total price: " + sum + "";
        }

        private void filterNameTxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = ((BindingSource)booksDataGridView.DataSource);
            bs.Filter = $"BookName LIKE '%{filterNameTxt.Text}%'";
            calculatingTotalPrice();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            new FrmBookReport((BindingSource)booksDataGridView.DataSource).ShowDialog();
        }
    }
}
