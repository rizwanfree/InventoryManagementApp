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
using System.Windows.Forms;

namespace InventoryManagement.Screens.Accounts
{
    public partial class CustomerBalanceScreen : BalanceScreenTemplate
    {
        readonly private CustomerRepo _customer = new CustomerRepo();
        readonly private CustomerLedgerRepo _ledger = new CustomerLedgerRepo();
        public CustomerBalanceScreen()
        {
            InitializeComponent();
        }

        private void CustomerBalanceScreen_Load(object sender, EventArgs e)
        {
            MainClass.LoadDataToComboBox(cmbAccounts, _customer.GetForComboBox());
            //int ind = cmbAccounts.Items.IndexOf("HAMZA");
            //cmbAccounts.Items.RemoveAt(ind);
        }

        public override void btnShowBalance_Click(object sender, EventArgs e)
        {
            dgvAccount.Rows.Clear();
            int customerID = Convert.ToInt32(cmbAccounts.SelectedValue);
            if (chkAll.Checked)
            {                
                DataTable dt = _ledger.GetRecordsByCustomerID(customerID);
                LoadAllTransaction(dt, 0);
            }
            else
            {
                var fromDate = dtFrom.Value.ToShortDateString();
                var endDate = dtTo.Value.ToShortDateString();

                DataRow prevoiousBalanceDR = _ledger.GetPreviousBalance(fromDate, customerID);                
                LoadPreviousBalanceTransaction(prevoiousBalanceDR);
                DataTable dt = _ledger.GetRecordsByCustomerIDAndDate(customerID, fromDate, endDate);
                int balance = prevoiousBalanceDR["Balance"].ToString() == string.Empty ? 0 : Convert.ToInt32(prevoiousBalanceDR["Balance"]);
                LoadAllTransaction(dt, balance);
            }
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            int debit = 0;
            int credit = 0;
            int balance = 0;

            foreach (DataGridViewRow row in dgvAccount.Rows)
            {
                int rowDebit = row.Cells["Debit"].Value.ToString() == string.Empty ? 0 : Convert.ToInt32(row.Cells["Debit"].Value);
                int rowCredit = row.Cells["Credit"].Value.ToString() == string.Empty ? 0 : Convert.ToInt32(row.Cells["Credit"].Value);

                debit += rowDebit;
                credit += rowCredit;
            }
            balance = debit - credit;
            lblDebit.Text = debit.ToString();
            lblCredit.Text = credit.ToString();
            lblBalance.Text = balance.ToString();
        }

        private void LoadPreviousBalanceTransaction(DataRow dr)
        {
            var balance = dr["Balance"];
            var particular = dr["Particular"].ToString();

            dgvAccount.Rows.Add("", particular, "", "", balance);
        }

        private void LoadAllTransaction(DataTable dt, int openingBalance)
        {
            int balance = openingBalance;
            foreach (DataRow dr in dt.Rows)
            {
                var date = dr["Date"].ToString();
                var particular = dr["Particular"].ToString();
                var debit = dr["Debit"].ToString() == string.Empty ? 0.ToString() : dr["Debit"].ToString();
                var credit = dr["Credit"].ToString() == string.Empty ? 0.ToString() : dr["Credit"].ToString();
                var tBalance = Convert.ToInt32(debit) - Convert.ToInt32(credit);
                balance += tBalance;

                dgvAccount.Rows.Add(date, particular, debit, credit, balance);
            }
        }
    }
}
