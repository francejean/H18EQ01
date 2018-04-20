using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PrjEq01_CommonForm;

namespace PrjEq01_Application.UserControls.Info_Client
{
	public partial class IC_Reserv : IC_Base
	{
		public IC_Reserv()
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

			}
			else if (result == DialogResult.Cancel)
			{
				bS.Position = BS_pos_backup;
			}

			base.bt_list_Click(sender, e);
		}

		public override void SetReadOnly(States state)
		{
			base.SetReadOnly(state);
			this.tb_solde.Enabled = (state == States.ADD || state == States.EDIT);
		}

		public override void WipeInformation()
		{
			base.WipeInformation();

			this.tb_solde.ResetText();
		}
	}
}
