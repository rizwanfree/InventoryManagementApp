using InventoryManagement.Entities;
using InventoryManagement.Services;
using InventoryManagement.Services.CategoryServices;
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

namespace InventoryManagement.Screens.Categories
{
    public partial class CatagoryScreen : Sample2
    {
        readonly ICRUD _category = new CategoryRepo();

        public int CategoryID { get; set; } = 0;
        public CatagoryScreen()
        {
            InitializeComponent();
        }

        private void CatagoryScreen_Load(object sender, EventArgs e)
        {
            MainClass.DisableResetControls(leftPanel);
            LoadDataToDataGrid();
        }

        private void LoadDataToDataGrid()
        {
            MainClass.LoadDataToDataGrid(dgvCategory, _category.GetAll());
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableResetControls(leftPanel);
            txtCategory.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.CategoryID < 0)
            {
                MessageBox.Show("Select Category from List");
            }
            else
            {
                this.isUpdate = true;
                MainClass.EnableControls(leftPanel);
                txtCategory.Focus();
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (isUpdate) { _category.UpdateRecord(GetObjects()); }
            else { _category.InsertRecord(GetObjects()); }
            LoadDataToDataGrid();

        }

        private object GetObjects()
        {
            Category c = new Category
            {
                CategoryID = this.isUpdate ? this.CategoryID : 0,
                CategoryName = txtCategory.Text,
            };
            return c;
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {
            _category.GetByName(textBox1.Text.Trim());
            LoadDataToDataGrid();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = dgvCategory.CurrentRow.Index;
            int id = Convert.ToInt32(dgvCategory.Rows[rowID].Cells["ID"].Value);
            this.CategoryID = id;
            LoadDataToControls(id);
        }

        private void LoadDataToControls(int id)
        {
            DataRow dr = _category.GetSingle(id);
            txtCategory.Text = dr["Name"].ToString();
        }
    }
}
