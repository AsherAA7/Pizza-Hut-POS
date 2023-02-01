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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
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
            getOrders();
        }


        private void getOrders()
        {
            xGrid.Rows.Clear();
            string [] Arr;
            StreamReader abc = new StreamReader("Customer-Order.txt");
            while(!abc.EndOfStream)
            {
                Arr = abc.ReadLine().Split('#');
                xGrid.Rows.Add(Arr[0], Arr[1], Arr[2], Arr[4], Arr[5], Arr[6], Arr[7]);
            }
            abc.Close();
            abc.Dispose();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {

        }

        private void xGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
