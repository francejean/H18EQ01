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
		private ItemSelectedDeleg _onSelected;

		public ItemSelectedDeleg OnSelected { get => _onSelected; set => _onSelected = value; }

		public LC_Reserv()
		{
			InitializeComponent();
		}

		public override void SetReadOnly(States state)
		{
			bt_listCommodite.Enabled = (state != States.CONSULT);
		}

		protected override void bt_list_Click(object sender, EventArgs e)
		{
			int BS_pos_backup = BS.Position;
			List_Forms.LF_Chambres lf_chambres = new List_Forms.LF_Chambres(BS);
			DialogResult result = lf_chambres.ShowDialog();

			if (result == DialogResult.OK)
			{
				if(_onSelected != null)
				{
					if(e is DataGridViewCellEventArgs)
					{
						DataGridViewCellEventArgs a = e as DataGridViewCellEventArgs;
						OnSelected(Convert.ToInt16(dgv_chambre.Rows[a.RowIndex].Cells[0].Value));
					}
				}
			}
			else if (result == DialogResult.Cancel)
			{
				BS.Position = BS_pos_backup;
			}
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
