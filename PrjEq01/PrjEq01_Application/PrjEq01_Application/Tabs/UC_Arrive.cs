using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PrjEq01_CommonForm;

namespace PrjEq01_Application.Tabs
{
	public partial class UC_Arrive : UserControl, PrjEq01_CommonForm.IButtons
    {
        public States State { get; set; }

        public UC_Arrive()
		{
			InitializeComponent();
            ic_arrive.setBS(BS_CLIENT);
            ir_arrive.setBS(BS_RESERVATION);
		}

		private void Tab_Arrive_Load(object sender, EventArgs e)
		{
			Fill();
            Link();
            Sync_ForeignTables();
		}

		private void Fill()
		{
			this.TA_ARRIVE.Fill(this.ds_master.ARRIVE);
			this.TA_RESERVATION.FillByARRIVE(this.ds_master.RESERVATION);
			this.TA_CLIENT.Fill(this.ds_master.CLIENT);
			this.TA_CHAMBRE.FillByARRIVE(this.ds_master.CHAMBRE);
            this.TA_DE.FillBy(ds_master.DE);
		}

        private void Link()
        {
            Link_ARRIVE();
            Link_CLIENT();
            Link_RESERVATION();
            Link_CHAMBRE();
        }

		private void Link_ARRIVE()
		{
			this.BS_ARRIVE.DataMember = "ARRIVE";
			this.BS_ARRIVE.DataSource = this.ds_master;

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
			this.BS_CLIENT.DataSource = this.ds_master;

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
			this.BS_RESERVATION.DataSource = this.ds_master;

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
            this.BS_CHAMBRE.DataMember = "DE_FK_IdReser";
            this.BS_CHAMBRE.DataSource = this.BS_RESERVATION;

            try
            {
                ls_chambre.dgv_chambre.DataSource = BS_CHAMBRE;
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
        }

        public void SetReadOnly()
        {
            List<IReadOnly> consult_controls = new List<IReadOnly>();
            consult_controls.Add(ic_arrive);
            consult_controls.Add(ir_arrive);
            consult_controls.Add(ls_chambre);

            foreach(IReadOnly consult_control in consult_controls)
            {
                consult_control.SetReadOnly(State);
            }

            switch (State)
            {
                case States.ADD:
                    tb_noArrive.ReadOnly = false; 
                    break;
                case States.EDIT:
                    tb_noArrive.ReadOnly = false;
                    break;
                case States.DELETE:
                    tb_noArrive.ReadOnly = true;
                    break;
                case States.SAVE:
                    tb_noArrive.ReadOnly = true;
                    break;
                case States.MOVE:
                    tb_noArrive.ReadOnly = true;
                    break;
            }
        }

        public bool Sync_ForeignTables()
        {
            BS_CLIENT.Position = BS_CLIENT.Find("IdCli", ds_master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdCli"]);
            BS_RESERVATION.Position = BS_RESERVATION.Find("IdReser", ds_master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdReser"]);
            return true;
        }

        public void Add()
        {
            SetReadOnly();
        }

        public void Edit()
        {
            SetReadOnly();
        }

        public void Delete()
        {
            SetReadOnly();
        }

        public void Undo()
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void Save()
        {
            MessageBox.Show("Fonction en développement.");
            SetReadOnly();
        }

        public void Go_Start()
        {
            BS_ARRIVE.MoveFirst();
            Sync_ForeignTables();
            SetReadOnly();
        }

        public void Go_Back()
        {
            BS_ARRIVE.MovePrevious();
            Sync_ForeignTables();
            SetReadOnly();
        }

        public void Go_Forward()
        {
            BS_ARRIVE.MoveNext();
            Sync_ForeignTables();
            SetReadOnly();
        }

        public void Go_End()
        {
            BS_ARRIVE.MoveLast();
            Sync_ForeignTables();
            SetReadOnly();
        }
    }
}
