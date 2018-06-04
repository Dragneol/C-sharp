using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hello";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + "," + e.Y;
        }

        private void frmMain_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "World";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tslb.Text = "Open";
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            frmOpen f = new frmOpen();


            //cannot focus on other form
            #region Moduless
            //f.MdiParent = this;
            //f.Show();
            #endregion

            //can focus on other form
            #region Model
            f.ShowDialog();
            #endregion
        }
    }
}
