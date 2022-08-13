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
    public partial class frm_dom_billrate : Form
    {
        double charge_0_30_if_below_60kWh = 2.50;
        double charge_31_60_if_below_60kWh = 4.85;
        double fixed_charge_0_30_if_below_60kWh = 30.00;
        double fixed_charge_31_60_if_below_60kWh = 60.00;
        double charge_0_60_if_above_60kWh = 7.85;
        double fixed_charge_0_60_if_above_60kWh = 0.00;
        double charge_61_90_if_above_60kWh = 90.00;
        double fixed_charge_61_90_if_above_60kWh = 10.00;
        double charge_91_120_if_above_60kWh = 27.75;
        double fixed_charge_91_120_if_above_60kWh = 480.00;
        double charge_121_180_if_above_60kWh = 32.00;
        double fixed_charge_121_180_if_above_60kWh = 480.00;
        double charge_180_infinity_if_above_60kWh = 45.00;
        double fixed_charge_180_infinity_if_above_60kWh = 540.00;

        public frm_dom_billrate()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bl_t2_4_Click(object sender, EventArgs e)
        {

        }

        private void frm_dom_billrate_Load(object sender, EventArgs e)
        {
            lbl_t1_1.Text = charge_0_30_if_below_60kWh.ToString();
            lbl_t1_2.Text = charge_31_60_if_below_60kWh.ToString();
            lbl_t1_3.Text = fixed_charge_0_30_if_below_60kWh.ToString();
            lbl_t1_4.Text = fixed_charge_31_60_if_below_60kWh.ToString();

            lbl_t2_1.Text = charge_0_60_if_above_60kWh.ToString();
            lbl_t2_2.Text = charge_61_90_if_above_60kWh.ToString();
            lbl_t2_3.Text = charge_91_120_if_above_60kWh.ToString();
            lbl_t2_4.Text = charge_121_180_if_above_60kWh.ToString();
            lbl_t2_5.Text = charge_180_infinity_if_above_60kWh.ToString();
            lbl_t2_6.Text = fixed_charge_0_60_if_above_60kWh.ToString();
            lbl_t2_7.Text = fixed_charge_61_90_if_above_60kWh.ToString();
            lbl_t2_8.Text = fixed_charge_91_120_if_above_60kWh.ToString();
            lbl_t2_9.Text = fixed_charge_121_180_if_above_60kWh.ToString();
            lbl_t2_10.Text = fixed_charge_180_infinity_if_above_60kWh.ToString();

        }
    }
}
