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
    public partial class frm_ind_cat_I_1 : Form
    {
        double charge_before_300 = 10.80;
        double charge_after_300 = 12.20;
        double fixed_charge = 600;
        double before_300;
        double after_300;
        double total_cahrage;
        double max_demand_charge = 0;
        public frm_ind_cat_I_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = tb_units.Text;
            int value;
            if(int.TryParse(temp , out value)) 
            {
                int units_consumed = int.Parse(tb_units.Text);
                if (units_consumed < 301 && units_consumed >= 0)
                {
                    before_300 = units_consumed * charge_before_300;
                    lbl_1.Text = before_300.ToString();
                    lbl_2.Text = "0";
                    lbl_3.Text = fixed_charge.ToString();
                    total_cahrage = before_300 + fixed_charge;
                    lbl_4.Text = total_cahrage.ToString();
                    tb_result.Visible = true;
                    tb_units.Clear();

                }
                else if (units_consumed > 300)
                {
                    before_300 = 300 * charge_before_300;
                    after_300 = (units_consumed - 300) * charge_after_300;
                    lbl_1.Text = before_300.ToString();
                    lbl_2.Text = after_300.ToString();
                    lbl_3.Text = fixed_charge.ToString();
                    total_cahrage = before_300 + after_300 + fixed_charge;
                    lbl_4.Text = total_cahrage.ToString();
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
                MessageBox.Show("Please enter a valid number","Invalid number",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void pnl_result_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbl_billrate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_ind_cat_I_1_Load(object sender, EventArgs e)
        {
            lbl_t_1.Text = charge_before_300.ToString();
            lbl_t_2.Text = charge_after_300.ToString();
            lbl_t_3.Text = fixed_charge.ToString();
            lbl_t_4.Text = max_demand_charge.ToString();
;
        }
    }
}
