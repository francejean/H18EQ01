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

namespace PrjEq01_Application.Tabs
{
	public partial class UC_Clients : UserControl, IButtons
	{
		public States State { get; set; }

		public UC_Clients()
		{
			InitializeComponent();
			State = States.CONSULT;
		}

		public bool Add()
		{
			throw new NotImplementedException();
		}

		public bool Delete()
		{
			throw new NotImplementedException();
		}

		public bool Edit()
		{
			throw new NotImplementedException();
		}

		public bool Undo()
		{
			throw new NotImplementedException();
		}

		public bool Save()
		{
			throw new NotImplementedException();
		}

		public void Go_Back()
		{
			throw new NotImplementedException();
		}

		public void Go_End()
		{
			throw new NotImplementedException();
		}

		public void Go_Forward()
		{
			throw new NotImplementedException();
		}

		public void Go_Start()
		{
			throw new NotImplementedException();
		}

		public void SetReadOnly(States state)
		{
			throw new NotImplementedException();
		}

		public void Fill()
		{
			throw new NotImplementedException();
		}
	}
}
