namespace InventoryManagement.Screens.Accounts
{
    partial class CustomerBalanceScreen
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
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Size = new Size(974, 67);
            // 
            // btnExit
            // 
            btnExit.Size = new Size(116, 37);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 710);
            panel3.Size = new Size(974, 42);
            // 
            // CustomerBalanceScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 752);
            Name = "CustomerBalanceScreen";
            Text = "CustomerBalanceScreen";
            Load += CustomerBalanceScreen_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}