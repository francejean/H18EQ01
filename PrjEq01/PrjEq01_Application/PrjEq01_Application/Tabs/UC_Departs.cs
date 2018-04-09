﻿using System;
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
    public partial class UC_Departs : UserControl, PrjEq01_CommonForm.IButtons
    {
        public States State { get; set; }

        public UC_Departs()
        {
            InitializeComponent();
            //set BS UC_Depart.designer ligne 34-35
            this.ic_base.bt_list.Enabled = false;
            this.ic_base.bt_list.Visible = false;
            State = States.CONSULT;
        }

        private void Tab_Departs_Load(object sender, EventArgs e)
        {
            Fill();
            LinkAll();
            Sync_ForeignTables();
            ir_departs.tb_confirmerPar.Enabled = false;
        }

        private void Fill()
        {
            TA_ARRIVE.Fill(this.dS_Master.ARRIVE);
            TA_CLIENT.Fill(this.dS_Master.CLIENT);
            TA_DEPART.FillByDEPART(this.dS_Master.DEPART);
            TA_RESERVATION.Fill(this.dS_Master.RESERVATION);
        }

        private void LinkAll()
        {
            LinkArrive();
            LinkClient();
            LinkReservation();
            LinkDepart();
        }

        private void LinkArrive()
        {
            BS_ARRIVE.DataMember = "ARRIVE";
            BS_ARRIVE.DataSource = dS_Master;
            
            try
            {
                tb_noArrivee.DataBindings.Add("Text", BS_ARRIVE, "IdArrive");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LinkClient()
        {
            BS_CLIENT.DataMember = "CLIENT";
            BS_CLIENT.DataSource = dS_Master;

            try
            {
                ic_base.tb_noClient.DataBindings.Add("Text", BS_CLIENT, "IdCli");
                ic_base.tb_nomClient.DataBindings.Add("Text", BS_CLIENT, "Nom");
                ic_base.tb_adresse.DataBindings.Add("Text", BS_CLIENT, "Adresse");
                ic_base.tb_telephone.DataBindings.Add("Text", BS_CLIENT, "Telephone");
                ic_base.tb_typeCarte.DataBindings.Add("Text", BS_CLIENT, "TypeCarte");
                ic_base.tb_noCarte.DataBindings.Add("Text", BS_CLIENT, "NoCarte");
                ic_base.tb_expiration.DataBindings.Add("Text", BS_CLIENT, "DatExp");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LinkReservation()
        {
            BS_RESERVATION.DataMember = "RESERVATION";
            BS_RESERVATION.DataSource = this.dS_Master;

            try
            {
                ir_departs.tb_noReserv.DataBindings.Add("Text", BS_RESERVATION, "IdReser");
                ir_departs.DTP_Reserv.DataBindings.Add("Text", BS_RESERVATION, "DateReser");
                ir_departs.DTP_Debut.DataBindings.Add("Text", BS_RESERVATION, "DateDebut");
                ir_departs.DTP_Fin.DataBindings.Add("Text", BS_RESERVATION, "DateFin");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LinkDepart()
        {
            BS_DEPART.DataMember = "DEPART_FK_IdReser";
            BS_DEPART.DataSource = BS_RESERVATION;
            dgv_departs.AutoGenerateColumns = false;
            dgv_departs.DataSource = BS_DEPART;
        }

        public void SetReadOnly()
        {
            List<IInfoBox> consult_controls = new List<IInfoBox>
            {
                ic_base,
                ir_departs
            };

            foreach (IInfoBox consult_control in consult_controls)
            {
                consult_control.SetReadOnly(State);
            }

            /*switch (State)
            {
                case States.ADD:
                    tb_noArrive.ReadOnly = false;
                    break;
                case States.EDIT:
                    tb_noArrive.ReadOnly = false;
                    break;
                case States.DELETE:
                    tb_noArrive.ReadOnly = false;
                    break;
                case States.SAVE:
                    tb_noArrive.ReadOnly = false;
                    break;
                case States.MOVE:
                    tb_noArrive.ReadOnly = false;
                    break;
            }*/
        }

        public bool Sync_ForeignTables()
        {
            BS_CLIENT.Position = BS_CLIENT.Find("IdCli", dS_Master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdCli"]);
            BS_RESERVATION.Position = BS_RESERVATION.Find("IdReser", dS_Master.Tables["ARRIVE"].Rows[BS_ARRIVE.Position]["IdReser"]);
            return true;
        }

        public void Add()
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void Edit()
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void Delete()
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void Undo()
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void Save()
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void Go_Start()
        {
            BS_ARRIVE.MoveFirst();
            Sync_ForeignTables();
            //MessageBox.Show("Fonction en développement.");
        }

        public void Go_Back()
        {
            BS_ARRIVE.MovePrevious();
            Sync_ForeignTables();
            //MessageBox.Show("Fonction en développement.");
        }

        public void Go_Forward()
        {
            BS_ARRIVE.MoveNext();
            Sync_ForeignTables();
            //MessageBox.Show("Fonction en développement.");
        }

        public void Go_End()
        {
            BS_ARRIVE.MoveLast();
            Sync_ForeignTables();
            //MessageBox.Show("Fonction en développement.");
        }

        private void bt_list_Click(object sender, EventArgs e)
        {
            PrjEq01_Application.List_Forms.LF_Arrive lf_arrive = new PrjEq01_Application.List_Forms.LF_Arrive(BS_ARRIVE);
            int tempPositionBS_ARRIVE = BS_ARRIVE.Position;
            if (lf_arrive.ShowDialog() == DialogResult.Cancel)
            {
                BS_ARRIVE.Position = tempPositionBS_ARRIVE;
            }
            else
            {
                Sync_ForeignTables();
            }
        }
    }
}
