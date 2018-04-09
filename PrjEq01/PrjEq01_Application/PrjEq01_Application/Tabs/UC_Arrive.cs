using System;
using System.Collections.Generic;
using System.Data;
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
            lc_base.setBS(BS_CHAMBRE);
            State = States.CONSULT;
		}

		private void Tab_Arrive_Load(object sender, EventArgs e)
		{
			Fill();
            Link_All(true);
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
        

		private void Link_ARRIVE(bool link_state)
		{
			this.BS_ARRIVE.DataMember = "ARRIVE";
			this.BS_ARRIVE.DataSource = this.ds_master;
            if(link_state == true)
            {
                try
                {
                    tb_noArrive.DataBindings.Add("Text", BS_ARRIVE, "IdArrive");
                    ic_arrive.tb_noClient.DataBindings.Add("Text", BS_ARRIVE, "IdCli");
                    ir_arrive.tb_noReserv.DataBindings.Add("Text", BS_ARRIVE, "IdReser");
                    ic_arrive.tb_noChambre.DataBindings.Add("Text", BS_ARRIVE, "NoCham");
                }
                catch (Exception ee) { MessageBox.Show(ee.Message); }
            }
            else
            {
                try
                {
                    tb_noArrive.DataBindings.Clear();
                    ic_arrive.tb_noClient.DataBindings.Clear();
                    ir_arrive.tb_noReserv.DataBindings.Clear();
                    ic_arrive.tb_noChambre.DataBindings.Clear();
                }
                catch (Exception ee) { MessageBox.Show(ee.Message); }
            }
		}

		private void Link_CLIENT(bool link_state)
		{
			this.BS_CLIENT.DataMember = "CLIENT";
			this.BS_CLIENT.DataSource = this.ds_master;

            if(link_state == true)
            {
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
            else
            {
                try
                {
                    ic_arrive.tb_nomClient.DataBindings.Clear();
                    ic_arrive.tb_adresse.DataBindings.Clear();
                    ic_arrive.tb_telephone.DataBindings.Clear();
                    ic_arrive.tb_typeCarte.DataBindings.Clear();
                    ic_arrive.tb_noCarte.DataBindings.Clear();
                    ic_arrive.tb_expiration.DataBindings.Clear();
                }
                catch (Exception ee) { MessageBox.Show(ee.Message); }
            }
			
		}

		private void Link_RESERVATION(bool link_state)
		{
			this.BS_RESERVATION.DataMember = "RESERVATION";
			this.BS_RESERVATION.DataSource = this.ds_master;

            if(link_state == true)
            {
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
            else
            {
                try
                {
                    ir_arrive.DTP_Reserv.DataBindings.Clear();
                    ir_arrive.DTP_Debut.DataBindings.Clear();
                    ir_arrive.DTP_Fin.DataBindings.Clear();
                    ir_arrive.tb_noClient.DataBindings.Clear();
                    ir_arrive.tb_nom.DataBindings.Clear();
                }
                catch (Exception ee) { MessageBox.Show(ee.Message); }
            }
			
		}

		private void Link_CHAMBRE(bool link_state)
		{
            this.BS_CHAMBRE.DataMember = "DE_FK_IdReser";
            this.BS_CHAMBRE.DataSource = this.BS_RESERVATION;

            if(link_state)
            {
                try
                {
                    lc_base.dgv_chambre.DataSource = BS_CHAMBRE;
                }
                catch (Exception e)
                { MessageBox.Show(e.Message); }
            }
            else
            {
                try
                {
                    lc_base.dgv_chambre.DataSource = null;
                }
                catch (Exception e)
                { MessageBox.Show(e.Message); }
            }
            
        }

        private void Link_All(bool link_state)
        {
            Link_ARRIVE(link_state);
            Link_CHAMBRE(link_state);
            Link_CLIENT(link_state);
            Link_RESERVATION(link_state);
        }

        public void SetReadOnly()
        {
            List<IInfoBox> consult_controls = new List<IInfoBox>
            {
                ic_arrive,
                ir_arrive,
                lc_base
            };

            foreach (IInfoBox consult_control in consult_controls)
            {
                consult_control.SetReadOnly(State);
            }

			tb_noArrive.ReadOnly = !(State == States.ADD || State == States.EDIT);
		}

        public void Sync_ForeignTables()
        {
            try
            {
                BS_CLIENT.Position = BS_CLIENT.Find("IdCli", ds_master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdCli"]);
                BS_RESERVATION.Position = BS_RESERVATION.Find("IdReser", ds_master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdReser"]);
            }
            catch(Exception e)
            { MessageBox.Show(e.Message); }
        }

        public void Add()
        {
            SetReadOnly();
            NewArrive();
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
            if(State == States.ADD)
            {
                ds_master.Tables["Arrive"].Rows.RemoveAt(ds_master.ARRIVE.Rows.Count - 1);
                BS_ARRIVE.Position = 0;
                Link_All(true);
            }
            SetReadOnly();
        }

        public void Save()
        {
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

        public void NewArrive()
        {
            BS_ARRIVE.Position = BS_ARRIVE.Count - 1;
            ds_master.ARRIVE.Columns["IdArrive"].AutoIncrementSeed = (int)ds_master.ARRIVE.Rows[BS_ARRIVE.Position]["IdArrive"] + 1;

            DataRow DTR_Arrive = ds_master.Tables["Arrive"].NewRow();
            DTR_Arrive["IdArrive"] = (int)ds_master.ARRIVE.Columns["IdArrive"].AutoIncrementSeed;
            DTR_Arrive["DateArrive"] = DateTime.Today;
            DTR_Arrive["IdCli"] = DBNull.Value;
            DTR_Arrive["IdReser"] = DBNull.Value;
            DTR_Arrive["NoCham"] = DBNull.Value;

            ds_master.Tables["Arrive"].Rows.Add(DTR_Arrive);
            BS_ARRIVE.Position = BS_ARRIVE.Count - 1;

            DTR_Arrive.BeginEdit();

            Link_All(false);

            ic_arrive.WipeInformation();
            ir_arrive.WipeInformation();
        }
    }
}
