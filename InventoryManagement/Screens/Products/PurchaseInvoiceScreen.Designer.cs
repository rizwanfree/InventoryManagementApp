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
            panel4 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            label2 = new Label();
            dtInvoiceDate = new DateTimePicker();
            label3 = new Label();
            cmbSupplier = new ComboBox();
            cmbProduct = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtQuantity = new TextBox();
            txtFoot = new TextBox();
            label6 = new Label();
            txtPrice = new TextBox();
            label7 = new Label();
            txtKG = new TextBox();
            label8 = new Label();
            btnAddToCart = new Button();
            button2 = new Button();
            button3 = new Button();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            leftPanel.Controls.Add(button3);
            leftPanel.Controls.Add(button2);
            leftPanel.Controls.Add(btnAddToCart);
            leftPanel.Controls.Add(txtKG);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(txtPrice);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(txtFoot);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(txtQuantity);
            leftPanel.Controls.Add(label5);
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
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(txtQuantity, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(txtFoot, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(txtPrice, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(txtKG, 0);
            leftPanel.Controls.SetChildIndex(btnAddToCart, 0);
            leftPanel.Controls.SetChildIndex(button2, 0);
            leftPanel.Controls.SetChildIndex(button3, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Controls.Add(panel5);
            rightPanel.Controls.Add(panel4);
            rightPanel.Size = new Size(951, 771);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(panel4, 0);
            rightPanel.Controls.SetChildIndex(panel5, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(951, 56);
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 704);
            panel4.Name = "panel4";
            panel4.Size = new Size(951, 67);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(771, 121);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 583);
            panel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(771, 583);
            dataGridView1.TabIndex = 4;
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
            dtInvoiceDate.TabIndex = 3;
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
            cmbSupplier.TabIndex = 5;
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(3, 246);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(257, 25);
            cmbProduct.TabIndex = 7;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 274);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 8;
            label5.Text = "Qty/Ft";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(3, 296);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(158, 25);
            txtQuantity.TabIndex = 9;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtFoot
            // 
            txtFoot.Location = new Point(167, 346);
            txtFoot.Name = "txtFoot";
            txtFoot.ReadOnly = true;
            txtFoot.Size = new Size(127, 25);
            txtFoot.TabIndex = 11;
            txtFoot.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 324);
            label6.Name = "label6";
            label6.Size = new Size(93, 19);
            label6.TabIndex = 10;
            label6.Text = "Approx KG/Ft";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(167, 296);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(127, 25);
            txtPrice.TabIndex = 13;
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
            // txtKG
            // 
            txtKG.Location = new Point(3, 346);
            txtKG.Name = "txtKG";
            txtKG.Size = new Size(158, 25);
            txtKG.TabIndex = 15;
            txtKG.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 324);
            label8.Name = "label8";
            label8.Size = new Size(67, 19);
            label8.TabIndex = 14;
            label8.Text = "Qty In KG";
            // 
            // btnAddToCart
            // 
            btnAddToCart.FlatAppearance.BorderSize = 2;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Location = new Point(3, 377);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(291, 47);
            btnAddToCart.TabIndex = 16;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.edit_add;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(266, 196);
            button2.Name = "button2";
            button2.Size = new Size(28, 25);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.edit_add;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(266, 245);
            button3.Name = "button3";
            button3.Size = new Size(28, 25);
            button3.TabIndex = 18;
            button3.UseVisualStyleBackColor = true;
            // 
            // PurchaseInvoiceScreen
            // 
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Label label5;
        private ComboBox cmbProduct;
        private Label label4;
        private ComboBox cmbSupplier;
        private Label label3;
        private DateTimePicker dtInvoiceDate;
        private Label label2;
        private Panel panel6;
        private Button btnAddToCart;
        private TextBox txtKG;
        private Label label8;
        private TextBox txtPrice;
        private Label label7;
        private TextBox txtFoot;
        private Label label6;
        private TextBox txtQuantity;
        private Button button3;
        private Button button2;
    }
}