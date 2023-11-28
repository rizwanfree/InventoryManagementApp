using InventoryManagement.Services;
using InventoryManagement.Services.ProductServices;
using InventoryManagement.Services.VendorServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace InventoryManagement.Screens.Products
{
    public partial class PurchaseInvoiceScreen : Sample2
    {
        readonly ICRUD _supplier = new VendorRepo();
        readonly ICRUD _product = new ProductRepo();
        public PurchaseInvoiceScreen()
        {
            InitializeComponent();
        }

        private void PurchaseInvoiceScreen_Load(object sender, EventArgs e)
        {
            MainClass.LoadDataToComboBox(cmbSupplier, _supplier.GetForComboBox());
            MainClass.LoadDataToComboBox(cmbProduct, _product.GetForComboBox());
        }

        private void cmbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbProduct.SelectedValue);
            GetProductInfo(id);
        }

        private void GetProductInfo(int id)
        {
            var dr = _product.GetSingle(id);
            txtFoot.Text = dr["KG Per Foot"].ToString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal quantity = Convert.ToDecimal(txtQuantity.Text);
                decimal kgft = Convert.ToDecimal(txtFoot.Text);
                decimal quantityInKG = quantity * kgft;
                txtKG.Text = quantityInKG.ToString();
            }
            catch (Exception)
            {                
                txtQuantity.Clear();                               
            }
        }
    }
}
