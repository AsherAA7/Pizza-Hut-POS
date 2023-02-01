namespace PizzaHut
{
    partial class Add_Salad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Salad));
            this.xGrid = new System.Windows.Forms.DataGridView();
            this.saladgrp = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
            this.saladgrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // xGrid
            // 
            this.xGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xGrid.Location = new System.Drawing.Point(12, 249);
            this.xGrid.Name = "xGrid";
            this.xGrid.RowTemplate.Height = 28;
            this.xGrid.Size = new System.Drawing.Size(773, 304);
            this.xGrid.TabIndex = 0;
            this.xGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // saladgrp
            // 
            this.saladgrp.BackColor = System.Drawing.Color.Transparent;
            this.saladgrp.Controls.Add(this.btnClose);
            this.saladgrp.Controls.Add(this.btnSave);
            this.saladgrp.Controls.Add(this.label1);
            this.saladgrp.Controls.Add(this.lblName);
            this.saladgrp.Controls.Add(this.txtPrice);
            this.saladgrp.Controls.Add(this.txtName);
            this.saladgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saladgrp.Location = new System.Drawing.Point(12, 12);
            this.saladgrp.Name = "saladgrp";
            this.saladgrp.Size = new System.Drawing.Size(774, 231);
            this.saladgrp.TabIndex = 1;
            this.saladgrp.TabStop = false;
            this.saladgrp.Text = "Salad-Information";
            this.saladgrp.Enter += new System.EventHandler(this.saladgrp_Enter);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(375, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salad-Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Salad Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(159, 102);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(336, 26);
            this.txtPrice.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 26);
            this.txtName.TabIndex = 0;
            // 
            // Add_Salad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 603);
            this.Controls.Add(this.saladgrp);
            this.Controls.Add(this.xGrid);
            this.Name = "Add_Salad";
            this.Text = "Salad_Shop";
            this.Load += new System.EventHandler(this.Add_Salad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
            this.saladgrp.ResumeLayout(false);
            this.saladgrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView xGrid;
        private System.Windows.Forms.GroupBox saladgrp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
    }
}