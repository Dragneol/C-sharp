using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckDate;
namespace SWQ391
{
    public partial class Form1 : Form
    {
        #region Static Number
        private static int MIN_DAY = 1;
        private static int MAX_DAY = 31;
        private static int MIN_MONTH = 1;
        private static int MAX_MONTH = 12;
        private static int MIN_YEAR = 1000;
        private static int MAX_YEAR = 3000;
        #endregion
        CheckDateMethod valid = new CheckDateMethod();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rel = MessageBox.Show("Are you want to exit", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (rel == System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            #region Get Data Input
            int day, month, year;
            int.TryParse(txtDay.Text, out day);
            int.TryParse(txtMonth.Text, out month);
            int.TryParse(txtYear.Text, out year);
            #endregion
            #region Vadlid Data
            string mess = "";
            if (day < MIN_DAY || day > MAX_DAY)
                mess += string.Format($"Day must be in {MIN_DAY}-{MAX_DAY}\n");
            if (month < MIN_MONTH || month > MAX_MONTH)
                mess += string.Format($"Month must be in {MIN_MONTH}-{MAX_MONTH}\n");
            if (year < MIN_YEAR || year > MAX_YEAR)
                mess += string.Format($"Year must be in {MIN_YEAR}-{MAX_YEAR}\n");
            if (!mess.Equals(""))
            {
                MessageBox.Show(mess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mess = valid.IsValidDate(year, month, day) ? $"{day}/{month}/{year} is Valid" : $"{day}/{month}/{year} is InValid";
                MessageBox.Show(mess);
            }
            #endregion
        }
    }
}
