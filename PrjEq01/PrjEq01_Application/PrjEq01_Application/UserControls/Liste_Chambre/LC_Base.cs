using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjEq01_CommonForm;

namespace PrjEq01_Application.UserControls
{
    public partial class LC_Base : UserControl, IReadOnly
    {
        public LC_Base()
        {
            InitializeComponent();
        }

        private void bt_list_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void SetReadOnly(States state)
        {
            bool readOnly = false;

            switch (state)
            {
                case States.ADD:
                    readOnly = false;
                    bt_listCommodite.Enabled = true;
                    break;
                case States.EDIT:
                    readOnly = false;
                    bt_listCommodite.Enabled = false;
                    break;
                case States.DELETE:
                    readOnly = true;
                    bt_listCommodite.Enabled = false;
                    break;
                case States.SAVE:
                    readOnly = true;
                    bt_listCommodite.Enabled = false;
                    break;
                case States.MOVE:
                    readOnly = true;
                    bt_listCommodite.Enabled = false;
                    break;
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ((TextBox)ctrl).ReadOnly = readOnly;
                else if (ctrl.GetType() == typeof(ComboBox))
                    ((ComboBox)ctrl).Enabled = readOnly;
                else if (ctrl.GetType() == typeof(CheckBox))
                    ((CheckBox)ctrl).Enabled = readOnly;
                else if (ctrl.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)ctrl).Enabled = !readOnly;
            }
            
        }
    }
}
