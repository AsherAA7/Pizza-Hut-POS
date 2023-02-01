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
    public partial class Add_Drink : Form
    {
        private int e;
        private int r;
        public Add_Drink()
        {
            InitializeComponent();
            xGrid.Columns.Add("A", "PID");
            xGrid.Columns.Add("B", "Drink Name");
            xGrid.Columns.Add("C", "Price");
            getDrinks();
            rowcn();

        }


        private void getDrinks()
        {
            xGrid.Rows.Clear();
            string[] Arr;
            StreamReader abc =  new StreamReader("Add-drink.txt");
            while (!abc.EndOfStream)
            {
                Arr = abc.ReadLine().Split('#');
                xGrid.Rows.Add(Arr[0], Arr[1], Arr[2]);
            }
            abc.Close();
            abc.Dispose();
        }

        private void Add_Drink_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter abc = new StreamWriter("Add-drink.txt", true);
            abc.WriteLine(r + "#" + txtName.Text + "#" + txtPrice.Text);
            abc.Close();
            abc.Dispose();
            txtName.Text = txtPrice.Text = null;
            rowcn();
            getDrinks();
        }

        private void rowcn()
        {
            e = xGrid.Rows.Count;
            r = e;
        }

     private void txtPrice_TextChanged(object sender, EventArgs e)
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
         StreamWriter xyz = new StreamWriter("Add-drink.txt", false);
         string I, P, C;
         for (int i = 0; i < xGrid.Rows.Count - 1; i++)
         {
             I = xGrid.Rows[i].Cells[0].Value.ToString();
             P = xGrid.Rows[i].Cells[1].Value.ToString();
             C = xGrid.Rows[i].Cells[2].Value.ToString();
             xyz.WriteLine(I + "#" + P + "#" + C);
         }
         xyz.Flush();
         xyz.Close();
     }

     private void saladgrp_Enter(object sender, EventArgs e)
     {

     }
       
    }


       
    }
