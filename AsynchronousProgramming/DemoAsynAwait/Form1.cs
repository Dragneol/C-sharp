using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAsynAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async Task<int> Add(int a, int b)
        {
            await Task.Delay(5000);
            int c = a + b;
            //txtResult.Text = c.ToString();
            return c;
        }       
        private  async void btnTest_Click(object sender, EventArgs e)
        {
            int x;
            //Asynchronous
            //Add(2, 3);
            //x = await Add(3, 4);
            //Synchronous 
            //x = Add(2, 3).Result;
            txtResult.Text = x.ToString();
            MessageBox.Show("Asynchronous","Completed.");
        }
    }
}
