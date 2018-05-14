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

namespace PrjEq01_Application.UserControls.Info_Reservation
{
	public partial class IR_Reserv : IR_Base
	{
		public IR_Reserv()
		{
			InitializeComponent();
		}

		protected override void bt_list_Click(object sender, EventArgs e)
		{
			int BS_pos_backup = BS.Position;
			List_Forms.LF_Reservation lf_reservation = new List_Forms.LF_Reservation(BS);

			if (lf_reservation.ShowDialog() == DialogResult.OK)
			{
				DataRowView DTR = (DataRowView) BS[BS.Position];
				int index = (int) DTR["IdReser"];
				ReservSelected(index);
			}
			else
			{
				BS.Position = BS_pos_backup;
			}
		}

		public override void SetReadOnly(States state)
		{
			base.SetReadOnly(state);
			bool readOnly = States.CONSULT != state;

			DTP_Debut.Enabled = readOnly;
			DTP_Fin.Enabled = readOnly;
			bt_list.Enabled = !readOnly;
		}

		public override void WipeInformation()
		{
			DTP_Reserv.ResetText();
			DTP_Debut.ResetText();
			DTP_Fin.ResetText();
		}

		public bool CheckErrors()
		{
			bool result = true;
			if(DTP_Reserv.Value > DTP_Debut.Value)
			{
				errorProvider.SetError(DTP_Debut, "La date de début ne peut pas être plus tôt que la date de la réservation");
				result = false;
			}
			else errorProvider.SetError(DTP_Debut, "");

			if (DTP_Reserv.Value > DTP_Debut.Value)
			{
				errorProvider.SetError(DTP_Fin, "La date de fin ne peut pas être plus tôt que la date de la réservation");
				result = false;
			}
			else errorProvider.SetError(DTP_Fin, "");

			if (DTP_Debut.Value > DTP_Fin.Value)
			{
				errorProvider.SetError(DTP_Fin, "La date de fin ne peut pas être plus tôt que la date du début");
				result = false;
			}
			else errorProvider.SetError(DTP_Fin, "");

			

			return result;
		}
	}
}
