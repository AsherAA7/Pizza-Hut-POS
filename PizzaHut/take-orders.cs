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
    public partial class take_orders : Form
    {
        private int e;
        private int r;
        private string[] Arr;
        public take_orders()
        {
            InitializeComponent();
            xGrid.Columns.Add("A", "CID");
            xGrid.Columns.Add("B", "Customer Name");
            xGrid.Columns.Add("C", "Phone");
            xGrid.Columns.Add("D", "Pizza");
            xGrid.Columns.Add("E", "Pizza Price");
            xGrid.Columns.Add("F", "Salad");
            xGrid.Columns.Add("G", "Salad Price");
            xGrid.Columns.Add("H", "Drink");
            xGrid.Columns.Add("I", "Drink Price");
            xGrid.Columns.Add("J", "Total Price");
            Items();
            Salad();
            Drinks();
            rowcn();
            getOrders();
        }


        private void getOrders()
        {
            xGrid.Rows.Clear();
            string[] Arr;
            StreamReader abc = new StreamReader("Customer-Order.txt");
            while (!abc.EndOfStream)
            {
                Arr = abc.ReadLine().Split('#');
                xGrid.Rows.Add(Arr[0], Arr[1], Arr[2],Arr[3], Arr[4], Arr[5], Arr[6], Arr[7],Arr[8],Arr[9]);
            }
            abc.Close();
            abc.Dispose();
        }

        private void Items()
        {
            cmbPizza.Items.Clear();
            StreamReader abc = new StreamReader("Add-Pizza.txt");
            while (!abc.EndOfStream)
            {
                cmbPizza.Items.Add(abc.ReadLine());
            }
            abc.Close();
        }


        private void Salad()
        {
            cmbSalad.Items.Clear();
            StreamReader abc = new StreamReader("Add-Salad.txt");
            while (!abc.EndOfStream)
            {
                cmbSalad.Items.Add(abc.ReadLine());
            }
            abc.Close();
        }

        private void Drinks()
        {
            cmbDrink.Items.Clear();
            StreamReader abc = new StreamReader("Add-drink.txt");
            while (!abc.EndOfStream)
            {
                cmbDrink.Items.Add(abc.ReadLine());
            }
            abc.Close();
        }


        private void bnPizza_Click(object sender, EventArgs e)
        {
            cmbPizza.Items.Clear();
            StreamReader abc = new StreamReader("Add-Pizza.txt");
            while (!abc.EndOfStream)
            {
                cmbPizza.Items.Add(abc.ReadLine());
            }
            abc.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            cmbSalad.Items.Clear();
            StreamReader abc = new StreamReader("Add-Salad.txt");
            while (!abc.EndOfStream)
            {
                cmbSalad.Items.Add(abc.ReadLine());
            }
            abc.Close();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            cmbDrink.Items.Clear();
            StreamReader abc = new StreamReader("Add-drink.txt");
            while (!abc.EndOfStream)
            {
                cmbDrink.Items.Add(abc.ReadLine());
            }
            abc.Close();
        }

        private void cmbPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arr = cmbPizza.Text.Split('#');
            txtpizzzaname.Text = Arr[1];
            txtPizzaPrice.Text = Arr[2];
        }

        private void cmbSalad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arr =cmbSalad.Text.Split('#');
            txtsaladname.Text= Arr[1];
            txtSaladPrice.Text= Arr[2];
        }

        private void cmbDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arr= cmbDrink.Text.Split('#');
            txtDrinkname.Text = Arr[1];
            txtDrinkPrice.Text = Arr[2];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter abc = new StreamWriter("Customer-Order.txt",true);
            abc.WriteLine(r +"#"+ txtCusname.Text + "#" + txtPhone.Text + "#" + txtpizzzaname.Text + "#" + txtPizzaPrice.Text + "#" + txtsaladname.Text
            + "#" + txtSaladPrice.Text + "#" + txtDrinkname.Text + "#" + txtDrinkPrice.Text + "#" + lblTotal.Text
                );
            abc.Close();
            abc.Dispose();
            txtCusname.Text =txtPhone.Text= txtCusname.Text = txtpizzzaname.Text = txtPizzaPrice.Text = txtsaladname.Text = txtSaladPrice.Text =
            txtDrinkname.Text = txtDrinkPrice.Text = null;
            rowcn();
            getOrders();
        }

        private void take_orders_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int a, b, c,d;
            a = int.Parse(txtSaladPrice.Text);
            b = int.Parse(txtPizzaPrice.Text);
            c = int.Parse(txtDrinkPrice.Text);
            d = a + b + c;
            lblTotal.Text= (d.ToString());

        }

        private void rowcn()
        {
            e = xGrid.Rows.Count;
            r = e;
        }

        private void xGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string A = xGrid.CurrentRow.Cells[0].Value.ToString();
            int I = xGrid.CurrentRow.Index;
            DialogResult DR = MessageBox.Show("Are you sure to delete\n" + A + " ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                xGrid.Rows.RemoveAt(I);
                Grid2File();
            }
        }

        private void Grid2File()
        {
            StreamWriter xyz = new StreamWriter("Customer-Order.txt", false);
            string A, B, C, D, E, F, G, H, I, J;
            for (int i = 0; i < xGrid.Rows.Count - 1; i++)
            {
                A = xGrid.Rows[i].Cells[0].Value.ToString();
                B = xGrid.Rows[i].Cells[1].Value.ToString();
                C = xGrid.Rows[i].Cells[2].Value.ToString();
                D = xGrid.Rows[i].Cells[3].Value.ToString();
                E = xGrid.Rows[i].Cells[4].Value.ToString();
                F = xGrid.Rows[i].Cells[5].Value.ToString();
                G = xGrid.Rows[i].Cells[6].Value.ToString();
                H = xGrid.Rows[i].Cells[7].Value.ToString();
                I = xGrid.Rows[i].Cells[8].Value.ToString();
                J = xGrid.Rows[i].Cells[9].Value.ToString();
                xyz.WriteLine(A + "#" + B + "#" + C + "#" + D + "#" + E + "#" + F + "#" + G + "#" + H + "#" + I + "#" + J );
            }
            xyz.Flush();
            xyz.Close();
        }

        
       
    }
}
