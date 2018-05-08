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
			dgv_chambre.AutoGenerateColumns = false;
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

		public virtual void SetReadOnly(States state)
		{
			switch (state)
			{
				case States.ADD:
					bt_listCommodite.Enabled = false;
					break;
				case States.EDIT:
					bt_listCommodite.Enabled = true;
					break;
				case States.CONSULT:
					bt_listCommodite.Enabled = false;
					break;
			}
		}

		public void WipeInformation()
		{
		}

		public void SetListButton(bool enabled)
		{
			bt_listCommodite.Enabled = enabled;
		}
	}
}
