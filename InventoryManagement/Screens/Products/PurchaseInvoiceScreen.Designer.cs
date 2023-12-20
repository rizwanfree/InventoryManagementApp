namespace InventoryManagement.Screens.Products
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel5 = new Panel();
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
            lblStock = new Label();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
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
            leftPanel.Controls.Add(lblStock);
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
            leftPanel.Controls.SetChildIndex(lblStock, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvList);
            rightPanel.Controls.Add(panel5);
            rightPanel.Size = new Size(951, 771);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(panel5, 0);
            rightPanel.Controls.SetChildIndex(dgvList, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(951, 56);
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(txtNetTotal);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(txtDelivery);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(txtCutting);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtProductTotal);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Right;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(635, 121);
            panel5.Name = "panel5";
            panel5.Size = new Size(316, 650);
            panel5.TabIndex = 3;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new DataGridViewColumn[] { ID, Product, Price, Quantity, Total, btnRemove });
            dgvList.Dock = DockStyle.Fill;
            dgvList.Location = new Point(0, 121);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            Product.FillWeight = 300F;
            Product.HeaderText = "Product Name";
            Product.Name = "Product";
            // 
            // Price
            // 
            Price.FillWeight = 75F;
            Price.HeaderText = "Rate";
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.FillWeight = 80F;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Total
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Total.DefaultCellStyle = dataGridViewCellStyle2;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btnRemove
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            btnRemove.DefaultCellStyle = dataGridViewCellStyle3;
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
            label2.Location = new Point(3, 124);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // dtInvoiceDate
            // 
            dtInvoiceDate.Location = new Point(3, 146);
            dtInvoiceDate.Name = "dtInvoiceDate";
            dtInvoiceDate.Size = new Size(291, 25);
            dtInvoiceDate.TabIndex = 0;
            dtInvoiceDate.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 174);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 4;
            label3.Text = "Supplier";
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(3, 196);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(257, 25);
            cmbSupplier.TabIndex = 1;
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(3, 246);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(257, 25);
            cmbProduct.TabIndex = 3;
            cmbProduct.SelectionChangeCommitted += cmbProduct_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 224);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 6;
            label4.Text = "Product";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(167, 296);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(127, 25);
            txtPrice.TabIndex = 6;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(167, 274);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 12;
            label7.Text = "Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(3, 296);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(158, 25);
            txtQuantity.TabIndex = 5;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 274);
            label8.Name = "label8";
            label8.Size = new Size(67, 19);
            label8.TabIndex = 14;
            label8.Text = "Qty In KG";
            // 
            // btnAddToCart
            // 
            btnAddToCart.FlatAppearance.BorderSize = 2;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Location = new Point(3, 327);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(291, 47);
            btnAddToCart.TabIndex = 7;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.edit_add;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(266, 196);
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
            button3.Location = new Point(266, 245);
            button3.Name = "button3";
            button3.Size = new Size(28, 25);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 13F);
            label6.Location = new Point(3, 465);
            label6.Name = "label6";
            label6.Size = new Size(75, 24);
            label6.TabIndex = 17;
            label6.Text = "In Stock";
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Segoe UI Variable Display Semib", 13F);
            lblStock.Location = new Point(167, 465);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(127, 24);
            lblStock.TabIndex = 18;
            lblStock.TextAlign = ContentAlignment.MiddleRight;
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvList;
        private Panel panel5;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn btnRemove;
        private TextBox txtProductTotal;
        private Label label5;
        private Label lblStock;
        private Label label6;
        private TextBox txtNetTotal;
        private Label label11;
        private TextBox txtDelivery;
        private Label label10;
        private TextBox txtCutting;
        private Label label9;
    }
}