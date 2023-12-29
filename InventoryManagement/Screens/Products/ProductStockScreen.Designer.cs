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
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblProducts = new Label();
            lblQuantity = new Label();
            lblValue = new Label();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel4.SuspendLayout();
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
            rightPanel.Controls.Add(panel4);
            rightPanel.Controls.Add(dgvProducts);
            rightPanel.Size = new Size(901, 804);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dgvProducts, 0);
            rightPanel.Controls.SetChildIndex(panel4, 0);
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
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(lblValue);
            panel4.Controls.Add(lblQuantity);
            panel4.Controls.Add(lblProducts);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(0, 760);
            panel4.Name = "panel4";
            panel4.Size = new Size(901, 44);
            panel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI Variable Display Semib", 16F);
            label4.Location = new Point(577, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 44);
            label4.TabIndex = 2;
            label4.Text = "Total Value";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.Font = new Font("Segoe UI Variable Display Semib", 16F);
            label3.Location = new Point(261, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 44);
            label3.TabIndex = 1;
            label3.Text = "Total Quantity";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Segoe UI Variable Display Semib", 16F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 44);
            label2.TabIndex = 0;
            label2.Text = "Total Products";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProducts
            // 
            lblProducts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblProducts.Font = new Font("Segoe UI Variable Display Semib", 16F);
            lblProducts.Location = new Point(170, 0);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(85, 44);
            lblProducts.TabIndex = 3;
            lblProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Bottom;
            lblQuantity.Font = new Font("Segoe UI Variable Display Semib", 16F);
            lblQuantity.Location = new Point(441, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(130, 44);
            lblQuantity.TabIndex = 4;
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValue
            // 
            lblValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblValue.Font = new Font("Segoe UI Variable Display Semib", 16F);
            lblValue.Location = new Point(711, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(184, 44);
            lblValue.TabIndex = 5;
            lblValue.Text = "0000000000000";
            lblValue.TextAlign = ContentAlignment.MiddleCenter;
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
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label lblValue;
        private Label lblQuantity;
        private Label lblProducts;
    }
}