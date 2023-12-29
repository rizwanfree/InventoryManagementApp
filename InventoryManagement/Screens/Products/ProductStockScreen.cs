using InventoryManagement.Services.ProductServices;
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

namespace InventoryManagement.Screens.Products
{
    public partial class ProductStockScreen : Sample2
    {
        readonly ProductStockRepo _stock = new ProductStockRepo();
        public ProductStockScreen()
        {
            InitializeComponent();
        }

        private void ProductStockScreen_Load(object sender, EventArgs e)
        {
            LoadProductToDataGrid();
            CalculateStock();
        }

        private void CalculateStock()
        {
            int products = dgvProducts.RowCount;
            decimal quantity = 0;
            int value = 0;
            foreach (DataGridViewRow r in dgvProducts.Rows)
            {
                quantity += Convert.ToDecimal(r.Cells["Quantity At Hand"].Value);
                value += Convert.ToInt32(r.Cells["Value"].Value);
            }
            lblProducts.Text = products.ToString();
            lblQuantity.Text = quantity.ToString() + " KG";
            lblValue.Text = "Rs. " + value.ToString();
        }

        private void LoadProductToDataGrid()
        {
            MainClass.LoadDataToDataGrid(dgvProducts, _stock.GetAll());
            dgvProducts.Columns["Value"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {

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
            MainClass.LoadDataToDataGrid(dgvProducts, _stock.GetByName(textBox1.Text.Trim()));
        }
    }
}
