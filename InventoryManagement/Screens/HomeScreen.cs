using InventoryManagement.Screens.Categories;
using InventoryManagement.Screens.Products;
using InventoryManagement.Services;
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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserScreen u = new UserScreen();
            MainClass.ShowWindow(u, this, MDI.ActiveForm);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductScreen p = new ProductScreen();
            MainClass.ShowWindow(p, this, MDI.ActiveForm);
        }

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            CatagoryScreen c = new CatagoryScreen();
            MainClass.ShowWindow(c, this, MDI.ActiveForm);
        }
    }
}
