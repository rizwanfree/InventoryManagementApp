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
    }
}
