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
	public partial class UC_Chambre : UserControl, IButtons
	{
		public States State { get; set; }

		private bool mustFocusNoCham = false;
		private bool leaving = false;

		private DataRow DTR_Chambre;
		private DataRow DTR_Ayant;

		private BindingSource BS_BK_AYANT = new BindingSource();

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

		private void Fill()
		{
			TA_CHAMBRE.FillByCHAMBRE(this.dS_Master.CHAMBRE);
			TA_AYANT.FillBy(this.dS_Master.AYANT);
			TA_COMMODITE.Fill(this.dS_Master.COMMODITE);
			TA_TYPECHAM.Fill(this.dS_Master.TYPECHAM);
			TA_LOCALISATION.Fill(this.dS_Master.LOCALISATION);
		}

		private void LinkAll()
		{
			LinkTextData();
			LinkTypeCham();
			LinkLocalisation();
			LinkCommodite();
			LinkBKAyant();
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

		private void LinkBKAyant()
		{

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
				errorProvider.SetError(mtb_prix, "Vous devez entrer un prix de 5 chiffre (minimum 001,00$)");
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

		public void SetReadOnly()
		{
			bool stateBoolValue = true;
			switch (State)
			{
				case States.ADD:
					stateBoolValue = false;
					break;
				case States.CONSULT:
					stateBoolValue = true;
					break;
				case States.EDIT:
					stateBoolValue = false;
					break;
			}
			mtb_prix.ReadOnly = stateBoolValue;
			tb_etat.ReadOnly = stateBoolValue;
			tb_memo.ReadOnly = stateBoolValue;
			bt_listNoChambre.Enabled = stateBoolValue;
			bt_listCodeLoc.Enabled = !stateBoolValue;
			bt_listCodeType.Enabled = !stateBoolValue;
			bt_listCommodite.Enabled = !stateBoolValue;
			if ((State == States.ADD || State == States.EDIT) && dgv_commodite.RowCount > 0)
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
			mustFocusNoCham = true;
			tb_noCham.ReadOnly = false;
			tb_noCham.Focus();
		}

		private void ajustNbDispoInTypeCham()
		{

		}

		public void Add()
		{
			State = States.ADD; //NEEDTO CHANGE??
			NewChambre();
			//MessageBox.Show("Fonction en développement.");
		}

		public void Edit()
		{
			SetReadOnly();
			MessageBox.Show("Fonction en développement.");
		}

		public void Delete()
		{
			SetReadOnly();
			MessageBox.Show("Fonction en développement.");
		}

		public void Undo()
		{
			if (State == States.ADD)
			{
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
					BS_CHAMBRE.ResetCurrentItem();
				}
				mustFocusNoCham = false;
				BS_CHAMBRE.Position = 0;
			}
			State = States.CONSULT; //NEEDTO CHANGE??
			SetReadOnly();
			//MessageBox.Show("Fonction en développement.");
		}

		public bool Save()
		{
			if (State == States.ADD)
			{
				if (IsAllInfoChambreValide())
				{
					errorProvider.Clear();
					State = States.CONSULT; //NEEDTO CHANGE??
					BS_CHAMBRE.Position = 0;
					DTR_Chambre.EndEdit();
					DTR_Ayant.EndEdit();
					TA_CHAMBRE.Update(dS_Master.CHAMBRE);
					TA_AYANT.Update(dS_Master.AYANT);
					ajustNbDispoInTypeCham(); //NEEDTO DO IT
					SetReadOnly();
					return true;
				}
			}
			return false;
		}

		public void Go_Start()
		{
			BS_CHAMBRE.MoveFirst();
			//MessageBox.Show("Fonction en développement.");
		}

		public void Go_Back()
		{
			BS_CHAMBRE.MovePrevious();
			//MessageBox.Show("Fonction en développement.");
		}

		public void Go_Forward()
		{
			BS_CHAMBRE.MoveNext();
			//MessageBox.Show("Fonction en développement.");
		}

		public void Go_End()
		{
			BS_CHAMBRE.MoveLast();
			//MessageBox.Show("Fonction en développement.");
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
			//MessageBox.Show("Fonction en développement.");
		}

		private void bt_listCodeType_Click(object sender, EventArgs e)
		{
			if (!mustFocusNoCham)
			{
				PrjEq01_Application.List_Forms.LF_ChambreCodeType lf_chambreCodeType = new PrjEq01_Application.List_Forms.LF_ChambreCodeType();
				lf_chambreCodeType.Dgv_main.DataSource = BS_TYPECHAM;
				if (lf_chambreCodeType.ShowDialog() == DialogResult.OK)
				{
					tb_codeType.Text = dS_Master.Tables["TYPECHAM"].Rows[BS_TYPECHAM.Position]["CodTypCham"].ToString();
					tb_descType.Text = dS_Master.Tables["TYPECHAM"].Rows[BS_TYPECHAM.Position]["DescTyp"].ToString();
					IsCodeTypeValide(0);
				}
			}
			//MessageBox.Show("Fonction en développement.");
		}

		private void bt_listCodeLoc_Click(object sender, EventArgs e)
		{
			if (!mustFocusNoCham)
			{
				PrjEq01_Application.List_Forms.LF_ChambreCodeLoc lf_chambreCodeLoc = new PrjEq01_Application.List_Forms.LF_ChambreCodeLoc();
				lf_chambreCodeLoc.Dgv_main.DataSource = BS_LOCALISATION;
				if (lf_chambreCodeLoc.ShowDialog() == DialogResult.OK)
				{
					tb_codeLoc.Text = dS_Master.Tables["LOCALISATION"].Rows[BS_LOCALISATION.Position]["CodLoc"].ToString();
					tb_descLoc.Text = dS_Master.Tables["LOCALISATION"].Rows[BS_LOCALISATION.Position]["DescLoc"].ToString();
					IsCodeLocValide(0);
				}
			}
			//MessageBox.Show("Fonction en développement.");
		}

		private void bt_listCommodite_Click(object sender, EventArgs e)
		{
			if (!mustFocusNoCham)
			{
				/*PrjEq01_Application.List_Forms.LF_ChambreCommodite lf_chambreCommodite = new PrjEq01_Application.List_Forms.LF_ChambreCommodite();
                lf_chambreCommodite.Dgv_main.DataSource = BS_COMMODITE;
                int tempPositionBS_COMMODITE = BS_COMMODITE.Position;
                if (lf_chambreCommodite.ShowDialog() == DialogResult.Cancel)
                {
                    BS_TYPECHAM.Position = tempPositionBS_COMMODITE;
                }*/
				MessageBox.Show("Fonction en développement.");
			}
		}

		private void bt_deleteCommodite_Click(object sender, EventArgs e)
		{
			if (!mustFocusNoCham)
			{
				MessageBox.Show("Fonction en développement.");
			}
		}

		private void dgv_commodite_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (State == States.ADD || State == States.EDIT)
			{
				bt_deleteCommodite.Enabled = true;
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

					dS_Master.Tables["CHAMBRE"].Rows.Add(DTR_Chambre);
					BS_CHAMBRE.Position = BS_CHAMBRE.Count - 1;
					DTR_Chambre.BeginEdit();

					LinkTextData();

					mustFocusNoCham = false;
					tb_noCham.ReadOnly = true;
					SetReadOnly();
					tb_etage.Text = tb_noCham.Text.ToCharArray().GetValue(0).ToString();
					IsEtageValide(0);
				}
				else
				{
					tb_noCham.Focus();
				}
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

		private void dgv_commodite_Validating(object sender, CancelEventArgs e)
		{
			if ((State == States.ADD || State == States.EDIT) && !mustFocusNoCham && !leaving)
			{
				IsCommoditeValide(0);
			}
		}

		private void mtb_prix_TextChanged(object sender, EventArgs e)
		{
			if (mtb_prix.Text.Length < 5 && State == States.CONSULT)
			{
				while (mtb_prix.Text.Length < 5)
				{
					mtb_prix.Text = 0 + mtb_prix.Text;
				}
			}
		}

		private void tb_noCham_KeyDown(object sender, KeyEventArgs e)
		{
			if(mustFocusNoCham && e.KeyCode == Keys.Enter)
			{
				tb_etat.Focus();
			}
		}
	}
}
