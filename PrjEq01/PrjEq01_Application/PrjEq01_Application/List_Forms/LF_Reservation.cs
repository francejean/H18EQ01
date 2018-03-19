using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjEq01_Application.List_Forms
{
    public partial class LF_Reservation : PrjEq01_Application.List_Forms.LF_Base
    {
        public LF_Reservation(BindingSource BS) : base(BS)
        {
            InitializeComponent();
        }

		public UserControls.Inherit_DGV dgv_noReser
		{
			get
			{
				return this.dgv_main;
			}
			set
			{
				this.dgv_main = value;
			}
		}

        private void LF_Reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Master.RESERVATION' table. You can move, or remove it, as needed.
            this.TA_RESERVATION.Fill(this.ds_master.RESERVATION);
        }
    }
}
