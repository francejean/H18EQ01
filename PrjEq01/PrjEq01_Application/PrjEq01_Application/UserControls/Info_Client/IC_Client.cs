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
		public IC_Client()
		{
			InitializeComponent();
		}

		public override void SetReadOnly(States state)
		{
			if (state == States.ADD || state == States.EDIT)
			{
				foreach (Control ctrl in gb_client.Controls)
				{
					if (ctrl is TextBox)
					{
						TextBox textbox = (TextBox)ctrl;
						textbox.ReadOnly = false;
					}
					else if (ctrl is DateTimePicker)
					{
						ctrl.Enabled = false;
					}
				}
			}
		}
	}
}
