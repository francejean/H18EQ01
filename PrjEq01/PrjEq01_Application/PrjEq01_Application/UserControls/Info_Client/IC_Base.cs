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
        protected BindingSource BS;

        public IC_Base()
		{
			InitializeComponent();
            TA_CLIENT.Fill(ds_master.CLIENT);
        }

        public void setBS(BindingSource BS)
        {
            this.BS = BS;
        }

        protected virtual void bt_list_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void SetReadOnly(States state)
        {
            bool readOnly	= !(state == States.ADD || state == States.EDIT);
			bt_list.Enabled = (state == States.ADD);

			foreach (Control ctrl in gb_client.Controls)
			{
				if (ctrl.GetType() == typeof(TextBox))
					((TextBox)ctrl).ReadOnly = readOnly;
				else
					ctrl.Enabled = (ctrl.GetType() != typeof(DateTimePicker)) ? readOnly : !readOnly;
			}
		}

		public virtual void WypeInformation()
		{
			this.tb_adresse.ResetText();
			this.tb_expiration.ResetText();
			this.tb_noCarte.ResetText();
			this.tb_noClient.ResetText();
			this.tb_nomClient.ResetText();
			this.tb_telephone.ResetText();
			this.tb_typeCarte.ResetText();
		}
	}
}
