using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEq01_Application
{
	public partial class FormApplication : PrjEq01_CommonForm.FormCommon
	{
		public FormApplication()
		{
			InitializeComponent();
			Tab_Arrivées.uc_tab = uc_arrive;
			Tab_Chambres.uc_tab = uc_chambre;
			Tab_Départs.uc_tab = uc_departs;
			Tab_Réservations.uc_tab = uc_reservation;
		}
	}
}
