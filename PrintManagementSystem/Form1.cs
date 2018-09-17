using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Disabling numericUpDown's and Textboxes when the checkbox is unchecked
        private void chk4x6_Pop_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk4x6_Pop.Checked)
            {
                num4x6_Pop.Enabled = true;
                txt4x6_Pop.Enabled = true;
            } else
            {
                num4x6_Pop.Enabled = false;
                txt4x6_Pop.Enabled = false;
                num4x6_Pop.Value = 0;
                txt4x6_Pop.Text = "0";
            }
        }

        private void chk5x7_Pop_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5x7_Pop.Checked)
            {
                num5x7_Pop.Enabled = true;
                txt5x7_Pop.Enabled = true;
            }
            else
            {
                num5x7_Pop.Enabled = false;
                txt5x7_Pop.Enabled = false;
                num5x7_Pop.Value = 0;
                txt5x7_Pop.Text = "0";
            }
        }

        private void chk8x10_Pop_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8x10_Pop.Checked)
            {
                num8x10_Pop.Enabled = true;
                txt8x10_Pop.Enabled = true;
            }
            else
            {
                num8x10_Pop.Enabled = false;
                txt8x10_Pop.Enabled = false;
                num8x10_Pop.Value = 0;
                txt8x10_Pop.Text = "0";
            }
        }

        private void chk11x14_Pop_CheckedChanged(object sender, EventArgs e)
        {
            if (chk11x14_Pop.Checked)
            {
                num11x14_Pop.Enabled = true;
                txt11x14_Pop.Enabled = true;
            }
            else
            {
                num11x14_Pop.Enabled = false;
                txt11x14_Pop.Enabled = false;
                num11x14_Pop.Value = 0;
                txt11x14_Pop.Text = "0";
            }
        }

        private void chk16x20_Lg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk16x20_Lg.Checked)
            {
                num16x20_Lg.Enabled = true;
                txt16x20_Lg.Enabled = true;
            }
            else
            {
                num16x20_Lg.Enabled = false;
                txt16x20_Lg.Enabled = false;
                num16x20_Lg.Value = 0;
                txt16x20_Lg.Text = "0";
            }
        }

        private void chk20x30_Lg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk20x30_Lg.Checked)
            {
                num20x30_Lg.Enabled = true;
                txt20x30_Lg.Enabled = true;
            }
            else
            {
                num20x30_Lg.Enabled = false;
                txt20x30_Lg.Enabled = false;
                num20x30_Lg.Value = 0;
                txt20x30_Lg.Text = "0";
            }
        }

        private void chk24x30_Lg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk24x30_Lg.Checked)
            {            
                num20x30_Lg.Enabled = true;
                txt24x30_Lg.Enabled = true;
            }
            else
            {
                num24x30_Lg.Enabled = false;
                txt24x30_Lg.Enabled = false;
                num24x30_Lg.Value = 0;
                txt24x30_Lg.Text = "0";
            }
        }
        private void chk30x36_Lg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk30x36_Lg.Checked)
            {
                num30x36_Lg.Enabled = true;
                txt30x36_Lg.Enabled = true;
            }
            else
            {
                num30x36_Lg.Enabled = false;
                txt30x36_Lg.Enabled = false;
                num30x36_Lg.Value = 0;
                txt30x36_Lg.Text = "0";
            }
        }

        private void chk3x5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3x5.Checked)
            {
                num3x5.Enabled = true;
                txt3x5.Enabled = true;
            }
            else
            {
                num3x5.Enabled = false;
                txt3x5.Enabled = false;
                num3x5.Value = 0;
                txt3x5.Text = "0";
            }
        }

        private void chk4x5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4x5.Checked)
            {
                num4x5.Enabled = true;
                txt4x5.Enabled = true;
            }
            else
            {
                num4x5.Enabled = false;
                txt4x5.Enabled = false;
                num4x5.Value = 0;
                txt4x5.Text = "0";
            }
        }

        private void chk4x6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4x6.Checked)
            {
                num4x6.Enabled = true;
                txt4x6.Enabled = true;
            }
            else
            {
                num4x6.Enabled = false;
                txt4x6.Enabled = false;
                num4x6.Value = 0;
                txt4x6.Text = "0";
            }
        }

        private void chk4x12_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4x12.Checked)
            {
                num4x12.Enabled = true;
                txt4x12.Enabled = true;
            }
            else
            {
                num4x12.Enabled = false;
                txt4x12.Enabled = false;
                num4x12.Value = 0;
                txt4x12.Text = "0";
            }
        }

        private void chk5x5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5x5.Checked)
            {
                num5x5.Enabled = true;
                txt5x5.Enabled = true;
            }
            else
            {
                num5x5.Enabled = false;
                txt5x5.Enabled = false;
                num5x5.Value = 0;
                txt5x5.Text = "0";
            }
        }

        private void chk5x7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5x7.Checked)
            {
                num5x7.Enabled = true;
                txt5x7.Enabled = true;
            }
            else
            {
                num5x7.Enabled = false;
                txt5x7.Enabled = false;
                num5x7.Value = 0;
                txt5x7.Text = "0";
            }
        }

        private void chk6x9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6x9.Checked)
            {
                num6x9.Enabled = true;
                txt6x9.Enabled = true;
            }
            else
            {
                num6x9.Enabled = false;
                txt6x9.Enabled = false;
                num6x9.Value = 0;
                txt6x9.Text = "0";
            }
        }

        private void chk6x18_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6x18.Checked)
            {
                num6x18.Enabled = true;
                txt6x18.Enabled = true;
            }
            else
            {
                num6x18.Enabled = false;
                txt6x18.Enabled = false;
                num6x18.Value = 0;
                txt6x18.Text = "0";
            }
        }

        private void chk8x10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8x10.Checked)
            {
                num8x10.Enabled = true;
                txt8x10.Enabled = true;
            }
            else
            {
                num8x10.Enabled = false;
                txt8x10.Enabled = false;
                num8x10.Value = 0;
                txt8x10.Text = "0";
            }
        }

        private void chk8x12_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8x10.Checked)
            {
                num8x10.Enabled = true;
                txt8x10.Enabled = true;
            }
            else
            {
                num8x10.Enabled = false;
                txt8x10.Enabled = false;
                num8x10.Value = 0;
                txt8x10.Text = "0";
            }
        }

        private void chk8x11_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8x11.Checked)
            {
                num8x11.Enabled = true;
                txt8x11.Enabled = true;
            }
            else
            {
                num8x11.Enabled = false;
                txt8x11.Enabled = false;
                num8x11.Value = 0;
                txt8x11.Text = "0";
            }
        }

        private void chk9x12_CheckedChanged(object sender, EventArgs e)
        {
            if (chk9x12.Checked)
            {
                num9x12.Enabled = true;
                txt9x12.Enabled = true;
            }
            else
            {
                num9x12.Enabled = false;
                txt9x12.Enabled = false;
                num9x12.Value = 0;
                txt9x12.Text = "0";
            }
        }

        private void chk10x10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk10x10.Checked)
            {
                num10x10.Enabled = true;
                txt10x10.Enabled = true;
            }
            else
            {
                num10x10.Enabled = false;
                txt10x10.Enabled = false;
                num10x10.Value = 0;
                txt10x10.Text = "0";
            }
        }

        private void chk10x13_CheckedChanged(object sender, EventArgs e)
        {
            if (chk10x13.Checked)
            {
                num10x13.Enabled = true;
                txt10x13.Enabled = true;
            }
            else
            {
                num10x13.Enabled = false;
                txt10x13.Enabled = false;
                num10x13.Value = 0;
                txt10x13.Text = "0";
            }
        }

        private void chk10x15_CheckedChanged(object sender, EventArgs e)
        {
            if (chk10x15.Checked)
            {
                num10x15.Enabled = true;
                txt10x15.Enabled = true;
            }
            else
            {
                num10x15.Enabled = false;
                txt10x15.Enabled = false;
                num10x15.Value = 0;
                txt10x15.Text = "0";
            }
        }

        private void chk11x14_CheckedChanged(object sender, EventArgs e)
        {
            if (chk11x14.Checked)
            {
                num11x14.Enabled = true;
                txt11x14.Enabled = true;
            }
            else
            {
                num11x14.Enabled = false;
                txt11x14.Enabled = false;
                num11x14.Value = 0;
                txt11x14.Text = "0";
            }
        }

        private void chk11x17_CheckedChanged(object sender, EventArgs e)
        {
            if (chk11x17.Checked)
            {
                num11x17.Enabled = true;
                txt11x17.Enabled = true;
            }
            else
            {
                num11x17.Enabled = false;
                txt11x17.Enabled = false;
                num11x17.Value = 0;
                txt11x17.Text = "0";
            }
        }

        private void chk12x12_CheckedChanged(object sender, EventArgs e)
        {
            if (chk12x12.Checked)
            {
                num12x12.Enabled = true;
                txt12x12.Enabled = true;
            }
            else
            {
                num12x12.Enabled = false;
                txt12x12.Enabled = false;
                num12x12.Value = 0;
                txt12x12.Text = "0";
            }
        }

        private void chk12x18_CheckedChanged(object sender, EventArgs e)
        {
            if (chk12x18.Checked)
            {
                num12x18.Enabled = true;
                txt12x18.Enabled = true;
            }
            else
            {
                num12x18.Enabled = false;
                txt12x18.Enabled = false;
                num12x18.Value = 0;
                txt12x18.Text = "0";
            }
        }

        private void chk16x16_CheckedChanged(object sender, EventArgs e)
        {
            if (chk16x16.Checked)
            {
                num16x16.Enabled = true;
                txt16x16.Enabled = true;
            }
            else
            {
                num16x16.Enabled = false;
                txt16x16.Enabled = false;
                num16x16.Value = 0;
                txt16x16.Text = "0";
            }
        }

        private void chk16x20_CheckedChanged(object sender, EventArgs e)
        {
            if (chk16x20.Checked)
            {
                num16x20.Enabled = true;
                txt16x20.Enabled = true;
            }
            else
            {
                num16x20.Enabled = false;
                txt16x20.Enabled = false;
                num16x20.Value = 0;
                txt16x20.Text = "0";
            }
        }

        private void chk16x24_CheckedChanged(object sender, EventArgs e)
        {
            if (chk16x24.Checked)
            {
                num16x24.Enabled = true;
                txt16x24.Enabled = true;
            }
            else
            {
                num16x24.Enabled = false;
                txt16x24.Enabled = false;
                num16x24.Value = 0;
                txt16x24.Text = "0";
            }
        }

        private void chk20x20_CheckedChanged(object sender, EventArgs e)
        {
            if (chk20x20.Checked)
            {
                num20x20.Enabled = true;
                txt20x20.Enabled = true;
            }
            else
            {
                num20x20.Enabled = false;
                txt20x20.Enabled = false;
                num20x20.Value = 0;
                txt20x20.Text = "0";
            }
        }

        private void chk20x24_CheckedChanged(object sender, EventArgs e)
        {
            if (chk20x24.Checked)
            {
                num20x24.Enabled = true;
                txt20x24.Enabled = true;
            }
            else
            {
                num20x24.Enabled = false;
                txt20x24.Enabled = false;
                num20x24.Value = 0;
                txt20x24.Text = "0";
            }
        }

        private void chk20x30_CheckedChanged(object sender, EventArgs e)
        {
            if (chk20x30.Checked)
            {
                num20x30.Enabled = true;
                txt20x30.Enabled = true;
            }
            else
            {
                num20x30.Enabled = false;
                txt20x30.Enabled = false;
                num8x11.Value = 0;
                txt8x11.Text = "0";
            }
        }

        private void chk24x24_CheckedChanged(object sender, EventArgs e)
        {
            if (chk24x24.Checked)
            {
                num24x24.Enabled = true;
                txt24x24.Enabled = true;
            }
            else
            {
                num24x24.Enabled = false;
                txt24x24.Enabled = false;
                num24x24.Value = 0;
                txt24x24.Text = "0";
            }
        }

        private void chk24x30_CheckedChanged(object sender, EventArgs e)
        {
            if (chk24x30.Checked)
            {
                num24x30.Enabled = true;
                txt24x30.Enabled = true;
            }
            else
            {
                num24x30.Enabled = false;
                txt24x30.Enabled = false;
                num24x30.Value = 0;
                txt24x30.Text = "0";
            }
        }

        private void chk24x36_CheckedChanged(object sender, EventArgs e)
        {
            if (chk24x36.Checked)
            {
                num24x36.Enabled = true;
                txt24x36.Enabled = true;
            }
            else
            {
                num24x36.Enabled = false;
                txt24x36.Enabled = false;
                num24x36.Value = 0;
                txt24x36.Text = "0";
            }
        }

        private void chk30x30_CheckedChanged(object sender, EventArgs e)
        {
            if (chk30x30.Checked)
            {
                num30x30.Enabled = true;
                txt30x30.Enabled = true;
            }
            else
            {
                num30x30.Enabled = false;
                txt30x30.Enabled = false;
                num30x30.Value = 0;
                txt30x30.Text = "0";
            }
        }

        private void chk30x36_CheckedChanged(object sender, EventArgs e)
        {
            if (chk30x36.Checked)
            {
                num30x36.Enabled = true;
                txt30x36.Enabled = true;
            }
            else
            {
                num30x36.Enabled = false;
                txt30x36.Enabled = false;
                num30x36.Value = 0;
                txt30x36.Text = "0";
            }
        }

        // Wire the checkboxes to calculate line item total into appropriate textbox
        private void num4x6_Pop_ValueChanged(object sender, EventArgs e)
        {
            var units_4x6 = (int)num4x6_Pop.Value;
            const double price_4x6 = 4.95;
            double value_4x6 = units_4x6 * price_4x6;
            txt4x6_Pop.Text = value_4x6.ToString();
        }

        private void num5x7_Pop_ValueChanged(object sender, EventArgs e)
        {
            var units_5x7 = (int)num5x7_Pop.Value;
            const double price_5x7 = 5.95;
            double value_5x7 = units_5x7 * price_5x7;
            txt5x7_Pop.Text = value_5x7.ToString();
        }

        private void num8x10_Pop_ValueChanged(object sender, EventArgs e)
        {
            var units_8x10 = (int)num8x10_Pop.Value;
            double price_8x10 = 9.95;
            double value_8x10 = units_8x10 * price_8x10;
            txt8x10_Pop.Text = value_8x10.ToString();
        }

        private void num11x14_Pop_ValueChanged(object sender, EventArgs e)
        {
            var units_11x14 = (int)num11x14_Pop.Value;
            double price_11x14 = 19.95;
            double value_11x14 = units_11x14 * price_11x14;
            txt11x14_Pop.Text = value_11x14.ToString();
        }

        private void num16x20_Lg_ValueChanged(object sender, EventArgs e)
        {
            var units_16x20 = (int)num16x20_Lg.Value;
            double price_16x20 = 49.95;
            double value_16x20 = units_16x20 * price_16x20;
            txt16x20_Lg.Text = value_16x20.ToString();
        }

        private void num20x30_Lg_ValueChanged(object sender, EventArgs e)
        {
            var units_20x30 = (int)num20x30_Lg.Value;
            double price_20x30 = 94.95;
            double value_20x30 = units_20x30 * price_20x30;
            txt20x30_Lg.Text = value_20x30.ToString();
        }

        private void num24x30_Lg_ValueChanged(object sender, EventArgs e)
        {
            var units_24x30 = (int)num24x30_Lg.Value;
            double price_24x30 = 0;
            double value_24x30 = units_24x30 * price_24x30;
            txt24x30_Lg.Text = value_24x30.ToString();
        }

        private void num30x36_Lg_ValueChanged(object sender, EventArgs e)
        {
            var units_30x36 = (int)num30x36_Lg.Value;
            double price_30x36 = 0;
            double value_30x36 = units_30x36 * price_30x36;
            txt30x36_Lg.Text = value_30x36.ToString();
        }
    }
}