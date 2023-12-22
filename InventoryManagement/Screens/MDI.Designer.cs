namespace InventoryManagement
{
    partial class MDI
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
            myMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            utilitiesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            myMenu.SuspendLayout();
            SuspendLayout();
            // 
            // myMenu
            // 
            myMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, systemToolStripMenuItem, productsToolStripMenuItem, customerToolStripMenuItem, supplierToolStripMenuItem, reportsToolStripMenuItem, utilitiesToolStripMenuItem });
            myMenu.Location = new Point(0, 0);
            myMenu.Name = "myMenu";
            myMenu.Size = new Size(1235, 24);
            myMenu.TabIndex = 1;
            myMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(57, 20);
            systemToolStripMenuItem.Text = "System";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(66, 20);
            productsToolStripMenuItem.Text = "Products";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(76, 20);
            customerToolStripMenuItem.Text = "Customers";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(67, 20);
            supplierToolStripMenuItem.Text = "Suppliers";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // utilitiesToolStripMenuItem
            // 
            utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            utilitiesToolStripMenuItem.Size = new Size(58, 20);
            utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(180, 22);
            usersToolStripMenuItem.Text = "Users";
            // 
            // MDI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 800);
            Controls.Add(myMenu);
            Font = new Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = myMenu;
            Name = "MDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDI";
            WindowState = FormWindowState.Maximized;
            Load += MDI_Load;
            myMenu.ResumeLayout(false);
            myMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip myMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem utilitiesToolStripMenuItem;
    }
}