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

namespace PrjEq01_Application.Tabs
{
	public partial class UC_Reservation : UserControl, PrjEq01_CommonForm.IButtons
	{
        public States State { get; set; }

        public UC_Reservation()
		{
			InitializeComponent();
			ic_Reserv.setBS(BS_CLIENT);
			ir_Base.setBS(BS_RESERVATION);
		}

		private void Tab_Reservation_Load(object sender, EventArgs e)
		{
			Fill();
			Link();
			Sync_ForeignTables();
		}

		private void Fill()
		{
			TA_DE.FillBy(DS_Master.DE);
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
			this.BS_CHAMBRE.DataMember = "DE_FK_IdReser";
			this.BS_CHAMBRE.DataSource = this.BS_RESERVATION;

			try
			{
				ls_chambre.dgv_chambre.DataSource = BS_CHAMBRE;
			}
			catch (Exception e)
			{ MessageBox.Show(e.Message); }
		}

		public void SetReadOnly()
		{
			List<IInfoBox> consult_controls = new List<IInfoBox>();
			consult_controls.Add(ic_Reserv);
			consult_controls.Add(ir_Base);

			foreach (IInfoBox consult_control in consult_controls)
			{ consult_control.SetReadOnly(State); }
		}

		public bool Sync_ForeignTables()
		{
			BS_CLIENT.Position = BS_CLIENT.Find("IdCli", DS_Master.Tables["RESERVATION"].Rows[BS_RESERVATION.Position]["IdCli"]);
			return false;
		}

		public void Add()
		{
			ic_Reserv.WipeInformation();
			ir_Base.WipeInformation();

			SetReadOnly();
		}

		public void Edit()
		{
            MessageBox.Show("Fonction en développement.");
			SetReadOnly();
		}

		public void Delete()
		{
            MessageBox.Show("Fonction en développement.");
			SetReadOnly();
		}

		public void Undo()
		{
			Fill();
			Link();
			SetReadOnly();
		}

		public void Save()
		{
			MessageBox.Show("Fonction en développement.");
			SetReadOnly();
		}

		public void Go_Start()
		{
			this.BS_RESERVATION.MoveFirst();
			Sync_ForeignTables();
			SetReadOnly();
		}

		public void Go_Back()
		{
			this.BS_RESERVATION.MovePrevious();
			Sync_ForeignTables();
			SetReadOnly();
		}

		public void Go_Forward()
		{
			this.BS_RESERVATION.MoveNext();
			Sync_ForeignTables();
			SetReadOnly();
		}

		public void Go_End()
		{
			this.BS_RESERVATION.MoveLast();
			Sync_ForeignTables();
			SetReadOnly();
		}
	}
}
