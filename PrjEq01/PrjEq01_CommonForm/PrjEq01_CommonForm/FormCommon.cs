using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjEq01_CommonForm;

namespace PrjEq01_CommonForm
{
    public partial class FormCommon : Form
    {

        public FormCommon()
        {
            InitializeComponent();
        }

		private void Button_Add_Click(object sender, EventArgs e)
		{
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
            selected_tab.uc_tab.AddExt();
		}

		private void Button_Edit_Click(object sender, EventArgs e)
		{
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
            selected_tab.uc_tab.EditExt();
        }

		private void Button_Delete_Click(object sender, EventArgs e)
		{
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
            selected_tab.uc_tab.DeleteExt();
        }

		private void Button_Undo_Click(object sender, EventArgs e)
		{
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
            selected_tab.uc_tab.Undo();
        }

		private void Button_Save_Click(object sender, EventArgs e)
		{
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
            selected_tab.uc_tab.Save();
        }

        private void Button_Back_All_Click(object sender, EventArgs e)
        {
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
            selected_tab.uc_tab.Go_Start();
        }

        private void Button_Back_One_Click(object sender, EventArgs e)
        {
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
            selected_tab.uc_tab.Go_Back();
        }

        private void Button_Forward_One_Click(object sender, EventArgs e)
        {
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
            selected_tab.uc_tab.Go_Forward();
        }

        private void Button_Forward_All_Click(object sender, EventArgs e)
        {
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
            selected_tab.uc_tab.Go_End();
        }
    }
}
