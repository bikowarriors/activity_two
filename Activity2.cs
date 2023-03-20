using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selTB.Text = wishList.Text;
        }

        private void fillB_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("House");
            wishList.Items.Add("Food");
            wishList.Items.Add("Car");
            wishList.Items.Add("Phone");
            wishList.Items.Add("$1,000,000");
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sortB_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void countB_Click(object sender, EventArgs e)
        {
            countTbox.Text = Convert.ToString(wishList.Items.Count);
        }

        private void selTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void countTbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
