using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEq01_Application.UserControls.Info_Reservation
{
    public partial class IR_Depart : PrjEq01_Application.UserControls.IR_Base
    {
        public IR_Depart()
        {
            InitializeComponent();
        }

        protected override void bt_list_Click(object sender, EventArgs e)
        {
            if (this.Parent is Tabs.UC_Reservation)
            {
                List_Forms.LF_Reservation lf_reservation = new List_Forms.LF_Reservation(BS);
                Tabs.UC_Reservation uc_reser = (Tabs.UC_Reservation)this.Parent;

                int tmpPos_BS_RESERVATION = BS.Position;

                if (lf_reservation.ShowDialog() == DialogResult.Cancel)
                {
                    BS.Position = tmpPos_BS_RESERVATION;
                }
                else
                {
                    uc_reser.Sync_ForeignTables();
                }
            }
        }
    }
}
