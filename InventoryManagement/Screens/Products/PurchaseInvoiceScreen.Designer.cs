﻿namespace InventoryManagement.Screens.Products
{
    partial class PurchaseInvoiceScreen
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            PurchaseScreenRightPanel = new Panel();
            txtNetTotal = new TextBox();
            label11 = new Label();
            txtDelivery = new TextBox();
            label10 = new Label();
            txtCutting = new TextBox();
            label9 = new Label();
            txtProductTotal = new TextBox();
            label5 = new Label();
            dgvList = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnRemove = new DataGridViewButtonColumn();
            panel6 = new Panel();
            label2 = new Label();
            dtInvoiceDate = new DateTimePicker();
            label3 = new Label();
            cmbSupplier = new ComboBox();
            cmbProduct = new ComboBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label7 = new Label();
            txtQuantity = new TextBox();
            label8 = new Label();
            btnAddToCart = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            txtBNumber = new TextBox();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            PurchaseScreenRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Size = new Size(951, 65);
            // 
            // textBox1
            // 
            textBox1.Size = new Size(307, 29);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            leftPanel.BackgroundImageLayout = ImageLayout.Stretch;
            leftPanel.Controls.Add(txtBNumber);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(button3);
            leftPanel.Controls.Add(button2);
            leftPanel.Controls.Add(btnAddToCart);
            leftPanel.Controls.Add(txtQuantity);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(txtPrice);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(cmbProduct);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(cmbSupplier);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(dtInvoiceDate);
            leftPanel.Controls.Add(label2);
            leftPanel.Controls.Add(panel6);
            leftPanel.Size = new Size(300, 771);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(panel6, 0);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(dtInvoiceDate, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(cmbSupplier, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(cmbProduct, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(txtPrice, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(txtQuantity, 0);
            leftPanel.Controls.SetChildIndex(btnAddToCart, 0);
            leftPanel.Controls.SetChildIndex(button2, 0);
            leftPanel.Controls.SetChildIndex(button3, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(txtBNumber, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvList);
            rightPanel.Controls.Add(PurchaseScreenRightPanel);
            rightPanel.Size = new Size(951, 771);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(PurchaseScreenRightPanel, 0);
            rightPanel.Controls.SetChildIndex(dgvList, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(951, 56);
            // 
            // PurchaseScreenRightPanel
            // 
            PurchaseScreenRightPanel.BackColor = Color.DarkSlateGray;
            PurchaseScreenRightPanel.Controls.Add(txtNetTotal);
            PurchaseScreenRightPanel.Controls.Add(label11);
            PurchaseScreenRightPanel.Controls.Add(txtDelivery);
            PurchaseScreenRightPanel.Controls.Add(label10);
            PurchaseScreenRightPanel.Controls.Add(txtCutting);
            PurchaseScreenRightPanel.Controls.Add(label9);
            PurchaseScreenRightPanel.Controls.Add(txtProductTotal);
            PurchaseScreenRightPanel.Controls.Add(label5);
            PurchaseScreenRightPanel.Dock = DockStyle.Right;
            PurchaseScreenRightPanel.ForeColor = Color.White;
            PurchaseScreenRightPanel.Location = new Point(635, 121);
            PurchaseScreenRightPanel.Name = "PurchaseScreenRightPanel";
            PurchaseScreenRightPanel.Size = new Size(316, 650);
            PurchaseScreenRightPanel.TabIndex = 3;
            // 
            // txtNetTotal
            // 
            txtNetTotal.BackColor = SystemColors.InfoText;
            txtNetTotal.Font = new Font("Segoe UI Variable Display Semib", 13F);
            txtNetTotal.ForeColor = Color.Gold;
            txtNetTotal.Location = new Point(164, 153);
            txtNetTotal.Name = "txtNetTotal";
            txtNetTotal.ReadOnly = true;
            txtNetTotal.Size = new Size(146, 31);
            txtNetTotal.TabIndex = 21;
            txtNetTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Display Semib", 13F);
            label11.Location = new Point(6, 156);
            label11.Name = "label11";
            label11.Size = new Size(85, 24);
            label11.TabIndex = 22;
            label11.Text = "Net Total";
            // 
            // txtDelivery
            // 
            txtDelivery.BackColor = SystemColors.Window;
            txtDelivery.Font = new Font("Segoe UI Variable Display Semib", 13F);
            txtDelivery.ForeColor = SystemColors.ControlText;
            txtDelivery.Location = new Point(164, 114);
            txtDelivery.Name = "txtDelivery";
            txtDelivery.ReadOnly = true;
            txtDelivery.Size = new Size(146, 31);
            txtDelivery.TabIndex = 19;
            txtDelivery.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Display Semib", 13F);
            label10.Location = new Point(6, 117);
            label10.Name = "label10";
            label10.Size = new Size(148, 24);
            label10.TabIndex = 20;
            label10.Text = "Cartage Charges";
            // 
            // txtCutting
            // 
            txtCutting.BackColor = SystemColors.Window;
            txtCutting.Font = new Font("Segoe UI Variable Display Semib", 13F);
            txtCutting.ForeColor = SystemColors.ControlText;
            txtCutting.Location = new Point(164, 77);
            txtCutting.Name = "txtCutting";
            txtCutting.ReadOnly = true;
            txtCutting.Size = new Size(146, 31);
            txtCutting.TabIndex = 17;
            txtCutting.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 13F);
            label9.Location = new Point(6, 80);
            label9.Name = "label9";
            label9.Size = new Size(145, 24);
            label9.TabIndex = 18;
            label9.Text = "Cutting Charges";
            // 
            // txtProductTotal
            // 
            txtProductTotal.BackColor = SystemColors.InfoText;
            txtProductTotal.Font = new Font("Segoe UI Variable Display Semib", 13F);
            txtProductTotal.ForeColor = Color.Gold;
            txtProductTotal.Location = new Point(164, 40);
            txtProductTotal.Name = "txtProductTotal";
            txtProductTotal.ReadOnly = true;
            txtProductTotal.Size = new Size(146, 31);
            txtProductTotal.TabIndex = 15;
            txtProductTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display Semib", 13F);
            label5.Location = new Point(6, 43);
            label5.Name = "label5";
            label5.Size = new Size(50, 24);
            label5.TabIndex = 16;
            label5.Text = "Total";
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.BackgroundColor = Color.White;
            dgvList.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Variable Display Semib", 13F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new DataGridViewColumn[] { ID, Product, Price, Quantity, Total, btnRemove });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Segoe UI Variable Display Semib", 12F);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvList.DefaultCellStyle = dataGridViewCellStyle15;
            dgvList.Dock = DockStyle.Fill;
            dgvList.Location = new Point(0, 121);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersVisible = false;
            dataGridViewCellStyle16.Font = new Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvList.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvList.Size = new Size(635, 650);
            dgvList.TabIndex = 4;
            dgvList.CellClick += dgvList_CellClick;
            dgvList.CellValidated += dgvList_CellValidated;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // Product
            // 
            dataGridViewCellStyle10.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Product.DefaultCellStyle = dataGridViewCellStyle10;
            Product.FillWeight = 300F;
            Product.HeaderText = "Product Name";
            Product.Name = "Product";
            // 
            // Price
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Price.DefaultCellStyle = dataGridViewCellStyle11;
            Price.FillWeight = 75F;
            Price.HeaderText = "Rate";
            Price.Name = "Price";
            // 
            // Quantity
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quantity.DefaultCellStyle = dataGridViewCellStyle12;
            Quantity.FillWeight = 80F;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Total
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total.DefaultCellStyle = dataGridViewCellStyle13;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btnRemove
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.ForeColor = Color.Gray;
            btnRemove.DefaultCellStyle = dataGridViewCellStyle14;
            btnRemove.HeaderText = "Remove";
            btnRemove.Name = "btnRemove";
            btnRemove.Text = "Remove";
            btnRemove.UseColumnTextForButtonValue = true;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 56);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 65);
            panel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label2.Location = new Point(5, 129);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // dtInvoiceDate
            // 
            dtInvoiceDate.Font = new Font("Segoe UI Variable Display Semib", 12F);
            dtInvoiceDate.Location = new Point(5, 154);
            dtInvoiceDate.Name = "dtInvoiceDate";
            dtInvoiceDate.Size = new Size(291, 29);
            dtInvoiceDate.TabIndex = 0;
            dtInvoiceDate.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label3.Location = new Point(5, 244);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 4;
            label3.Text = "Supplier";
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new Font("Segoe UI Variable Display Semib", 12F);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(5, 268);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(257, 29);
            cmbSupplier.TabIndex = 2;
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.Font = new Font("Segoe UI Variable Display Semib", 12F);
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(5, 334);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(257, 29);
            cmbProduct.TabIndex = 3;
            cmbProduct.SelectionChangeCommitted += cmbProduct_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label4.Location = new Point(5, 310);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 6;
            label4.Text = "Product";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI Variable Display Semib", 12F);
            txtPrice.Location = new Point(166, 390);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(130, 29);
            txtPrice.TabIndex = 5;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label7.Location = new Point(166, 366);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 12;
            label7.Text = "Rate";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Variable Display Semib", 12F);
            txtQuantity.Location = new Point(5, 390);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(158, 29);
            txtQuantity.TabIndex = 4;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label8.Location = new Point(5, 366);
            label8.Name = "label8";
            label8.Size = new Size(114, 21);
            label8.TabIndex = 14;
            label8.Text = "Quantity In KG";
            // 
            // btnAddToCart
            // 
            btnAddToCart.FlatAppearance.BorderSize = 2;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnAddToCart.Location = new Point(5, 425);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(291, 47);
            btnAddToCart.TabIndex = 6;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.edit_add;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI Variable Display Semib", 12F);
            button2.Location = new Point(266, 268);
            button2.Name = "button2";
            button2.Size = new Size(28, 25);
            button2.TabIndex = 2;
            button2.TabStop = false;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.edit_add;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI Variable Display Semib", 12F);
            button3.Location = new Point(266, 333);
            button3.Name = "button3";
            button3.Size = new Size(28, 25);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label6.Location = new Point(5, 188);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 16;
            label6.Text = "Invoice/Bill #";
            // 
            // txtBNumber
            // 
            txtBNumber.Location = new Point(5, 212);
            txtBNumber.Name = "txtBNumber";
            txtBNumber.Size = new Size(291, 25);
            txtBNumber.TabIndex = 1;
            // 
            // PurchaseInvoiceScreen
            // 
            AcceptButton = btnAddToCart;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 771);
            Name = "PurchaseInvoiceScreen";
            Text = "PurchaseInvoiceScreen";
            Load += PurchaseInvoiceScreen_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            PurchaseScreenRightPanel.ResumeLayout(false);
            PurchaseScreenRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvList;
        private Panel PurchaseScreenRightPanel;
        private ComboBox cmbProduct;
        private Label label4;
        private ComboBox cmbSupplier;
        private Label label3;
        private DateTimePicker dtInvoiceDate;
        private Label label2;
        private Panel panel6;
        private Button btnAddToCart;
        private TextBox txtQuantity;
        private Label label8;
        private TextBox txtPrice;
        private Label label7;
        private Button button3;
        private Button button2;
        private TextBox txtProductTotal;
        private Label label5;
        private TextBox txtNetTotal;
        private Label label11;
        private TextBox txtDelivery;
        private Label label10;
        private TextBox txtCutting;
        private Label label9;
        private Label label6;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn btnRemove;
        private TextBox txtBNumber;
    }
}