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

        private void set_ts_buttons(States state)
        {
            List<ToolStripButton> ts_button_list = ts_main.Items.OfType<ToolStripButton>().ToList();
            if (state == States.ADD || state == States.EDIT)
            {
                ts_button_list.Find(x => x.Name == "button_add").Enabled = false;
                ts_button_list.Find(x => x.Name == "button_edit").Enabled = false;
                ts_button_list.Find(x => x.Name == "button_delete").Enabled = false;
                ts_button_list.Find(x => x.Name == "button_undo").Enabled = true;
                ts_button_list.Find(x => x.Name == "button_save").Enabled = true;
                ts_button_list.Find(x => x.Name == "button_backAll").Enabled = false;
                ts_button_list.Find(x => x.Name == "button_backOne").Enabled = false;
                ts_button_list.Find(x => x.Name == "button_forwardOne").Enabled = false;
                ts_button_list.Find(x => x.Name == "button_forwardAll").Enabled = false;
            }
            else if(state == States.CONSULT)
            {
                ts_button_list.Find(x => x.Name == "button_add").Enabled = true;
                ts_button_list.Find(x => x.Name == "button_edit").Enabled = (tc_main.SelectedTab.Name != "Tab_Départs" && tc_main.SelectedTab.Name != "Tab_Clients");
				        ts_button_list.Find(x => x.Name == "button_delete").Enabled = (tc_main.SelectedTab.Name != "Tab_Clients");
                ts_button_list.Find(x => x.Name == "button_undo").Enabled = false;
                ts_button_list.Find(x => x.Name == "button_save").Enabled = false;
                ts_button_list.Find(x => x.Name == "button_backAll").Enabled = true;
                ts_button_list.Find(x => x.Name == "button_backOne").Enabled = true;
                ts_button_list.Find(x => x.Name == "button_forwardOne").Enabled = true;
                ts_button_list.Find(x => x.Name == "button_forwardAll").Enabled = true;
            }
        }

		private void Button_Add_Click(object sender, EventArgs e)
		{
            States state = States.ADD;
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
			if (selected_tab.uc_tab.Add())
			{
				if (tc_main.SelectedTab.Name != "Tab_Chambres")
				{
					selected_tab.uc_tab.SetReadOnly(state);
				}
				selected_tab.uc_tab.State = state;
				set_ts_buttons(state);
			}
        }

		private void Button_Edit_Click(object sender, EventArgs e)
		{
            States state = States.EDIT;
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
			if (selected_tab.uc_tab.Edit())
			{
				selected_tab.uc_tab.SetReadOnly(state);
				selected_tab.uc_tab.State = state;
				set_ts_buttons(state);
			}
        }

		private void Button_Delete_Click(object sender, EventArgs e)
		{
            States state = States.CONSULT;
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
			if (selected_tab.uc_tab.Delete())
			{
				selected_tab.uc_tab.SetReadOnly(state);
				selected_tab.uc_tab.State = state;
				set_ts_buttons(state);
			}
        }

		private void Button_Undo_Click(object sender, EventArgs e)
		{
            States state = States.CONSULT;
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
			if (selected_tab.uc_tab.Undo())
			{
				selected_tab.uc_tab.SetReadOnly(state);
				selected_tab.uc_tab.State = state;
				set_ts_buttons(state);
			}
        }

		private void Button_Save_Click(object sender, EventArgs e)
		{
            States state = States.CONSULT;
            Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
			if (selected_tab.uc_tab.Save())
            {
				selected_tab.uc_tab.SetReadOnly(state);
                selected_tab.uc_tab.State = state;
				set_ts_buttons(state);
            }
        }

        private void Button_Back_All_Click(object sender, EventArgs e)
        {
			States state = States.CONSULT;
			Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
			selected_tab.uc_tab.SetReadOnly(state);
			selected_tab.uc_tab.Go_Start();
			selected_tab.uc_tab.State = state;
		}

        private void Button_Back_One_Click(object sender, EventArgs e)
        {
			States state = States.CONSULT;
			Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
			selected_tab.uc_tab.SetReadOnly(state);
			selected_tab.uc_tab.Go_Back();
			selected_tab.uc_tab.State = state;
		}

        private void Button_Forward_One_Click(object sender, EventArgs e)
        {
			States state = States.CONSULT;
			Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
			selected_tab.uc_tab.SetReadOnly(state);
			selected_tab.uc_tab.Go_Forward();
			selected_tab.uc_tab.State = state;
		}

        private void Button_Forward_All_Click(object sender, EventArgs e)
        {
			States state = States.CONSULT;
			Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
			selected_tab.uc_tab.SetReadOnly(state);
			selected_tab.uc_tab.Go_End();
			selected_tab.uc_tab.State = state;
		}

        private void tc_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Tab_Interface selected_tab = (Tab_Interface)tc_main.TabPages[tc_main.SelectedIndex];
                set_ts_buttons(selected_tab.uc_tab.State);
				selected_tab.uc_tab.Fill();
			}
            catch (Exception exc) { };
        }
    }
}
