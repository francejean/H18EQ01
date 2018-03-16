using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEq01_Application.UserControls
{
	public partial class IR_Base: UserControl, IReadOnly
	{
		public IR_Base()
		{
			InitializeComponent();
		}

        private void bt_list_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void SetReadOnly(bool state)
        {
            foreach (Control ctrl in gb_reserv.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ((TextBox)ctrl).ReadOnly = state;
                if (ctrl.GetType() == typeof(ComboBox))
                    ((ComboBox)ctrl).Enabled = state;
                if (ctrl.GetType() == typeof(CheckBox))
                    ((CheckBox)ctrl).Enabled = state;
                if (ctrl.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)ctrl).Enabled = !state;
            }
        }
    }
}
