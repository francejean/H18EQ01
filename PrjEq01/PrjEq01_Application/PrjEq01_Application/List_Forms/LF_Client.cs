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

        public LF_Client(BindingSource BS) : base(BS)
        {
            InitializeComponent();
            dgv_main.DataSource = this.BS;
        }
    }
}
