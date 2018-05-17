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
using System.Data.SqlClient;

namespace PrjEq01_Application.Tabs
{
	public partial class UC_Departs : UserControl, IButtons
	{
		public States State { get; set; }

		private DataRow DTR_Depart;

		private ErrorProvider errorProvider = new ErrorProvider();

		public UC_Departs()
		{
			InitializeComponent();
			ic_base.bt_list.Enabled = false;
			ic_base.bt_list.Visible = false;
			ir_departs.tb_confirmerPar.Enabled = false;
			State = States.CONSULT;
		}

		private void Tab_Departs_Load(object sender, EventArgs e)
		{
			Fill();
			LinkAll();
			Sync_ForeignTables();
		}

		public void Fill()
		{
			string idArrive = null;
			if(BS_ARRIVE.Position >= 0)
			{
				try
				{
					idArrive = dS_Master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdArrive"].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

			if (State == States.ADD)
			{
				TA_ARRIVE.FillBy(this.dS_Master.ARRIVE, DateTime.Today.ToString());
			}
			else
			{
				TA_ARRIVE.Fill(this.dS_Master.ARRIVE);
			}
			TA_CLIENT.Fill(this.dS_Master.CLIENT);
			TA_RESERVATION.Fill(this.dS_Master.RESERVATION);
			TA_DE.Fill(this.dS_Master.DE);
			if (State == States.CONSULT)
			{
				TA_DEPART.FillByDEPART(this.dS_Master.DEPART);
			}
			if (BS_ARRIVE != null && idArrive != null)
			{
				BS_ARRIVE.Position = BS_ARRIVE.Find("IdArrive", idArrive);
			}
			else
			{
				BS_ARRIVE.Position = 0;
			}
			Sync_ForeignTables();
		}

		private void LinkAll()
		{
			LinkArrive();
			LinkClient();
			LinkReservation();
			LinkDepart();
			LinkDe();
		}

		private void LinkArrive()
		{
			BS_ARRIVE.DataMember = "ARRIVE";
			BS_ARRIVE.DataSource = dS_Master;

			try
			{
				tb_noArrivee.DataBindings.Add("Text", BS_ARRIVE, "IdArrive");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void LinkClient()
		{
			BS_CLIENT.DataMember = "CLIENT";
			BS_CLIENT.DataSource = dS_Master;

			try
			{
				ic_base.tb_noClient.DataBindings.Add("Text", BS_CLIENT, "IdCli");
				ic_base.tb_nomClient.DataBindings.Add("Text", BS_CLIENT, "Nom");
				ic_base.tb_adresse.DataBindings.Add("Text", BS_CLIENT, "Adresse");
				ic_base.tb_telephone.DataBindings.Add("Text", BS_CLIENT, "Telephone");
				ic_base.tb_typeCarte.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
				ic_base.tb_noCarte.DataBindings.Add("Text", BS_CLIENT, "NoCarte");
				ic_base.dtp_datExp.DataBindings.Add("Text", BS_CLIENT, "DatExp");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void LinkReservation()
		{
			BS_RESERVATION.DataMember = "RESERVATION";
			BS_RESERVATION.DataSource = this.dS_Master;

			try
			{
				ir_departs.tb_noReserv.DataBindings.Add("Text", BS_RESERVATION, "IdReser");
				ir_departs.DTP_Reserv.DataBindings.Add("Text", BS_RESERVATION, "DateReser");
				ir_departs.DTP_Debut.DataBindings.Add("Text", BS_RESERVATION, "DateDebut");
				ir_departs.DTP_Fin.DataBindings.Add("Text", BS_RESERVATION, "DateFin");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void LinkDepart()
		{
			BS_DEPART.DataMember = "DEPART_FK_IdReser";
			BS_DEPART.DataSource = BS_RESERVATION;
			dgv_departs.AutoGenerateColumns = false;
			dgv_departs.DataSource = BS_DEPART;
		}

		private void LinkDe()
		{
			BS_DE.DataMember = "DE";
			BS_DE.DataSource = dS_Master;
		}

		private bool IsConfirmerParValide()
		{
			errorProvider.SetError(ir_departs.tb_confirmerPar, string.Empty);
			if (ir_departs.tb_confirmerPar.Text.Length == 0)
			{
				errorProvider.SetError(ir_departs.tb_confirmerPar, "Vous devez confirmer un départ en entrant vos initials");
				return false;
			}
			else
			{
				return true;
			}
		}

		public void SetReadOnly(States state)
		{
			ir_departs.tb_confirmerPar.Enabled = (state == States.ADD);
			bt_listArrivee.Enabled = (state == States.CONSULT);
		}

		private void Sync_ForeignTables()
		{
			if(BS_ARRIVE.Count > 0)
			{
				if (BS_CLIENT.DataSource != null)
					BS_CLIENT.Position = BS_CLIENT.Find("IdCli", dS_Master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdCli"]);
				if (BS_RESERVATION.DataSource != null)
					BS_RESERVATION.Position = BS_RESERVATION.Find("IdReser", dS_Master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdReser"]);
			}
			else
			{
				ir_departs.WipeInformation();
				ic_base.WipeInformation();
			}
		}

		private void NewDepart()
		{
			DTR_Depart = dS_Master.Tables["DEPART"].NewRow();
			DTR_Depart["IdDepart"] = 0;
			DTR_Depart["DateDepart"] = DateTime.Today;
			DTR_Depart["IdCli"] = ic_base.tb_noClient.Text;
			DTR_Depart["IdReser"] = ir_departs.tb_noReserv.Text;
			DTR_Depart["NoCham"] = dS_Master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["NoCham"];
			DTR_Depart["ConfirmerPar"] = null;
			DTR_Depart["Nom"] = ic_base.tb_nomClient.Text;
			dS_Master.Tables["DEPART"].Rows.Add(DTR_Depart);
			BS_DEPART.Position = BS_DEPART.Count - 1;
		}

		private void DeleteDepart()
		{
			DTR_Depart = dS_Master.Tables["DEPART"].NewRow();
			DTR_Depart["IdReser"] = dS_Master.Tables["DEPART"].Rows[BS_DEPART.Position]["IdReser"];
			DTR_Depart["NoCham"] = dS_Master.Tables["DEPART"].Rows[BS_DEPART.Position]["NoCham"];
			BS_DEPART.RemoveCurrent();
			BS_DEPART.MoveFirst();
			try
			{
				TA_DEPART.Update(dS_Master.DEPART);
				AjustDe(false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			DTR_Depart.Delete();
		}


		private void AjustDe(bool attribuee)
		{
			if (DateTime.Today < ir_departs.DTP_Fin.Value)
			{
				Object[] pk = new object[2];
				pk[0] = DTR_Depart["IdReser"];
				pk[1] = DTR_Depart["NoCham"];
				DataRow DTR_De = dS_Master.Tables["DE"].Rows.Find(pk);
				if (DTR_De != null)
				{
					DTR_De.BeginEdit();
					DTR_De["Attribuee"] = attribuee;
					DTR_De.EndEdit();
					try
					{
						TA_DE.Update(dS_Master.DE);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		public bool Add()
		{
			TA_ARRIVE.FillBy(dS_Master.ARRIVE, DateTime.Today.ToString());
			if (dS_Master.Tables["ARRIVE"].Rows.Count <= 0)
			{
				MessageBox.Show("Aucune arrivées n'est disponible pour être associéer à un départ");
				TA_ARRIVE.Fill(dS_Master.ARRIVE);
				Sync_ForeignTables();
				return false;
			}
			PrjEq01_Application.List_Forms.LF_Arrive lf_arrive = new PrjEq01_Application.List_Forms.LF_Arrive(BS_ARRIVE);
			if (lf_arrive.ShowDialog() == DialogResult.Cancel)
			{
				TA_ARRIVE.Fill(dS_Master.ARRIVE);
				Sync_ForeignTables();
				return false;
			}
			Sync_ForeignTables();
			NewDepart();
			return true;
		}

		public bool Edit()
		{
			MessageBox.Show("Vous ne pouvez pas modifier un départ.");
			return false;
		}

		public bool Delete()
		{
			TA_DEPART.FillByToDel(dS_Master.DEPART, DateTime.Today.ToString());
			if (dS_Master.Tables["DEPART"].Rows.Count <= 0)
			{
				MessageBox.Show("Aucun depart n'est disponible pour être supprimer");
				TA_DEPART.FillByDEPART(dS_Master.DEPART);
				return false;
			}
			BS_DEPART.DataSource = dS_Master;
			BS_DEPART.DataMember = "DEPART";
			PrjEq01_Application.List_Forms.LF_Depart lf_depart = new PrjEq01_Application.List_Forms.LF_Depart(BS_DEPART);
			if (lf_depart.ShowDialog() == DialogResult.Cancel)
			{
				TA_DEPART.FillByDEPART(dS_Master.DEPART);
				BS_DEPART.DataSource = BS_RESERVATION;
				BS_DEPART.DataMember = "DEPART_FK_IdReser";
				return false;
			}
			DialogResult result = MessageBox.Show("Êtes-vous certains de vouloir supprimer ce départ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			switch (result)
			{
				case DialogResult.Yes:
					DeleteDepart();
					break;
				case DialogResult.No:
					break;
			}
			TA_DEPART.FillByDEPART(dS_Master.DEPART);
			BS_DEPART.DataSource = BS_RESERVATION;
			BS_DEPART.DataMember = "DEPART_FK_IdReser";
			return true;
		}

		public bool Undo()
		{
			if (State == States.ADD)
			{
				errorProvider.Clear();
				dS_Master.Tables["DEPART"].RejectChanges();
				BS_DEPART.ResetCurrentItem();
				TA_ARRIVE.Fill(dS_Master.ARRIVE);
				Sync_ForeignTables();
			}
			ir_departs.tb_confirmerPar.ResetText();
			return true;
		}

		public bool Save()
		{
			if (State == States.ADD)
			{
				if (IsConfirmerParValide())
				{
					DTR_Depart.BeginEdit();
					DTR_Depart["ConfirmerPar"] = ir_departs.tb_confirmerPar.Text;
					DTR_Depart.EndEdit();
					try
					{
						TA_DEPART.Update(dS_Master.DEPART);
						AjustDe(false);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return false;
					}
					TA_ARRIVE.Fill(dS_Master.ARRIVE);
					Sync_ForeignTables();
					ir_departs.tb_confirmerPar.ResetText();
					return true;
				}
				else
				{
					ir_departs.tb_confirmerPar.Focus();
					return false;
				}
			}
			return false;
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

		private void bt_list_Click(object sender, EventArgs e)
		{
			PrjEq01_Application.List_Forms.LF_Arrive lf_arrive = new PrjEq01_Application.List_Forms.LF_Arrive(BS_ARRIVE);
			int tempPositionBS_ARRIVE = BS_ARRIVE.Position;
			if (lf_arrive.ShowDialog() == DialogResult.Cancel)
			{
				BS_ARRIVE.Position = tempPositionBS_ARRIVE;
			}
			else
			{
				Sync_ForeignTables();
			}
		}
	}
}
