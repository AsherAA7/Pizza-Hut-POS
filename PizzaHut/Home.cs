using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaHut
{
    public partial class Home : Form
    {
        public Home(string Level)
        {
            InitializeComponent();
            if (Level.Equals("Admin"))
            {
                addcoldmnu.Enabled = true;
                addcoldmnu.Enabled = true;
                addpizzamnu.Enabled = true;
                takeOredermnu.Enabled = true;
                addusermnu.Enabled = true;
            }
            else
            {
               
                //addcoldmnu.Enabled = false;
                addcoldmnu.Enabled = false;
                addpizzamnu.Enabled = false;
                addusermnu.Enabled = false;
            }
        }

        private void adddsaladmnu_Click(object sender, EventArgs e)
        {
            new Add_Salad().Show();
        }

        private void addcoldmnu_Click(object sender, EventArgs e)
        {
            new Add_Drink().Show();
        }

        private void addpizzamnu_Click(object sender, EventArgs e)
        {
            new Add_Pizza().Show();
        }

        private void takeOredermnu_Click(object sender, EventArgs e)
        {
            new take_orders().Show();
        }

        private void viewOrdermnu_Click(object sender, EventArgs e)
        {
            new ViewOrders().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Add_user().Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

       
    }
}
