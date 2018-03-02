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
	public partial class Tab_Arrive : UserControl
	{
		public Tab_Arrive()
		{
			InitializeComponent();
		}

		private void Tab_Arrive_Load(object sender, EventArgs e)
		{
			Fill();
		}

		private void Fill()
		{
			this.TA_ARRIVE.Fill(this.DS_Master.ARRIVE);
			this.TA_DEPART.Fill(this.DS_Master.DEPART);
			this.TA_RESERVATION.FillByARRIVE(this.DS_Master.RESERVATION);
			this.TA_TRX.Fill(this.DS_Master.TRX);
			this.TA_CLIENT.Fill(this.DS_Master.CLIENT);
			this.TA_CHAMBRE.Fill(this.DS_Master.CHAMBRE);

			Link_ARRIVE();
			Link_CLIENT();
			Link_RESERVATION();
			Link_CHAMBRE();
		}

		private void Link_ARRIVE()
		{
			this.BS_ARRIVE.DataMember = "ARRIVE";
			this.BS_ARRIVE.DataSource = this.DS_Master;

			try
			{
				tb_noArrive.DataBindings.Add("Text", BS_ARRIVE, "IdArrive");
                ic_arrive.tb_noClient.DataBindings.Add("Text", BS_ARRIVE, "IdCli");
                ic_arrive.tb_noChambre.DataBindings.Add("Text", BS_ARRIVE, "NoCham");
			}
			catch (Exception ee) { MessageBox.Show(ee.Message); }
		}

		private void Link_CLIENT()
		{
			this.BS_CLIENT.DataMember = "CLIENT";
			this.BS_CLIENT.DataSource = this.DS_Master;

			try
			{
				ic_arrive.tb_nomClient.DataBindings.Add("Text", BS_CLIENT, "Nom");
				ic_arrive.tb_adresse.DataBindings.Add("Text", BS_CLIENT, "Adresse");
				ic_arrive.DataBindings.Add("Text", BS_CLIENT, "Telephone");
				.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
				.DataBindings.Add("Text", BS_CLIENT, "NoCarte");
				.DataBindings.Add("Text", BS_CLIENT, "DatExp");
			}
			catch (Exception ee) { MessageBox.Show(ee.Message); }
		}

		private void Link_RESERVATION()
		{
			this.BS_RESERVATION.DataMember = "RESERVATION";
			this.BS_RESERVATION.DataSource = this.DS_Master;

			try
			{
				/*.DataBindings.Add("Text", BS_RESERVATION, "IdReser");
				.DataBindings.Add("Text", BS_RESERVATION, "DateReser");
				.DataBindings.Add("Text", BS_RESERVATION, "DateDebut");
				.DataBindings.Add("Text", BS_RESERVATION, "DateFin");
				.DataBindings.Add("Text", BS_RESERVATION, "IdCli");
				.DataBindings.Add("Text", BS_RESERVATION, "Nom");*/
			}
			catch (Exception ee) { MessageBox.Show(ee.Message); }
		}

		private void Link_CHAMBRE()
		{
			this.BS_CHAMBRE.DataMember = "CHAMBRE";
			this.BS_CHAMBRE.DataSource = this.DS_Master;

			try
			{
				ls_chambre.dgv_chambre.DataSource = BS_CHAMBRE;
			}
			catch (Exception ee) { MessageBox.Show(ee.Message); }
		}
	}
}
