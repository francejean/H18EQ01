using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjEq01_Application.UserControls.Liste_Chambre
{
	public partial class LC_Arrive : PrjEq01_Application.UserControls.LC_Base
	{
		private ItemSelectedDeleg chambreSelected;

		public ItemSelectedDeleg ChambreSelected { get => chambreSelected; set => chambreSelected = value; }

		public LC_Arrive()
		{
			InitializeComponent();
		}

		private void dgv_chambre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex != -1)
			{
				chambreSelected(Convert.ToInt16(dgv_chambre.Rows[e.RowIndex].Cells[0].Value));
			}
		}
	}
}
