namespace PizzaHut
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addusermnu = new System.Windows.Forms.ToolStripMenuItem();
            this.addcoldmnu = new System.Windows.Forms.ToolStripMenuItem();
            this.addpizzamnu = new System.Windows.Forms.ToolStripMenuItem();
            this.adddsaladmnu = new System.Windows.Forms.ToolStripMenuItem();
            this.takeOredermnu = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addusermnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addusermnu
            // 
            this.addusermnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addcoldmnu,
            this.addpizzamnu,
            this.adddsaladmnu,
            this.takeOredermnu,
            this.addUserToolStripMenuItem,
            this.viewOrderToolStripMenuItem});
            this.addusermnu.Name = "addusermnu";
            this.addusermnu.Size = new System.Drawing.Size(50, 29);
            this.addusermnu.Text = "File";
            // 
            // addcoldmnu
            // 
            this.addcoldmnu.Name = "addcoldmnu";
            this.addcoldmnu.Size = new System.Drawing.Size(209, 30);
            this.addcoldmnu.Text = "Add-Cold-drink";
            this.addcoldmnu.Click += new System.EventHandler(this.addcoldmnu_Click);
            // 
            // addpizzamnu
            // 
            this.addpizzamnu.Name = "addpizzamnu";
            this.addpizzamnu.Size = new System.Drawing.Size(209, 30);
            this.addpizzamnu.Text = "Add-Pizza";
            this.addpizzamnu.Click += new System.EventHandler(this.addpizzamnu_Click);
            // 
            // adddsaladmnu
            // 
            this.adddsaladmnu.Name = "adddsaladmnu";
            this.adddsaladmnu.Size = new System.Drawing.Size(209, 30);
            this.adddsaladmnu.Text = "Add-Salad";
            this.adddsaladmnu.Click += new System.EventHandler(this.adddsaladmnu_Click);
            // 
            // takeOredermnu
            // 
            this.takeOredermnu.Name = "takeOredermnu";
            this.takeOredermnu.Size = new System.Drawing.Size(209, 30);
            this.takeOredermnu.Text = "Take-Orders";
            this.takeOredermnu.Click += new System.EventHandler(this.takeOredermnu_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.addUserToolStripMenuItem.Text = "Add-User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "PIZZA HUT";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-11, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "MANAGEMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 62);
            this.label3.TabIndex = 3;
            this.label3.Text = "SYSTEM";
            // 
            // viewOrderToolStripMenuItem
            // 
            this.viewOrderToolStripMenuItem.Name = "viewOrderToolStripMenuItem";
            this.viewOrderToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.viewOrderToolStripMenuItem.Text = "View-Order";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addusermnu;
        private System.Windows.Forms.ToolStripMenuItem addcoldmnu;
        private System.Windows.Forms.ToolStripMenuItem addpizzamnu;
        private System.Windows.Forms.ToolStripMenuItem adddsaladmnu;
        private System.Windows.Forms.ToolStripMenuItem takeOredermnu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrderToolStripMenuItem;
    }
}