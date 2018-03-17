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
    public partial class LF_Reservation : Form
    {
        public LF_Reservation()
        {
            InitializeComponent();
            Fill();
            dgv_reservation.DataSource = BS_RESERVATION;
        }

        private void Fill()
        {
            this.TA_RESERVATION.Fill(this.ds_master.RESERVATION);

            this.BS_RESERVATION.DataMember = "RESERVATION";
            this.BS_RESERVATION.DataSource = this.ds_master;
        }
    }
}
