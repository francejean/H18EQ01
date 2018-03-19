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
    public partial class LF_ChambreCommodite : PrjEq01_Application.List_Forms.LF_Base
    {
        public LF_ChambreCommodite()
        {
            InitializeComponent();
        }

        public PrjEq01_Application.UserControls.Inherit_DGV Dgv_main
        {
            get
            {
                return this.dgv_main;
            }
            set
            {
                dgv_main = value;
            }
        }
    }
}
