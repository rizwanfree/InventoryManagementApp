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
            btnShow = new Button();
            panel2 = new Panel();
            dgvAccount = new DataGridView();
            panel3 = new Panel();
            btnExit = new Button();
            panel4 = new Panel();
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
            panel1.Size = new Size(961, 67);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Variable Display Semib", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(961, 67);
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
            tableLayoutPanel1.Controls.Add(btnShow, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 67);
            tableLayoutPanel1.Margin = new Padding(3, 10, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(961, 105);
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
            cmbAccounts.Location = new Point(86, 3);
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
            dtFrom.Location = new Point(86, 37);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(246, 27);
            dtFrom.TabIndex = 4;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(86, 71);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(246, 27);
            dtTo.TabIndex = 5;
            // 
            // chkAll
            // 
            chkAll.Anchor = AnchorStyles.Left;
            chkAll.AutoSize = true;
            chkAll.CheckAlign = ContentAlignment.MiddleRight;
            chkAll.Location = new Point(340, 39);
            chkAll.Name = "chkAll";
            chkAll.Size = new Size(138, 24);
            chkAll.TabIndex = 7;
            chkAll.Text = "All Transactions";
            chkAll.UseVisualStyleBackColor = true;
            chkAll.CheckedChanged += chkAll_CheckedChanged;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.Left;
            btnShow.DialogResult = DialogResult.OK;
            btnShow.Location = new Point(340, 73);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(138, 27);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show Account";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAccount);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 595);
            panel2.TabIndex = 2;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Dock = DockStyle.Fill;
            dgvAccount.Location = new Point(0, 0);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.Size = new Size(961, 595);
            dgvAccount.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 725);
            panel3.Name = "panel3";
            panel3.Size = new Size(961, 42);
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
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Bottom;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(0, 683);
            panel4.Name = "panel4";
            panel4.Size = new Size(961, 42);
            panel4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Total";
            // 
            // BalanceScreenTemplate
            // 
            AcceptButton = btnShow;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(961, 767);
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
        private TableLayoutPanel tableLayoutPanel1;
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
        public Button btnShow;
        public CheckBox chkAll;
        public Button btnExit;
        public Panel panel3;
    }
}