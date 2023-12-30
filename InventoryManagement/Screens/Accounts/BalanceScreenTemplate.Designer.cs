namespace InventoryManagement.Screens
{
    partial class BalanceScreenTemplate
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            cmbAccounts = new ComboBox();
            label4 = new Label();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            chkAll = new CheckBox();
            btnShowBalance = new Button();
            panel2 = new Panel();
            dgvAccount = new DataGridView();
            TransactionDate = new DataGridViewTextBoxColumn();
            Particular = new DataGridViewTextBoxColumn();
            Debit = new DataGridViewTextBoxColumn();
            Credit = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnExit = new Button();
            panel4 = new Panel();
            lblDebit = new Label();
            lblBalance = new Label();
            lblCredit = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 67);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Variable Display Semib", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(979, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Balance";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5579567F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.44204F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 623F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbAccounts, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(dtFrom, 1, 1);
            tableLayoutPanel1.Controls.Add(dtTo, 1, 2);
            tableLayoutPanel1.Controls.Add(chkAll, 2, 1);
            tableLayoutPanel1.Controls.Add(btnShowBalance, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 67);
            tableLayoutPanel1.Margin = new Padding(3, 10, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(979, 105);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 1;
            label3.Text = "From";
            // 
            // cmbAccounts
            // 
            tableLayoutPanel1.SetColumnSpan(cmbAccounts, 2);
            cmbAccounts.FormattingEnabled = true;
            cmbAccounts.Location = new Point(90, 3);
            cmbAccounts.Name = "cmbAccounts";
            cmbAccounts.Size = new Size(391, 28);
            cmbAccounts.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 76);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 3;
            label4.Text = "To";
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(90, 37);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(246, 27);
            dtFrom.TabIndex = 4;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(90, 71);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(246, 27);
            dtTo.TabIndex = 5;
            // 
            // chkAll
            // 
            chkAll.Anchor = AnchorStyles.Left;
            chkAll.AutoSize = true;
            chkAll.CheckAlign = ContentAlignment.MiddleRight;
            chkAll.Location = new Point(358, 39);
            chkAll.Name = "chkAll";
            chkAll.Size = new Size(138, 24);
            chkAll.TabIndex = 7;
            chkAll.Text = "All Transactions";
            chkAll.UseVisualStyleBackColor = true;
            chkAll.CheckedChanged += chkAll_CheckedChanged;
            // 
            // btnShowBalance
            // 
            btnShowBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnShowBalance.Location = new Point(358, 71);
            btnShowBalance.Name = "btnShowBalance";
            btnShowBalance.Size = new Size(138, 31);
            btnShowBalance.TabIndex = 8;
            btnShowBalance.Text = "Submit";
            btnShowBalance.UseVisualStyleBackColor = true;
            btnShowBalance.Click += btnShowBalance_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAccount);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 595);
            panel2.TabIndex = 2;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { TransactionDate, Particular, Debit, Credit, Balance });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvAccount.DefaultCellStyle = dataGridViewCellStyle12;
            dgvAccount.Dock = DockStyle.Fill;
            dgvAccount.Location = new Point(0, 0);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersVisible = false;
            dgvAccount.Size = new Size(979, 595);
            dgvAccount.TabIndex = 0;
            // 
            // TransactionDate
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TransactionDate.DefaultCellStyle = dataGridViewCellStyle8;
            TransactionDate.FillWeight = 125F;
            TransactionDate.HeaderText = "Date";
            TransactionDate.Name = "TransactionDate";
            TransactionDate.ReadOnly = true;
            TransactionDate.Width = 125;
            // 
            // Particular
            // 
            Particular.FillWeight = 385F;
            Particular.HeaderText = "Particular";
            Particular.Name = "Particular";
            Particular.ReadOnly = true;
            Particular.Width = 385;
            // 
            // Debit
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            Debit.DefaultCellStyle = dataGridViewCellStyle9;
            Debit.FillWeight = 150F;
            Debit.HeaderText = "Debit";
            Debit.Name = "Debit";
            Debit.ReadOnly = true;
            Debit.Width = 150;
            // 
            // Credit
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            Credit.DefaultCellStyle = dataGridViewCellStyle10;
            Credit.FillWeight = 150F;
            Credit.HeaderText = "Credit";
            Credit.Name = "Credit";
            Credit.ReadOnly = true;
            Credit.Width = 150;
            // 
            // Balance
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            Balance.DefaultCellStyle = dataGridViewCellStyle11;
            Balance.FillWeight = 150F;
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            Balance.Width = 150;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 725);
            panel3.Name = "panel3";
            panel3.Size = new Size(979, 42);
            panel3.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(855, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 37);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(lblDebit);
            panel4.Controls.Add(lblBalance);
            panel4.Controls.Add(lblCredit);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Bottom;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(0, 683);
            panel4.Name = "panel4";
            panel4.Size = new Size(979, 42);
            panel4.TabIndex = 4;
            // 
            // lblDebit
            // 
            lblDebit.Font = new Font("Segoe UI Variable Display Semib", 14F, FontStyle.Bold);
            lblDebit.Location = new Point(529, 9);
            lblDebit.Name = "lblDebit";
            lblDebit.Size = new Size(151, 26);
            lblDebit.TabIndex = 1;
            lblDebit.Text = "0";
            lblDebit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI Variable Display Semib", 14F, FontStyle.Bold);
            lblBalance.Location = new Point(843, 9);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(133, 26);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCredit
            // 
            lblCredit.Font = new Font("Segoe UI Variable Display Semib", 14F, FontStyle.Bold);
            lblCredit.Location = new Point(686, 9);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(151, 26);
            lblCredit.TabIndex = 2;
            lblCredit.Text = "0";
            lblCredit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 26);
            label1.TabIndex = 0;
            label1.Text = "Total";
            // 
            // BalanceScreenTemplate
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(979, 767);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "BalanceScreenTemplate";
            StartPosition = FormStartPosition.CenterScreen;
            Load += BalanceScreenTemplate_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        public ComboBox cmbAccounts;
        public DateTimePicker dtFrom;
        public DateTimePicker dtTo;
        public DataGridView dgvAccount;
        public Label lblTitle;
        private Panel panel4;
        private Label label1;
        public CheckBox chkAll;
        public Button btnExit;
        public Panel panel3;
        public Label lblBalance;
        public Label lblCredit;
        public Label lblDebit;
        public TableLayoutPanel tableLayoutPanel1;
        public Button btnShowBalance;
        private DataGridViewTextBoxColumn TransactionDate;
        private DataGridViewTextBoxColumn Particular;
        private DataGridViewTextBoxColumn Debit;
        private DataGridViewTextBoxColumn Credit;
        private DataGridViewTextBoxColumn Balance;
    }
}