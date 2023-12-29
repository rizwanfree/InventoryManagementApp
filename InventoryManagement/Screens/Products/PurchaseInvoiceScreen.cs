using InventoryManagement.Entities;
using InventoryManagement.Services;
using InventoryManagement.Services.ProductServices;
using InventoryManagement.Services.PurchaseService;
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
    public partial class PurchaseInvoiceScreen : Sample2
    {
        readonly VendorRepo _supplier = new VendorRepo();
        readonly ProductRepo _product = new ProductRepo();
        readonly ProductStockRepo _stockRepo = new ProductStockRepo();
        readonly PurchaseInvoiceRepo _purchase = new PurchaseInvoiceRepo();
        readonly PurchaseInvoiceDetailRepo _detail = new PurchaseInvoiceDetailRepo();

        public int PurchaseInvoiceID { get; set; }
        public int PurchaseInvoiceDetailsID { get; set; }
        public PurchaseInvoiceScreen()
        {
            InitializeComponent();
        }

        private void PurchaseInvoiceScreen_Load(object sender, EventArgs e)
        {
            MainClass.LoadDataToComboBox(cmbSupplier, _supplier.GetForComboBox());
            MainClass.LoadDataToComboBox(cmbProduct, _product.GetForComboBox());
            MainClass.DisableResetControls(leftPanel);

            if (this.isUpdate)
            {
                btnAdd.Enabled = false;
                LoadInvoiceDataToControls();        // Load Invoice Data to controls
                CalculateProductTotal(dgvList);     // Calculate Total
            }
        }

        private void LoadInvoiceDataToControls()
        {
            DataRow dr = _purchase.GetSingle(PurchaseInvoiceID);

            dtInvoiceDate.Value = Convert.ToDateTime(dr["InvoiceDate"]);
            txtBNumber.Text = dr["BillNumber"].ToString();
            cmbSupplier.SelectedValue = Convert.ToInt32(dr["VendorID"]);

            // Load Details from Sell Details Table

            DataTable dt = _detail.GetByID(PurchaseInvoiceID);
            foreach (DataRow row in dt.Rows)
            {
                int productID = Convert.ToInt32(row["ProductID"]);
                decimal quantity = Convert.ToDecimal(row["Quantity"]);
                decimal price = Convert.ToDecimal(row["Rate"]);
                int total = Convert.ToInt32(row["Total"]);
                string productName = row["ProductName"].ToString();

                dgvList.Rows.Add(productID, productName, price, quantity, total);
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableResetControls(leftPanel);
            MainClass.EnableResetControls(PurchaseScreenRightPanel);
            this.isUpdate = false;
            txtBNumber.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Update Invoice
            MainClass.EnableControls(leftPanel);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {            
            if (isUpdate)
            {
                UpdateInvoice();
            }
            else
            {
                // Save Purchase Invoice

                _purchase.InsertRecord(GetPurchaseInvoiceObjects());

                // Get Last Purchase Invoice ID from Database
                int lastPurchseInvoiceID = _purchase.GetLastInvoiceID();

                // Save Purchase Invoice Details by looping through data grid
                InsertPurchaseInvoiceDetails(lastPurchseInvoiceID);

                // Update Stock
                UpdateStock();

                // TODO: handle Expenses

                // TODO: handle Ledger system
            }

            MainClass.DisableResetControls(leftPanel);
            MainClass.DisableResetControls(PurchaseScreenRightPanel);
            dgvList.Rows.Clear();
            this.PurchaseInvoiceDetailsID = 0;
            this.PurchaseInvoiceID = 0;
            this.isUpdate=false;

        }

        private void UpdateInvoice()
        {
            // Update Stock by adding all items to stock
            UpdateStockReturnItem();

            // Delete Old Records
            _detail.DeleteRecord(this.PurchaseInvoiceID);

            // Insert Record again
            InsertPurchaseInvoiceDetails(this.PurchaseInvoiceID);

            // Update Stock
            UpdateStock();

            this.isUpdate = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void UpdateStockReturnItem()
        {
            // Get All products from Sell Invoice Details
            DataTable dt = _detail.GetByID(this.PurchaseInvoiceID);
            // Loop thru table and update stock by adding product quantities
            foreach (DataRow row in dt.Rows)
            {
                int productID = Convert.ToInt32(row["ProductID"]);
                decimal quantity = Convert.ToDecimal(row["Quantity"]);
                string updateDate = DateTime.Now.ToShortDateString();

                // Get Stock from Stock Table
                decimal stock = _stockRepo.GetStock(productID);
                decimal newStock = stock - quantity;

                // Update Stock
                List<DBParameter> paras = new List<DBParameter>();
                paras.Add(new DBParameter { Parameter = "@ProductID", Value = productID });
                paras.Add(new DBParameter { Parameter = "@UpdateDate", Value = DateTime.Now.ToShortDateString() });
                paras.Add(new DBParameter { Parameter = "@InStock", Value = newStock });
                _stockRepo.UpdateStockSell(paras.ToArray());
            }
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
                decimal rate = Convert.ToDecimal(row.Cells["Price"].Value);
                decimal newStock = quantity + oldStock;
                
                DBParameter pid = new DBParameter(){ Parameter = "@ProductID", Value = productID};
                DBParameter uDate = new DBParameter() { Parameter = "@UpdateDate", Value = updateDate };
                DBParameter ratePara = new DBParameter() { Parameter = "@Rate", Value = rate};
                DBParameter updatedStock = new DBParameter() { Parameter = "@InStock", Value = newStock};

                List<DBParameter> paras = new List<DBParameter>();
                paras.Add(pid);
                paras.Add(uDate);
                paras.Add(updatedStock);
                paras.Add(ratePara);
                _stockRepo.UpdateStock(paras.ToArray());
            }
        }

        private void InsertPurchaseInvoiceDetails(int lastPurchseInvoiceID)
        {
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                // Insert Records in Invoice Details Table
                _detail.InsertRecord(GetInvoiceDetailObjects(row, lastPurchseInvoiceID));
            }
        }

        private object GetInvoiceDetailObjects(DataGridViewRow row, int lastPurchseInvoiceID)
        {
            PurchaseInvoiceDetail p = new PurchaseInvoiceDetail();
            p.PurchaseInvoiceDetailID = this.isUpdate ? this.PurchaseInvoiceDetailsID : 0;
            p.PurchaseInvoiceID = lastPurchseInvoiceID;
            p.ProductID = Convert.ToInt32(row.Cells["ID"].Value);
            p.Quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
            p.Rate = Convert.ToDecimal(row.Cells["Price"].Value);
            p.Total = Convert.ToDecimal(row.Cells["Total"].Value);
            return p;
        }

        private object GetPurchaseInvoiceObjects()
        {
            PurchaseInvoice p = new PurchaseInvoice();
            p.PurchaseInvoiceID = this.isUpdate ? this.PurchaseInvoiceID : 0;
            p.VendorID = Convert.ToInt32(cmbSupplier.SelectedValue);
            p.BillNumber = txtBNumber.Text;
            p.InvoiceDate = dtInvoiceDate.Value.ToShortDateString();
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
                    int productID = Convert.ToInt32(cmbProduct.SelectedValue);
                    decimal qtyFeet = Convert.ToDecimal(txtQuantity.Text);
                    decimal price = Convert.ToDecimal(txtPrice.Text);
                    decimal kg = Convert.ToDecimal(txtQuantity.Text);
                    int total = Convert.ToInt32(qtyFeet * price);
                    dgvList.Rows.Add(productID, product, price, kg, total);
                    int suppID = Convert.ToInt32(cmbSupplier.SelectedValue);
                    ClearFields();
                    
                    //MainClass.EnableResetControls(leftPanel);
                    cmbSupplier.SelectedValue = suppID;
                    cmbProduct.Focus();

                    CalculateProductTotal(dgvList);
                }
            }
        }

        private void ClearFields()
        {
            txtQuantity.Clear();
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
    }
}
