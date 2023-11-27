namespace InventoryManagement.Screens
{
    partial class UserScreen
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
            label3 = new Label();
            txtName = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            panel4 = new Panel();
            dgvUsers = new DataGridView();
            cmbStatus = new ComboBox();
            label8 = new Label();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Size = new Size(889, 65);
            // 
            // textBox1
            // 
            textBox1.Size = new Size(285, 29);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(cmbStatus);
            leftPanel.Controls.Add(panel4);
            leftPanel.Controls.Add(txtEmail);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(txtPhone);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(txtPassword);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(txtUsername);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(txtName);
            leftPanel.Controls.Add(label3);
            leftPanel.Size = new Size(300, 706);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(txtName, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(txtUsername, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(txtPassword, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(txtPhone, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(txtEmail, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(cmbStatus, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvUsers);
            rightPanel.Size = new Size(889, 706);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dgvUsers, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(889, 56);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 162);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 25);
            txtName.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 212);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(274, 25);
            txtUsername.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 190);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(274, 25);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 240);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 312);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(274, 25);
            txtPhone.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 290);
            label6.Name = "label6";
            label6.Size = new Size(154, 19);
            label6.TabIndex = 8;
            label6.Text = "Phone (03XX-XXXXXX)";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 362);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 25);
            txtEmail.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 340);
            label7.Name = "label7";
            label7.Size = new Size(43, 19);
            label7.TabIndex = 10;
            label7.Text = "Email";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 65);
            panel4.TabIndex = 11;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 121);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(889, 585);
            dgvUsers.TabIndex = 2;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "In-Active" });
            cmbStatus.Location = new Point(12, 412);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(274, 25);
            cmbStatus.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 390);
            label8.Name = "label8";
            label8.Size = new Size(48, 19);
            label8.TabIndex = 13;
            label8.Text = "Status";
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 706);
            Name = "UserScreen";
            Text = "Users";
            Load += UserScreen_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEmail;
        private Label label7;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private Panel panel4;
        private DataGridView dgvUsers;
        private Label label8;
        private ComboBox cmbStatus;
    }
}