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
    public partial class SearchTemplate : Form
    {
        public SearchTemplate()
        {
            InitializeComponent();
        }

        public virtual void btnSearchDate_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTemplate_Load(object sender, EventArgs e)
        {

        }

        public virtual void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
