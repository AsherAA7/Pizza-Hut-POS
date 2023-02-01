namespace PizzaHut
{
    partial class Add_Drink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Drink));
            this.saladgrp = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.xGrid = new System.Windows.Forms.DataGridView();
            this.saladgrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // saladgrp
            // 
            this.saladgrp.BackColor = System.Drawing.Color.Transparent;
            this.saladgrp.Controls.Add(this.btnClose);
            this.saladgrp.Controls.Add(this.btnSave);
            this.saladgrp.Controls.Add(this.lblPrice);
            this.saladgrp.Controls.Add(this.lblName);
            this.saladgrp.Controls.Add(this.txtPrice);
            this.saladgrp.Controls.Add(this.txtName);
            this.saladgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saladgrp.Location = new System.Drawing.Point(12, 12);
            this.saladgrp.Name = "saladgrp";
            this.saladgrp.Size = new System.Drawing.Size(621, 231);
            this.saladgrp.TabIndex = 2;
            this.saladgrp.TabStop = false;
            this.saladgrp.Text = "ColdDrink-Information";
            this.saladgrp.Enter += new System.EventHandler(this.saladgrp_Enter);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(383, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(22, 125);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(117, 25);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Drink Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Drink Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(167, 126);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(336, 26);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 26);
            this.txtName.TabIndex = 0;
            // 
            // xGrid
            // 
            this.xGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xGrid.Location = new System.Drawing.Point(12, 270);
            this.xGrid.Name = "xGrid";
            this.xGrid.RowTemplate.Height = 28;
            this.xGrid.Size = new System.Drawing.Size(621, 358);
            this.xGrid.TabIndex = 3;
            this.xGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xGrid_CellDoubleClick);
            // 
            // Add_Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 669);
            this.Controls.Add(this.xGrid);
            this.Controls.Add(this.saladgrp);
            this.Name = "Add_Drink";
            this.Text = "Drink_Shop";
            this.Load += new System.EventHandler(this.Add_Drink_Load);
            this.saladgrp.ResumeLayout(false);
            this.saladgrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox saladgrp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView xGrid;
    }
}