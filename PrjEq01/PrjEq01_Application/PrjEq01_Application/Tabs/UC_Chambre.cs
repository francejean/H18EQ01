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
    public partial class UC_Chambre : UserControl, PrjEq01_CommonForm.IButtons
    {
        public States State { get; set; }

        public UC_Chambre()
        {
            InitializeComponent();
        }

        private void Tab_Chambre_Load(object sender, EventArgs e)
        {
            Fill();
            LinkAll();
        }

        private void LinkAll()
        {
            LinkChambre();
            LinkAyant();
            LinkTypeCham();
            LinkLocalisation();
            LinkCommodite();
        }

        private void Fill()
        {
            TA_CHAMBRE.FillByCHAMBRE(this.dS_Master.CHAMBRE);
            TA_AYANT.Fill(this.dS_Master.AYANT);
            TA_COMMODITE.Fill(this.dS_Master.COMMODITE);
            TA_TYPECHAM.Fill(this.dS_Master.TYPECHAM);
            TA_LOCALISATION.Fill(this.dS_Master.LOCALISATION);
        }

        private void LinkChambre()
        {
            BS_CHAMBRE.DataMember = "CHAMBRE";
            BS_CHAMBRE.DataSource = this.dS_Master;

            try
            {
                tb_noCham.DataBindings.Add("Text", BS_CHAMBRE, "NoCham");
                tb_etage.DataBindings.Add("Text", BS_CHAMBRE, "Etage");
                tb_etat.DataBindings.Add("Text", BS_CHAMBRE, "Etat");
                tb_codeType.DataBindings.Add("Text", BS_CHAMBRE, "CodTypCham");
                tb_codeLoc.DataBindings.Add("Text", BS_CHAMBRE, "CodLoc");
                mtb_prix.DataBindings.Add("Text", BS_CHAMBRE, "Prix");
                tb_descType.DataBindings.Add("Text", BS_CHAMBRE, "DescTyp");
                tb_descLoc.DataBindings.Add("Text", BS_CHAMBRE, "DescLoc");
                tb_memo.DataBindings.Add("Text", BS_CHAMBRE, "Memo");
            }
            catch
            {

            }
        }

        private void LinkAyant()
        {
            BS_AYANT.DataMember = "AYANT_FK_NoCham";
            BS_AYANT.DataSource = BS_CHAMBRE;
            dgv_commodite.DataSource = BS_AYANT;
        }

        private void LinkTypeCham()
        {
            BS_TYPECHAM.DataMember = "TYPECHAM";
            BS_TYPECHAM.DataSource = dS_Master;
        }

        private void LinkLocalisation()
        {
            BS_LOCALISATION.DataMember = "LOCALISATION";
            BS_LOCALISATION.DataSource = dS_Master;
        }

        private void LinkCommodite()
        {
            BS_COMMODITE.DataMember = "COMMODITE";
            BS_COMMODITE.DataSource = dS_Master;
        }

        public void SetReadOnly(bool state)
        {
            foreach (Control ctrl in gb_infoChambre.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ((TextBox)ctrl).ReadOnly = state;
                if (ctrl.GetType() == typeof(MaskedTextBox))
                    ((MaskedTextBox)ctrl).ReadOnly = state;
            }
            bt_listCodeLoc.Enabled = !state;
            bt_listCodeType.Enabled = !state;
            bt_listCommodite.Enabled = !state;
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
            BS_CHAMBRE.MoveFirst();
            //MessageBox.Show("Fonction en développement.");
        }

        public void Go_Back()
        {
            BS_CHAMBRE.MovePrevious();
            //MessageBox.Show("Fonction en développement.");
        }

        public void Go_Forward()
        {
            BS_CHAMBRE.MoveNext();
            //MessageBox.Show("Fonction en développement.");
        }

        public void Go_End()
        {
            BS_CHAMBRE.MoveLast();
            //MessageBox.Show("Fonction en développement.");
        }

        private void bt_listNoChambre_Click(object sender, EventArgs e)
        {
            PrjEq01_Application.List_Forms.LF_ChambreNoCham lf_chambreNoCham = new PrjEq01_Application.List_Forms.LF_ChambreNoCham();
            lf_chambreNoCham.Dgv_noCham.DataSource = BS_CHAMBRE;
            int tempPositionBS_CHAMBRE = BS_CHAMBRE.Position;
            if (lf_chambreNoCham.ShowDialog() == DialogResult.Cancel)
            {
                BS_CHAMBRE.Position = tempPositionBS_CHAMBRE;
            }
            //MessageBox.Show("Fonction en développement.");
        }

        private void bt_listCodeType_Click(object sender, EventArgs e)
        {
            /*PrjEq01_Application.List_Forms.LF_ChambreCodeType lf_chambreCodeType = new PrjEq01_Application.List_Forms.LF_ChambreCodeType();
            lf_chambreCodeType.Dgv_main.DataSource = BS_TYPECHAM;
            int tempPositionBS_TYPECHAM = BS_TYPECHAM.Position;
            if (lf_chambreCodeType.ShowDialog() == DialogResult.Cancel)
            {
                BS_TYPECHAM.Position = tempPositionBS_TYPECHAM;
            }
            //MessageBox.Show("Fonction en développement.");*/
        }

        private void bt_listCodeLoc_Click(object sender, EventArgs e)
        {
            /*PrjEq01_Application.List_Forms.LF_ChambreCodeLoc lf_chambreCodeLoc = new PrjEq01_Application.List_Forms.LF_ChambreCodeLoc();
            lf_chambreCodeLoc.Dgv_main.DataSource = BS_LOCALISATION;
            int tempPositionBS_LOCALISATION = BS_LOCALISATION.Position;
            if (lf_chambreCodeLoc.ShowDialog() == DialogResult.Cancel)
            {
                BS_TYPECHAM.Position = tempPositionBS_LOCALISATION;
            }
            //MessageBox.Show("Fonction en développement.");*/
        }

        private void bt_listCommodite_Click(object sender, EventArgs e)
        {
            /*PrjEq01_Application.List_Forms.LF_ChambreCommodite lf_chambreCommodite = new PrjEq01_Application.List_Forms.LF_ChambreCommodite();
            lf_chambreCommodite.Dgv_main.DataSource = BS_COMMODITE;
            int tempPositionBS_COMMODITE = BS_COMMODITE.Position;
            if (lf_chambreCommodite.ShowDialog() == DialogResult.Cancel)
            {
                BS_TYPECHAM.Position = tempPositionBS_COMMODITE;
            }
            //MessageBox.Show("Fonction en développement.");*/
        }
    }
}
