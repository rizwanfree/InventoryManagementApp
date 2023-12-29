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
    public partial class BalanceScreenTemplate : Form
    {
        public BalanceScreenTemplate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void BalanceScreenTemplate_Load(object sender, EventArgs e)
        {

        }

        public virtual void chkAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        public virtual void btnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
