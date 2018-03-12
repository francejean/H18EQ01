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
    public partial class UC_Chambre : UserControl, PrjEq01_CommonForm.IButtons
    {
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
        }

        private void Fill()
        {
            TA_CHAMBRE.FillBy(this.dS_Master.CHAMBRE);
            TA_AYANT.Fill(this.dS_Master.AYANT);
            TA_COMMODITE.Fill(this.dS_Master.COMMODITE);
            TA_TYPECHAM.Fill(this.dS_Master.TYPECHAM);
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
            BS_AYANT.DataSource = BS_CHAMBRE;
            //MessageBox.Show("Fonction en développement.");
        }

        public void Go_Back()
        {
            BS_CHAMBRE.MovePrevious();
            BS_AYANT.DataSource = BS_CHAMBRE;
            //MessageBox.Show("Fonction en développement.");
        }

        public void Go_Forward()
        {
            BS_CHAMBRE.MoveNext();
            BS_AYANT.DataSource = BS_CHAMBRE;
            //MessageBox.Show("Fonction en développement.");
        }

        public void Go_End()
        {
            BS_CHAMBRE.MoveLast();
            BS_AYANT.DataSource = BS_CHAMBRE;
            //MessageBox.Show("Fonction en développement.");
        }
    }
}
