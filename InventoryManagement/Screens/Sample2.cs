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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public virtual void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
