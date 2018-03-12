using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEq01_Application.UserControls
{
    public partial class Liste_Chambre : UserControl
    {
        public Liste_Chambre()
        {
            InitializeComponent();
        }

        private void bt_list_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonction en développement.");
        }

        private void fillByARRIVEToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHAMBRETableAdapter.FillByARRIVE(this.dS_Master.CHAMBRE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByARRIVEToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.cHAMBRETableAdapter.FillByARRIVE(this.dS_Master.CHAMBRE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByARRIVEToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.cHAMBRETableAdapter.FillByARRIVE(this.dS_Master.CHAMBRE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
