namespace InventoryManagement.Screens
{
    partial class Sample
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
            leftPanel = new Panel();
            panel1 = new Panel();
            rightPanel = new Panel();
            panel2 = new Panel();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.DarkSlateGray;
            leftPanel.Controls.Add(panel1);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.ForeColor = Color.White;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(300, 772);
            leftPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 56);
            panel1.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = SystemColors.Control;
            rightPanel.Controls.Add(panel2);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(300, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(909, 772);
            rightPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 56);
            panel2.TabIndex = 0;
            // 
            // Sample
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 772);
            ControlBox = false;
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Font = new Font("Segoe UI Variable Display Semib", 10F);
            Name = "Sample";
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel leftPanel;
        protected Panel panel1;
        protected Panel rightPanel;
        protected Panel panel2;
    }
}