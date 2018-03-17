using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjEq01_Application.List_Forms
{
    public partial class LF_Client : PrjEq01_Application.List_Forms.LF_Base
    {
        public LF_Client()
        {
            InitializeComponent();
        }

        private void LF_Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Master.CLIENT' table. You can move, or remove it, as needed.
            this.TA_CLIENT.Fill(this.ds_master.CLIENT);
        }
    }
}
