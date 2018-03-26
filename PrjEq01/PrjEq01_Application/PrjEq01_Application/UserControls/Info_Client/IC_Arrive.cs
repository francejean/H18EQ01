using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjEq01_Application.UserControls.Info_Client
{
	public partial class IC_Arrive : PrjEq01_Application.UserControls.IC_Base
	{
        public IC_Arrive()
		{
			InitializeComponent();
		}

        protected override void bt_list_Click(object sender, EventArgs e)
        {
            List_Forms.LF_Client lf_client = new List_Forms.LF_Client(BS);
            lf_client.ShowDialog();
        }
    }
}
