using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PrjEq01_CommonForm;

namespace PrjEq01_Application.UserControls.Liste_Chambre
{
	public partial class LC_Reserv : LC_Base
	{
		public ChamberSelectedDeleg OnSelected { get; set; }
		public ChamberBeforeSelection BeforeSelection { get; set; }

		public LC_Reserv()
		{
			InitializeComponent();

			dgv_chambre.DataMember = "CHAMBRE";
			dgv_chambre.DataSource = BS;
		}

		public override void SetReadOnly(States state)
		{
			bt_listCommodite.Enabled = (state != States.CONSULT);
		}

		protected override void bt_list_Click(object sender, EventArgs e)
		{

		}

		// Returns true if there is any errors
		public bool CheckErrors()
		{
			if (this.dgv_chambre.RowCount == 0)
			{
				this.errorProvider.SetError(bt_listCommodite, "Vous devez ajouter au moins une chambre à la réservation");
				return true;
			}

			this.errorProvider.SetError(bt_listCommodite, "");
			return false;
		}

		public void ResetErrors()
		{
			this.errorProvider.SetError(bt_listCommodite, "");
		}
	}
}
