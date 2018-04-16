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
        protected BindingSource bS;
        protected DataRow dataRow;
        private ItemSelectedDeleg reservSelected;

        public BindingSource BS { get => bS; set => bS = value; }
        public DataRow DataRow { set => dataRow = value; }
        public ItemSelectedDeleg ReservSelected { get => reservSelected; set => reservSelected = value; }
        

        public IR_Base()
		{
			InitializeComponent();
            TA_RESERVATION.Fill(ds_master.RESERVATION);
		}

        protected virtual void bt_list_Click(object sender, EventArgs e)
        {
            reservSelected();
        }

        public virtual void SetReadOnly(States state)
        {
            bool readOnly	= States.CONSULT == state;
            // Different for Reserv and Arrive
            bt_list.Enabled = (state == States.ADD);


            //A mettre dans IR_Reservation
            /*foreach (Control ctrl in gb_reserv.Controls)
            {
              if (ctrl is TextBox)
                ((TextBox)ctrl).ReadOnly = readOnly;
              else if (!(ctrl is Label))
                ctrl.Enabled = !readOnly;
            }*/
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
}
