using InventoryManagement.Entities;
using InventoryManagement.Services.CustomerService;
using InventoryManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagement.Screens.Customers
{
    public partial class CustomerScreen : Sample2
    {
        public int CustomerID { get; set; }
        readonly CustomerRepo _customer = new();
        readonly CustomerLedgerRepo _ledger = new();
        public CustomerScreen()
        {
            InitializeComponent();
        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            MainClass.DisableResetControls(leftPanel);
            LoadCustomersToDataGrid();

        }

        private void LoadCustomersToDataGrid()
        {
            MainClass.LoadDataToDataGrid(dgvCustomer, _customer.GetAll());
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            this.isUpdate = false;
            this.CustomerID = -1;
            MainClass.EnableResetControls(leftPanel);
            txtCustomerName.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.CustomerID >= 0)
            {
                this.isUpdate = true;
                MainClass.EnableControls(leftPanel);
                txtCustomerName.Focus();
            }
            else
            {
                MessageBox.Show("Select Supplier From List");
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isUpdate)
                {
                    _customer.UpdateRecord(GetObjects());
                }
                else
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        _customer.InsertRecord(GetObjects());
                        int lastCustomerID = Convert.ToInt32(_customer.GetLastID());    // Get Last Record ID from Database
                        _ledger.InsertRecord(GetLedgerObjects(lastCustomerID));
                        btnAdd.Focus();
                        ts.Complete();
                    }
                }
                this.isUpdate = false;
                this.CustomerID = -1;
                MainClass.DisableResetControls(leftPanel);
                LoadCustomersToDataGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private object GetLedgerObjects(int customerID)
        {
            CustomerLedger c = new CustomerLedger();
            c.TransactionID = 0;
            c.TransactionDate = dtOpeningBalanceDate.Text;
            c.CustomerID = customerID;
            c.Particular = "Opening Balance";

            int debit = txtOpeningBalance.Text == string.Empty ? 0 : Convert.ToInt32(txtOpeningBalance.Text);
            int credit = txtOpeningBalance.Text == string.Empty ? 0 : Convert.ToInt32(txtOpeningBalance.Text); ;
            string drcr = string.Empty;
            if (debit >= 0) { credit = 0; drcr = "DR"; }
            else { debit = 0; drcr = "CR"; }
            c.Debit = debit;
            c.Credit = credit;
            c.Reff = string.Empty;
            c.DRCR = drcr;
            return c;
            
        }

        private object GetObjects()
        {
            Customer v = new Customer();
            v.CustomerID = this.isUpdate ? this.CustomerID : 0;
            v.CustomerName = txtCustomerName.Text.ToUpper().Trim();
            v.ContactPerson = txtContactPerson.Text.ToUpper().Trim();
            v.Phone = txtPhone.Text.ToUpper().Trim();
            v.Mobile = txtMobile.Text.ToUpper().Trim();
            v.Address = txtAddress.Text.ToUpper().Trim();
            v.NTN = txtNTN.Text.ToUpper().Trim();
            v.GST = txtGST.Text.ToUpper().Trim();
            return v;
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Really Delete this Customer ?", "Deletion", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                _customer.DeleteRecord(this.CustomerID);
                LoadCustomersToDataGrid();
            }
        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = _customer.GetByName(textBox1.Text);
            MainClass.LoadDataToDataGrid(dgvCustomer, dt);
        }

        private void LoadCustomerDataToControls(int id)
        {
            DataRow dr = _customer.GetSingle(id);
            if (dr != null)
            {
                txtCustomerName.Text = dr["Customer Name"].ToString();
                txtContactPerson.Text = dr["Contact Person"].ToString();
                txtGST.Text = dr["GST"].ToString();
                txtMobile.Text = dr["Mobile"].ToString();
                txtNTN.Text = dr["NTN"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtAddress.Text = dr["Address"].ToString();
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = dgvCustomer.CurrentRow.Index;
            this.CustomerID = Convert.ToInt32(dgvCustomer.Rows[rowID].Cells["ID"].Value);
            LoadCustomerDataToControls(CustomerID);
        }
    }
}
