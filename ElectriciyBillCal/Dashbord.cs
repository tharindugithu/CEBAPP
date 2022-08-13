using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectriciyBillCal
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void customDesign()
        {
            pnl_btn_submenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        private void hideSubMenu()
        {
            if(pnl_btn_submenu.Visible == true)
            {
                pnl_btn_submenu.Visible = false;
            }
            
        }
        private void showSubMenu1(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu1();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        private void hideSubMenu1()
        {
            if (pnl_dom_submenu.Visible == true)
            {
                pnl_dom_submenu.Visible = false;
            }

        }
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_right.Controls.Add(childForm);
            pnl_right.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void pnl_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_gen_cat_GP_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_gen_cat_GP_1());
        }

        private void btn_ind_cat_I_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_ind_cat_I_1());
        }

        private void btn_hot_cat_H_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_hot_cat_H_1());
        }

        private void btn_gov_GV_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_gov_cat_GV_1());
        }

        private void btn_dom_cat_1_Click(object sender, EventArgs e)
        {
            showSubMenu1(pnl_dom_submenu);
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_dom_cal());
        }

        private void btn_billrate_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_dom_billrate());
        }

        private void btn_rel_cat_R_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_rel_cat_R_1());
        }

        private void pnl_buttons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            customDesign();
        }

        private void btn_billcalculator_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_btn_submenu);
        }
    }
}
