using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PrjEq01_CommonForm;

namespace PrjEq01_Application.Tabs
{
	public partial class UC_Arrive : UserControl, PrjEq01_CommonForm.IButtons
	{
		public States State { get; set; }
		private DataRow DTR_Arrive, DTR_De;
		private ErrorProvider errorProvider;

		private bool LinkArrive_State, LinkClient_State, LinkReservation_State, LinkChambre_State;

		public UC_Arrive()
		{
			InitializeComponent();
			ic_arrive.BS = BS_CLIENT;
			ic_arrive.ClientSelected += OnClientSelected;
			ir_arrive.BS = BS_RESERVATION;
			ir_arrive.ReservSelected += OnReservSelected;
			lc_arrive.setBS(BS_CHAMBRE);
			lc_arrive.ChambreSelected += OnChambreSelected;
			State = States.CONSULT;

			errorProvider = new ErrorProvider();
		}

		private void Tab_Arrive_Load(object sender, EventArgs e)
		{
			Fill();
			Link_All(true);
			Sync_ForeignTables();
		}

		public void Fill()
		{
			int IdArrive = 0;
			try
			{
				IdArrive = (int)ds_master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdArrive"];
			}
			catch (Exception e) { }

			this.TA_CLIENT.Fill(this.ds_master.CLIENT);
			this.TA_DE.FillBy(ds_master.DE);
			if (State == States.ADD || State == States.EDIT)
			{
				this.TA_RESERVATION.FillByArriveDate(this.ds_master.RESERVATION, ds_master.ARRIVE[BS_ARRIVE.Position].DateArrive.ToString());
			}
			else if (State == States.CONSULT)
			{
				this.TA_ARRIVE.Fill(this.ds_master.ARRIVE);
				this.TA_CHAMBRE.FillByARRIVE(this.ds_master.CHAMBRE);
				this.TA_RESERVATION.FillByARRIVE(this.ds_master.RESERVATION);
			}
			if (BS_ARRIVE.DataSource != null)
				BS_ARRIVE.Position = BS_ARRIVE.Find("IdArrive", IdArrive);
			Sync_ForeignTables();
		}

		private void Link_All(bool link_state)
		{
			Link_CLIENT(link_state);
			Link_RESERVATION(link_state);
			Link_ARRIVE(link_state);
			Link_CHAMBRE(link_state);
		}

		private void Link_ARRIVE(bool link_state)
		{
			this.BS_ARRIVE.DataMember = "ARRIVE";
			this.BS_ARRIVE.DataSource = this.ds_master;

			if (LinkArrive_State != link_state)
			{
				if (link_state == true)
				{
					try
					{
						tb_noArrive.DataBindings.Add("Text", BS_ARRIVE, "IdArrive");
						ic_arrive.tb_noClient.DataBindings.Add("Text", BS_ARRIVE, "IdCli");
						ir_arrive.tb_noReserv.DataBindings.Add("Text", BS_ARRIVE, "IdReser");
						ic_arrive.tb_noChambre.DataBindings.Add("Text", BS_ARRIVE, "NoCham");
					}
					catch (Exception ee) { MessageBox.Show(ee.Message); }
				}
				else
				{
					try
					{
						tb_noArrive.DataBindings.Clear();
						ic_arrive.tb_noClient.DataBindings.Clear();
						ir_arrive.tb_noReserv.DataBindings.Clear();
						ic_arrive.tb_noChambre.DataBindings.Clear();
					}
					catch (Exception ee) { MessageBox.Show(ee.Message); }
				}
				LinkArrive_State = link_state;
			}

		}

