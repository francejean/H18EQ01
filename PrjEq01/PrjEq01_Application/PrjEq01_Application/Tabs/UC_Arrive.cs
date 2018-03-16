using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEq01_Application.Tabs
{
	public partial class UC_Arrive : UserControl, PrjEq01_CommonForm.IButtons
    {
		public UC_Arrive()
		{
			InitializeComponent();
		}

		private void Tab_Arrive_Load(object sender, EventArgs e)
		{
			Fill();
		}

		private void Fill()
		{
			this.TA_ARRIVE.Fill(this.DS_Master.ARRIVE);
			this.TA_DEPART.Fill(this.DS_Master.DEPART);
			this.TA_RESERVATION.FillByARRIVE(this.DS_Master.RESERVATION);
			this.TA_TRX.Fill(this.DS_Master.TRX);
			this.TA_CLIENT.Fill(this.DS_Master.CLIENT);
			this.TA_CHAMBRE.FillByARRIVE(this.DS_Master.CHAMBRE);

			Link_ARRIVE();
			Link_CLIENT();
			Link_RESERVATION();
			Link_CHAMBRE();

            Sync_ForeignTables();
		}

		private void Link_ARRIVE()
		{
			this.BS_ARRIVE.DataMember = "ARRIVE";
			this.BS_ARRIVE.DataSource = this.DS_Master;

			try
			{
				tb_noArrive.DataBindings.Add("Text", BS_ARRIVE, "IdArrive");
                ic_arrive.tb_noClient.DataBindings.Add("Text", BS_ARRIVE, "IdCli");
                ir_arrive.tb_noReserv.DataBindings.Add("Text", BS_ARRIVE, "IdReser");
                ic_arrive.tb_noChambre.DataBindings.Add("Text", BS_ARRIVE, "NoCham");
			}
			catch (Exception ee) { MessageBox.Show(ee.Message); }
		}

		private void Link_CLIENT()
		{
			this.BS_CLIENT.DataMember = "CLIENT";
			this.BS_CLIENT.DataSource = this.DS_Master;

			try
			{
				ic_arrive.tb_nomClient.DataBindings.Add("Text", BS_CLIENT, "Nom");
				ic_arrive.tb_adresse.DataBindings.Add("Text", BS_CLIENT, "Adresse");
				ic_arrive.tb_telephone.DataBindings.Add("Text", BS_CLIENT, "Telephone");
				ic_arrive.tb_typeCarte.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
				ic_arrive.tb_noCarte.DataBindings.Add("Text", BS_CLIENT, "NoCarte");
				ic_arrive.tb_expiration.DataBindings.Add("Text", BS_CLIENT, "DatExp");
			}
			catch (Exception ee) { MessageBox.Show(ee.Message); }
		}

		private void Link_RESERVATION()
		{
			this.BS_RESERVATION.DataMember = "RESERVATION";
			this.BS_RESERVATION.DataSource = this.DS_Master;

			try
			{
				ir_arrive.DTP_Reserv.DataBindings.Add("Text", BS_RESERVATION, "DateReser");
				ir_arrive.DTP_Debut.DataBindings.Add("Text", BS_RESERVATION, "DateDebut");
				ir_arrive.DTP_Fin.DataBindings.Add("Text", BS_RESERVATION, "DateFin");
				ir_arrive.tb_noClient.DataBindings.Add("Text", BS_RESERVATION, "IdCli");
				ir_arrive.tb_nom.DataBindings.Add("Text", BS_RESERVATION, "Nom");
			}
			catch (Exception ee) { MessageBox.Show(ee.Message); }
		}

		private void Link_CHAMBRE()
		{
			this.BS_CHAMBRE.DataMember = "CHAMBRE";
			this.BS_CHAMBRE.DataSource = this.DS_Master;

			try
			{
				ls_chambre.dgv_chambre.DataSource = BS_CHAMBRE;
			}
			catch (Exception ee) { MessageBox.Show(ee.Message); }
		}

        public void SetReadOnly(bool state)
        {
            List<IReadOnly> consult_controls = new List<IReadOnly>();
            consult_controls.Add(ic_arrive);
            consult_controls.Add(ir_arrive);

            foreach(IReadOnly consult_control in consult_controls)
            {
                consult_control.SetReadOnly(state);
            }

            tb_noArrive.ReadOnly = state;
        }

        public bool Sync_ForeignTables()
        {
            BS_CLIENT.Position = BS_CLIENT.Find("IdCli", DS_Master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdCli"]);
            BS_RESERVATION.Position = BS_RESERVATION.Find("IdReser", DS_Master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdReser"]);
            return true;
        }

        public void Add()
        {
            MessageBox.Show("Fonction en développement.");
            SetReadOnly(false);
        }

        public void Edit()
        {
            MessageBox.Show("Fonction en développement.");
            SetReadOnly(false);
        }

        public void Delete()
        {
            MessageBox.Show("Fonction en développement.");
            SetReadOnly(true);
        }

        public void Undo()
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void Save()
        {
            MessageBox.Show("Fonction en développement.");
            SetReadOnly(true);
        }

        public void Go_Start()
        {
            BS_ARRIVE.MoveFirst();
            Sync_ForeignTables();
            SetReadOnly(true);
        }

        public void Go_Back()
        {
            BS_ARRIVE.MovePrevious();
            Sync_ForeignTables();
            SetReadOnly(true);
        }

        public void Go_Forward()
        {
            BS_ARRIVE.MoveNext();
            Sync_ForeignTables();
            SetReadOnly(true);
        }

        public void Go_End()
        {
            BS_ARRIVE.MoveLast();
            Sync_ForeignTables();
            SetReadOnly(true);
        }
    }
}
