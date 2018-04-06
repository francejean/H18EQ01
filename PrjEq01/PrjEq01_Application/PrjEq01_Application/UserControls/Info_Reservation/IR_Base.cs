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
	public partial class IR_Base: UserControl, IInfoBox
	{
        protected BindingSource BS;

		public IR_Base()
		{
			InitializeComponent();
            TA_RESERVATION.Fill(ds_master.RESERVATION);
		}

        public void setBS(BindingSource BS)
        {
            this.BS = BS;
        }

        protected virtual void bt_list_Click(object sender, EventArgs e)
        {
        }

        public void SetReadOnly(States state)
        {
            bool readOnly	= !(state == States.ADD || state == States.EDIT);
			bt_list.Enabled = (state == States.ADD);

			foreach (Control ctrl in gb_reserv.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ((TextBox)ctrl).ReadOnly = readOnly;
				else
					ctrl.Enabled = (ctrl.GetType() != typeof(DateTimePicker)) ? readOnly : !readOnly;
            }
        }

		public virtual void WypeInformation()
		{
			this.tb_noReserv.ResetText();
			this.DTP_Debut.ResetText();
			this.DTP_Fin.ResetText();
			this.DTP_Reserv.ResetText();
		}
	}
}
