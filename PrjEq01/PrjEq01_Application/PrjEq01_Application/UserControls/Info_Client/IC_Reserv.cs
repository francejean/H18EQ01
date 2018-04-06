using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            int BS_pos_backup = BS.Position;
            List_Forms.LF_Reservation lf_reservation = new List_Forms.LF_Reservation(BS);
            DialogResult result = lf_reservation.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
            else if (result == DialogResult.Cancel)
            {
                BS.Position = BS_pos_backup;
            }
        }

		public override void WipeInformation()
		{
			base.WipeInformation();

			this.tb_solde.ResetText();
		}
	}
}
