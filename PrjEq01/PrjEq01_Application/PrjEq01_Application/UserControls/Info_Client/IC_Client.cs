using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PrjEq01_CommonForm;

namespace PrjEq01_Application.UserControls.Info_Client
{
	public partial class IC_Client : PrjEq01_Application.UserControls.IC_Base
	{
		public OnValidatedDeleg onNomValidated;
		public OnValidatedDeleg onAdresseValidated;
		public OnValidatedDeleg onTelephoneValidated;
		public OnValidatedDeleg onTypeCarteValidated;
		public OnValidatedDeleg onNoCarteValidated;
		public OnValidatedDeleg onDatExpValidated;


		public IC_Client()
		{
			InitializeComponent();
		}

		public override void SetReadOnly(States state)
		{
			foreach (Control ctrl in gb_client.Controls)
			{
				if (ctrl is TextBox && ctrl.Name != "tb_noClient")
				{
					TextBox textbox = (TextBox)ctrl;
					textbox.ReadOnly = !(state == States.ADD || state == States.EDIT);
				}
				else if (ctrl is DateTimePicker || ctrl is ComboBox)
				{
					ctrl.Enabled = (state == States.ADD || state == States.EDIT);
				}
			}
		}

		public override void WipeInformation()
		{
			foreach (Control ctrl in gb_client.Controls)
			{
				if ((ctrl is TextBox || ctrl is DateTimePicker || ctrl is ComboBox) && (ctrl.Name != "tb_noClient"))
					ctrl.ResetText();
			}
		}

		private void tb_nomClient_Validated(object sender, EventArgs e)
		{
			onNomValidated?.Invoke();
		}

		private void tb_adresse_Validated(object sender, EventArgs e)
		{
			onAdresseValidated?.Invoke();
		}

		private void tb_telephone_Validated(object sender, EventArgs e)
		{
			onTelephoneValidated?.Invoke();
		}

		private void cb_typeCarte_Validated(object sender, EventArgs e)
		{
			onTypeCarteValidated?.Invoke();
		}

		private void tb_noCarte_Validated(object sender, EventArgs e)
		{
			onNoCarteValidated?.Invoke();
		}

		private void dtp_datExp_Validated(object sender, EventArgs e)
		{
			onDatExpValidated?.Invoke();
		}
	}
}
