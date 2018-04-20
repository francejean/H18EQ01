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
	public partial class IR_Depart : PrjEq01_Application.UserControls.IR_Base
	{
		public IR_Depart()
		{
			InitializeComponent();
			this.bt_list.Enabled = false;
			this.bt_list.Visible = false;
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

			base.bt_list_Click(sender, e);
		}
	}
}
