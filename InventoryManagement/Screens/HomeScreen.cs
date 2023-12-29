using InventoryManagement.Screens.Categories;
using InventoryManagement.Screens.Customers;
using InventoryManagement.Screens.Products;
using InventoryManagement.Screens.Searches;
using InventoryManagement.Screens.Vendors;
using InventoryManagement.Services;
using InventoryManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Screens
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserScreen u = new UserScreen();
            MainClass.ShowWindow(u, this, MDI.ActiveForm);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductScreen p = new ProductScreen();
            MainClass.ShowWindow(p, this, MDI.ActiveForm);
        }

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            CatagoryScreen c = new CatagoryScreen();
            MainClass.ShowWindow(c, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            ((MDI)MdiParent).myMenu.Visible = true;
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            VendorScreen v = new VendorScreen();
            MainClass.ShowWindow(v, this, MDI.ActiveForm);
        }

        private void btnPurchaseInvoice_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceScreen p = new PurchaseInvoiceScreen();
            MainClass.ShowWindow(p, this, MDI.ActiveForm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerScreen c = new CustomerScreen();
            MainClass.ShowWindow(c, this, MDI.ActiveForm);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ProductStockScreen p = new ProductStockScreen();
            MainClass.ShowWindow(p, this, MDI.ActiveForm);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SellInvoiceScreen s = new SellInvoiceScreen();
            MainClass.ShowWindow(s, this, MDI.ActiveForm);
        }

        private void btnSearchSellInvoices_Click(object sender, EventArgs e)
        {
            using (SellInvoicesListScreen s = new SellInvoicesListScreen())
            {
                s.title = "Customer Invoices";
                s.btnSearchText = "Search By Customer";
                var result = s.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SellInvoiceScreen sell = new SellInvoiceScreen();
                    sell.SellInvoiceID = s.InvoiceID;
                    sell.isUpdate = true;
                    MainClass.ShowWindow(sell, this, MDI.ActiveForm);
                }
            }
        }

        private void btnSearchPurchaseInvoices_Click(object sender, EventArgs e)
        {
            using (PurchaseInvoicesListScreen s = new PurchaseInvoicesListScreen())
            {
                s.title = "Purchase Invoices";
                s.btnSearchText = "Search By Vendor";
                var result = s.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PurchaseInvoiceScreen p = new PurchaseInvoiceScreen();
                    p.PurchaseInvoiceID = s.InvoiceID;
                    p.isUpdate = true;
                    MainClass.ShowWindow(p, this, MDI.ActiveForm);
                }
            }
        }
    }
}
