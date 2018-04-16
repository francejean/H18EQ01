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

namespace PrjEq01_Application.UserControls.Info_Reservation
{
	public partial class IR_Reserv : IR_Base
	{
		public IR_Reserv()
		{
			InitializeComponent();
		}

		public override void SetReadOnly(States state)
		{
			base.SetReadOnly(state);
			bool readOnly = States.CONSULT == state;

			foreach (Control ctrl in gb_reserv.Controls)
            {
              if (ctrl is TextBox)
                ((TextBox)ctrl).ReadOnly = readOnly;
              else if (!(ctrl is Label))
                ctrl.Enabled = !readOnly;
            }
		}
	}
}
