using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        ProductDB db = new ProductDB();
        int id, quantity;
        string name;
        decimal price;
        Product product;
        private void loadList()
        {
            dataGridView1.DataSource = db.GetProductList();
        }
        private void fromTxt()
        {
            int.TryParse(txtID.Text, out id);
            int.TryParse(txtQuantity.Text, out quantity);
            name = txtName.Text;
            decimal.TryParse(txtPrice.Text, out price);
            product = new Product { ID = id, Name = name, Price = price, Quantity = quantity };
        }
        private void resetTxt()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }
        private void toTxt()
        {
            if (product == null)
            {
                MessageBox.Show("Not Found");
                return;
            }
            txtID.Text = product.ID + "";
            txtName.Text = product.Name + "";
            txtPrice.Text = product.Price + "";
            txtQuantity.Text = product.Quantity + "";
        }
        public Form1()
        {
            InitializeComponent();
            loadList();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetTxt();
            product = (Product)dataGridView1.CurrentRow.DataBoundItem;
            toTxt();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            fromTxt();
            if (validData())
            {
                bool updated = db.UpdateProduct(product);
                MessageBox.Show("Updated");
                loadList();
            }
            else
            {
                MessageBox.Show("Invalid Data Input");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            resetTxt();
            product = (Product)dataGridView1.CurrentRow.DataBoundItem;
            toTxt();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            fromTxt();
            if (validData())
            {
                try
                {
                    bool added = db.AddNewProduct(product);
                    if (added)
                    {
                        MessageBox.Show("Added");
                        resetTxt();
                        loadList();
                    }
                } catch (Exception)
                {
                    MessageBox.Show("ID already existed");
                }
            }
            else
            {
                MessageBox.Show("Invalid Data Input");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            fromTxt();
            resetTxt();
            if (id <= 0)
            {
                MessageBox.Show("Invalid Data Input");
                return;
            }
            product = db.FindProduct(id);
            toTxt();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            fromTxt();
            if (validData())
            {
                try
                {
                    bool added = db.RemoveProduct(product);
                    if (added)
                    {
                        MessageBox.Show("Deleted");
                        resetTxt();
                        loadList();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Internal Errors");
                }
            }
            else
            {
                MessageBox.Show("Invalid Data Input");
            }
        }

        private bool validData() => (id > 0 && quantity > 0 && name.Length > 0 && price > 0);
    }
}
