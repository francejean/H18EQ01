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
using System.Text.RegularExpressions;

namespace PrjEq01_Application.Tabs
{
	public partial class UC_Clients : UserControl, IButtons
	{
		public States State { get; set; }

		DataRow DTR_Client;

		ErrorProvider errorProvider;

		public UC_Clients()
		{
			InitializeComponent();
			State = States.CONSULT;

			errorProvider = new ErrorProvider();

			ic_client.onNomValidated = checkNom;
			ic_client.onAdresseValidated = checkAdresse;
			ic_client.onTelephoneValidated = checkTelephone;
			ic_client.onTypeCarteValidated = checkTypeCarte;
			ic_client.onNoCarteValidated = checkNoCarte;
			ic_client.onDatExpValidated = checkDatExp;
		}

		private void UC_Clients_Load(object sender, EventArgs e)
		{
			Fill();
			Link_CLIENT();
		}

		public void SetReadOnly(States state)
		{
			ic_client.SetReadOnly(state);
		}

		public void Fill()
		{
			if(State != States.ADD)
				TA_CLIENT.Fill(ds_master.CLIENT);
		}

		public void Link_CLIENT()
		{
			BS_CLIENT.DataMember = "CLIENT";
			BS_CLIENT.DataSource = ds_master;

			try
			{
				ic_client.tb_noClient.DataBindings.Add("Text", BS_CLIENT, "IdCli");
				ic_client.tb_nomClient.DataBindings.Add("Text", BS_CLIENT, "Nom");
				ic_client.tb_adresse.DataBindings.Add("Text", BS_CLIENT, "Adresse");
				ic_client.tb_telephone.DataBindings.Add("Text", BS_CLIENT, "Telephone");
				ic_client.cb_typeCarte.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
				ic_client.tb_noCarte.DataBindings.Add("Text", BS_CLIENT, "NoCarte");
				ic_client.dtp_datExp.DataBindings.Add("Text", BS_CLIENT, "DatExp");
			}
			catch (Exception e) { }
		}

		public bool Add()
		{
			NewClient();
			return true;
		}

		public bool Delete()
		{
			return true;
		}

		public bool Edit()
		{
			return true;
		}

		public bool Undo()
		{
			DTR_Client.Delete();
			BS_CLIENT.MoveFirst();
			return true;
		}

