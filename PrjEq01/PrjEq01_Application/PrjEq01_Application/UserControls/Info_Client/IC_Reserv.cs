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
			List_Forms.LF_Client lf_client = new List_Forms.LF_Client(bS);
			DialogResult result = lf_client.ShowDialog();

			if (result == DialogResult.OK)
			{
				ClientSelected((int)ds_master.Tables["CLIENT"].Rows[bS.Position]["IdCli"]);
			}
			else if (result == DialogResult.Cancel)
			{
				bS.Position = BS_pos_backup;
			}
		}

		public override void SetReadOnly(States state)
		{
			base.SetReadOnly(state);
			//this.tb_solde.ReadOnly = (state == States.CONSULT);
		}

		public override void WipeInformation()
		{
			base.WipeInformation();

			this.tb_solde.ResetText();
		}

		public void ResetErrors()
		{
			errorProvider.SetError(bt_list, "");
		}

		// Returns true if there is any errors
		public bool CheckErrors()
		{
			if (tb_noClient.Text.Length == 0)
			{
				errorProvider.SetError(bt_list, "Vous devez sélectionner un client.");
				return true;
			}
			errorProvider.SetError(bt_list, "");
			return false;
		}
	}
}
