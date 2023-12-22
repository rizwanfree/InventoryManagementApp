namespace InventoryManagement.Screens.Customers
{
    partial class CustomerScreen
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
            txtGST = new TextBox();
            label8 = new Label();
            txtNTN = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtMobile = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtContactPerson = new TextBox();
            label3 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            dtOpeningBalanceDate = new DateTimePicker();
            txtOpeningBalance = new TextBox();
            label9 = new Label();
            dgvCustomer = new DataGridView();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Size = new Size(999, 65);
            // 
            // textBox1
            // 
            textBox1.Size = new Size(323, 29);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(label10);
            leftPanel.Controls.Add(dtOpeningBalanceDate);
            leftPanel.Controls.Add(txtOpeningBalance);
            leftPanel.Controls.Add(label9);
            leftPanel.Controls.Add(panel4);
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
            leftPanel.Controls.Add(txtCustomerName);
            leftPanel.Controls.Add(label2);
            leftPanel.Size = new Size(300, 803);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(txtCustomerName, 0);
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
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(label9, 0);
            leftPanel.Controls.SetChildIndex(txtOpeningBalance, 0);
            leftPanel.Controls.SetChildIndex(dtOpeningBalanceDate, 0);
            leftPanel.Controls.SetChildIndex(label10, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvCustomer);
            rightPanel.Size = new Size(999, 803);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dgvCustomer, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(999, 56);
            // 
            // txtGST
            // 
            txtGST.Location = new Point(3, 515);
            txtGST.Name = "txtGST";
            txtGST.Size = new Size(282, 25);
            txtGST.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 493);
            label8.Name = "label8";
            label8.Size = new Size(46, 19);
            label8.TabIndex = 28;
            label8.Text = "GST #";
            // 
            // txtNTN
            // 
            txtNTN.Location = new Point(3, 465);
            txtNTN.Name = "txtNTN";
            txtNTN.Size = new Size(282, 25);
            txtNTN.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 438);
            label7.Name = "label7";
            label7.Size = new Size(50, 19);
            label7.TabIndex = 26;
            label7.Text = "NTN #";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(3, 353);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(282, 82);
            txtAddress.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 331);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 24;
            label6.Text = "Address";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(3, 303);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(282, 25);
            txtMobile.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 281);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 22;
            label5.Text = "Mobile #";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(3, 253);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(282, 25);
            txtPhone.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 231);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 20;
            label4.Text = "Phone #";
            // 
            // txtContactPerson
            // 
            txtContactPerson.Location = new Point(3, 203);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(282, 25);
            txtContactPerson.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 181);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 18;
            label3.Text = "Contact Person";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(3, 153);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(282, 25);
            txtCustomerName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 128);
            label2.Name = "label2";
            label2.Size = new Size(176, 19);
            label2.TabIndex = 16;
            label2.Text = "Customer Name/Company";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 65);
            panel4.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(163, 542);
            label10.Name = "label10";
            label10.Size = new Size(43, 19);
            label10.TabIndex = 34;
            label10.Text = "As Of";
            // 
            // dtOpeningBalanceDate
            // 
            dtOpeningBalanceDate.CustomFormat = "dd-MMM-yyyy";
            dtOpeningBalanceDate.Format = DateTimePickerFormat.Custom;
            dtOpeningBalanceDate.Location = new Point(163, 564);
            dtOpeningBalanceDate.Name = "dtOpeningBalanceDate";
            dtOpeningBalanceDate.Size = new Size(122, 25);
            dtOpeningBalanceDate.TabIndex = 33;
            // 
            // txtOpeningBalance
            // 
            txtOpeningBalance.Location = new Point(3, 564);
            txtOpeningBalance.Name = "txtOpeningBalance";
            txtOpeningBalance.Size = new Size(154, 25);
            txtOpeningBalance.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 542);
            label9.Name = "label9";
            label9.Size = new Size(125, 19);
            label9.TabIndex = 31;
            label9.Text = "Opening Balance #";
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(0, 121);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(999, 682);
            dgvCustomer.TabIndex = 3;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // CustomerScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 803);
            Name = "CustomerScreen";
            Text = "CustomerScreen";
            Load += CustomerScreen_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox txtGST;
        private Label label8;
        private TextBox txtNTN;
        private Label label7;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtMobile;
        private Label label5;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtContactPerson;
        private Label label3;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label10;
        private DateTimePicker dtOpeningBalanceDate;
        private TextBox txtOpeningBalance;
        private Label label9;
        private DataGridView dgvCustomer;
    }
}