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
	public partial class IR_Base : UserControl, IInfoBox
	{
		protected BindingSource bS;
		private ItemSelectedDeleg reservSelected;

		public BindingSource BS { get => bS; set => bS = value; }
		public ItemSelectedDeleg ReservSelected { get => reservSelected; set => reservSelected = value; }


		public IR_Base()
		{
			InitializeComponent();
			TA_RESERVATION.Fill(ds_master.RESERVATION);
		}

		protected virtual void bt_list_Click(object sender, EventArgs e)
		{
		}

		public virtual void SetReadOnly(States state)
		{
			bt_list.Enabled = (state == States.ADD);
		}

		public virtual void WipeInformation()
		{
			foreach (Control ctrl in gb_reserv.Controls)
			{
				if (ctrl is TextBox || ctrl is DateTimePicker)
					ctrl.ResetText();
			}
		}
	}
}
