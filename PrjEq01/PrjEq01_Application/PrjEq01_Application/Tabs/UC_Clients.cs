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
	public partial class UC_Clients : UserControl, IButtons
	{
		public States State { get; set; }

		DataRow DTR_Client;

		public UC_Clients()
		{
			InitializeComponent();
			State = States.CONSULT;
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
				ic_client.tb_typeCarte.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
				ic_client.tb_noCarte.DataBindings.Add("Text", BS_CLIENT, "NoCarte");
				ic_client.dtp_datExp.DataBindings.Add("Text", BS_CLIENT, "DatExp");
			}
			catch (Exception e) { MessageBox.Show(e.Message); }
		}

		public bool Add()
		{
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
			return true;
		}

		public bool Save()
		{
			DialogResult result = MessageBox.Show("Do you want to save the client?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			switch (result)
			{
				case DialogResult.Yes:
					return true;
				case DialogResult.No:
					return false;
				default:
					return false;
			}
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
	}
}
