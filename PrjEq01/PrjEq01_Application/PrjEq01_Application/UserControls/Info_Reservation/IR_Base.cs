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
	public partial class IR_Base: UserControl, IReadOnly
	{
        protected BindingSource BS;

		public IR_Base()
		{
			InitializeComponent();
		}

        public void setBS(BindingSource BS)
        {
            this.BS = BS;
        }

        protected virtual void bt_list_Click(object sender, EventArgs e)
		{
			if (this.Parent is Tabs.UC_Reservation)
			{
				List_Forms.LF_Reservation lf_reservation = new List_Forms.LF_Reservation(BS);
				Tabs.UC_Reservation uc_reser = (Tabs.UC_Reservation)this.Parent;

				int tmpPos_BS_RESERVATION = BS.Position;

				if (lf_reservation.ShowDialog() == DialogResult.Cancel)
				{
					BS.Position = tmpPos_BS_RESERVATION;
				}
				else
				{
					uc_reser.Sync_ForeignTables();
				}
			}
		}

        public void SetReadOnly(States state)
        {
            bool readOnly = false;

            switch (state)
            {
                case States.ADD:
                    readOnly = false;
                    bt_list.Enabled = true;
                    break;
                case States.EDIT:
                    readOnly = false;
                    bt_list.Enabled = false;
                    break;
                case States.DELETE:
                    readOnly = true;
                    bt_list.Enabled = false;
                    break;
                case States.SAVE:
                    readOnly = true;
                    bt_list.Enabled = false;
                    break;
                case States.MOVE:
                    readOnly = true;
                    bt_list.Enabled = false;
                    break;
            }

            foreach (Control ctrl in gb_reserv.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ((TextBox)ctrl).ReadOnly = readOnly;
                else if (ctrl.GetType() == typeof(ComboBox))
                    ((ComboBox)ctrl).Enabled = readOnly;
                else if (ctrl.GetType() == typeof(CheckBox))
                    ((CheckBox)ctrl).Enabled = readOnly;
                else if (ctrl.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)ctrl).Enabled = readOnly;
                else if (ctrl.GetType() == typeof(Button))
                    ((Button)ctrl).Enabled = readOnly;
            }
        }
    }
}
