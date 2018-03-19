﻿using System;
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
			if (this.Parent is Tabs.UC_Reservation)
			{
				List_Forms.LF_Reservation lf_reservation = new List_Forms.LF_Reservation();
				Tabs.UC_Reservation uc_reser = (Tabs.UC_Reservation)this.Parent;

				BindingSource BS = uc_reser.Get_BS_RESERVATION();
				lf_reservation.Dgv_noReser.DataSource = BS;
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
