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
	public partial class UC_Reservation : UserControl, PrjEq01_CommonForm.IButtons
	{
		public UC_Reservation()
		{
			InitializeComponent();
		}

		private void Tab_Reservation_Load(object sender, EventArgs e)
		{
			Fill();
			Link();
			Sync_ForeignTables();
		}

		private void Fill()
		{
			TA_DE.Fill(DS_Master.DE);
			TA_CHAMBRE.Fill(DS_Master.CHAMBRE);
			TA_RESERVATION.Fill(DS_Master.RESERVATION);
			TA_CLIENT.Fill(DS_Master.CLIENT);
		}

		private void Link()
		{
			Link_Reservation();
			Link_Client();
			Link_Chamber();
		}

		private void Link_Reservation()
		{
			this.BS_RESERVATION.DataMember = "RESERVATION";
			this.BS_RESERVATION.DataSource = this.DS_Master;

			try
			{
				ic_Reserv.tb_noClient.DataBindings.Add("Text", BS_RESERVATION, "IdCli");
				ir_Base.tb_noReserv.DataBindings.Add("Text", BS_RESERVATION, "IdReser");
				ir_Base.DTP_Reserv.DataBindings.Add("Text", BS_RESERVATION, "DateReser");
				ir_Base.DTP_Debut.DataBindings.Add("Text", BS_RESERVATION, "DateDebut");
				ir_Base.DTP_Fin.DataBindings.Add("Text", BS_RESERVATION, "DateFin");
			}
			catch (Exception e)
			{ MessageBox.Show(e.Message); }
		}

		private void Link_Client()
		{
			this.BS_CLIENT.DataMember = "CLIENT";
			this.BS_CLIENT.DataSource = this.DS_Master;

			try
			{
				ic_Reserv.tb_nomClient.DataBindings.Add("Text", BS_CLIENT, "Nom");
				ic_Reserv.tb_adresse.DataBindings.Add("Text", BS_CLIENT, "Adresse");
				ic_Reserv.tb_telephone.DataBindings.Add("Text", BS_CLIENT, "Telephone");
				ic_Reserv.tb_noCarte.DataBindings.Add("Text", BS_CLIENT, "NoCarte");
				ic_Reserv.tb_typeCarte.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
				ic_Reserv.tb_expiration.DataBindings.Add("Text", BS_CLIENT, "DatExp");
				ic_Reserv.tb_solde.DataBindings.Add("Text", BS_CLIENT, "SoldeDu");
			}
			catch (Exception e)
			{ MessageBox.Show(e.Message); }
		}

		private void Link_Chamber()
		{
			this.BS_CHAMBRE.DataMember = "CHAMBRE";
			this.BS_CHAMBRE.DataSource = this.DS_Master;

			try
			{
				ls_chambre.dgv_chambre.DataSource = BS_CHAMBRE;
			}
			catch (Exception e)
			{ MessageBox.Show(e.Message); }
		}

		public void SetReadOnly(bool state)
		{
			List<IReadOnly> consult_controls = new List<IReadOnly>();
			consult_controls.Add(ic_Reserv);
			consult_controls.Add(ir_Base);

			foreach (IReadOnly consult_control in consult_controls)
			{ consult_control.SetReadOnly(state); }

			ic_Reserv.tb_solde.ReadOnly = state;
		}

		private bool Sync_ForeignTables()
		{
			BS_CLIENT.Position = BS_CLIENT.Find("IdCli", DS_Master.Tables["RESERVATION"].Rows[BS_RESERVATION.Position]["IdCli"]);
			return false;
		}

		public void Add()
		{
			MessageBox.Show("Fonction en développement.");
			SetReadOnly(false);
		}

		public void Edit()
		{
			MessageBox.Show("Fonction en développement.");
			SetReadOnly(false);
		}

		public void Delete()
		{
			MessageBox.Show("Fonction en développement.");
			SetReadOnly(true);
		}

		public void Undo()
		{
			MessageBox.Show("Fonction en développement.");
		}

		public void Save()
		{
			MessageBox.Show("Fonction en développement.");
			SetReadOnly(true);
		}

		public void Go_Start()
		{
			this.BS_RESERVATION.MoveFirst();
			Sync_ForeignTables();
			SetReadOnly(true);
		}

		public void Go_Back()
		{
			this.BS_RESERVATION.MovePrevious();
			Sync_ForeignTables();
			SetReadOnly(true);
		}

		public void Go_Forward()
		{
			this.BS_RESERVATION.MoveNext();
			Sync_ForeignTables();
			SetReadOnly(true);
		}

		public void Go_End()
		{
			this.BS_RESERVATION.MoveLast();
			Sync_ForeignTables();
			SetReadOnly(true);
		}
	}
}
