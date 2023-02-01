using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PizzaHut
{
    public partial class Siginup : Form
    {
        public Siginup()
        {
            InitializeComponent();
        }

        private void Security_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StreamReader abc = new StreamReader("Users//" + txtEmail.Text + ".txt");
            string Pass = abc.ReadLine();
            string Level = abc.ReadLine();
            abc.Close();
            if (txtPass.Text.Equals(Pass))
            {
                new Home(Level).Show();
            }
            else
            {
                txtEmail.Text = "Try again...";
                txtPass.Text = null;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        }


    }
