using InventoryManagement.Entities;
using InventoryManagement.Services;
using InventoryManagement.Services.UserServices;
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

namespace InventoryManagement.Screens
{
    public partial class UserScreen : Sample2
    {
        readonly ICRUD _user = new UserService();
        public int ID { get; set; }

        public UserScreen()
        {
            InitializeComponent();

        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            MainClass.DisableControls(leftPanel);
            LoadDataToDataGrid();
        }

        private void LoadDataToDataGrid()
        {
            MainClass.LoadDataToDataGrid(dgvUsers, _user.GetAll());
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableResetControls(leftPanel);
            txtName.Focus();

        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            this.isUpdate = true;
            int id = dgvUsers.CurrentCell.RowIndex;
            this.ID = Convert.ToInt32(dgvUsers.Rows[id].Cells[0].Value);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                if (isUpdate)   // Code for Update
                {
                    UpdateUser();
                }
                else            // Code for Save
                {
                    SaveUser();
                }
            }
        }

        private void UpdateUser()
        {
            _user.UpdateRecord(this.ID);
        }

        private void SaveUser()
        {
            try
            {
                _user.InsertRecord(GetObjects());
                MessageBox.Show("User Inserted");
                MainClass.DisableResetControls(leftPanel);
                btnAdd.Focus();
                LoadDataToDataGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            int id = dgvUsers.CurrentRow.Index;
            int rowID = Convert.ToInt32(dgvUsers.Rows[id].Cells[0].Value);
            DialogResult result = MessageBox.Show("Really Delete ?", "Delete User", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                _user.DeleteRecord(rowID);
                }
            MainClass.DisableResetControls(leftPanel);
            LoadDataToDataGrid();
        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = _user.GetByName(textBox1.Text);
            MainClass.LoadDataToDataGrid(dgvUsers, dt);
        }

        private object GetObjects()
        {
            User u = new User();
            u.Name = txtName.Text.Trim();
            u.Username = txtUsername.Text.Trim();
            u.Password = txtPassword.Text.Trim();
            u.Phone = txtPhone.Text.Trim();
            u.Email = txtEmail.Text.Trim();
            u.Status = Convert.ToInt32(cmbStatus.SelectedIndex) == 0 ? 1 : 0;
            return u;
        }

        private bool IsValidated()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Enter Name..");
                txtName.Clear();
                txtName.Focus();
                return false;
            }
            if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Enter User Name..");
                txtUsername.Clear();
                txtUsername.Focus();
                return false;
            }
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter Password..");
                txtPassword.Clear();
                txtPassword.Focus();
                return false;
            }
            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Enter Phone/Mobile Number..");
                txtPhone.Clear();
                txtPhone.Focus();
                return false;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Enter Email Address..");
                txtEmail.Clear();
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = dgvUsers.CurrentRow.Index;
            int rowID = Convert.ToInt32(dgvUsers.Rows[id].Cells[0].Value);
            LoadSingleUserToControl(rowID);
        }

        private void LoadSingleUserToControl(int rowID)
        {
            DataRow dr = _user.GetSingle(rowID);
            txtName.Text = dr["Name"].ToString();
            txtUsername.Text = dr["Username"].ToString();
            txtPassword.Text = dr["Password"].ToString();
            txtPhone.Text = dr["Phone"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            cmbStatus.SelectedIndex = dr["Status"].ToString() == "1" ? 0 : 1;

        }
    }
}
