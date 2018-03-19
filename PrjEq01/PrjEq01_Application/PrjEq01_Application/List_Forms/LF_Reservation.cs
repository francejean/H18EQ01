using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjEq01_Application.List_Forms
{
    public partial class LF_Reservation : PrjEq01_Application.List_Forms.LF_Base
    {

        public LF_Reservation()
        {
            InitializeComponent();
        }

        public LF_Reservation(BindingSource BS) : base(BS)
        {
            InitializeComponent();
            dgv_main.DataSource = this.BS;
        }

		public UserControls.Inherit_DGV dgv_noReser
		{
			get
			{
				return this.dgv_main;
			}
			set
			{
				this.dgv_main = value;
			}
		}
    }
}
