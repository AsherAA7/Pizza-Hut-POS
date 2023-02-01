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
    public partial class Add_user : Form
    {
        public Add_user()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StreamWriter abc = new StreamWriter("Users//" + txtEmail.Text + ".txt");
            abc.WriteLine(txtPass.Text);
            abc.WriteLine(cmbType.Text);
            abc.Close();
            txtPass.Text = null;
            txtEmail.Text = "User created...";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
