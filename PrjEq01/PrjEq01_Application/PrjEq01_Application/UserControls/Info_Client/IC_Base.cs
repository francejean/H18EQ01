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

namespace PrjEq01_Application.UserControls
{

	public partial class IC_Base : UserControl, IInfoBox
	{
		protected BindingSource bS;
		private ItemSelectedDeleg clientSelected;

		public BindingSource BS { set => bS = value; }
		public ItemSelectedDeleg ClientSelected { get => clientSelected; set => clientSelected = value; }



		public IC_Base()
		{
			InitializeComponent();
			TA_CLIENT.Fill(ds_master.CLIENT);
		}

		protected virtual void bt_list_Click(object sender, EventArgs e)
		{

		}

		public virtual void SetReadOnly(States state)
		{
			bool readOnly = !(state == States.ADD || state == States.EDIT);
			bt_list.Enabled = (state == States.ADD);

			/*foreach (Control ctrl in gb_client.Controls)
	        {
		        if (ctrl is TextBox)
			        ((TextBox)ctrl).ReadOnly = readOnly;
		        else if(!(ctrl is Label))
			        ctrl.Enabled = (ctrl is DateTimePicker) ? readOnly : !readOnly;
	        }*/
		}

		public virtual void WipeInformation()
		{
			foreach (Control ctrl in gb_client.Controls)
			{
				if (ctrl is TextBox || ctrl is DateTimePicker)
					ctrl.ResetText();
			}
		}
	}
}
