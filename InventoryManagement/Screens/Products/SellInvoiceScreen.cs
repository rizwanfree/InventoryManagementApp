using InventoryManagement.Entities;
using InventoryManagement.Services;
using InventoryManagement.Services.CustomerService;
using InventoryManagement.Services.ProductServices;
using InventoryManagement.Services.SellService;
using InventoryManagement.Services.VendorServices;
using InventoryManagement.Utilities;
using RSDBCore;
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
    public partial class SellInvoiceScreen : Sample2
    {
        readonly CustomerRepo _customer = new CustomerRepo();
        readonly ProductRepo _product = new ProductRepo();
        readonly ProductStockRepo _stockRepo = new ProductStockRepo();
        readonly SellInvoiceRepo _sell = new SellInvoiceRepo();
        readonly SellInvoiceDetailRepo _detail = new SellInvoiceDetailRepo();

        public int SellInvoiceID { get; set; }
        public int SellInvoiceDetailsID { get; set; }
        public SellInvoiceScreen()
        {
            InitializeComponent();
        }

        private void SellInvoiceScreen_Load(object sender, EventArgs e)
        {
            MainClass.LoadDataToComboBox(cmbCustomer, _customer.GetForComboBox());
            MainClass.LoadDataToComboBox(cmbProduct, _product.GetForComboBox());
            MainClass.DisableResetControls(leftPanel);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableResetControls(leftPanel);
            MainClass.EnableResetControls(SellScreenRightPanel);
            this.isUpdate = false;
            txtBNumber.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Update Invoice
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {

            }
            else
            {
                // Save Sell Invoice

                _sell.InsertRecord(GetSellInvoiceObjects());

                // Get Last Sell Invoice ID from Database
                int lastsSellInvoiceID = _sell.GetLastInvoiceID();

                // Save Sell Invoice Details by looping through data grid
                InsertSellInvoiceDetails(lastsSellInvoiceID);

                // Update Stock
                UpdateStock();

                // TODO: handle Expenses

                // TODO: handle Ledger system
            }

            MainClass.DisableResetControls(leftPanel);
            //MainClass.DisableResetControls(SellScreenRightPanel);
            dgvList.Rows.Clear();
            this.SellInvoiceDetailsID = 0;
            this.SellInvoiceID = 0;
            this.isUpdate = false;

        }

        private void UpdateStock()
        {
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                // Insert Records in Invoice Details Table
                int productID = Convert.ToInt32(row.Cells["ID"].Value);
                decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                decimal oldStock = _stockRepo.GetStock(productID);

                string updateDate = DateTime.Now.ToString();
                decimal newStock = oldStock - quantity;

                DBParameter pid = new DBParameter() { Parameter = "@ProductID", Value = productID };
                DBParameter uDate = new DBParameter() { Parameter = "@UpdateDate", Value = updateDate };
                DBParameter updatedStock = new DBParameter() { Parameter = "@InStock", Value = newStock };

                List<DBParameter> paras = new List<DBParameter>();
                paras.Add(pid);
                paras.Add(uDate);
                paras.Add(updatedStock);
                _stockRepo.UpdateStock(paras.ToArray());
            }
        }

        private void InsertSellInvoiceDetails(int lastPurchseInvoiceID)
        {
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                // Insert Records in Invoice Details Table
                _detail.InsertRecord(GetInvoiceDetailObjects(row, lastPurchseInvoiceID));
            }
        }

        private object GetInvoiceDetailObjects(DataGridViewRow row, int lastPurchseInvoiceID)
        {
            SellInvoiceDetail p = new SellInvoiceDetail();
            p.SellInvoiceDetailID = this.isUpdate ? this.SellInvoiceDetailsID : 0;
            p.SellInvoiceID = lastPurchseInvoiceID;
            p.ProductID = Convert.ToInt32(row.Cells["ID"].Value);
            p.Quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
            p.Rate = Convert.ToDecimal(row.Cells["Price"].Value);
            p.Total = Convert.ToDecimal(row.Cells["Total"].Value);
            return p;
        }

        private object GetSellInvoiceObjects()
        {
            SellInvoice p = new SellInvoice();
            p.SellInvoiceID = this.isUpdate ? this.SellInvoiceID : 0;
            p.CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue);
            p.BillNumber = txtBNumber.Text;
            p.InvoiceDate = dtInvoiceDate.Value.ToString();
            return p;
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
            //GetProductStock(id);
        }

        private void GetProductInfo(int id)
        {
            DataRow dr = _product.GetSingle(id);
            if (dr != null)
            {
                decimal kgft = Convert.ToDecimal(dr["KG Per Foot"]);
                txtkgft.Text = kgft.ToString();
            }
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
                    int productID = Convert.ToInt32(cmbProduct.SelectedValue);
                    decimal qtyFeet = Convert.ToDecimal(txtQuantity.Text);
                    decimal qtyKG = Convert.ToDecimal(txtKG.Text);
                    decimal price = Convert.ToDecimal(txtPrice.Text);
                    decimal kg = Convert.ToDecimal(txtQuantity.Text);
                    int total = Convert.ToInt32(qtyFeet * price);
                    dgvList.Rows.Add(productID, product, price, kg, qtyKG, total);
                    int customerID = Convert.ToInt32(cmbCustomer.SelectedValue);
                    ClearFields();

                    //MainClass.EnableResetControls(leftPanel);
                    cmbCustomer.SelectedValue = customerID;
                    cmbProduct.Focus();

                    CalculateProductTotal(dgvList);
                }
            }
        }

        private void ClearFields()
        {
            txtQuantity.Clear();
            txtKG.Clear();
            txtkgft.Clear();
            txtPrice.Clear();
            cmbProduct.SelectedIndex = -1;
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
            CalculateProductTotal(dgvList);
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

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Length > 0 && txtkgft.Text.Length > 0 && Convert.ToDecimal(txtkgft.Text) > 0)
            {
                decimal ftQuantity = Convert.ToDecimal(txtQuantity.Text);
                decimal kgft = Convert.ToDecimal(txtkgft.Text);
                decimal kgQuantity = ftQuantity * kgft;
                txtKG.Text = kgQuantity.ToString();
            }
        }

        private void txtKG_TextChanged(object sender, EventArgs e)
        {
            if (txtKG.Text.Length > 0 && txtkgft.Text.Length > 0 && Convert.ToDecimal(txtkgft.Text) > 0)
            {
                decimal kgQuantity = Convert.ToDecimal(txtKG.Text);
                decimal kgft = Convert.ToDecimal(txtkgft.Text);
                decimal ftQuantity = kgQuantity / kgft;
                txtQuantity.Text = ftQuantity.ToString();
            }
        }
    }
}