		public bool Save()
		{
			if (!CheckSaveErrors())
			{
				DialogResult result = MessageBox.Show("Do you want to save the client?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				switch (result)
				{
					case DialogResult.Yes:
						DTR_Client.EndEdit();
						TA_CLIENT.Update(ds_master.CLIENT);
						return true;
					case DialogResult.No:
						return false;
					default:
						break;
				}
			}
			return false;
		}

		public void Go_Start()
		{
			BS_CLIENT.MoveFirst();
		}

		public void Go_Back()
		{
			BS_CLIENT.MovePrevious();
		}

		public void Go_Forward()
		{
			BS_CLIENT.MoveNext();
		}

		public void Go_End()
		{
			BS_CLIENT.MoveLast();
		}

		public void NewClient()
		{
			BS_CLIENT.Position = BS_CLIENT.Count - 1;
			ds_master.CLIENT.Columns["IdCli"].AutoIncrementSeed = (int)ds_master.CLIENT[BS_CLIENT.Position]["IdCli"] + 1;

			DTR_Client = ds_master.Tables["CLIENT"].NewRow();
			DTR_Client["IdCli"] = (int)ds_master.CLIENT.Columns["IdCli"].AutoIncrementSeed;
			DTR_Client["Nom"] = String.Empty;
			DTR_Client.SetColumnError(DTR_Client.Table.Columns["Nom"], "Un nom doit être fournie");
			DTR_Client["Adresse"] = String.Empty;
			DTR_Client.SetColumnError(DTR_Client.Table.Columns["Adresse"], "Une adresse doit être fournie");
			DTR_Client["Telephone"] = String.Empty;
			DTR_Client.SetColumnError(DTR_Client.Table.Columns["Telephone"], "Un numéro de téléphone doit être fournie");
			DTR_Client["NoCarte"] = string.Empty;
			DTR_Client.SetColumnError(DTR_Client.Table.Columns["NoCarte"], "Un numéro de carte doit être fournie");
			ic_client.cb_typeCarte.SelectedIndex = 0;
			DTR_Client["TypeCarte"] = ic_client.cb_typeCarte.Text;
			DTR_Client["DatExp"] = DateTime.Today;
			DTR_Client.SetColumnError(DTR_Client.Table.Columns["DatExp"], "Une date d'expiration doit être fournie");
			DTR_Client["SoldeDu"] = 0;

			ds_master.Tables["Client"].Rows.Add(DTR_Client);
			BS_CLIENT.Position = BS_CLIENT.Count - 1;

			DTR_Client.BeginEdit();

			ic_client.WipeInformation();
		}

		public bool CheckSaveErrors()
		{
			checkNom();
			checkAdresse();
			checkTelephone();
			checkTypeCarte();
			checkNoCarte();
			checkDatExp();

			if (DTR_Client.HasErrors)
			{
				SetErrors();
				return true;
			}
			return false;
		}

		public void SetErrors()
		{
			foreach(DataColumn column in DTR_Client.GetColumnsInError())
			{
				switch (column.ColumnName)
				{
					case "Nom":
						errorProvider.SetError(ic_client.tb_nomClient, DTR_Client.GetColumnError(column));
						break;
					case "Adresse":
						errorProvider.SetError(ic_client.tb_adresse, DTR_Client.GetColumnError(column));
						break;
					case "Telephone":
						errorProvider.SetError(ic_client.tb_telephone, DTR_Client.GetColumnError(column));
						break;
					case "NoCarte":
						errorProvider.SetError(ic_client.tb_noCarte, DTR_Client.GetColumnError(column));
						break;
					case "TypeCarte":
						errorProvider.SetError(ic_client.cb_typeCarte, DTR_Client.GetColumnError(column));
						break;
					case "DatExp":
						errorProvider.SetError(ic_client.dtp_datExp, DTR_Client.GetColumnError(column));
						break;
					default:
						break;
				}
			}
		}

		public void checkColumn(string columName, Control control, string filter, string errorDesc)
		{
			if (!Regex.IsMatch(control.Text, filter))
			{
				DTR_Client.SetColumnError(DTR_Client.Table.Columns[columName], errorDesc);
			}
			else
			{
				DTR_Client.SetColumnError(DTR_Client.Table.Columns[columName], "");
			}
			errorProvider.SetError(control, DTR_Client.GetColumnError(DTR_Client.Table.Columns[columName]));
		}

		public void checkNom()
		{
			if(State == States.ADD && DTR_Client.RowState == DataRowState.Added)
			{
				if(ic_client.tb_nomClient.Text != String.Empty)
				{
					checkColumn("Nom", ic_client.tb_nomClient, @"(([A-Z][a-z]+)\s([A-Z][a-z]+)+)", "Veuillez écrire un nom valide (Majuscule, prénom et nom de famille)");
				}
			}
		}

		public void checkAdresse()
		{
			if(State == States.ADD)
			{
				if (ic_client.tb_adresse.Text != String.Empty)
				{
					checkColumn("Adresse", ic_client.tb_adresse, @"[0-9]+\s(\w+\s*)+", "Veuillez écrire une adresse valide (Numéro civique puis nom de rue)");
				}
			}
		}

		public void checkTelephone()
		{
			if (State == States.ADD)
			{
				if (ic_client.tb_telephone.Text != String.Empty)
				{
					checkColumn("Telephone", ic_client.tb_telephone, @"\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})", "Veuillez écrire un numéro de téléphone valide");
				}
			}
		}

		public void checkTypeCarte()
		{
			if(State == States.ADD)
			{
				checkNoCarte();
			}
		}

		public void checkNoCarte()
		{
			if(State == States.ADD)
			{
				if(ic_client.tb_noCarte.Text != String.Empty)
				{
					String filter = "";
					switch (ic_client.cb_typeCarte.Text)
					{
						case "VISA":
							filter = @"4[0-9]{12}(?:[0-9]{3})";
							break;
						case "MASTERCARD":
							filter = @"(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}";
							break;
						case "AMERICANEXPRESS":
							filter = @"3[47][0-9]{13}";
							break;
					}
					checkColumn("NoCarte", ic_client.tb_noCarte, filter, "Veuillez entrer un numéro de carte valide");
				}
			}
		}

		public void checkDatExp()
		{
			if(State == States.ADD)
			{
				try
				{
					if (ic_client.dtp_datExp.Value < DateTime.Now)
					{
						DTR_Client.SetColumnError(DTR_Client.Table.Columns["DatExp"], "Date non valide (plus petite ou égale à aujourd'hui)");
					}
					else
					{
						DTR_Client.SetColumnError(DTR_Client.Table.Columns["DatExp"], "");
					}
					errorProvider.SetError(ic_client.dtp_datExp, DTR_Client.GetColumnError(DTR_Client.Table.Columns["DatExp"]));
				}
				catch (Exception e) { };
			}
		}
	}
}
