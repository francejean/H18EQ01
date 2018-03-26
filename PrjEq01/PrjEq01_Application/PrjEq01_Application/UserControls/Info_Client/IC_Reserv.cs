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
			if (this.Parent is Tabs.UC_Reservation)
			{
				List_Forms.LF_Client lf_client = new List_Forms.LF_Client(BS);
				Tabs.UC_Reservation uc_reser = (Tabs.UC_Reservation)this.Parent;

				BindingSource bs = uc_reser.Get_BS_CLIENT();
				int tmpPos_BS_RESERVATION = bs.Position;

				if (lf_client.ShowDialog() == DialogResult.Cancel)
				{
					bs.Position = tmpPos_BS_RESERVATION;
				}
			}
		}
	}
}
