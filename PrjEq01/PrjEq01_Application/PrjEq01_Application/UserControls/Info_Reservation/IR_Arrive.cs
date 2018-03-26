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
        public IR_Arrive()
        {
            InitializeComponent();
        }

        protected override void bt_list_Click(object sender, EventArgs e)
        {
            List_Forms.LF_Reservation lf_reservation = new List_Forms.LF_Reservation(BS);

            if (lf_reservation.ShowDialog() == DialogResult.OK)
            {
                //tb_noReserv.Text = ds_master["RESERVATION"].rows[BS.Position]["NO-reserv"]
                //Faire la meme chose pour la datarow arrive pour le no reserv
            }
        }
    }
}
