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
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                List<string> productsInDGV = new List<string>();
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    string p = row.Cells["Product"].Value.ToString();
                    productsInDGV.Add(p);
                }
                string product = cmbProduct.Text;
                if (productsInDGV.Contains(cmbProduct.Text))
                {
                    MessageBox.Show($"{product} Already in List");
                }
                else
                {
                    decimal qtyFeet = Convert.ToDecimal(txtQuantity.Text);
                    decimal price = Convert.ToDecimal(txtPrice.Text);
                    decimal kg = Convert.ToDecimal(txtQuantity.Text);
                    int total = Convert.ToInt32(qtyFeet * price);
                    dgvList.Rows.Add("", product, price, kg, total);
                    int suppID = Convert.ToInt32(cmbSupplier.SelectedValue);
                    MainClass.EnableResetControls(leftPanel);
                    cmbSupplier.SelectedValue = suppID;
                    cmbProduct.Focus();

                    CalculateProductTotal(dgvList);
                }
            }
        }

        private bool IsValidated()
        {
            if (cmbProduct.SelectedIndex == -1) { return false; }
            if (txtQuantity.Text == string.Empty) return false;
            if (txtPrice.Text == string.Empty) { return false; }
            if (txtQuantity.Text == string.Empty) return false;

            return true;
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int colID = dgvList.CurrentCell.ColumnIndex;
            if (dgvList.Columns[colID].Name == "btnRemove")
            {
                int rowID = dgvList.CurrentRow.Index;
                dgvList.Rows.RemoveAt(rowID);
            }
        }

        private void dgvList_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int colID = dgvList.CurrentCell.ColumnIndex;
                if (dgvList.Columns[colID].Name == "Price" || dgvList.Columns[colID].Name == "Quantity")
                {
                    int rowID = dgvList.CurrentRow.Index;
                    int rate = Convert.ToInt32(dgvList.Rows[rowID].Cells["Price"].Value);
                    int quantity = Convert.ToInt32(dgvList.Rows[rowID].Cells["Quantity"].Value);
                    int total = rate * quantity;
                    dgvList.Rows[rowID].Cells["Total"].Value = total;
                }
                CalculateProductTotal(dgvList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CalculateProductTotal(DataGridView dgv)
        {
            int total = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                total += Convert.ToInt32(row.Cells["Total"].Value);
            }
            txtProductTotal.Text = total.ToString();    
        }
    }
}
