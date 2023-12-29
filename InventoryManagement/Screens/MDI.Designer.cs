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
            masterToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            ledgerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            customersToolStripMenuItem = new ToolStripMenuItem();
            ledgerToolStripMenuItem2 = new ToolStripMenuItem();
            payBillToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            ledgerToolStripMenuItem3 = new ToolStripMenuItem();
            payBillToolStripMenuItem1 = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            utilitiesToolStripMenuItem = new ToolStripMenuItem();
            myMenu.SuspendLayout();
            SuspendLayout();
            // 
            // myMenu
            // 
            myMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, masterToolStripMenuItem, ledgerToolStripMenuItem, reportsToolStripMenuItem, utilitiesToolStripMenuItem });
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
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // masterToolStripMenuItem
            // 
            masterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem });
            masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            masterToolStripMenuItem.Size = new Size(55, 20);
            masterToolStripMenuItem.Text = "Master";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(102, 22);
            usersToolStripMenuItem.Text = "Users";
            // 
            // ledgerToolStripMenuItem
            // 
            ledgerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, customersToolStripMenuItem, supplierToolStripMenuItem });
            ledgerToolStripMenuItem.Name = "ledgerToolStripMenuItem";
            ledgerToolStripMenuItem.Size = new Size(69, 20);
            ledgerToolStripMenuItem.Text = "Accounts";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(128, 6);
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ledgerToolStripMenuItem2, payBillToolStripMenuItem });
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(131, 22);
            customersToolStripMenuItem.Text = "Customers";
            // 
            // ledgerToolStripMenuItem2
            // 
            ledgerToolStripMenuItem2.Name = "ledgerToolStripMenuItem2";
            ledgerToolStripMenuItem2.Size = new Size(164, 22);
            ledgerToolStripMenuItem2.Text = "Ledger";
            ledgerToolStripMenuItem2.Click += ledgerToolStripMenuItem2_Click;
            // 
            // payBillToolStripMenuItem
            // 
            payBillToolStripMenuItem.Name = "payBillToolStripMenuItem";
            payBillToolStripMenuItem.Size = new Size(164, 22);
            payBillToolStripMenuItem.Text = "Receive Payment";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ledgerToolStripMenuItem3, payBillToolStripMenuItem1 });
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(131, 22);
            supplierToolStripMenuItem.Text = "Supplier";
            // 
            // ledgerToolStripMenuItem3
            // 
            ledgerToolStripMenuItem3.Name = "ledgerToolStripMenuItem3";
            ledgerToolStripMenuItem3.Size = new Size(112, 22);
            ledgerToolStripMenuItem3.Text = "Ledger";
            // 
            // payBillToolStripMenuItem1
            // 
            payBillToolStripMenuItem1.Name = "payBillToolStripMenuItem1";
            payBillToolStripMenuItem1.Size = new Size(112, 22);
            payBillToolStripMenuItem1.Text = "Pay Bill";
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
            // MDI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 720);
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
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem masterToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem ledgerToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem utilitiesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem ledgerToolStripMenuItem2;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem payBillToolStripMenuItem;
        private ToolStripMenuItem ledgerToolStripMenuItem3;
        private ToolStripMenuItem payBillToolStripMenuItem1;
        public MenuStrip myMenu;
    }
}