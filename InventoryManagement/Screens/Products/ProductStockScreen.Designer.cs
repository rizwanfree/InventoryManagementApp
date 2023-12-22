namespace InventoryManagement.Screens.Products
{
    partial class ProductStockScreen
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
            dgvProducts = new DataGridView();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Size = new Size(901, 65);
            // 
            // textBox1
            // 
            textBox1.Size = new Size(289, 29);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            leftPanel.Size = new Size(300, 804);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvProducts);
            rightPanel.Size = new Size(901, 804);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dgvProducts, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(901, 56);
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 121);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProducts.Size = new Size(901, 683);
            dgvProducts.TabIndex = 2;
            // 
            // ProductStockScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 804);
            Name = "ProductStockScreen";
            Text = "ProductStockScreen";
            Load += ProductStockScreen_Load;
            leftPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
    }
}