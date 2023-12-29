using InventoryManagement.Screens.Products;
using InventoryManagement.Services.PurchaseService;
using InventoryManagement.Services.SellService;
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

namespace InventoryManagement.Screens.Searches
{
    public partial class PurchaseInvoicesListScreen : SearchTemplate
    {
        public string title { get; set; } = string.Empty;
        public string btnSearchText { get; set; } = string.Empty;
        public int InvoiceID { get; set; }

        readonly PurchaseInvoiceRepo _purchase = new PurchaseInvoiceRepo();
        public PurchaseInvoicesListScreen()
        {
            InitializeComponent();
        }

        private void PurchaseInvoicesListScreen_Load(object sender, EventArgs e)
        {
            lblTitle.Text = title;
            btnSearch.Text = btnSearchText;
        }

        public override void btnSearchDate_Click(object sender, EventArgs e)
        {
            string fromDate = dtFrom.Value.ToShortDateString();
            string toDate = dtTo.Value.ToShortDateString();
            MainClass.LoadDataToDataGrid(dgvList, _purchase.GetByDate(fromDate, toDate));

            AddButtonColumn();
        }

        public override void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvList.CurrentRow.Index;
            //int colIndex = dgvList.Columns.i
            if (dgvList.Columns[e.ColumnIndex].Name == "ActionButton")
            {
                int invoiceID = Convert.ToInt32(dgvList.Rows[rowIndex].Cells["ID"].Value);
                this.InvoiceID = invoiceID;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void AddButtonColumn()
        {
            var buttonCol = new DataGridViewButtonColumn()
            {
                Name = "ActionButton",
                UseColumnTextForButtonValue = false,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    NullValue = "Open",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            this.dgvList.Columns.Add(buttonCol);
        }

        public override void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            MainClass.LoadDataToDataGrid(dgvList, _purchase.GetByName(name));
            AddButtonColumn();
        }
    }
}
