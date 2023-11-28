namespace InventoryManagement.Screens.Vendors
{
    partial class VendorScreen
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
            label2 = new Label();
            txtVendorName = new TextBox();
            txtContactPerson = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtMobile = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtNTN = new TextBox();
            label7 = new Label();
            txtGST = new TextBox();
            label8 = new Label();
            dgvVendor = new DataGridView();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendor).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Size = new Size(880, 65);
            // 
            // textBox1
            // 
            textBox1.Size = new Size(284, 29);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(txtGST);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(txtNTN);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(txtAddress);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(txtMobile);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(txtPhone);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(txtContactPerson);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(txtVendorName);
            leftPanel.Controls.Add(label2);
            leftPanel.Controls.Add(panel4);
            leftPanel.Size = new Size(300, 749);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(txtVendorName, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(txtContactPerson, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(txtPhone, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(txtMobile, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(txtAddress, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(txtNTN, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(txtGST, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvVendor);
            rightPanel.Size = new Size(880, 749);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dgvVendor, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(880, 56);
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 65);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 124);
            label2.Name = "label2";
            label2.Size = new Size(167, 19);
            label2.TabIndex = 2;
            label2.Text = "Supplier Name/Company";
            // 
            // txtVendorName
            // 
            txtVendorName.Location = new Point(9, 149);
            txtVendorName.Name = "txtVendorName";
            txtVendorName.Size = new Size(282, 25);
            txtVendorName.TabIndex = 3;
            // 
            // txtContactPerson
            // 
            txtContactPerson.Location = new Point(9, 199);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(282, 25);
            txtContactPerson.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 177);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 4;
            label3.Text = "Contact Person";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(9, 249);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(282, 25);
            txtPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 227);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 6;
            label4.Text = "Phone #";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(9, 299);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(282, 25);
            txtMobile.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 277);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 8;
            label5.Text = "Mobile #";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(9, 349);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(282, 82);
            txtAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 327);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // txtNTN
            // 
            txtNTN.Location = new Point(9, 461);
            txtNTN.Name = "txtNTN";
            txtNTN.Size = new Size(282, 25);
            txtNTN.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 434);
            label7.Name = "label7";
            label7.Size = new Size(50, 19);
            label7.TabIndex = 12;
            label7.Text = "NTN #";
            // 
            // txtGST
            // 
            txtGST.Location = new Point(9, 511);
            txtGST.Name = "txtGST";
            txtGST.Size = new Size(282, 25);
            txtGST.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 489);
            label8.Name = "label8";
            label8.Size = new Size(46, 19);
            label8.TabIndex = 14;
            label8.Text = "GST #";
            // 
            // dgvVendor
            // 
            dgvVendor.AllowUserToAddRows = false;
            dgvVendor.AllowUserToDeleteRows = false;
            dgvVendor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendor.BackgroundColor = Color.White;
            dgvVendor.BorderStyle = BorderStyle.None;
            dgvVendor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendor.Dock = DockStyle.Fill;
            dgvVendor.Location = new Point(0, 121);
            dgvVendor.MultiSelect = false;
            dgvVendor.Name = "dgvVendor";
            dgvVendor.ReadOnly = true;
            dgvVendor.RowHeadersVisible = false;
            dgvVendor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendor.Size = new Size(880, 628);
            dgvVendor.TabIndex = 2;
            dgvVendor.CellClick += dgvVendor_CellClick;
            // 
            // VendorScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 749);
            Name = "VendorScreen";
            Text = "VendorScreen";
            Load += VendorScreen_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVendor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPhone;
        private Label label4;
        private TextBox txtContactPerson;
        private Label label3;
        private TextBox txtVendorName;
        private Label label2;
        private Panel panel4;
        private TextBox txtGST;
        private Label label8;
        private TextBox txtNTN;
        private Label label7;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtMobile;
        private Label label5;
        private DataGridView dgvVendor;
    }
}