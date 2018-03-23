using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjEq01_Application.UserControls.Info_Reservation
{
    public partial class IR_Arrive : PrjEq01_Application.UserControls.IR_Base
    {
        public IR_Arrive(BindingSource BS) : base(BS)
        {
            InitializeComponent();
        }

        protected override void bt_list_Click(object sender, EventArgs e)
        {
            List_Forms.LF_Reservation lf_reservation = new List_Forms.LF_Reservation(BS);
            lf_reservation.ShowDialog();
        }
    }
}
