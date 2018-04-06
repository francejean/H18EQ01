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
    public partial class LF_Arrive : PrjEq01_Application.List_Forms.LF_Base
    {
        public LF_Arrive(BindingSource BS)
        {
            InitializeComponent();
            this.dgv_main.DataSource = BS;
        }
    }
}
