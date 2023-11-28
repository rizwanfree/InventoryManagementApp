using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Utilities
{
    public class MainClass
    {
        public static void ShowWindow(Form openWin, Form closeWin, Form MDIWin)
        {
            closeWin.Close();
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static void ShowWindow(Form openWin,  Form MDIWin)
        {
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static void DisableResetControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = false;
                    ((TextBox)c).Text = string.Empty;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                    ((ComboBox)c).Enabled = false;
                    c.ForeColor = Color.White;
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                    ((RadioButton)c).Enabled = false;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked= false;
                    ((CheckBox)c).Enabled = false;
                }
            }
        }
        public static void DisableControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = false;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = false;
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Enabled = false;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = false;
                }
            }
        }
        public static void EnableControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = true;
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Enabled = true;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = true;
                }
            }
        }
        public static void EnableResetControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                    ((TextBox)c).Text = string.Empty;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                    ((ComboBox)c).Enabled = true;
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                    ((RadioButton)c).Enabled = true;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                    ((CheckBox)c).Enabled = true;
                }
            }
        }

        public static void LoadDataToDataGrid(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;
        }

        public static void LoadDataToComboBox(ComboBox cb, DataTable dt)
        {
            cb.DataSource = dt;
            cb.ValueMember = "ID";
            cb.DisplayMember = "Name";
            cb.SelectedIndex = -1;
        }
    }
}
