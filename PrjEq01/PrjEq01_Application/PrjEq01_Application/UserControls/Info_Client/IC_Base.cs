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
	public partial class IC_Base : UserControl, IReadOnly
    {
        public IC_Base()
		{
			InitializeComponent();
        }

        protected virtual void bt_list_Click(object sender, EventArgs e)
        {
            List_Forms.LF_Client lf_client = new List_Forms.LF_Client();
            lf_client.ShowDialog();
        }

        public void SetReadOnly(bool state)
        {
            foreach (Control ctrl in gb_client.Controls)
            {
				if (ctrl.GetType() == typeof(TextBox))
					((TextBox)ctrl).ReadOnly = state;
				else if (ctrl.GetType() == typeof(ComboBox))
					((ComboBox)ctrl).Enabled = state;
				else if (ctrl.GetType() == typeof(CheckBox))
					((CheckBox)ctrl).Enabled = state;
				else if (ctrl.GetType() == typeof(DateTimePicker))
					((DateTimePicker)ctrl).Enabled = state;
				else if (ctrl.GetType() == typeof(Button))
					((Button)ctrl).Enabled = state;

			}
        }
    }
}
