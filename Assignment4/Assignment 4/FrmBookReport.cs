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
    public partial class FrmBookReport : Form
    {
        public FrmBookReport(BindingSource bs)
        {
            InitializeComponent();
            this.booksGrid.DataSource = bs;
            bs.Sort = "BookPrice desc";
        }
    }
}
