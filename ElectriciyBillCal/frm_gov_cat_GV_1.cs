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
    public partial class frm_gov_cat_GV_1 : Form
    {
        double charge = 14.65;
        double fixed_charge = 600;
        double chg_forUnits;
        double total_cahrage;
        double max_demand_charge = 0;
        public frm_gov_cat_GV_1()
        {
            InitializeComponent();
        }

        private void frm_gov_cat_GV_1_Load(object sender, EventArgs e)
        {
            lbl_t_1.Text = charge.ToString();
            lbl_t_2.Text = fixed_charge.ToString();
            lbl_t_3.Text = max_demand_charge.ToString();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string temp = tb_units.Text;
            int value;
            if (int.TryParse(temp, out value))
            {
                int units_consumed = int.Parse(tb_units.Text);
                if (units_consumed >= 0)
                {
                    chg_forUnits = units_consumed * charge;
                    lbl_1.Text = chg_forUnits.ToString();
                    lbl_2.Text = fixed_charge.ToString();
                    total_cahrage = chg_forUnits + fixed_charge;
                    lbl_3.Text = total_cahrage.ToString();
                    tb_result.Visible = true;
                    tb_units.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a postive number", "Negavite number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
