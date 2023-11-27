﻿using InventoryManagement.Entities;
using InventoryManagement.Services;
using InventoryManagement.Services.CategoryServices;
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
    public partial class ProductScreen : Sample2
    {
        readonly ICRUD _category = new CategoryRepo();
        readonly ICRUD _product = new ProductRepo();

        public int ProductID { get; set; }
        public ProductScreen()
        {
            InitializeComponent();
        }

        private void ProductScreen_Load(object sender, EventArgs e)
        {
            MainClass.DisableResetControls(leftPanel);
            LoadCategoryToComboBox();
            LoadProductsToDataGrid();
        }

        private void LoadProductsToDataGrid()
        {
            MainClass.LoadDataToDataGrid(dgvProduct, _product.GetAll());
        }

        private void LoadCategoryToComboBox()
        {
            MainClass.LoadDataToComboBox(cmbCategory, _category.GetAll());
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableResetControls(leftPanel);
            txtProductName.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.ProductID < 0)
            {
                MessageBox.Show("Select Product from list");
            }
            else
            {
                this.isUpdate = true;
                MainClass.EnableControls(leftPanel);
                txtProductName.Focus();
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                _product.UpdateRecord(GetObjects());
            }
            else
            {
                _product.InsertRecord(GetObjects());
            }
            MainClass.DisableResetControls(leftPanel);
            LoadProductsToDataGrid();
            this.isUpdate = false;
            btnAdd.Focus();
        }

        private object GetObjects()
        {
            Product p = new Product();
            p.ProductID = this.isUpdate ? this.ProductID : 0;
            p.ProductName = txtProductName.Text;
            p.KGFT = Convert.ToDecimal(txtKGFT.Text);
            p.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);
            return p;
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {
            MainClass.LoadDataToDataGrid(dgvProduct, _product.GetByName(txtProductName.Text));
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = dgvProduct.CurrentRow.Index;
            this.ProductID = Convert.ToInt32(dgvProduct.Rows[rowID].Cells["ID"].Value);
            LoadDataToControls();
        }

        private void LoadDataToControls()
        {
            DataRow dr = _product.GetSingle(this.ProductID);
            txtProductName.Text = dr["Name"].ToString();
            cmbCategory.SelectedValue = Convert.ToInt32(dr["Category"].ToString());
            txtKGFT.Text = dr["KG Per Foot"].ToString();
        }
    }
}
