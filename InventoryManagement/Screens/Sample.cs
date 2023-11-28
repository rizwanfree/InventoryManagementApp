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
    public partial class Sample : Form
    {
        public bool isUpdate { get; set; }
        public string UserName = "Test User";
        public Sample()
        {
            InitializeComponent();
            lblName.Text = UserName;
        }
    }
}
