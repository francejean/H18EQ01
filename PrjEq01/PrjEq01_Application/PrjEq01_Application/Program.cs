using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEq01_Application
{

	public delegate void ItemSelectedDeleg(int PK);
	public delegate void ChamberSelectedDeleg(string PK);
	public delegate void ChamberBeforeSelection();
	public delegate void OnValidatedDeleg();

	static class Program
	{
		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormApplication());
		}
	}
}
