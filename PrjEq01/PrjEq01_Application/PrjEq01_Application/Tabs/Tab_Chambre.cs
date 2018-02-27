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
    public partial class Tab_Chambre : UserControl
    {
        public Tab_Chambre()
        {
            InitializeComponent();
        }

        private void Tab_Chambre_Load(object sender, EventArgs e)
        {
            Fill();
            LinkAll();
        }

        private void LinkAll()
        {
            LinkChambre();
            LinkAyant();
        }

        private void Fill()
        {
            TA_CHAMBRE.FillBy(this.dS_Master.CHAMBRE);
            TA_AYANT.Fill(this.dS_Master.AYANT);
        }

        private void LinkChambre()
        {
            BS_CHAMBRE.DataMember = "CHAMBRE";
            BS_CHAMBRE.DataSource = this.dS_Master;

            try
            {
                noChamTextBox.DataBindings.Add("Text", BS_CHAMBRE, "NoCham");
                //do it with all text box
            }
            catch
            {

            }
        }

        private void LinkAyant()
        {
            BS_AYANT.DataMember = "AYANT_FK_NoCham";
            BS_AYANT.DataSource = BS_CHAMBRE;
            dataGridView1.DataSource = BS_AYANT;
        }
    }
}
