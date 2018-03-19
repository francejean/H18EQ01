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
    public partial class UC_Departs : UserControl, PrjEq01_CommonForm.IButtons
    {
        public UC_Departs()
        {
            InitializeComponent();
           //set BS UC_Depart.designer ligne 34-35
        }

        public void SetReadOnly(bool state)
        {
            List<IReadOnly> consult_controls = new List<IReadOnly>
            {
                ic_base,
                ir_departs
            };

            foreach (IReadOnly consult_control in consult_controls)
            {
                consult_control.SetReadOnly(state);
            }

            tb_noArrivee.ReadOnly = state;
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
            MessageBox.Show("Fonction en développement.");
        }

        public void Go_Back()
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void Go_Forward()
        {
            MessageBox.Show("Fonction en développement.");
        }

        public void Go_End()
        {
            MessageBox.Show("Fonction en développement.");
        }
    }
}
