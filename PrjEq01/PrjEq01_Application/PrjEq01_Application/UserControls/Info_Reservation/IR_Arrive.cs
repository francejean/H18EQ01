﻿using System;
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
            int BS_pos_backup = BS.Position;
            List_Forms.LF_Reservation lf_reservation = new List_Forms.LF_Reservation(BS);
            DialogResult result = lf_reservation.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_noReserv.Text = ds_master.Tables["RESERVATION"].Rows[BS.Position]["IdReser"].ToString();
                base.bt_list_Click(sender, e);
            }
            else if (result == DialogResult.Cancel)
            {
                BS.Position = BS_pos_backup;
            }
        }
    }
}
