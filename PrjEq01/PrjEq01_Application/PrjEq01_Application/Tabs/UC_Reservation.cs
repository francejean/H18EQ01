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
	public partial class UC_Reservation : UserControl, IButtons
	{
		public States State { get; set; }

		private DataRow DTR_RESERV;
		private DataRow DTR_DE;

		private BindingSource BS_BK_CHAMBRE = new BindingSource();

		private bool LinkReser_State, LinkClient_State, LinkChambre_State;

		// le solde à ajouter au solde courant du client
		private decimal soldeClientAjouter = 0;

		public UC_Reservation()
		{
			InitializeComponent();

			ic_Reserv.BS = BS_CLIENT;
			ic_Reserv.ClientSelected = this.OnClientSelected;

			ir_Reserv.BS = BS_RESERVATION;
			ir_Reserv.ReservSelected = this.OnReservSelected;

			lc_reserv.setBS(BS_BK_CHAMBRE);
			lc_reserv.OnSelected = this.OnChambreSelected;
			lc_reserv.BeforeSelection = this.BeforeChamberSelection;
			lc_reserv.DeleteCurrent = this.OnLCDelete;

			State = States.CONSULT;
		}

		private void Tab_Reservation_Load(object sender, EventArgs e)
		{
			Fill();
			Link_All(true);
			
			Sync_ForeignTables();
		}

		public void Fill()
		{
			TA_DE.FillBy(DS_Master.DE);
			TA_CLIENT.Fill(DS_Master.CLIENT);
			TA_CHAMBRE.Fill(DS_Master.CHAMBRE);
			TA_RESERVATION.Fill(DS_Master.RESERVATION);
		}

		private void Link_All(bool link_state)
		{
			Link_Reservation(link_state);
			Link_Client(link_state);
			Link_Chamber(link_state);

			// BS_DE
			BS_DE.DataMember = "DE_FK_IdReser";
			BS_DE.DataSource = BS_RESERVATION;
			lc_reserv.dgv_chambre.DataSource = BS_DE;

			// BS_BK_CHAMBRE
			BS_BK_CHAMBRE.DataMember = "BK_CHAMBRE";
			BS_BK_CHAMBRE.DataSource = DS_Master;
		}

		private void Link_Reservation(bool link_state)
		{
			this.BS_RESERVATION.DataMember = "RESERVATION";
			this.BS_RESERVATION.DataSource = this.DS_Master;

			if (LinkReser_State != link_state)
			{
				if (link_state)
				{
					try
					{
						ic_Reserv.tb_noClient.DataBindings.Add("Text", BS_RESERVATION, "IdCli");
						ir_Reserv.tb_noReserv.DataBindings.Add("Text", BS_RESERVATION, "IdReser");
						ir_Reserv.DTP_Reserv.DataBindings.Add("Text", BS_RESERVATION, "DateReser");
						ir_Reserv.DTP_Debut.DataBindings.Add("Text", BS_RESERVATION, "DateDebut");
						ir_Reserv.DTP_Fin.DataBindings.Add("Text", BS_RESERVATION, "DateFin");
					}
					catch (Exception e)
					{ MessageBox.Show(e.Message); }
				}
				else
				{
					try
					{
						ic_Reserv.tb_noClient.DataBindings.Clear();
						ir_Reserv.tb_noReserv.DataBindings.Clear();
						ir_Reserv.DTP_Reserv.DataBindings.Clear();
						ir_Reserv.DTP_Debut.DataBindings.Clear();
						ir_Reserv.DTP_Fin.DataBindings.Clear();
					}
					catch (Exception e)
					{ MessageBox.Show(e.Message); }
				}
				LinkReser_State = link_state;
			}
		}

		private void Link_Client(bool link_state)
		{
			this.BS_CLIENT.DataMember = "CLIENT";
			this.BS_CLIENT.DataSource = this.DS_Master;

			if (LinkClient_State != link_state)
			{
				if (link_state)
				{
					try
					{
						ic_Reserv.tb_nomClient.DataBindings.Add("Text", BS_CLIENT, "Nom");
						ic_Reserv.tb_adresse.DataBindings.Add("Text", BS_CLIENT, "Adresse");
						ic_Reserv.tb_telephone.DataBindings.Add("Text", BS_CLIENT, "Telephone");
						ic_Reserv.tb_noCarte.DataBindings.Add("Text", BS_CLIENT, "NoCarte");
						ic_Reserv.cb_typeCarte.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
						ic_Reserv.dtp_datExp.DataBindings.Add("Text", BS_CLIENT, "DatExp");
						ic_Reserv.tb_solde.DataBindings.Add("Text", BS_CLIENT, "SoldeDu");
					}
					catch (Exception e)
					{ MessageBox.Show(e.Message); }
				}
				else
				{
					try
					{
						ic_Reserv.tb_nomClient.DataBindings.Clear();
						ic_Reserv.tb_adresse.DataBindings.Clear();
						ic_Reserv.tb_telephone.DataBindings.Clear();
						ic_Reserv.tb_noCarte.DataBindings.Clear();
						ic_Reserv.cb_typeCarte.DataBindings.Clear();
						ic_Reserv.dtp_datExp.DataBindings.Clear();
						ic_Reserv.tb_solde.DataBindings.Clear();
					}
					catch (Exception e)
					{ MessageBox.Show(e.Message); }
				}
				LinkClient_State = link_state;
			}
		}

		private void Link_Chamber(bool link_state)
		{
			this.BS_CHAMBRE.DataMember = "CHAMBRE";
			this.BS_CHAMBRE.DataSource = this.DS_Master;
			if (LinkChambre_State != link_state)
			{
				if (link_state)
				{
					try
					{
						lc_reserv.dgv_chambre.DataSource = BS_DE;
					}
					catch (Exception e)
					{ MessageBox.Show(e.Message); }
				}
				else
				{
					try
					{
						lc_reserv.dgv_chambre.DataSource = null;
					}
					catch (Exception e)
					{ MessageBox.Show(e.Message); }
				}
				LinkChambre_State = link_state;
			}
		}

		public void SetReadOnly(States state)
		{
			List<IInfoBox> consult_controls = new List<IInfoBox> { ic_Reserv, ir_Reserv, lc_reserv };

			foreach (IInfoBox consult_control in consult_controls)
			{ consult_control.SetReadOnly(state); }
		}

		public bool Sync_ForeignTables()
		{
			BS_CLIENT.Position = BS_CLIENT.Find("IdCli", DS_Master.Tables["RESERVATION"].Rows[BS_RESERVATION.Position]["IdCli"]);
			return false;
		}

		private void EmptyFields()
		{
			ic_Reserv.WipeInformation();
			ir_Reserv.WipeInformation();
		}

		public void OnClientSelected(int IdCli)
		{
			DTR_RESERV["IdCli"] = IdCli;

			soldeClientAjouter += (decimal)DS_Master.Tables["CLIENT"].Rows[BS_CLIENT.Position]["SoldeDu"];
			AjusteSoldeDuClient(0);
			
			Link_Client(true);
			Sync_ForeignTables();
		}

		public void OnReservSelected(int IdReserv)
		{
			ir_Reserv.BS.Position = BS_RESERVATION.Find("IdReser", IdReserv);
			
			Sync_ForeignTables();
		}

		public bool BeforeChamberSelection()
		{
			if (ic_Reserv.tb_noClient.Text != "" && ic_Reserv.tb_noClient.Text != "-1")
			{
				if (ir_Reserv.DTP_Debut.Enabled && ir_Reserv.DTP_Fin.Enabled)
					TA_BK_CHAMBRE.FillBy(DS_Master.BK_CHAMBRE, ir_Reserv.DTP_Debut.Value, ir_Reserv.DTP_Fin.Value);

				ic_Reserv.bt_list.Enabled = false;
				ir_Reserv.DTP_Debut.Enabled = false;
				ir_Reserv.DTP_Fin.Enabled = false;

				errorProvider.SetError(ic_Reserv.bt_list, "");
				return true;
			}
			else
				errorProvider.SetError(ic_Reserv.bt_list, "Choisissez un client avant d'ajouter des chambres.");

			return false;
		}

		public void OnChambreSelected(string PK)
		{
			if(State == States.ADD || State == States.EDIT)
			{
				DTR_DE = DS_Master.Tables["De"].NewRow();
				//DTR_DE["IdReser"] = DS_Master.Tables["RESERVATION"].Rows[BS_RESERVATION.Position]["IdReser"];
				DTR_DE["IdReser"] = ir_Reserv.tb_noReserv.Text;
				DTR_DE["NoCham"] = DS_Master.Tables["BK_CHAMBRE"].Rows[BS_BK_CHAMBRE.Position]["NoCham"];

				DTR_DE["CodTypCham"] = DS_Master.Tables["BK_CHAMBRE"].Rows[BS_BK_CHAMBRE.Position]["CodTypCham"];
				DTR_DE["Attribuee"] = true;
				DTR_DE["Prix"] = DS_Master.Tables["BK_CHAMBRE"].Rows[BS_BK_CHAMBRE.Position]["Prix"];

				DS_Master.Tables["DE"].Rows.Add(DTR_DE);

				BS_BK_CHAMBRE.RemoveCurrent();
				DS_Master.Tables["BK_CHAMBRE"].AcceptChanges();
				
				AjusteSoldeDuClient((decimal)DS_Master.Tables["BK_CHAMBRE"].Rows[BS_BK_CHAMBRE.Position]["Prix"]);
			}
		}

		public void OnLCDelete()
		{
			bool addOnBK = false;
			DTR_DE = DS_Master.Tables["DE"].Rows[BS_DE.Position];
			DTR_RESERV = DS_Master.Tables["RESERVATION"].Rows[BS_RESERVATION.Position];
			DataRow DTR_chambre = DS_Master.Tables["CHAMBRE"].Rows.Find(DTR_DE["NoCham"]);
			if (DTR_chambre["Etat"].ToString() == "1")
			{
				foreach (DataRow DTR_reservtmp in DS_Master.Tables["RESERVATION"].Rows)
				{
					if (DTR_reservtmp["IdReser"] != DTR_DE["IdReser"])
					{
						if (((DateTime)DTR_reservtmp["DateDebut"] >= (DateTime)DTR_RESERV["DateDebut"] && (DateTime)DTR_reservtmp["DateDebut"] <= (DateTime)DTR_RESERV["DateFin"]) ||
							((DateTime)DTR_reservtmp["DateFin"] >= (DateTime)DTR_RESERV["DateDebut"] && (DateTime)DTR_reservtmp["DateFin"] <= (DateTime)DTR_RESERV["DateFin"]))
						{

						}
					}
				}
			}
		}

		private void AjusteSoldeDuClient(decimal ajoutMontant)
		{
			soldeClientAjouter += ajoutMontant;

			if ((int)DTR_RESERV["IdCli"] != -1)
			{
				ic_Reserv.tb_solde.Text = soldeClientAjouter.ToString();
			}
		}

		public bool Add()
		{
			NewReserv();
			return true;
		}

		public bool Edit()
		{
			BS_BK_CHAMBRE.Position = BS_BK_CHAMBRE.Count - 1;
			
			DTR_RESERV = DS_Master.Tables["Reservation"].Rows[BS_RESERVATION.Position];
			DTR_RESERV.BeginEdit();

			return true;
		}

		public bool Delete()
		{
			TA_TRX.Fill(DS_Master.TRX);
			TA_ARRIVE.Fill(DS_Master.ARRIVE);
			TA_DEPART.Fill(DS_Master.DEPART);

			DTR_RESERV = DS_Master.Tables["RESERVATION"].Rows[BS_RESERVATION.Position];
			int i = DTR_RESERV.GetChildRows("ARRIVE_FK_IdReser").Length;
			int j = DTR_RESERV.GetChildRows("DEPART_FK_IdReser").Length;

			// Pré-conditions
			if(i != 0 && j != i)
			{
				MessageBox.Show("Le nombre d'arrivés n'est pas compatible avec le nombre de départs associés à cette réservation","Impossible de suprimer");
				return false;
			}

			if (ir_Reserv.DTP_Fin.Value.AddDays(2) < DateTime.Today)
			{
				MessageBox.Show("Une réservation doit rester dans la base de donnée au moins 2 jours après sa date de fin.", "Impossible de suprimer");
				return false;
			}

			// Post-conditions
			foreach (DataRow DTR in DTR_RESERV.GetChildRows("TRX_FK_IdReser"))
			{
				DTR["IdReser"] = null;
			}

			foreach (DataRow DTR in DTR_RESERV.GetChildRows("DE_FK_IdReser"))
			{
				DTR.Delete();
			}

			foreach (DataRow DTR in DTR_RESERV.GetChildRows("DEPART_FK_IdReser"))
			{
				DTR.Delete();
			}

			foreach (DataRow DTR in DTR_RESERV.GetChildRows("ARRIVE_FK_IdReser"))
			{
				DTR.Delete();
			}

			DTR_RESERV.Delete();

			try
			{
				TA_TRX.Update(DS_Master.TRX);
				TA_DE.Update(DS_Master.DE);
				TA_ARRIVE.Update(DS_Master.ARRIVE);
				TA_DEPART.Update(DS_Master.DEPART);
				TA_RESERVATION.Update(DS_Master.RESERVATION);

				Sync_ForeignTables();

				MessageBox.Show("Reservation supprimé avec succès.", "Succès");
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return false;
		}

		public bool Undo()
		{
			if (State == States.ADD)
			{
				ic_Reserv.ResetErrors();
				lc_reserv.ResetErrors();

				DS_Master.Tables["Reservation"].Rows.RemoveAt(DS_Master.RESERVATION.Rows.Count - 1);
				DTR_RESERV.CancelEdit();
				DTR_DE?.CancelEdit();
				BS_RESERVATION.Position = 0;
				Link_All(true);
			}
			else if (State == States.EDIT)
			{
				ic_Reserv.ResetErrors();
				lc_reserv.ResetErrors();

				DTR_RESERV.CancelEdit();
				DTR_DE?.CancelEdit();
				BS_RESERVATION.Position = 0;
			}
			return true;
		}

		public bool Save()
		{
			if (!CheckErrors())
			{
				ic_Reserv.ResetErrors();
				lc_reserv.ResetErrors();

				TA_RESERVATION.Update(DS_Master.RESERVATION);
				try
				{
					TA_DE.Update(DS_Master.DE);
					return true;
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
				}
			}
			return false;
		}
		
		public void Go_Start()
		{
			this.BS_RESERVATION.MoveFirst();
			Sync_ForeignTables();
		}

		public void Go_Back()
		{
			this.BS_RESERVATION.MovePrevious();
			Sync_ForeignTables();
		}

		public void Go_Forward()
		{
			this.BS_RESERVATION.MoveNext();
			Sync_ForeignTables();
		}

		public void Go_End()
		{
			this.BS_RESERVATION.MoveLast();
			Sync_ForeignTables();
		}

		private void NewReserv()
		{
			TA_DE.FillBy(DS_Master.DE);
			TA_BK_CHAMBRE.Fill(DS_Master.BK_CHAMBRE);

			BS_RESERVATION.Position = BS_RESERVATION.Count - 1;
			BS_BK_CHAMBRE.Position = BS_BK_CHAMBRE.Count - 1;
			DS_Master.RESERVATION.Columns["IdReser"].AutoIncrementSeed = (int)DS_Master.RESERVATION.Rows[BS_RESERVATION.Position]["IdReser"] + 1;
			
			DTR_RESERV = DS_Master.Tables["Reservation"].NewRow();
			DTR_RESERV["IdReser"] = (int)DS_Master.RESERVATION.Columns["IdReser"].AutoIncrementSeed;
			DTR_RESERV["IdCli"] = -1;
			DTR_RESERV["DateReser"] = DateTime.Today;
			DTR_RESERV["DateDebut"] = DateTime.Today;
			DTR_RESERV["DateFin"] = DateTime.Today.AddDays(3);
			DS_Master.Tables["Reservation"].Rows.Add(DTR_RESERV);

			BS_RESERVATION.Position = BS_RESERVATION.Count - 1;

			Link_All(false);
			Link_Reservation(true);

			EmptyFields();
		}

		private bool CheckErrors()
		{
			// We need all the functions to execute
			bool result = false;
			result |= this.ic_Reserv.CheckErrors();
			result |= this.ir_Reserv.CheckErrors();
			result |= this.lc_reserv.CheckErrors();

			return result;
		}
	}
}
