using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjEq01_Application.List_Forms
{
    public partial class LF_Chambres : PrjEq01_Application.List_Forms.LF_Base
    {
        public LF_Chambres()
        {
            InitializeComponent();
        }

        public LF_Chambres(BindingSource BS) : base(BS)
        {
            InitializeComponent();
            dgv_main.DataSource = this.BS;
        }
    }
}
