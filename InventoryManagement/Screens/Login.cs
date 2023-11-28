using InventoryManagement.Utilities;
using RSDBCore;
using System.Data;

namespace InventoryManagement.Screens
{
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBSQLite db = new DBSQLite();
            DBParameter userPara = new DBParameter() { Parameter = "@Username", Value = txtUsername.Text.Trim()};
            DBParameter passwordPara = new DBParameter() { Parameter = "@Password", Value = txtPassword.Text.Trim() };
            List<DBParameter> paramList = new List<DBParameter>();
            paramList.Add(userPara);
            paramList.Add(passwordPara);

            string sql = @"SELECT Name,
                               Username
                           FROM Users
                           WHERE Username = @Username
                           AND Password = @Password";

            DataTable dt = db.GetDataList(sql, paramList.ToArray());
            if (dt != null && dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                //this.UserName = dr["Name"].ToString();
                
                base.lblName.Text = dr["Name"].ToString();
                HomeScreen obj = new HomeScreen();                
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
