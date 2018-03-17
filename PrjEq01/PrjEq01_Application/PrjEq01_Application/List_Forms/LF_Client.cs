using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEq01_Application.List_Forms
{
    public partial class LF_Client : Form
    {
        public LF_Client()
        {
            InitializeComponent();
            Fill();
            dgv_client.DataSource = BS_CLIENT;
        }

        private void Fill()
        {
            this.TA_CLIENT.Fill(this.ds_master.CLIENT);

            this.BS_CLIENT.DataMember = "CLIENT";
            this.BS_CLIENT.DataSource = this.ds_master;
        }
    }
}
