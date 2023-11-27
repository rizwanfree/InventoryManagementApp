namespace InventoryManagement.Screens.Products
{
    partial class ProductScreen
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
            label3 = new Label();
            txtProductName = new TextBox();
            label4 = new Label();
            cmbCategory = new ComboBox();
            label5 = new Label();
            txtKGFT = new TextBox();
            dgvProduct = new DataGridView();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Size = new Size(954, 65);
            // 
            // textBox1
            // 
            textBox1.Size = new Size(306, 29);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(txtKGFT);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(cmbCategory);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(txtProductName);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(panel4);
            leftPanel.Size = new Size(300, 810);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(txtProductName, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(cmbCategory, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(txtKGFT, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvProduct);
            rightPanel.Size = new Size(954, 810);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dgvProduct, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(954, 56);
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 65);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 124);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 2;
            label3.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(6, 147);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(288, 25);
            txtProductName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 175);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 4;
            label4.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(6, 197);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(288, 25);
            cmbCategory.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 225);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 6;
            label5.Text = "KG/Ft";
            // 
            // txtKGFT
            // 
            txtKGFT.Location = new Point(6, 247);
            txtKGFT.Name = "txtKGFT";
            txtKGFT.Size = new Size(288, 25);
            txtKGFT.TabIndex = 7;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.BorderStyle = BorderStyle.None;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(0, 121);
            dgvProduct.MultiSelect = false;
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(954, 689);
            dgvProduct.TabIndex = 2;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // ProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 810);
            Name = "ProductScreen";
            Text = "ProductScreen";
            Load += ProductScreen_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtProductName;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private ComboBox cmbCategory;
        private TextBox txtKGFT;
        private Label label5;
        private DataGridView dgvProduct;
    }
}