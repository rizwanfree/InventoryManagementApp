namespace InventoryManagement.Screens
{
    partial class HomeScreen
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSearchSellInvoices = new Button();
            btnSearchPurchaseInvoices = new Button();
            btnCustomer = new Button();
            btnVendor = new Button();
            btnCatagory = new Button();
            btnSell = new Button();
            btnPurchaseInvoice = new Button();
            btnStock = new Button();
            btnProducts = new Button();
            btnUsers = new Button();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Size = new Size(300, 813);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(tableLayoutPanel1);
            rightPanel.Size = new Size(1009, 813);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(tableLayoutPanel1, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(1009, 56);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6673565F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66736F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66736F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66736F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66736F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6631947F));
            tableLayoutPanel1.Controls.Add(btnSearchSellInvoices, 0, 4);
            tableLayoutPanel1.Controls.Add(btnSearchPurchaseInvoices, 0, 4);
            tableLayoutPanel1.Controls.Add(btnCustomer, 5, 0);
            tableLayoutPanel1.Controls.Add(btnVendor, 4, 0);
            tableLayoutPanel1.Controls.Add(btnCatagory, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSell, 1, 1);
            tableLayoutPanel1.Controls.Add(btnPurchaseInvoice, 0, 1);
            tableLayoutPanel1.Controls.Add(btnStock, 3, 0);
            tableLayoutPanel1.Controls.Add(btnProducts, 2, 0);
            tableLayoutPanel1.Controls.Add(btnUsers, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1009, 757);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSearchSellInvoices
            // 
            btnSearchSellInvoices.Cursor = Cursors.Hand;
            btnSearchSellInvoices.Dock = DockStyle.Fill;
            btnSearchSellInvoices.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnSearchSellInvoices.FlatAppearance.BorderSize = 2;
            btnSearchSellInvoices.FlatStyle = FlatStyle.Flat;
            btnSearchSellInvoices.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnSearchSellInvoices.Location = new Point(3, 607);
            btnSearchSellInvoices.Name = "btnSearchSellInvoices";
            btnSearchSellInvoices.Size = new Size(162, 147);
            btnSearchSellInvoices.TabIndex = 9;
            btnSearchSellInvoices.Text = "Search Sell Invoices";
            btnSearchSellInvoices.UseVisualStyleBackColor = true;
            btnSearchSellInvoices.Click += btnSearchSellInvoices_Click;
            // 
            // btnSearchPurchaseInvoices
            // 
            btnSearchPurchaseInvoices.Cursor = Cursors.Hand;
            btnSearchPurchaseInvoices.Dock = DockStyle.Fill;
            btnSearchPurchaseInvoices.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnSearchPurchaseInvoices.FlatAppearance.BorderSize = 2;
            btnSearchPurchaseInvoices.FlatStyle = FlatStyle.Flat;
            btnSearchPurchaseInvoices.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnSearchPurchaseInvoices.Location = new Point(171, 607);
            btnSearchPurchaseInvoices.Name = "btnSearchPurchaseInvoices";
            btnSearchPurchaseInvoices.Size = new Size(162, 147);
            btnSearchPurchaseInvoices.TabIndex = 8;
            btnSearchPurchaseInvoices.Text = "Search Purchase Invoices";
            btnSearchPurchaseInvoices.UseVisualStyleBackColor = true;
            btnSearchPurchaseInvoices.Click += btnSearchPurchaseInvoices_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.Dock = DockStyle.Fill;
            btnCustomer.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnCustomer.FlatAppearance.BorderSize = 2;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnCustomer.Location = new Point(843, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(163, 145);
            btnCustomer.TabIndex = 7;
            btnCustomer.Text = "Customers";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnVendor
            // 
            btnVendor.Cursor = Cursors.Hand;
            btnVendor.Dock = DockStyle.Fill;
            btnVendor.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnVendor.FlatAppearance.BorderSize = 2;
            btnVendor.FlatStyle = FlatStyle.Flat;
            btnVendor.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnVendor.Location = new Point(675, 3);
            btnVendor.Name = "btnVendor";
            btnVendor.Size = new Size(162, 145);
            btnVendor.TabIndex = 6;
            btnVendor.Text = "Suppliers";
            btnVendor.UseVisualStyleBackColor = true;
            btnVendor.Click += btnVendor_Click;
            // 
            // btnCatagory
            // 
            btnCatagory.Cursor = Cursors.Hand;
            btnCatagory.Dock = DockStyle.Fill;
            btnCatagory.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnCatagory.FlatAppearance.BorderSize = 2;
            btnCatagory.FlatStyle = FlatStyle.Flat;
            btnCatagory.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnCatagory.Image = Properties.Resources.Network_Drive_Offline_;
            btnCatagory.Location = new Point(171, 3);
            btnCatagory.Name = "btnCatagory";
            btnCatagory.Size = new Size(162, 145);
            btnCatagory.TabIndex = 5;
            btnCatagory.Text = "Catagories";
            btnCatagory.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCatagory.UseVisualStyleBackColor = true;
            btnCatagory.Click += btnCatagory_Click;
            // 
            // btnSell
            // 
            btnSell.Cursor = Cursors.Hand;
            btnSell.Dock = DockStyle.Fill;
            btnSell.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnSell.FlatAppearance.BorderSize = 2;
            btnSell.FlatStyle = FlatStyle.Flat;
            btnSell.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnSell.Location = new Point(171, 154);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(162, 145);
            btnSell.TabIndex = 4;
            btnSell.Text = "Sales";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // btnPurchaseInvoice
            // 
            btnPurchaseInvoice.Cursor = Cursors.Hand;
            btnPurchaseInvoice.Dock = DockStyle.Fill;
            btnPurchaseInvoice.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnPurchaseInvoice.FlatAppearance.BorderSize = 2;
            btnPurchaseInvoice.FlatStyle = FlatStyle.Flat;
            btnPurchaseInvoice.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnPurchaseInvoice.Location = new Point(3, 154);
            btnPurchaseInvoice.Name = "btnPurchaseInvoice";
            btnPurchaseInvoice.Size = new Size(162, 145);
            btnPurchaseInvoice.TabIndex = 3;
            btnPurchaseInvoice.Text = "Purchase Invoice";
            btnPurchaseInvoice.UseVisualStyleBackColor = true;
            btnPurchaseInvoice.Click += btnPurchaseInvoice_Click;
            // 
            // btnStock
            // 
            btnStock.Cursor = Cursors.Hand;
            btnStock.Dock = DockStyle.Fill;
            btnStock.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnStock.FlatAppearance.BorderSize = 2;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnStock.Image = Properties.Resources.business;
            btnStock.Location = new Point(507, 3);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(162, 145);
            btnStock.TabIndex = 2;
            btnStock.Text = "Stocks";
            btnStock.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnProducts
            // 
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.Dock = DockStyle.Fill;
            btnProducts.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnProducts.FlatAppearance.BorderSize = 2;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnProducts.Image = Properties.Resources.database;
            btnProducts.Location = new Point(339, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(162, 145);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnUsers
            // 
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.Dock = DockStyle.Fill;
            btnUsers.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnUsers.FlatAppearance.BorderSize = 2;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnUsers.Image = Properties.Resources.Community_Help;
            btnUsers.Location = new Point(3, 3);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(162, 145);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Users";
            btnUsers.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 813);
            Name = "HomeScreen";
            Text = "HomeScreen";
            WindowState = FormWindowState.Maximized;
            Load += HomeScreen_Load;
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSell;
        private Button btnPurchaseInvoice;
        private Button btnStock;
        private Button btnProducts;
        private Button btnUsers;
        private Button btnCatagory;
        private Button btnCustomer;
        private Button btnVendor;
        private Button btnSearchSellInvoices;
        private Button btnSearchPurchaseInvoices;
    }
}