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

        public int PurchaseInvoiceID { get; set; }
        public PurchaseInvoiceScreen()
        {
            InitializeComponent();
        }

        private void PurchaseInvoiceScreen_Load(object sender, EventArgs e)
        {
            MainClass.LoadDataToComboBox(cmbSupplier, _supplier.GetForComboBox());
            MainClass.LoadDataToComboBox(cmbProduct, _product.GetForComboBox());
            MainClass.DisableResetControls(leftPanel);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableResetControls(leftPanel);
            this.isUpdate = false;
            cmbSupplier.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {

        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                string product = cmbProduct.Text;
                decimal qtyFeet = Convert.ToDecimal(txtQuantity.Text);
                decimal price = Convert.ToDecimal(txtPrice.Text);
                decimal kg = Convert.ToDecimal(txtKG.Text);
                int total = Convert.ToInt32(qtyFeet * price);
                dgvList.Rows.Add("", product, qtyFeet, price, kg, total);
                MainClass.EnableResetControls(leftPanel);
                cmbProduct.Focus();
            }

        }

        private bool IsValidated()
        {
            if (cmbProduct.SelectedIndex == -1)
            {
                return false;
            }
            if (txtQuantity.Text == string.Empty) return false;
            if (txtPrice.Text == string.Empty) { return false; }
            if (txtKG.Text == string.Empty) return false;


            return true;
        }
    }
}
