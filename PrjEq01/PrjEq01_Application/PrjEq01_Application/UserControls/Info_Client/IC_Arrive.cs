using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjEq01_Application.UserControls.Info_Client
{
	public partial class IC_Arrive : PrjEq01_Application.UserControls.IC_Base
	{
		public IC_Arrive()
		{
			InitializeComponent();
		}

		protected override void bt_list_Click(object sender, EventArgs e)
		{
			int BS_pos_backup = bS.Position;
			List_Forms.LF_Reservation lf_reservation = new List_Forms.LF_Reservation(bS);
			DialogResult result = lf_reservation.ShowDialog();

			if (result == DialogResult.OK)
			{
				ClientSelected((int)ds_master.Tables["CLIENT"].Rows[bS.Position]["IdCli"]);
			}
			else if (result == DialogResult.Cancel)
			{
				bS.Position = BS_pos_backup;
			}
		}
	}
}
