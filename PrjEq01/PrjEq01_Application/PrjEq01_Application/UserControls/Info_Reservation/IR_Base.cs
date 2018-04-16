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
	public partial class IR_Base: UserControl, IInfoBox
	{
        protected BindingSource BS;

        private ItemSelectedDeleg reservSelected;
        public ItemSelectedDeleg ReservSelected { get => reservSelected; set => reservSelected = value; }

        public IR_Base()
		{
			InitializeComponent();
            TA_RESERVATION.Fill(ds_master.RESERVATION);
		}

    public void setBS(BindingSource BS)
    {
        this.BS = BS;
    }

    protected virtual void bt_list_Click(object sender, EventArgs e)
    {
        reservSelected();
    }

    public void SetReadOnly(States state)
    {
      bool readOnly	= States.CONSULT == state;

			// Different for Reserv and Arrive
			bt_list.Enabled = (state == States.ADD);

			foreach (Control ctrl in gb_reserv.Controls)
			{
				if (ctrl is TextBox)
					((TextBox)ctrl).ReadOnly = readOnly;
				else if (!(ctrl is Label))
					ctrl.Enabled = !readOnly;
			}
		}

		public virtual void WipeInformation()
		{
      foreach (Control ctrl in gb_reserv.Controls)
      {
        if (ctrl is TextBox || ctrl is DateTimePicker)
          ctrl.ResetText();
    }
  }
}
