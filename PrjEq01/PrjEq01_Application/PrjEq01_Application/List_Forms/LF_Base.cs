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
    public partial class LF_Base : Form
    {
        protected BindingSource BS;

        public LF_Base()
        {
            InitializeComponent();
            BS = new BindingSource();
        }

        public LF_Base(BindingSource BS)
        {
            InitializeComponent();
            this.BS = BS;
        }
    }
}
