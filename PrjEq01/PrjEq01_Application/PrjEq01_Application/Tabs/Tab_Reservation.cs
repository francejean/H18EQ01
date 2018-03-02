using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEq01_Application.Tabs
{
	public partial class Tab_Reservation : UserControl
	{
		public Tab_Reservation()
		{
			

			InitializeComponent();
		}

		private void Tab_Reservation_Load(object sender, EventArgs e)
		{
			Fill();
			Link_Reservation();
		}

		private void Fill()
		{
			TA_DE.Fill(DS_Master.DE);
			TA_CHAMBRE.Fill(DS_Master.CHAMBRE);
			TA_RESERVATION.Fill(DS_Master.RESERVATION);
		}

		private void Link_Reservation()
		{
			this.BS_RESERVATION.DataMember = "Réseversation";
			this.BS_RESERVATION.DataSource = this.DS_Master;

			try
			{
				saisi_Info_Client1.TextBox_NoClient.DataBindings.Add("Text", BS_RESERVATION, "");
			}
			catch (Exception e)
			{ MessageBox.Show(e.Message); }
		}
	}
}
