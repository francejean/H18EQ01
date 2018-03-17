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
    public partial class LF_ChambreNoCham : Form
    {
        public LF_ChambreNoCham()
        {
            InitializeComponent();
        }

        public DataGridView Dgv_noCham
        {
            get
            {
                return this.dgv_noCham;
            }
            set
            {
                dgv_noCham = value;
            }
        }

        private void LF_ChambreNoCham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Master.CHAMBRE' table. You can move, or remove it, as needed.
            //this.cHAMBRETableAdapter.Fill(this.dS_Master.CHAMBRE);

        }
    }
}
