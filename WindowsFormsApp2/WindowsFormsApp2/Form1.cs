using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            string data = "";
            data += string.Format($"Multi {mul.Text}\n");
            data += string.Format($"Pass {pass.Text}\n");
            data += string.Format($"Up {upper.Text}\n");
            data += string.Format($"Mask {mask.Text}\n");

            MessageBox.Show(data, "Data");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show($"{radioButton1}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<dynamic> dynamics = new List<dynamic>
            {
                new { ID=1, Name="caphe"},
                new { ID=2, Name="coco"},
                new { ID=3, Name="cacao"},
                new { ID=4, Name="coffe"},
            };
            cboItems.DisplayMember = "Name";
            cboItems.ValueMember = "ID";
            cboItems.DataSource = dynamics;

            dataGridView1.DataSource = dynamics;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            
        }
    }
}
