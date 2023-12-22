using InventoryManagement.Entities;
using InventoryManagement.Services;
using InventoryManagement.Services.VendorServices;
using InventoryManagement.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace InventoryManagement.Screens.Vendors
{
    public partial class VendorScreen : Sample2
    {
        readonly ICRUD _vendor = new VendorRepo();
        public int VendorID { get; set; }
        public VendorScreen()
        {
            InitializeComponent();
        }

        private void VendorScreen_Load(object sender, EventArgs e)
        {
            MainClass.DisableResetControls(leftPanel);
            LoadVendorsToDataGrid();
        }

        private void LoadVendorsToDataGrid()
        {
            MainClass.LoadDataToDataGrid(dgvVendor, _vendor.GetAll());
        }
        private object GetObjects()
        {
            Vendor v = new Vendor();
            v.VendorID = this.isUpdate ? this.VendorID : 0;
            v.VendorName = txtVendorName.Text.ToUpper().Trim();
            v.ContactPerson = txtContactPerson.Text.ToUpper().Trim();
            v.Phone = txtPhone.Text.ToUpper().Trim();
            v.Mobile = txtMobile.Text.ToUpper().Trim();
            v.Address = txtAddress.Text.ToUpper().Trim();
            v.NTN = txtNTN.Text.ToUpper().Trim();
            v.GST = txtGST.Text.ToUpper().Trim();
            return v;
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            this.isUpdate = false;
            MainClass.EnableResetControls(leftPanel);
            txtVendorName.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.VendorID >= 0)
            {
                this.isUpdate = true;
                MainClass.EnableControls(leftPanel);
                txtVendorName.Focus();
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
                    _vendor.UpdateRecord(GetObjects());
                }
                else
                {
                    _vendor.InsertRecord(GetObjects());
                    btnAdd.Focus();

                }
                this.isUpdate = false;
                this.VendorID = -1;
                MainClass.DisableResetControls(leftPanel);
                LoadVendorsToDataGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Really Delete this Supplier ?", "Deletion", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                _vendor.DeleteRecord(this.VendorID);
                LoadVendorsToDataGrid();
            }
        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = _vendor.GetByName(textBox1.Text);
            MainClass.LoadDataToDataGrid(dgvVendor, dt);
        }

        private void dgvVendor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = dgvVendor.CurrentRow.Index;
            this.VendorID = Convert.ToInt32(dgvVendor.Rows[rowID].Cells["ID"].Value);
            LoadVendorDataToControls(this.VendorID);
        }

        private void LoadVendorDataToControls(int id)
        {
            DataRow dr = _vendor.GetSingle(id);
            if (dr != null)
            {
                txtVendorName.Text = dr["Supplier Name"].ToString();
                txtContactPerson.Text = dr["Contact Person"].ToString();
                txtGST.Text = dr["GST"].ToString();
                txtMobile.Text = dr["Mobile"].ToString();
                txtNTN.Text = dr["NTN"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtAddress.Text = dr["Address"].ToString();
            }
        }
    }
}