		private void Link_CLIENT(bool link_state)
		{
			this.BS_CLIENT.DataMember = "CLIENT";
			this.BS_CLIENT.DataSource = this.ds_master;

			if (LinkClient_State != link_state)
			{
				if (link_state == true)
				{
					try
					{
						ic_arrive.tb_nomClient.DataBindings.Add("Text", BS_CLIENT, "Nom");
						ic_arrive.tb_adresse.DataBindings.Add("Text", BS_CLIENT, "Adresse");
						ic_arrive.tb_telephone.DataBindings.Add("Text", BS_CLIENT, "Telephone");
						ic_arrive.tb_typeCarte.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
						ic_arrive.tb_noCarte.DataBindings.Add("Text", BS_CLIENT, "NoCarte");
						ic_arrive.dtp_datExp.DataBindings.Add("Text", BS_CLIENT, "DatExp");
					}
					catch (Exception ee) { MessageBox.Show(ee.Message); }
				}
				else
				{
					try
					{
						ic_arrive.tb_nomClient.DataBindings.Clear();
						ic_arrive.tb_adresse.DataBindings.Clear();
						ic_arrive.tb_telephone.DataBindings.Clear();
						ic_arrive.tb_typeCarte.DataBindings.Clear();
						ic_arrive.tb_noCarte.DataBindings.Clear();
						ic_arrive.dtp_datExp.DataBindings.Clear();
					}
					catch (Exception ee) { MessageBox.Show(ee.Message); }
				}
				LinkClient_State = link_state;
			}
		}

		private void Link_RESERVATION(bool link_state)
		{
			this.BS_RESERVATION.DataMember = "RESERVATION";
			this.BS_RESERVATION.DataSource = this.ds_master;

			if (LinkReservation_State != link_state)
			{
				if (link_state == true)
				{
					try
					{
						ir_arrive.DTP_Reserv.DataBindings.Add("Text", BS_RESERVATION, "DateReser");
						ir_arrive.DTP_Debut.DataBindings.Add("Text", BS_RESERVATION, "DateDebut");
						ir_arrive.DTP_Fin.DataBindings.Add("Text", BS_RESERVATION, "DateFin");
						ir_arrive.tb_noClient.DataBindings.Add("Text", BS_RESERVATION, "IdCli");
						ir_arrive.tb_nom.DataBindings.Add("Text", BS_RESERVATION, "Nom");
					}
					catch (Exception ee) { MessageBox.Show(ee.Message); }
				}
				else
				{
					try
					{
						ir_arrive.DTP_Reserv.DataBindings.Clear();
						ir_arrive.DTP_Debut.DataBindings.Clear();
						ir_arrive.DTP_Fin.DataBindings.Clear();
						ir_arrive.tb_noClient.DataBindings.Clear();
						ir_arrive.tb_nom.DataBindings.Clear();
					}
					catch (Exception ee) { MessageBox.Show(ee.Message); }
				}
				LinkReservation_State = link_state;
			}
		}

		private void Link_CHAMBRE(bool link_state)
		{
			this.BS_CHAMBRE.DataMember = "DE_FK_IdReser";
			this.BS_CHAMBRE.DataSource = this.BS_RESERVATION;

			if (LinkChambre_State != link_state)
			{

				if (link_state)
				{
					try
					{
						lc_arrive.dgv_chambre.DataSource = BS_CHAMBRE;
					}
					catch (Exception e)
					{ MessageBox.Show(e.Message); }
				}
				else
				{
					try
					{
						lc_arrive.dgv_chambre.DataSource = null;
					}
					catch (Exception e)
					{ MessageBox.Show(e.Message); }
				}
				LinkChambre_State = link_state;
			}
		}

		public void SetReadOnly(States state)
		{
			List<IInfoBox> consult_controls = new List<IInfoBox>
			{
				ic_arrive,
				ir_arrive,
				lc_arrive
			};

			foreach (IInfoBox consult_control in consult_controls)
			{
				consult_control.SetReadOnly(state);
			}

			if (state == States.CONSULT)
				errorProvider.Clear();
		}

