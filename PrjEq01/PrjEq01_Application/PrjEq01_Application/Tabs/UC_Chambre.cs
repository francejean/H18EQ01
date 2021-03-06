﻿using System;
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
	public partial class UC_Chambre : UserControl, IButtons
	{
		public States State { get; set; }

		private bool mustFocusNoCham = false;
		private bool leaving = false;
		private bool prixAjust = false;
		private bool userChangePrix = false;

		private DataRow DTR_Chambre;
		private DataRow DTR_Ayant;
		private DataRow DTR_BK_Commodite;

		private ErrorProvider errorProvider = new ErrorProvider();

		public UC_Chambre()
		{
			InitializeComponent();
			State = States.CONSULT;
		}

		private void Tab_Chambre_Load(object sender, EventArgs e)
		{
			Fill();
			LinkAll();
		}

		public void Fill()
		{
			string safeNoCham = tb_noCham.Text;
			if (State == States.CONSULT)
			{
				TA_CHAMBRE.FillByCHAMBRE(this.dS_Master.CHAMBRE);
				TA_AYANT.FillBy(this.dS_Master.AYANT);
			}
			TA_COMMODITE.Fill(this.dS_Master.COMMODITE);
			TA_TYPECHAM.Fill(this.dS_Master.TYPECHAM);
			TA_LOCALISATION.Fill(this.dS_Master.LOCALISATION);
			if (tb_noCham.ReadOnly && BS_CHAMBRE.DataSource != null)
				BS_CHAMBRE.Position = BS_CHAMBRE.Find("NoCham", safeNoCham);
		}

		private void LinkAll()
		{
			LinkTextData();
			LinkTypeCham();
			LinkLocalisation();
			LinkCommodite();
			LinkBKCommodite();
		}

		private void LinkTextData()
		{
			LinkChambre();
			LinkAyant();
		}

		private void UnLinkTextData()
		{
			UnLinkChambre();
			UnLinkAyant();
		}

		private void LinkChambre()
		{
			BS_CHAMBRE.DataMember = "CHAMBRE";
			BS_CHAMBRE.DataSource = this.dS_Master;

			try
			{
				tb_noCham.DataBindings.Add("Text", BS_CHAMBRE, "NoCham");
				tb_etage.DataBindings.Add("Text", BS_CHAMBRE, "Etage");
				tb_etat.DataBindings.Add("Text", BS_CHAMBRE, "Etat");
				tb_codeType.DataBindings.Add("Text", BS_CHAMBRE, "CodTypCham");
				tb_codeLoc.DataBindings.Add("Text", BS_CHAMBRE, "CodLoc");
				mtb_prix.DataBindings.Add("Text", BS_CHAMBRE, "Prix");
				tb_descType.DataBindings.Add("Text", BS_CHAMBRE, "DescTyp");
				tb_descLoc.DataBindings.Add("Text", BS_CHAMBRE, "DescLoc");
				tb_memo.DataBindings.Add("Text", BS_CHAMBRE, "Memo");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UnLinkChambre()
		{
			tb_noCham.DataBindings.Clear();
			tb_etage.DataBindings.Clear();
			tb_etat.DataBindings.Clear();
			tb_codeType.DataBindings.Clear();
			tb_codeLoc.DataBindings.Clear();
			mtb_prix.DataBindings.Clear();
			tb_descType.DataBindings.Clear();
			tb_descLoc.DataBindings.Clear();
			tb_memo.DataBindings.Clear();
		}

		private void LinkAyant()
		{
			BS_AYANT.DataMember = "AYANT_FK_NoCham";
			BS_AYANT.DataSource = BS_CHAMBRE;
			dgv_commodite.DataSource = BS_AYANT;
		}

		private void UnLinkAyant()
		{
			dgv_commodite.DataSource = null;
		}

		private void LinkTypeCham()
		{
			BS_TYPECHAM.DataMember = "TYPECHAM";
			BS_TYPECHAM.DataSource = dS_Master;
		}

		private void LinkLocalisation()
		{
			BS_LOCALISATION.DataMember = "LOCALISATION";
			BS_LOCALISATION.DataSource = dS_Master;
		}

		private void LinkCommodite()
		{
			BS_COMMODITE.DataMember = "COMMODITE";
			BS_COMMODITE.DataSource = dS_Master;
		}

		private void LinkBKCommodite()
		{
			BS_BK_COMMODITE.DataMember = "BK_COMMODITE";
			BS_BK_COMMODITE.DataSource = dS_Master;
		}

		private bool IsNumeric(string nomber)
		{
			bool isNumeric = int.TryParse(nomber, out int temp);
			return isNumeric;
		}

		private bool IsAllInfoChambreValide()
		{
			bool isValide = true;
			if (!IsNoChamValide(1))
			{
				isValide = false;
				tb_noCham.Focus();
			}
			if (!IsEtageValide(1))
				isValide = false;
			if (!IsEtatValide(1))
				isValide = false;
			if (!IsCodeTypeValide(1))
				isValide = false;
			if (!IsCodeLocValide(1))
				isValide = false;
			if (!IsPrixValide(1))
				isValide = false;
			if (!IsCommoditeValide(1))
				isValide = false;
			return isValide;
		}

		private bool IsNoChamValide(int validationCase)
		{
			if (validationCase == 0 || validationCase == 1)
				errorProvider.SetError(tb_noCham, string.Empty);
			if (tb_noCham.Text.Length != 3 || !IsNumeric(tb_noCham.Text))
			{
				errorProvider.SetError(tb_noCham, "Vous devez entrez un numéro de chambre composé de 3 chiffres");
				return false;
			}
			else
			{
				int index = BS_CHAMBRE.Find("NoCham", tb_noCham.Text);
				if (index < 0)
				{
					if (State != States.ADD)
					{
						errorProvider.SetError(tb_noCham, "Ce numéro de chambre n'existe pas");
						return false;
					}
					else
					{
						errorProvider.SetError(tb_noCham, string.Empty);
						return true;
					}
				}
				else
				{
					if (State == States.ADD && validationCase == 0)
					{
						errorProvider.SetError(tb_noCham, "Vous devez entrez un numéro de chambre qui n'existe pas");
						return false;
					}
					else if (State == States.ADD && validationCase == 1)
					{
						errorProvider.SetError(tb_noCham, string.Empty);
						return true;
					}
					else
					{
						errorProvider.SetError(tb_noCham, string.Empty);
						return true;
					}
				}
			}
		}

		private bool IsEtageValide(int validationCase)
		{
			if (validationCase == 1)
				errorProvider.SetError(tb_etage, string.Empty);
			if ((tb_etage.Text.Length != 1 && tb_etage.Text.Length != 2) || !IsNumeric(tb_etage.Text))
			{
				errorProvider.SetError(tb_etage, "Vous devez entrez un étage de 1 ou 2 chiffres");
				return false;
			}
			else
			{
				errorProvider.SetError(tb_etage, string.Empty);
				return true;
			}
		}

		private bool IsEtatValide(int validationCase)
		{
			if (validationCase == 1)
				errorProvider.SetError(tb_etat, string.Empty);
			if (tb_etat.Text != "0" && tb_etat.Text != "1")
			{
				errorProvider.SetError(tb_etat, "Vous devez entrez un etat pour la chambre (1 = en état et 0 = hors d'état)");
				return false;
			}
			else
			{
				errorProvider.SetError(tb_etat, string.Empty);
				return true;
			}
		}

		private bool IsCodeTypeValide(int validationCase)
		{
			if (validationCase == 1)
				errorProvider.SetError(bt_listCodeType, string.Empty);
			if (tb_codeType.Text.Length == 0)
			{
				errorProvider.SetError(bt_listCodeType, "Vous devez sélectionner un type de chambre");
				return false;
			}
			else
			{
				errorProvider.SetError(bt_listCodeType, string.Empty);
				return true;
			}
		}

		private bool IsCodeLocValide(int validationCase)
		{
			if (validationCase == 1)
				errorProvider.SetError(bt_listCodeLoc, string.Empty);
			if (tb_codeLoc.Text.Length == 0)
			{
				errorProvider.SetError(bt_listCodeLoc, "Vous devez sélectionner une location pour la chambre");
				return false;
			}
			else
			{
				errorProvider.SetError(bt_listCodeLoc, string.Empty);
				return true;
			}
		}

		private bool IsPrixValide(int validationCase)
		{
			if (validationCase == 1)
				errorProvider.SetError(mtb_prix, string.Empty);
			bool fivenumber = true;
			foreach (char car in mtb_prix.Text)
			{
				if (car > '9' || car < '0')
					fivenumber = false;
			}
			if (!fivenumber || mtb_prix.Text.Length < 5)
			{
				errorProvider.SetError(mtb_prix, "Vous devez entrer un prix de 5 chiffre en incluant les '0' (minimum 001,00$)");
				return false;
			}
			else
			{
				int prix;
				int.TryParse(mtb_prix.Text, out prix);
				if (prix < 100)
				{
					errorProvider.SetError(mtb_prix, "Vous devez entrer un prix supérieur a 000,99$");
					return false;
				}
				else
				{
					errorProvider.SetError(mtb_prix, string.Empty);
					return true;
				}
			}
		}

		private bool IsCommoditeValide(int validationCase)
		{
			if (validationCase == 1)
				errorProvider.SetError(dgv_commodite, string.Empty);
			if (dgv_commodite.Rows.Count == 0)
			{
				errorProvider.SetError(dgv_commodite, "Une chambre doit posséder au moins une commodite");
				return false;
			}
			else
			{
				errorProvider.SetError(dgv_commodite, string.Empty);
				return true;
			}
		}

		public void SetReadOnly(States state)
		{
			mtb_prix.ReadOnly = (state == States.CONSULT);
			tb_etat.ReadOnly = (state == States.CONSULT);
			tb_memo.ReadOnly = (state == States.CONSULT);
			bt_listNoChambre.Enabled = (state == States.CONSULT);
			bt_listCodeLoc.Enabled = (state == States.ADD || state == States.EDIT);
			bt_listCodeType.Enabled = (state == States.ADD || state == States.EDIT);
			bt_listCommodite.Enabled = (state == States.ADD || state == States.EDIT);
			if ((state == States.ADD || state == States.EDIT) && dgv_commodite.RowCount > 0)
			{
				bt_deleteCommodite.Enabled = true;
			}
			else
			{
				bt_deleteCommodite.Enabled = false;
			}
		}

		private void WipeInformation()
		{
			foreach (Control ctrl in gb_infoChambre.Controls)
			{
				if (ctrl.GetType() == typeof(TextBox))
					ctrl.ResetText();
				if (ctrl.GetType() == typeof(MaskedTextBox))
					ctrl.ResetText();
			}
		}

		private void NewChambre()
		{
			UnLinkTextData();
			WipeInformation();
			bt_listNoChambre.Enabled = false;
			TA_BK_COMMODITE.Fill(this.dS_Master.BK_COMMODITE);
			mustFocusNoCham = true;
			prixAjust = false;
			tb_noCham.ReadOnly = false;
			tb_noCham.Focus();
		}

		private void EditChambre()
		{
			TA_BK_COMMODITE.FillBy(this.dS_Master.BK_COMMODITE, tb_noCham.Text);
			mustFocusNoCham = false;
			prixAjust = false;
			userChangePrix = false;
			DTR_Chambre = dS_Master.Tables["CHAMBRE"].Rows[BS_CHAMBRE.Position];
			DTR_Chambre.BeginEdit();
		}

		private void DeleteChambre()
		{
			BS_AYANT.Position = 0;
			DTR_Chambre = dS_Master.Tables["CHAMBRE"].Rows[BS_CHAMBRE.Position];
			foreach(DataRow DTR_toDel in DTR_Chambre.GetChildRows("AYANT_FK_NoCham"))
			{
				BS_AYANT.RemoveCurrent();
				BS_AYANT.Position++;
			}
			BS_CHAMBRE.RemoveCurrent();
			BS_CHAMBRE.MoveFirst();
			try
			{
				TA_AYANT.Update(dS_Master.AYANT);
				TA_CHAMBRE.Update(dS_Master.CHAMBRE);
				AjustNbDispoInTypeCham();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AjustNbDispoInTypeCham()
		{
			foreach (DataRow DTR_TypeCham in dS_Master.Tables["TYPECHAM"].Rows)
			{
				int totalDispo = 0;
				foreach (DataRow DTR_Cham in DTR_TypeCham.GetChildRows("CHAMBRE_FK_CodTypCham"))
				{
					if (DTR_Cham["Etat"].ToString() == "1")
					{
						totalDispo++;
					}
				}
				dS_Master.Tables["TYPECHAM"].Rows.Find(DTR_TypeCham["CodTypCham"])["NbDispo"] = totalDispo;

			}

			try
			{
				TA_TYPECHAM.Update(dS_Master.TYPECHAM);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public bool Add()
		{
			State = States.ADD;//STATE?
			NewChambre();
			return true;
		}

		public bool Edit()
		{
			TA_CHAMBRE.FillByNotInDE(dS_Master.CHAMBRE);
			if (dS_Master.Tables["CHAMBRE"].Rows.Count <= 0)
			{
				MessageBox.Show("Aucune chambre n'est disponible pour être modifier");
				TA_CHAMBRE.FillByCHAMBRE(dS_Master.CHAMBRE);
				return false;
			}
			PrjEq01_Application.List_Forms.LF_ChambreNoCham lf_chambreNoCham = new PrjEq01_Application.List_Forms.LF_ChambreNoCham();
			lf_chambreNoCham.Dgv_main.AutoGenerateColumns = false;
			lf_chambreNoCham.Dgv_main.DataSource = BS_CHAMBRE;
			if (lf_chambreNoCham.ShowDialog() == DialogResult.Cancel)
			{
				TA_CHAMBRE.FillByCHAMBRE(dS_Master.CHAMBRE);
				return false;
			}
			EditChambre();
			return true;
		}

		public bool Delete()
		{
			TA_CHAMBRE.FillByNotInDE(dS_Master.CHAMBRE);
			if (dS_Master.Tables["CHAMBRE"].Rows.Count <= 0)
			{
				MessageBox.Show("Aucune chambre n'est disponible pour être supprimer");
				TA_CHAMBRE.FillByCHAMBRE(dS_Master.CHAMBRE);
				return false;
			}
			PrjEq01_Application.List_Forms.LF_ChambreNoCham lf_chambreNoCham = new PrjEq01_Application.List_Forms.LF_ChambreNoCham();
			lf_chambreNoCham.Dgv_main.AutoGenerateColumns = false;
			lf_chambreNoCham.Dgv_main.DataSource = BS_CHAMBRE;
			if (lf_chambreNoCham.ShowDialog() == DialogResult.Cancel)
			{
				TA_CHAMBRE.FillByCHAMBRE(dS_Master.CHAMBRE);
				return false;
			}
			DialogResult result = MessageBox.Show("Êtes-vous certains de vouloir supprimer cette chambre?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			switch (result)
			{
				case DialogResult.Yes:
					DeleteChambre();
					break;
				case DialogResult.No:
					break;
			}
			TA_CHAMBRE.FillByCHAMBRE(dS_Master.CHAMBRE);
			return true;
		}

		public bool Undo()
		{
			if (State == States.ADD || State == States.EDIT)
			{
				bool stateEdit = (State == States.EDIT);
				State = States.CONSULT; //STATE??
				prixAjust = false;
				userChangePrix = false;
				errorProvider.Clear();
				if (mustFocusNoCham)
				{
					tb_noCham.ReadOnly = true;
					LinkTextData();
				}
				else
				{
					DTR_Chambre.EndEdit();
					dS_Master.Tables["CHAMBRE"].RejectChanges();
					dS_Master.Tables["AYANT"].RejectChanges();
					BS_CHAMBRE.ResetCurrentItem();
				}
				mustFocusNoCham = false;
				BS_CHAMBRE.Position = 0;
				if (stateEdit)
					TA_CHAMBRE.FillByCHAMBRE(dS_Master.CHAMBRE);
			}
			return true;
		}

		public bool Save()
		{
			if (State == States.ADD || State == States.EDIT)
			{
				tb_noCham.Focus();
				tb_noCham.DeselectAll();
				mtb_prixToFull();
				if (IsAllInfoChambreValide())
				{
					bool stateEdit = (State == States.EDIT);
					State = States.CONSULT;//STATE?
					errorProvider.Clear();
					BS_CHAMBRE.Position = 0;
					float.TryParse(DTR_Chambre["Prix"].ToString(), out float prix);
					if (!stateEdit || userChangePrix)
						DTR_Chambre["Prix"] = prix / 100;
					prixAjust = false;
					userChangePrix = false;
					DTR_Chambre.EndEdit();
					try
					{
						TA_CHAMBRE.Update(dS_Master.CHAMBRE);
						TA_AYANT.Update(dS_Master.AYANT);
						AjustNbDispoInTypeCham();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					BS_CHAMBRE.Sort = "NoCham";
					if (stateEdit)
						TA_CHAMBRE.FillByCHAMBRE(dS_Master.CHAMBRE);
					return true;
				}
				else
				{
					return false;
				}
			}
			return false;
		}

		public void Go_Start()
		{
			BS_CHAMBRE.MoveFirst();
		}

		public void Go_Back()
		{
			BS_CHAMBRE.MovePrevious();
		}

		public void Go_Forward()
		{
			BS_CHAMBRE.MoveNext();
		}

		public void Go_End()
		{
			BS_CHAMBRE.MoveLast();
		}

		private void bt_listNoChambre_Click(object sender, EventArgs e)
		{
			PrjEq01_Application.List_Forms.LF_ChambreNoCham lf_chambreNoCham = new PrjEq01_Application.List_Forms.LF_ChambreNoCham();
			lf_chambreNoCham.Dgv_main.AutoGenerateColumns = false;
			lf_chambreNoCham.Dgv_main.DataSource = BS_CHAMBRE;
			int tempPositionBS_CHAMBRE = BS_CHAMBRE.Position;
			if (lf_chambreNoCham.ShowDialog() == DialogResult.Cancel)
			{
				BS_CHAMBRE.Position = tempPositionBS_CHAMBRE;
			}
		}

		private void bt_listCodeType_Click(object sender, EventArgs e)
		{
			PrjEq01_Application.List_Forms.LF_TypeChambre lf_chambreCodeType = new PrjEq01_Application.List_Forms.LF_TypeChambre();
			lf_chambreCodeType.Dgv_main.DataSource = BS_TYPECHAM;
			if (lf_chambreCodeType.ShowDialog() == DialogResult.OK)
			{
				tb_codeType.Text = dS_Master.Tables["TYPECHAM"].Rows[BS_TYPECHAM.Position]["CodTypCham"].ToString();
				tb_descType.Text = dS_Master.Tables["TYPECHAM"].Rows[BS_TYPECHAM.Position]["DescTyp"].ToString();
				DTR_Chambre["CodTypCham"] = dS_Master.Tables["TYPECHAM"].Rows[BS_TYPECHAM.Position]["CodTypCham"];
				DTR_Chambre["DescTyp"] = dS_Master.Tables["TYPECHAM"].Rows[BS_TYPECHAM.Position]["DescTyp"];
				IsCodeTypeValide(0);
			}
		}

		private void bt_listCodeLoc_Click(object sender, EventArgs e)
		{
			PrjEq01_Application.List_Forms.LF_Localisation lf_chambreCodeLoc = new PrjEq01_Application.List_Forms.LF_Localisation();
			lf_chambreCodeLoc.Dgv_main.DataSource = BS_LOCALISATION;
			if (lf_chambreCodeLoc.ShowDialog() == DialogResult.OK)
			{
				tb_codeLoc.Text = dS_Master.Tables["LOCALISATION"].Rows[BS_LOCALISATION.Position]["CodLoc"].ToString();
				tb_descLoc.Text = dS_Master.Tables["LOCALISATION"].Rows[BS_LOCALISATION.Position]["DescLoc"].ToString();
				DTR_Chambre["CodLoc"] = dS_Master.Tables["LOCALISATION"].Rows[BS_LOCALISATION.Position]["CodLoc"];
				DTR_Chambre["DescLoc"] = dS_Master.Tables["LOCALISATION"].Rows[BS_LOCALISATION.Position]["DescLoc"];
				IsCodeLocValide(0);
			}
		}

		private void bt_listCommodite_Click(object sender, EventArgs e)
		{
			if (BS_BK_COMMODITE.Count == 0)
			{
				MessageBox.Show("Cette chambre comporte déjà toute les commoditées, impossible d'en ajouter plus");
				return;
			}
			PrjEq01_Application.List_Forms.LF_Commodite lf_chambreCommodite = new PrjEq01_Application.List_Forms.LF_Commodite();
			lf_chambreCommodite.Dgv_main.DataSource = BS_BK_COMMODITE;
			if (lf_chambreCommodite.ShowDialog() == DialogResult.OK)
			{
				DTR_Ayant = dS_Master.Tables["AYANT"].NewRow();
				DTR_Ayant["NoCham"] = tb_noCham.Text;
				DTR_Ayant["CodCom"] = dS_Master.Tables["BK_COMMODITE"].Rows[BS_BK_COMMODITE.Position]["CodCom"];
				DTR_Ayant["DescCom"] = dS_Master.Tables["BK_COMMODITE"].Rows[BS_BK_COMMODITE.Position]["DescCom"];
				dS_Master.Tables["AYANT"].Rows.Add(DTR_Ayant);
				BS_BK_COMMODITE.RemoveCurrent();
				dS_Master.Tables["BK_COMMODITE"].AcceptChanges();
			}
		}

		private void bt_deleteCommodite_Click(object sender, EventArgs e)
		{
			if (dgv_commodite.RowCount > 0)
			{
				DataRow foundRow = dS_Master.Tables["COMMODITE"].Rows.Find(dgv_commodite.Rows[BS_AYANT.Position].Cells[dgv_commodite.Columns[1].Index].Value);
				DTR_BK_Commodite = dS_Master.Tables["BK_COMMODITE"].NewRow();
				DTR_BK_Commodite.ItemArray = foundRow.ItemArray;
				dS_Master.Tables["BK_COMMODITE"].Rows.Add(DTR_BK_Commodite);
				BS_AYANT.RemoveCurrent();
			}
		}

		private void UC_Chambre_Leave(object sender, EventArgs e)
		{
			mustFocusNoCham = false;
			leaving = true;
			errorProvider.Clear();
		}

		private void UC_Chambre_Enter(object sender, EventArgs e)
		{
			if (State == States.ADD && tb_noCham.ReadOnly != true)
			{ 
				mustFocusNoCham = true;
				tb_noCham.Focus();
			}
			leaving = false;
		}

		private void tb_noCham_Validating(object sender, CancelEventArgs e)
		{
			if (State == States.ADD && mustFocusNoCham)
			{
				if (IsNoChamValide(0))
				{
					DTR_Chambre = dS_Master.Tables["CHAMBRE"].NewRow();
					DTR_Chambre["NoCham"] = tb_noCham.Text;
					BS_CHAMBRE.Sort = null;
					dS_Master.Tables["CHAMBRE"].Rows.Add(DTR_Chambre);

					BS_CHAMBRE.Position = BS_CHAMBRE.Count - 1;
					DTR_Chambre.BeginEdit();

					LinkTextData();

					mustFocusNoCham = false;
					tb_noCham.ReadOnly = true;
					SetReadOnly(State);
					tb_etage.Text = tb_noCham.Text.ToCharArray().GetValue(0).ToString();
					IsEtageValide(0);
				}
				else
				{
					tb_noCham.Focus();
				}
			}
		}

		private void tb_noCham_KeyDown(object sender, KeyEventArgs e)
		{
			if (mustFocusNoCham && e.KeyCode == Keys.Enter)
			{
				tb_etage.Focus();
				tb_etage.DeselectAll();
			}
		}

		private void tb_etage_Validating(object sender, CancelEventArgs e)
		{
			if ((State == States.ADD || State == States.EDIT) && !mustFocusNoCham && !leaving)
			{
				IsEtageValide(0);
			}
		}

		private void tb_etat_Validating(object sender, CancelEventArgs e)
		{
			if ((State == States.ADD || State == States.EDIT) && !mustFocusNoCham && !leaving)
			{
				IsEtatValide(0);
			}
		}

		private void tb_codeType_Validating(object sender, CancelEventArgs e)
		{
			if ((State == States.ADD || State == States.EDIT) && !mustFocusNoCham && !leaving)
			{
				IsCodeTypeValide(0);
			}
		}

		private void tb_codeLoc_Validating(object sender, CancelEventArgs e)
		{
			if ((State == States.ADD || State == States.EDIT) && !mustFocusNoCham && !leaving)
			{
				IsCodeLocValide(0);
			}
		}

		private void mtb_prix_Validating(object sender, CancelEventArgs e)
		{
			if ((State == States.ADD || State == States.EDIT) && !mustFocusNoCham && !leaving)
			{
				IsPrixValide(0);
			}
		}

		private void mtb_prix_Leave(object sender, EventArgs e)
		{
			if (State == States.ADD || State == States.EDIT)
			{
				prixAjust = true;
			}
		}

		private void mtb_prix_Enter(object sender, EventArgs e)
		{
			if (State == States.ADD || State == States.EDIT)
			{
				prixAjust = false;
			}
		}

		private void mtb_prix_TextChanged(object sender, EventArgs e)
		{
			if (State == States.EDIT)
				userChangePrix = true;
			if (mtb_prix.Text.Length < 5 && (State == States.CONSULT || prixAjust))
			{
				mtb_prixToFull();
				if (State != States.CONSULT)
					IsPrixValide(0);
			}
		}

		private void mtb_prixToFull()
		{
			while (mtb_prix.Text.Length < 5)
			{
				mtb_prix.Text = 0 + mtb_prix.Text;
			}
		}

		private void dgv_commodite_Validating(object sender, CancelEventArgs e)
		{
			if ((State == States.ADD || State == States.EDIT) && !mustFocusNoCham && !leaving)
			{
				IsCommoditeValide(0);
			}
		}
		private void dgv_commodite_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (State == States.ADD || State == States.EDIT)
			{
				bt_deleteCommodite.Enabled = true;
			}
			else
			{
				bt_deleteCommodite.Enabled = false;
			}
		}

		private void dgv_commodite_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if ((State == States.ADD || State == States.EDIT) && dgv_commodite.RowCount > 0)
			{
				bt_deleteCommodite.Enabled = true;
			}
			else
			{
				bt_deleteCommodite.Enabled = false;
			}
		}
	}
}
