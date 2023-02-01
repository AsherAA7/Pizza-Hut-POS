namespace PizzaHut
{
    partial class take_orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(take_orders));
            this.saladgrp = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCusname = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSalad = new System.Windows.Forms.ComboBox();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpizzzaname = new System.Windows.Forms.TextBox();
            this.txtPizzaPrice = new System.Windows.Forms.TextBox();
            this.txtSaladPrice = new System.Windows.Forms.TextBox();
            this.txtsaladname = new System.Windows.Forms.TextBox();
            this.txtDrinkPrice = new System.Windows.Forms.TextBox();
            this.txtDrinkname = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.xGrid = new System.Windows.Forms.DataGridView();
            this.saladgrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // saladgrp
            // 
            this.saladgrp.BackColor = System.Drawing.Color.Transparent;
            this.saladgrp.Controls.Add(this.lblPrice);
            this.saladgrp.Controls.Add(this.lblName);
            this.saladgrp.Controls.Add(this.txtPhone);
            this.saladgrp.Controls.Add(this.txtCusname);
            this.saladgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saladgrp.Location = new System.Drawing.Point(12, 23);
            this.saladgrp.Name = "saladgrp";
            this.saladgrp.Size = new System.Drawing.Size(562, 184);
            this.saladgrp.TabIndex = 4;
            this.saladgrp.TabStop = false;
            this.saladgrp.Text = "Customer-Information";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrice.Location = new System.Drawing.Point(108, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 25);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Phone";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(30, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Customer Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(203, 111);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(336, 26);
            this.txtPhone.TabIndex = 1;
            // 
            // txtCusname
            // 
            this.txtCusname.Location = new System.Drawing.Point(203, 48);
            this.txtCusname.Name = "txtCusname";
            this.txtCusname.Size = new System.Drawing.Size(336, 26);
            this.txtCusname.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(948, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(807, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbPizza
            // 
            this.cmbPizza.FormattingEnabled = true;
            this.cmbPizza.Location = new System.Drawing.Point(664, 57);
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(391, 28);
            this.cmbPizza.TabIndex = 5;
            this.cmbPizza.SelectedIndexChanged += new System.EventHandler(this.cmbPizza_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pizza";
            // 
            // cmbSalad
            // 
            this.cmbSalad.FormattingEnabled = true;
            this.cmbSalad.Location = new System.Drawing.Point(664, 112);
            this.cmbSalad.Name = "cmbSalad";
            this.cmbSalad.Size = new System.Drawing.Size(391, 28);
            this.cmbSalad.TabIndex = 7;
            this.cmbSalad.SelectedIndexChanged += new System.EventHandler(this.cmbSalad_SelectedIndexChanged);
            // 
            // cmbDrink
            // 
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(664, 162);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(391, 28);
            this.cmbDrink.TabIndex = 8;
            this.cmbDrink.SelectedIndexChanged += new System.EventHandler(this.cmbDrink_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Salad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Drink";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1237, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1485, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // txtpizzzaname
            // 
            this.txtpizzzaname.Location = new System.Drawing.Point(1071, 59);
            this.txtpizzzaname.Name = "txtpizzzaname";
            this.txtpizzzaname.Size = new System.Drawing.Size(336, 26);
            this.txtpizzzaname.TabIndex = 13;
            // 
            // txtPizzaPrice
            // 
            this.txtPizzaPrice.Location = new System.Drawing.Point(1424, 59);
            this.txtPizzaPrice.Name = "txtPizzaPrice";
            this.txtPizzaPrice.Size = new System.Drawing.Size(157, 26);
            this.txtPizzaPrice.TabIndex = 14;
            // 
            // txtSaladPrice
            // 
            this.txtSaladPrice.Location = new System.Drawing.Point(1424, 116);
            this.txtSaladPrice.Name = "txtSaladPrice";
            this.txtSaladPrice.Size = new System.Drawing.Size(157, 26);
            this.txtSaladPrice.TabIndex = 16;
            // 
            // txtsaladname
            // 
            this.txtsaladname.Location = new System.Drawing.Point(1071, 116);
            this.txtsaladname.Name = "txtsaladname";
            this.txtsaladname.Size = new System.Drawing.Size(336, 26);
            this.txtsaladname.TabIndex = 15;
            // 
            // txtDrinkPrice
            // 
            this.txtDrinkPrice.Location = new System.Drawing.Point(1424, 164);
            this.txtDrinkPrice.Name = "txtDrinkPrice";
            this.txtDrinkPrice.Size = new System.Drawing.Size(157, 26);
            this.txtDrinkPrice.TabIndex = 18;
            // 
            // txtDrinkname
            // 
            this.txtDrinkname.Location = new System.Drawing.Point(1071, 164);
            this.txtDrinkname.Name = "txtDrinkname";
            this.txtDrinkname.Size = new System.Drawing.Size(336, 26);
            this.txtDrinkname.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1508, 224);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 29);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(650, 216);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 37);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // xGrid
            // 
            this.xGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xGrid.Location = new System.Drawing.Point(12, 283);
            this.xGrid.Name = "xGrid";
            this.xGrid.RowTemplate.Height = 28;
            this.xGrid.Size = new System.Drawing.Size(1569, 347);
            this.xGrid.TabIndex = 22;
            this.xGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xGrid_CellContentClick);
            this.xGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xGrid_CellDoubleClick);
            // 
            // take_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1596, 642);
            this.Controls.Add(this.xGrid);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtDrinkPrice);
            this.Controls.Add(this.txtDrinkname);
            this.Controls.Add(this.txtSaladPrice);
            this.Controls.Add(this.txtsaladname);
            this.Controls.Add(this.txtPizzaPrice);
            this.Controls.Add(this.txtpizzzaname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDrink);
            this.Controls.Add(this.cmbSalad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPizza);
            this.Controls.Add(this.saladgrp);
            this.DoubleBuffered = true;
            this.Name = "take_orders";
            this.Text = "g";
            this.Load += new System.EventHandler(this.take_orders_Load);
            this.saladgrp.ResumeLayout(false);
            this.saladgrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox saladgrp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCusname;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSalad;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpizzzaname;
        private System.Windows.Forms.TextBox txtPizzaPrice;
        private System.Windows.Forms.TextBox txtSaladPrice;
        private System.Windows.Forms.TextBox txtsaladname;
        private System.Windows.Forms.TextBox txtDrinkPrice;
        private System.Windows.Forms.TextBox txtDrinkname;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView xGrid;
    }
}