using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillB_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("Concert Ticket");
            wishList.Items.Add("Bag");
            wishList.Items.Add("Shoes");
            wishList.Items.Add("Plane Ticket to Japan");
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sortB_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void countB_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(wishList.Items.Count);
        }

        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = wishList.Text;
        }
    }
}
