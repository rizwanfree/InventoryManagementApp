namespace InventoryManagement.Screens
{
    partial class SearchTemplate
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
            panel1 = new Panel();
            lblTitle = new Label();
            panel2 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnSearchDate = new Button();
            dtTo = new DateTimePicker();
            label2 = new Label();
            dtFrom = new DateTimePicker();
            label1 = new Label();
            panel3 = new Panel();
            btnExit = new Button();
            dgvList = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 56);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1030, 56);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Search";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnSearchDate);
            panel2.Controls.Add(dtTo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtFrom);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 43);
            panel2.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(850, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(177, 30);
            btnSearch.TabIndex = 6;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(515, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(329, 29);
            txtSearch.TabIndex = 5;
            // 
            // btnSearchDate
            // 
            btnSearchDate.Location = new Point(372, 6);
            btnSearchDate.Name = "btnSearchDate";
            btnSearchDate.Size = new Size(137, 30);
            btnSearchDate.TabIndex = 4;
            btnSearchDate.Text = "Search By Date";
            btnSearchDate.UseVisualStyleBackColor = true;
            btnSearchDate.Click += btnSearchDate_Click;
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "dd-MM-yyyy";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(236, 7);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(130, 29);
            dtTo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 8);
            label2.Name = "label2";
            label2.Size = new Size(31, 26);
            label2.TabIndex = 2;
            label2.Text = "To";
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "dd-MM-yyyy";
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(65, 7);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(130, 29);
            dtFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 8);
            label1.Name = "label1";
            label1.Size = new Size(56, 26);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 639);
            panel3.Name = "panel3";
            panel3.Size = new Size(1030, 61);
            panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(906, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 43);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Dock = DockStyle.Fill;
            dgvList.Location = new Point(0, 99);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(1030, 540);
            dgvList.TabIndex = 3;
            dgvList.CellClick += dgvList_CellClick;
            // 
            // SearchTemplate
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 700);
            Controls.Add(dgvList);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SearchTemplate";
            Load += SearchTemplate_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label lblTitle;
        private Panel panel2;
        public DateTimePicker dtFrom;
        public Label label1;
        public Button btnSearch;
        public TextBox txtSearch;
        public Button btnSearchDate;
        public DateTimePicker dtTo;
        public Label label2;
        private Panel panel3;
        public DataGridView dgvList;
        private Button btnExit;
    }
}