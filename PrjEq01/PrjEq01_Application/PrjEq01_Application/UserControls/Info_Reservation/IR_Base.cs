﻿using System;
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
        }

        public void SetReadOnly(States state)
        {
            bool readOnly = false;

            switch (state)
            {
                case States.ADD:
                    readOnly = false;
                    bt_list.Enabled = true;
                    break;
                case States.EDIT:
                    readOnly = false;
                    bt_list.Enabled = false;
                    break;
                case States.CONSULT:
                    readOnly = true;
                    bt_list.Enabled = false;
                    break;
            }

            foreach (Control ctrl in gb_reserv.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ((TextBox)ctrl).ReadOnly = readOnly;
                else if (ctrl.GetType() == typeof(ComboBox))
                    ((ComboBox)ctrl).Enabled = readOnly;
                else if (ctrl.GetType() == typeof(CheckBox))
                    ((CheckBox)ctrl).Enabled = readOnly;
                else if (ctrl.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)ctrl).Enabled = !readOnly;
            }
        }

		public virtual void WipeInformation()
		{
			this.tb_noReserv.ResetText();
			this.DTP_Debut.ResetText();
			this.DTP_Fin.ResetText();
			this.DTP_Reserv.ResetText();
		}
	}
}
