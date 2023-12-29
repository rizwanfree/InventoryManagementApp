namespace InventoryManagement.Screens.Searches
{
    partial class PurchaseInvoicesListScreen
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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Size = new Size(1035, 56);
            // 
            // SellInvoicesListScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 695);
            ControlBox = false;
            Name = "SellInvoicesListScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sell Invoices List";
            Load += PurchaseInvoicesListScreen_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}