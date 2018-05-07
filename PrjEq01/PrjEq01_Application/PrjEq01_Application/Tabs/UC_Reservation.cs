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

		private BindingSource BS_BK_CHAMBRE = new BindingSource();

		private bool LinkReser_State, LinkClient_State, LinkChambre_State;

		public UC_Reservation()
		{
			InitializeComponent();
			ic_Reserv.BS = BS_CLIENT;
			ic_Reserv.ClientSelected = this.OnClientSelected;
			ir_Reserv.BS = BS_RESERVATION;
			ir_Reserv.ReservSelected = this.OnReservSelected;
			lc_reserv.setBS(BS_CHAMBRE);

			State = States.CONSULT;
		}

		private void Tab_Reservation_Load(object sender, EventArgs e)
		{
			Fill();
			Link_All(true);

			BS_BK_CHAMBRE.DataSource = DS_Master;
			BS_BK_CHAMBRE.DataMember = "BK_CHAMBRE";
			
			Sync_ForeignTables();
		}

		private void Fill()
		{
			TA_DE.FillBy(DS_Master.DE);
			TA_CHAMBRE.Fill(DS_Master.CHAMBRE);
			TA_RESERVATION.Fill(DS_Master.RESERVATION);
			TA_CLIENT.Fill(DS_Master.CLIENT);
		}

		private void Link_All(bool link_state)
		{
			Link_Reservation(link_state);
			Link_Client(link_state);
			Link_Chamber(link_state);
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
						ic_Reserv.tb_typeCarte.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
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
						ic_Reserv.tb_typeCarte.DataBindings.Clear();
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
			this.BS_CHAMBRE.DataMember = "DE_FK_IdReser";
			this.BS_CHAMBRE.DataSource = this.BS_RESERVATION;
			if (LinkChambre_State != link_state)
			{
				if (link_state)
				{
					try
					{
						lc_reserv.dgv_chambre.DataSource = BS_CHAMBRE;
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
			DTR_RESERV.AcceptChanges();
			Link_Client(true);
			Sync_ForeignTables();
		}

		public void OnReservSelected(int IdReserv)
		{
			ir_Reserv.BS.Position = BS_RESERVATION.Find("IdReser", IdReserv);
			
			Sync_ForeignTables();
		}

		public bool Add()
		{
			NewReserv();
			return true;
		}

		public bool Edit()
		{
			MessageBox.Show("Fonction en développement.");
			//SetReadOnly(States.EDIT);
			return false;
		}

		public bool Delete()
		{
			MessageBox.Show("Fonction en développement.");
			//SetReadOnly(States.CONSULT);
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
				BS_RESERVATION.Position = 0;
				Link_All(true);
			}
			return true;
		}

		public bool Save()
		{
			if (!CheckErrors())
			{
				ic_Reserv.ResetErrors();
				lc_reserv.ResetErrors();
				return true;
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
			// We need the two functions to execute
			bool result1 = this.ic_Reserv.CheckErrors(),
				 result2 = this.lc_reserv.CheckErrors();
			return result1 || result2;
		}
	}
}
