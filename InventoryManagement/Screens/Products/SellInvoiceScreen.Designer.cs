namespace InventoryManagement.Screens.Products
{
    partial class SellInvoiceScreen
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            SellScreenRightPanel = new Panel();
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
            QuantityFT = new DataGridViewTextBoxColumn();
            QuantityKG = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnRemove = new DataGridViewButtonColumn();
            panel6 = new Panel();
            label2 = new Label();
            dtInvoiceDate = new DateTimePicker();
            label3 = new Label();
            cmbCustomer = new ComboBox();
            cmbProduct = new ComboBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label7 = new Label();
            txtFoot = new TextBox();
            label8 = new Label();
            btnAddToCart = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            txtBNumber = new TextBox();
            txtKG = new TextBox();
            label12 = new Label();
            txtkgft = new TextBox();
            label13 = new Label();
            rbKG = new RadioButton();
            rbFoot = new RadioButton();
            label14 = new Label();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            SellScreenRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Size = new Size(895, 65);
            // 
            // textBox1
            // 
            textBox1.Size = new Size(287, 29);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            leftPanel.BackgroundImageLayout = ImageLayout.Stretch;
            leftPanel.Controls.Add(label14);
            leftPanel.Controls.Add(rbFoot);
            leftPanel.Controls.Add(rbKG);
            leftPanel.Controls.Add(txtkgft);
            leftPanel.Controls.Add(label13);
            leftPanel.Controls.Add(txtKG);
            leftPanel.Controls.Add(label12);
            leftPanel.Controls.Add(txtBNumber);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(button3);
            leftPanel.Controls.Add(button2);
            leftPanel.Controls.Add(btnAddToCart);
            leftPanel.Controls.Add(txtFoot);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(txtPrice);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(cmbProduct);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(cmbCustomer);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(dtInvoiceDate);
            leftPanel.Controls.Add(label2);
            leftPanel.Controls.Add(panel6);
            leftPanel.Size = new Size(356, 771);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(panel6, 0);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(dtInvoiceDate, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(cmbCustomer, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(cmbProduct, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(txtPrice, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(txtFoot, 0);
            leftPanel.Controls.SetChildIndex(btnAddToCart, 0);
            leftPanel.Controls.SetChildIndex(button2, 0);
            leftPanel.Controls.SetChildIndex(button3, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(txtBNumber, 0);
            leftPanel.Controls.SetChildIndex(label12, 0);
            leftPanel.Controls.SetChildIndex(txtKG, 0);
            leftPanel.Controls.SetChildIndex(label13, 0);
            leftPanel.Controls.SetChildIndex(txtkgft, 0);
            leftPanel.Controls.SetChildIndex(rbKG, 0);
            leftPanel.Controls.SetChildIndex(rbFoot, 0);
            leftPanel.Controls.SetChildIndex(label14, 0);
            // 
            // panel1
            // 
            panel1.Size = new Size(356, 56);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvList);
            rightPanel.Controls.Add(SellScreenRightPanel);
            rightPanel.Location = new Point(356, 0);
            rightPanel.Size = new Size(895, 771);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(SellScreenRightPanel, 0);
            rightPanel.Controls.SetChildIndex(dgvList, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(895, 56);
            // 
            // SellScreenRightPanel
            // 
            SellScreenRightPanel.BackColor = Color.DarkSlateGray;
            SellScreenRightPanel.Controls.Add(txtNetTotal);
            SellScreenRightPanel.Controls.Add(label11);
            SellScreenRightPanel.Controls.Add(txtDelivery);
            SellScreenRightPanel.Controls.Add(label10);
            SellScreenRightPanel.Controls.Add(txtCutting);
            SellScreenRightPanel.Controls.Add(label9);
            SellScreenRightPanel.Controls.Add(txtProductTotal);
            SellScreenRightPanel.Controls.Add(label5);
            SellScreenRightPanel.Dock = DockStyle.Right;
            SellScreenRightPanel.ForeColor = Color.White;
            SellScreenRightPanel.Location = new Point(579, 121);
            SellScreenRightPanel.Name = "SellScreenRightPanel";
            SellScreenRightPanel.Size = new Size(316, 650);
            SellScreenRightPanel.TabIndex = 3;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 13F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new DataGridViewColumn[] { ID, Product, Price, QuantityFT, QuantityKG, Total, btnRemove });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Variable Display Semib", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvList.DefaultCellStyle = dataGridViewCellStyle8;
            dgvList.Dock = DockStyle.Fill;
            dgvList.Location = new Point(0, 121);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersVisible = false;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvList.Size = new Size(579, 650);
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Product.DefaultCellStyle = dataGridViewCellStyle2;
            Product.FillWeight = 139.547134F;
            Product.HeaderText = "Product Name";
            Product.Name = "Product";
            // 
            // Price
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Price.DefaultCellStyle = dataGridViewCellStyle3;
            Price.FillWeight = 34.8867836F;
            Price.HeaderText = "Rate";
            Price.Name = "Price";
            // 
            // QuantityFT
            // 
            QuantityFT.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityFT.DefaultCellStyle = dataGridViewCellStyle4;
            QuantityFT.FillWeight = 80F;
            QuantityFT.HeaderText = "Quantity In Foot";
            QuantityFT.Name = "QuantityFT";
            QuantityFT.Width = 167;
            // 
            // QuantityKG
            // 
            QuantityKG.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            QuantityKG.DefaultCellStyle = dataGridViewCellStyle5;
            QuantityKG.FillWeight = 46.5157051F;
            QuantityKG.HeaderText = "Quantity In KG";
            QuantityKG.Name = "QuantityKG";
            QuantityKG.Width = 118;
            // 
            // Total
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total.DefaultCellStyle = dataGridViewCellStyle6;
            Total.FillWeight = 46.5157051F;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btnRemove
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = Color.Gray;
            btnRemove.DefaultCellStyle = dataGridViewCellStyle7;
            btnRemove.FillWeight = 46.5157051F;
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
            panel6.Size = new Size(356, 65);
            panel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label2.Location = new Point(6, 129);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // dtInvoiceDate
            // 
            dtInvoiceDate.CustomFormat = "dd-MMM-yyyy";
            dtInvoiceDate.Font = new Font("Segoe UI Variable Display Semib", 12F);
            dtInvoiceDate.Format = DateTimePickerFormat.Custom;
            dtInvoiceDate.Location = new Point(5, 154);
            dtInvoiceDate.Name = "dtInvoiceDate";
            dtInvoiceDate.Size = new Size(142, 29);
            dtInvoiceDate.TabIndex = 0;
            dtInvoiceDate.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label3.Location = new Point(6, 186);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 4;
            label3.Text = "Customer";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.Font = new Font("Segoe UI Variable Display Semib", 12F);
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(5, 210);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(303, 29);
            cmbCustomer.TabIndex = 2;
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.Font = new Font("Segoe UI Variable Display Semib", 12F);
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(5, 269);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(303, 29);
            cmbProduct.TabIndex = 3;
            cmbProduct.SelectionChangeCommitted += cmbProduct_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label4.Location = new Point(6, 245);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 6;
            label4.Text = "Product";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI Variable Display Semib", 12F);
            txtPrice.Location = new Point(6, 412);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(172, 29);
            txtPrice.TabIndex = 8;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label7.Location = new Point(6, 388);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 12;
            label7.Text = "Rate";
            // 
            // txtFoot
            // 
            txtFoot.Font = new Font("Segoe UI Variable Display Semib", 12F);
            txtFoot.Location = new Point(181, 356);
            txtFoot.Name = "txtFoot";
            txtFoot.Size = new Size(169, 29);
            txtFoot.TabIndex = 7;
            txtFoot.TextAlign = HorizontalAlignment.Right;
            txtFoot.TextChanged += txtQuantity_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label8.Location = new Point(181, 332);
            label8.Name = "label8";
            label8.Size = new Size(128, 21);
            label8.TabIndex = 14;
            label8.Text = "Quantity In Foot";
            // 
            // btnAddToCart
            // 
            btnAddToCart.FlatAppearance.BorderSize = 2;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI Variable Display Semib", 12F);
            btnAddToCart.Location = new Point(6, 447);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(344, 47);
            btnAddToCart.TabIndex = 10;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.edit_add;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI Variable Display Semib", 12F);
            button2.Location = new Point(314, 210);
            button2.Name = "button2";
            button2.Size = new Size(36, 29);
            button2.TabIndex = 2;
            button2.TabStop = false;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.edit_add;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI Variable Display Semib", 12F);
            button3.Location = new Point(314, 267);
            button3.Name = "button3";
            button3.Size = new Size(36, 31);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label6.Location = new Point(153, 129);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 16;
            label6.Text = "Invoice/Bill #";
            // 
            // txtBNumber
            // 
            txtBNumber.Font = new Font("Segoe UI Variable Display Semib", 12F);
            txtBNumber.Location = new Point(153, 154);
            txtBNumber.Name = "txtBNumber";
            txtBNumber.Size = new Size(197, 29);
            txtBNumber.TabIndex = 1;
            // 
            // txtKG
            // 
            txtKG.Font = new Font("Segoe UI Variable Display Semib", 12F);
            txtKG.Location = new Point(6, 356);
            txtKG.Name = "txtKG";
            txtKG.Size = new Size(172, 29);
            txtKG.TabIndex = 6;
            txtKG.TextAlign = HorizontalAlignment.Right;
            txtKG.TextChanged += txtKG_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label12.Location = new Point(6, 332);
            label12.Name = "label12";
            label12.Size = new Size(160, 21);
            label12.TabIndex = 18;
            label12.Text = "Quantity In Kilogram";
            // 
            // txtkgft
            // 
            txtkgft.Font = new Font("Segoe UI Variable Display Semib", 12F);
            txtkgft.Location = new Point(181, 412);
            txtkgft.Name = "txtkgft";
            txtkgft.Size = new Size(169, 29);
            txtkgft.TabIndex = 9;
            txtkgft.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label13.Location = new Point(181, 388);
            label13.Name = "label13";
            label13.Size = new Size(48, 21);
            label13.TabIndex = 20;
            label13.Text = "Kg/ft";
            // 
            // rbKG
            // 
            rbKG.AutoSize = true;
            rbKG.FlatStyle = FlatStyle.Popup;
            rbKG.Location = new Point(127, 305);
            rbKG.Name = "rbKG";
            rbKG.Size = new Size(44, 23);
            rbKG.TabIndex = 4;
            rbKG.TabStop = true;
            rbKG.Text = "KG";
            rbKG.UseVisualStyleBackColor = true;
            rbKG.CheckedChanged += rbKG_CheckedChanged;
            // 
            // rbFoot
            // 
            rbFoot.AutoSize = true;
            rbFoot.FlatStyle = FlatStyle.Popup;
            rbFoot.Location = new Point(178, 305);
            rbFoot.Name = "rbFoot";
            rbFoot.Size = new Size(54, 23);
            rbFoot.TabIndex = 5;
            rbFoot.TabStop = true;
            rbFoot.Text = "Foot";
            rbFoot.UseVisualStyleBackColor = true;
            rbFoot.CheckedChanged += rbFoot_CheckedChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Display Semib", 12F);
            label14.Location = new Point(6, 305);
            label14.Name = "label14";
            label14.Size = new Size(99, 21);
            label14.TabIndex = 23;
            label14.Text = "Sell Method";
            // 
            // SellInvoiceScreen
            // 
            AcceptButton = btnAddToCart;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 771);
            Name = "SellInvoiceScreen";
            Text = "Sell Screen";
            Load += SellInvoiceScreen_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            SellScreenRightPanel.ResumeLayout(false);
            SellScreenRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvList;
        private Panel SellScreenRightPanel;
        private ComboBox cmbProduct;
        private Label label4;
        private ComboBox cmbCustomer;
        private Label label3;
        private DateTimePicker dtInvoiceDate;
        private Label label2;
        private Panel panel6;
        private Button btnAddToCart;
        private TextBox txtFoot;
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
        private TextBox txtBNumber;
        private TextBox txtKG;
        private Label label12;
        private TextBox txtkgft;
        private Label label13;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn QuantityFT;
        private DataGridViewTextBoxColumn QuantityKG;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn btnRemove;
        private Label label14;
        private RadioButton rbFoot;
        private RadioButton rbKG;
    }
}