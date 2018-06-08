using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        BookData bm = new BookData();
        DataTable dtBook;
        public Form1()
        {
            InitializeComponent();
        }

        private void BookID_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            getAllBooks();
        }
        private void getAllBooks()
        {
            dtBook = bm.getBooks();
            txtBookID.DataBindings.Clear();
            txtBookPrice.DataBindings.Clear();
            txtBookQuantity.DataBindings.Clear();
            txtBookTitle.DataBindings.Clear();

            txtBookID.DataBindings.Add("Text", dtBook, "BookID");
            txtBookPrice.DataBindings.Add("Text", dtBook, "BookPrice");
            txtBookTitle.DataBindings.Add("Text", dtBook, "BookTitle");
            txtBookQuantity.DataBindings.Add("Text", dtBook, "BookQuantity");
            dgvBookList.DataSource = dtBook;
            lblTotalQuantity.Text = string.Format($"TotalQuantity {dtBook.Compute("SUM(BookQuantity)", string.Empty)}");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID, Quantity;
            int.TryParse(txtBookID.Text, out ID);
            string Title = txtBookTitle.Text;
            float Price;
            float.TryParse(txtBookPrice.Text, out Price);
            int.TryParse(txtBookQuantity.Text, out Quantity);
            Books book = new Books
            {
                ID = ID,
                Price = Price,
                Title = Title,
                Quantity = Quantity,
            };

            bool r = bm.AddNewBook(book);
            string s = (r == true ? "Successfull" : "fail");
            MessageBox.Show(s);
            getAllBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID, Quantity;
            int.TryParse(txtBookID.Text, out ID);
            string Title = txtBookTitle.Text;
            float Price;
            float.TryParse(txtBookPrice.Text, out Price);
            int.TryParse(txtBookQuantity.Text, out Quantity);
            Books book = new Books
            {
                ID = ID,
                Price = Price,
                Title = Title,
                Quantity = Quantity,
            };

            bool r = bm.updateBook(book);
            string s = (r == true ? "Successfull" : "fail");
            MessageBox.Show(s);
            getAllBooks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(txtBookID.Text, out ID);
            bool r = bm.deleteBook(ID);
            string s = (r == true ? "Successfull" : "fail");
            MessageBox.Show(s);
            getAllBooks();
        }

        private void txtTitleFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtBook.DefaultView;
            string filter = string.Format($"BookTitle like '%{txtTitleFilter.Text}%'");
            dv.RowFilter = filter;
            lblTotalQuantity.Text = string.Format($"TotalQuantity {dtBook.Compute("SUM(BookQuantity)", string.Empty)}");
        }
    }        
}
