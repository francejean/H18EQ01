using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEq01_Application.Tabs
{
    public partial class Tab_Arrive : UserControl
    {
        public Tab_Arrive()
        {
            InitializeComponent();
        }

        private void Tab_Arrive_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            this.TA_ARRIVE.Fill(this.DS_Master.ARRIVE);
            this.TA_DEPART.Fill(this.DS_Master.DEPART);
            this.TA_RESERVATION.FillByARRIVE(this.DS_Master.RESERVATION);
            this.TA_TRX.Fill(this.DS_Master.TRX);

            Link_ARRIVE();
        }

        private void Link_ARRIVE()
        {
            this.BS_ARRIVE.DataMember = "ARRIVE";
            this.BS_ARRIVE.DataSource = this.DS_Master;

            try
            {
                Info_Client.TextBox_NoClient.DataBindings.Add("Text", BS_ARRIVE, "IdCli");
                TextBox_NoArrive.DataBindings.Add("Text", BS_ARRIVE, "IdArrive");
            }
            catch(Exception ee) { MessageBox.Show(ee.Message); }
        }
    }
}
