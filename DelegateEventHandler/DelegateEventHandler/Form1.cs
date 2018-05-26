using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateEventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnFirst.Click += Button_Click;
            btnSecond.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Text)
            {
                case "1":
                    MessageBox.Show("First");
                    break;
                case "2":
                    MessageBox.Show("Second");
                    break;
            }
        }
    }
}
