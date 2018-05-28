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
		private string noCham;

		public LF_Chambres()
		{
			InitializeComponent();
		}

		public LF_Chambres(BindingSource BS) : base(BS)
		{
			InitializeComponent();
			dgv_main.DataSource = this.BS;
		}

		public string GetNoChamSelected()
		{
			return this.noCham;
		}

		private void LF_Chambres_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.noCham = dgv_main.CurrentRow?.Cells["NoCham"].Value.ToString();
		}
	}
}
