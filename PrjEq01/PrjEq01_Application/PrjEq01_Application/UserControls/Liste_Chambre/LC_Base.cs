using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjEq01_CommonForm;

namespace PrjEq01_Application.UserControls
{
    public partial class LC_Base : UserControl, IInfoBox
    {
        protected BindingSource BS;

        public LC_Base()
        {
            InitializeComponent();
        }

        public void setBS(BindingSource BS)
        {
            this.BS = BS;
        }

        protected virtual void bt_list_Click(object sender, EventArgs e)
        {
            int BS_pos_backup = BS.Position;
            List_Forms.LF_Chambres lf_chambres = new List_Forms.LF_Chambres(BS);
            DialogResult result = lf_chambres.ShowDialog();

            if (result == DialogResult.OK)
            {
            }
            else if (result == DialogResult.Cancel)
            {
                BS.Position = BS_pos_backup;
            }
        }

        public void SetReadOnly(States state)
        {
            bool readOnly = false;

            switch (state)
            {
                case States.ADD:
                    readOnly = false;
                    bt_listCommodite.Enabled = true;
                    break;
                case States.EDIT:
                    readOnly = false;
                    bt_listCommodite.Enabled = false;
                    break;
                case States.CONSULT:
                    readOnly = true;
                    bt_listCommodite.Enabled = false;
                    break;
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ((TextBox)ctrl).ReadOnly = readOnly;
                else if (ctrl.GetType() == typeof(ComboBox))
                    ((ComboBox)ctrl).Enabled = readOnly;
                else if (ctrl.GetType() == typeof(CheckBox))
                    ((CheckBox)ctrl).Enabled = readOnly;
                else if (ctrl.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)ctrl).Enabled = !readOnly;
            }
            
        }

        public void WipeInformation()
        {
        }
    }
}