		public void Sync_ForeignTables()
		{
			try
			{
				if (BS_CLIENT.DataSource != null)
					BS_CLIENT.Position = BS_CLIENT.Find("IdCli", ds_master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdCli"]);
				if (BS_RESERVATION.DataSource != null)
					BS_RESERVATION.Position = BS_RESERVATION.Find("IdReser", ds_master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdReser"]);
			}
			catch (Exception e) { MessageBox.Show(e.Message); }
		}

		public bool Add()
		{
			NewArrive();
			MessageBox.Show("DateArrive : " + DTR_Arrive["DateArrive"].ToString());
			return true;
		}

		public bool Edit()
		{
			DTR_Arrive = ds_master.Tables["Arrive"].Rows[BS_ARRIVE.Position];
			return true;
		}

		public bool Delete()
		{
			DialogResult result = MessageBox.Show("Do you want to delete the arrive?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			switch (result)
			{
				case DialogResult.Yes:
					BS_ARRIVE.RemoveCurrent();
					TA_ARRIVE.Update(ds_master.ARRIVE);
					break;
				case DialogResult.No:
					break;
			}
			return true;
		}

		public bool Undo()
		{
			if (State == States.ADD || State == States.EDIT)
			{
				if (Convert.ToInt16(DTR_Arrive["NoCham"]) != -1)
				{
					DTR_De.RejectChanges();
					BS_RESERVATION.Position = BS_RESERVATION.Find("IdReser", DTR_Arrive["IdReser"]);
					DataRowView De = (DataRowView)BS_CHAMBRE[BS_CHAMBRE.Find("NoCham", DTR_Arrive["NoCham"])];
					DTR_De = De.Row;
					DTR_De.BeginEdit();
					DTR_De["Attribuee"] = false;
					DTR_De.EndEdit();
				}

				DTR_Arrive.RejectChanges();

				if(State == States.ADD)
				{
					ds_master.Tables["Arrive"].Rows.RemoveAt(ds_master.ARRIVE.Rows.Count - 1);
					DTR_Arrive.Delete();
					BS_ARRIVE.Position = 0;
				}

				this.TA_RESERVATION.FillByARRIVE(this.ds_master.RESERVATION);
				Sync_ForeignTables();
				Link_All(true);
			}
			return true;
		}

		public bool Save()
		{
			bool hasErrors = CheckSaveErrors();
			if (State == States.ADD || State == States.EDIT)
			{
				if (!hasErrors)
				{
					DialogResult result = MessageBox.Show("Do you want to save the information?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					switch (result)
					{
						case DialogResult.Yes:
							try
							{
								DTR_Arrive.EndEdit();
								DTR_De.EndEdit();
								TA_ARRIVE.Update(ds_master.ARRIVE);
								TA_DE.Update(ds_master.DE);
								Link_All(true);
								this.TA_RESERVATION.FillByARRIVE(this.ds_master.RESERVATION);
								Sync_ForeignTables();
							}
							catch (Exception e)
							{
								hasErrors = true;
								MessageBox.Show(e.Message);
							}
							return true;
						case DialogResult.No:
							return false;
						default:
							return false;
					}
				}
			}
			return !hasErrors;
		}

		public void Go_Start()
		{
			BS_ARRIVE.MoveFirst();
			Sync_ForeignTables();
		}

		public void Go_Back()
		{
			BS_ARRIVE.MovePrevious();
			Sync_ForeignTables();
		}

		public void Go_Forward()
		{
			BS_ARRIVE.MoveNext();
			Sync_ForeignTables();
		}

		public void Go_End()
		{
			BS_ARRIVE.MoveLast();
			Sync_ForeignTables();
		}

		public void NewArrive()
		{
			BS_ARRIVE.Position = BS_ARRIVE.Count - 1;
			ds_master.ARRIVE.Columns["IdArrive"].AutoIncrementSeed = (int)ds_master.ARRIVE.Rows[BS_ARRIVE.Position]["IdArrive"] + 1;

			DTR_Arrive = ds_master.Tables["Arrive"].NewRow();
			DTR_Arrive["IdArrive"] = (int)ds_master.ARRIVE.Columns["IdArrive"].AutoIncrementSeed;
			DTR_Arrive["DateArrive"] = DateTime.Now.ToLocalTime();
			DTR_Arrive["IdCli"] = -1;
			DTR_Arrive.SetColumnError(DTR_Arrive.Table.Columns["IdCli"], "Un client doit être sélectionné.");
			DTR_Arrive["IdReser"] = -1;
			DTR_Arrive.SetColumnError(DTR_Arrive.Table.Columns["IdReser"], "Une réservation doit être sélectionnée.");
			DTR_Arrive["NoCham"] = -1;
			DTR_Arrive.SetColumnError(DTR_Arrive.Table.Columns["NoCham"], "Une chambre doit être sélectionnée.");

			ds_master.Tables["Arrive"].Rows.Add(DTR_Arrive);
			BS_ARRIVE.Position = BS_ARRIVE.Count - 1;

			DTR_Arrive.BeginEdit();

			Link_All(false);
			Link_ARRIVE(true);

			this.TA_RESERVATION.FillByArriveDate(this.ds_master.RESERVATION, ds_master.ARRIVE[BS_ARRIVE.Position].DateArrive.ToString());

			ic_arrive.WipeInformation();
			ir_arrive.WipeInformation();
		}

		public void OnClientSelected(int IdCli)
		{
			DTR_Arrive["IdCli"] = IdCli;

			if (DTR_Arrive.GetColumnError("IdCli") != "")
			{
				DTR_Arrive.SetColumnError(DTR_Arrive.Table.Columns["IdCli"], "");
			}

			errorProvider.SetError(ic_arrive.tb_noClient, "");

			Link_CLIENT(true);
			Sync_ForeignTables();
		}

		public void OnReservSelected(int IdReser)
		{
			//lc_arrive.SetListButton(true);
			ir_arrive.BS = BS_RESERVATION;

			if (Convert.ToInt16(DTR_Arrive["NoCham"]) != -1)
			{
				BS_RESERVATION.Position = BS_RESERVATION.Find("IdReser", DTR_Arrive["IdReser"]);
				DataRowView De = (DataRowView)BS_CHAMBRE[BS_CHAMBRE.Find("NoCham", DTR_Arrive["NoCham"])];
				DTR_De = De.Row;
				DTR_De.BeginEdit();
				DTR_De["Attribuee"] = false;
				DTR_Arrive["NoCham"] = -1;
			}

			DTR_Arrive["IdReser"] = IdReser;
			DTR_Arrive.EndEdit();

			if (DTR_Arrive.GetColumnError("IdReser") != "")
			{
				DTR_Arrive.SetColumnError(DTR_Arrive.Table.Columns["IdReser"], "");
			}

			errorProvider.SetError(ir_arrive.tb_noReserv, "");

			Link_RESERVATION(true);
			Link_CHAMBRE(true);
			Sync_ForeignTables();
		}

		public void OnChambreSelected(int NoCham)
		{
			if (State == States.ADD || State == States.EDIT)
			{
				DataRowView De = (DataRowView)BS_CHAMBRE[BS_CHAMBRE.Find("NoCham", NoCham)];
				DTR_De = De.Row;
				if (Convert.ToInt16(DTR_De["NoCham"]) != Convert.ToInt16(DTR_Arrive["NoCham"]))
				{
					if (Convert.ToBoolean(DTR_De["Attribuee"]) == false)
					{
						DTR_De.BeginEdit();
						DTR_De["Attribuee"] = true;
						DTR_De.EndEdit();

						if (Convert.ToInt16(DTR_Arrive["NoCham"]) != -1)
						{
							De = (DataRowView)BS_CHAMBRE[BS_CHAMBRE.Find("NoCham", Convert.ToInt16(DTR_Arrive["NoCham"]))];
							DTR_De = De.Row;
							DTR_De.BeginEdit();
							DTR_De["Attribuee"] = false;
							DTR_De.EndEdit();
						}

						DTR_Arrive["NoCham"] = NoCham;

						if (DTR_Arrive.GetColumnError("NoCham") != "")
						{
							DTR_Arrive.SetColumnError(DTR_Arrive.Table.Columns["NoCham"], "");
						}

						errorProvider.SetError(ic_arrive.tb_noChambre, "");

						Sync_ForeignTables();
					}
					else
					{
						MessageBox.Show("Chambre déja attribuée", "Erreur chambre", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		public bool CheckSaveErrors()
		{
			if (State == States.ADD || State == States.EDIT)
			{
				if (DTR_Arrive.HasErrors)
				{
					SetErrors();
					return true;
				}
			}
			return false;
		}

		public void SetErrors()
		{
			foreach (DataColumn column in DTR_Arrive.GetColumnsInError())
			{
				switch (column.ColumnName)
				{
					case "IdCli":
						errorProvider.SetError(ic_arrive.tb_noClient, DTR_Arrive.GetColumnError(column));
						break;
					case "IdReser":
						errorProvider.SetError(ir_arrive.tb_noReserv, DTR_Arrive.GetColumnError(column));
						break;
					case "NoCham":
						errorProvider.SetError(ic_arrive.tb_noChambre, DTR_Arrive.GetColumnError(column));
						break;
				}
			}
		}
	}
}
