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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Enabling numericUpDown's and Textboxes when corresponding checkbox is checked

        // Popular print sizes
        private void chk4x6_Pop_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk4x6_Pop.Checked)
            {
                num4x6_Pop.Enabled = true;
                txt4x6_Pop.Enabled = true;
                num4x6_Pop.Focus();
                num4x6_Pop.Select(0, num4x6_Pop.Text.Length);
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
                num5x7_Pop.Focus();
                num5x7_Pop.Select(0, num5x7_Pop.Text.Length);
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
                num8x10_Pop.Focus();
                num8x10_Pop.Select(0, num8x10_Pop.Text.Length);
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
                num11x14_Pop.Focus();
                num11x14_Pop.Select(0, num11x14_Pop.Text.Length);
            }
            else
            {
                num11x14_Pop.Enabled = false;
                txt11x14_Pop.Enabled = false;
                num11x14_Pop.Value = 0;
                txt11x14_Pop.Text = "0";
            }
        }

        // Large print sizes
        private void chk16x20_Lg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk16x20_Lg.Checked)
            {
                num16x20_Lg.Enabled = true;
                txt16x20_Lg.Enabled = true;
                num16x20_Lg.Focus();
                num16x20_Lg.Select(0, num16x20_Lg.Text.Length);
            }
            else
            {
                num16x20_Lg.Enabled = false;
                txt16x20_Lg.Enabled = false;
                num16x20_Lg.Value = 0;
                txt16x20_Lg.Text = "0";
            }
        }

        private void chk20x24_Lg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk20x24_Lg.Checked)
            {
                num20x24_Lg.Enabled = true;
                txt20x24_Lg.Enabled = true;
                num20x24_Lg.Focus();
                num20x24_Lg.Select(0, num20x24_Lg.Text.Length);
            } else
            {
                num20x24_Lg.Enabled = false;
                txt20x24_Lg.Enabled = false;
                num20x24_Lg.Value = 0;
                txt20x24_Lg.Text = "0";
            }
        }

        private void chk20x30_Lg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk20x30_Lg.Checked)
            {
                num20x30_Lg.Enabled = true;
                txt20x30_Lg.Enabled = true;
                num20x30_Lg.Focus();
                num20x30_Lg.Select(0, num20x30_Lg.Text.Length);
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
                num24x30_Lg.Enabled = true;
                txt24x30_Lg.Enabled = true;
                num24x30_Lg.Focus();
                num24x30_Lg.Select(0, num24x30_Lg.Text.Length);
            }
            else
            {
                num24x30_Lg.Enabled = false;
                txt24x30_Lg.Enabled = false;
                num24x30_Lg.Value = 0;
                txt24x30_Lg.Text = "0";
            }
        }
        private void chk30x40_Lg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk30x40_Lg.Checked)
            {
                num30x40_Lg.Enabled = true;
                txt30x40_Lg.Enabled = true;
                num30x40_Lg.Focus();
                num30x40_Lg.Select(0, num30x40_Lg.Text.Length);
            }
            else
            {
                num30x40_Lg.Enabled = false;
                txt30x40_Lg.Enabled = false;
                num30x40_Lg.Value = 0;
                txt30x40_Lg.Text = "0";
            }
        }

        // All print size
        private void chk3x5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3x5.Checked)
            {
                num3x5.Enabled = true;
                txt3x5.Enabled = true;
                num3x5.Focus();
                num3x5.Select(0, num3x5.Text.Length);
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
                num4x5.Focus();
                num4x5.Select(0, num4x5.Text.Length);
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
                num4x6.Focus();
                num4x6.Select(0, num4x6.Text.Length);
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
                num4x12.Focus();
                num4x12.Select(0, num4x12.Text.Length);
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
                num5x5.Focus();
                num5x5.Select(0, num5x5.Text.Length);
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
                num5x7.Focus();
                num5x7.Select(0, num5x7.Text.Length);
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
                num6x9.Focus();
                num6x9.Select(0, num6x9.Text.Length);
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
                num6x18.Focus();
                num6x18.Select(0, num6x18.Text.Length);
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
                num8x10.Focus();
                num8x10.Select(0, num8x10.Text.Length);
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
            if (chk8x12.Checked)
            {
                num8x12.Enabled = true;
                txt8x12.Enabled = true;
                num8x12.Focus();
                num8x12.Select(0, num8x12.Text.Length);
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
                num8x11.Focus();
                num8x11.Select(0, num8x11.Text.Length);
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
                num9x12.Focus();
                num9x12.Select(0, num9x12.Text.Length);
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
                num10x10.Focus();
                num10x10.Select(0, num10x10.Text.Length);
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
                num10x13.Focus();
                num10x13.Select(0, num10x13.Text.Length);
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
                num10x15.Focus();
                num10x15.Select(0, num10x15.Text.Length);
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
                num11x14.Focus();
                num11x14.Select(0, num11x14.Text.Length);
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
                num11x17.Focus();
                num11x17.Select(0, num11x17.Text.Length);
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
                num12x12.Focus();
                num12x12.Select(0, num12x12.Text.Length);
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
                num12x18.Focus();
                num12x18.Select(0, num12x18.Text.Length);
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
                num16x16.Focus();
                num16x16.Select(0, num16x16.Text.Length);
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
                num16x20.Focus();
                num16x20.Select(0, num16x20.Text.Length);
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
                num16x24.Focus();
                num16x24.Select(0, num16x24.Text.Length);
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
                num20x20.Focus();
                num20x20.Select(0, num20x20.Text.Length);
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
                num20x24.Focus();
                num20x24.Select(0, num20x24.Text.Length);
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
                num20x30.Focus();
                num20x30.Select(0, num20x30.Text.Length);
            }
            else
            {
                num20x30.Enabled = false;
                txt20x30.Enabled = false;
                num20x30.Value = 0;
                txt20x30.Text = "0";
            }
        }

        private void chk24x24_CheckedChanged(object sender, EventArgs e)
        {
            if (chk24x24.Checked)
            {
                num24x24.Enabled = true;
                txt24x24.Enabled = true;
                num24x24.Focus();
                num24x24.Select(0, num24x24.Text.Length);
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
                num24x30.Focus();
                num24x30.Select(0, num24x30.Text.Length);
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
                num24x36.Focus();
                num24x36.Select(0, num24x36.Text.Length);
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
                num30x30.Focus();
                num30x30.Select(0, num30x30.Text.Length);
            }
            else
            {
                num30x30.Enabled = false;
                txt30x30.Enabled = false;
                num30x30.Value = 0;
                txt30x30.Text = "0";
            }
        }

        private void chk30x40_CheckedChanged(object sender, EventArgs e)
        {
            if (chk30x40.Checked)
            {
                num30x40.Enabled = true;
                txt30x40.Enabled = true;
                num30x40.Focus();
                num30x40.Select(0, num30x40.Text.Length);
            }
            else
            {
                num30x40.Enabled = false;
                txt30x40.Enabled = false;
                num30x40.Value = 0;
                txt30x40.Text = "0";
            }
        }

        // Calculate line item total when NumericUpDown value changes

        // Popular print sizes
        private void num4x6_Pop_ValueChanged(object sender, EventArgs e)
        {
            var units_4x6 = (int)num4x6_Pop.Value;
            const double price_4x6 = 4.95;
            double value_4x6 = units_4x6 * price_4x6;
            txt4x6_Pop.Text = String.Format("{0:0.00}", value_4x6);
        }

        private void num5x7_Pop_ValueChanged(object sender, EventArgs e)
        {
            var units_5x7 = (int)num5x7_Pop.Value;
            const double price_5x7 = 5.95;
            double value_5x7 = units_5x7 * price_5x7;
            txt5x7_Pop.Text = String.Format("{0:0.00}", value_5x7);
        }

        private void num8x10_Pop_ValueChanged(object sender, EventArgs e)
        {
            var units_8x10 = (int)num8x10_Pop.Value;
            double price_8x10 = 9.95;
            double value_8x10 = units_8x10 * price_8x10;
            txt8x10_Pop.Text = String.Format("{0:0.00}", value_8x10);
        }

        private void num11x14_Pop_ValueChanged(object sender, EventArgs e)
        {
            var units_11x14 = (int)num11x14_Pop.Value;
            double price_11x14 = 19.95;
            double value_11x14 = units_11x14 * price_11x14;
            txt11x14_Pop.Text = String.Format("{0:0.00}", value_11x14);
        }

        // Large print sizes
        private void num16x20_Lg_ValueChanged(object sender, EventArgs e)
        {
            var units_16x20 = (int)num16x20_Lg.Value;
            double price_16x20 = 49.95;
            double value_16x20 = units_16x20 * price_16x20;
            txt16x20_Lg.Text = String.Format("{0:0.00}", value_16x20);
        }

        private void num20x24_Lg_ValueChanged(object sender, EventArgs e)
        {
            var units_20x24 = (int)num20x24_Lg.Value;
            double price_20x24 = 74.95;
            double value_20x24 = units_20x24 * price_20x24;
            txt20x24_Lg.Text = String.Format("{0:0.00}", value_20x24);
        }

        private void num20x30_Lg_ValueChanged(object sender, EventArgs e)
        {
            var units_20x30 = (int)num20x30_Lg.Value;
            double price_20x30 = 94.95;
            double value_20x30 = units_20x30 * price_20x30;
            txt20x30_Lg.Text = String.Format("{0:0.00}", value_20x30);
        }

        private void num24x30_Lg_ValueChanged(object sender, EventArgs e)
        {
            var units_24x30 = (int)num24x30_Lg.Value;
            double price_24x30 = 149.95;
            double value_24x30 = units_24x30 * price_24x30;
            txt24x30_Lg.Text = String.Format("{0:0.00}", value_24x30);
        }

        private void num30x40_Lg_ValueChanged(object sender, EventArgs e)
        {
            var units_30x40 = (int)num30x40_Lg.Value;
            double price_30x40 = 0;
            double value_30x40 = units_30x40 * price_30x40;
            txt30x40_Lg.Text = String.Format("{0:0.00}", value_30x40);
        }

        // All print sizes
        private void num3x5_ValueChanged(object sender, EventArgs e)
        {
            var units_3x5 = (int)num3x5.Value;
            double price_3x5 = 2.95;
            double value_3x5 = units_3x5 * price_3x5;
            txt3x5.Text = String.Format("{0:0.00}", value_3x5);
        }

        private void num4x5_ValueChanged(object sender, EventArgs e)
        {
            var units_4x5 = (int)num4x5.Value;
            double price_4x5 = 3.95;
            double value_4x5 = units_4x5 * price_4x5;
            txt4x5.Text = String.Format("{0:0.00}", value_4x5);
        }

        private void num4x6_ValueChanged(object sender, EventArgs e)
        {
            var units_4x6 = (int)num4x6.Value;
            double price_4x6 = 4.95;
            double value_4x6 = units_4x6 * price_4x6;
            txt4x6.Text = String.Format("{0:0.00}", value_4x6);
        }

        private void num4x12_ValueChanged(object sender, EventArgs e)
        {
            var units_4x12 = (int)num4x12.Value;
            double price_4x12 = 6.95;
            double value_4x12 = units_4x12 * price_4x12;
            txt4x12.Text = String.Format("{0:0.00}", value_4x12);
        }

        private void num5x5_ValueChanged(object sender, EventArgs e)
        {
            var units_5x5 = (int)num5x5.Value;
            double price_5x5 = 4.95;
            double value_5x5 = units_5x5 * price_5x5;
            txt5x5.Text = String.Format("{0:0.00}", value_5x5);
        }

        private void num5x7_ValueChanged(object sender, EventArgs e)
        {
            var units_5x7 = (int)num4x6.Value;
            double price_5x7 = 5.95;
            double value_5x7 = units_5x7 * price_5x7;
            txt5x7.Text = String.Format("{0:0.00}", value_5x7);
        }

        private void num6x9_ValueChanged(object sender, EventArgs e)
        {
            var units_6x9 = (int)num6x9.Value;
            double price_6x9 = 6.95;
            double value_6x9 = units_6x9 * price_6x9;
            txt6x9.Text = String.Format("{0:0.00}", value_6x9);
        }

        private void num6x18_ValueChanged(object sender, EventArgs e)
        {
            var units_6x18 = (int)num6x18.Value;
            double price_6x18 = 14.95;
            double value_6x18 = units_6x18 * price_6x18;
            txt6x18.Text = String.Format("{0:0.00}", value_6x18);
        }

        private void num8x10_ValueChanged(object sender, EventArgs e)
        {
            var units_8x10 = (int)num4x6.Value;
            double price_8x10 = 9.95;
            double value_8x10 = units_8x10 * price_8x10;
            txt8x10.Text = String.Format("{0:0.00}", value_8x10);
        }

        private void num8x12_ValueChanged(object sender, EventArgs e)
        {
            var units_8x12 = (int)num8x12.Value;
            double price_8x12 = 12.95;
            double value_8x12 = units_8x12 * price_8x12;
            txt8x12.Text = String.Format("{0:0.00}", value_8x12);
        }

        private void num8x11_ValueChanged(object sender, EventArgs e)
        {
            var units_8x11 = (int)num8x11.Value;
            double price_8x11 = 11.95;
            double value_8x11 = units_8x11 * price_8x11;
            txt8x11.Text = String.Format("{0:0.00}", value_8x11);
        }

        private void num9x12_ValueChanged(object sender, EventArgs e)
        {
            var units_9x12 = (int)num9x12.Value;
            double price_9x12 = 13.95;
            double value_9x12 = units_9x12 * price_9x12;
            txt9x12.Text = String.Format("{0:0.00}", value_9x12);
        }

        private void num10x10_ValueChanged(object sender, EventArgs e)
        {
            var units_10x10 = (int)num10x10.Value;
            double price_10x10 = 13.95;
            double value_10x10 = units_10x10 * price_10x10;
            txt10x10.Text = String.Format("{0:0.00}", value_10x10);
        }

        private void num10x13_ValueChanged(object sender, EventArgs e)
        {
            var units_10x13 = (int)num10x13.Value;
            double price_10x13 = 17.95;
            double value_10x13 = units_10x13 * price_10x13;
            txt10x13.Text = String.Format("{0:0.00}", value_10x13);
        }

        private void num10x15_ValueChanged(object sender, EventArgs e)
        {
            var units_10x15 = (int)num10x15.Value;
            double price_10x15 = 18.95;
            double value_10x15 = units_10x15 * price_10x15;
            txt10x15.Text = String.Format("{0:0.00}", value_10x15);
        }

        private void num11x14_ValueChanged(object sender, EventArgs e)
        {
            var units_11x14 = (int)num11x14.Value;
            double price_11x14 = 19.95;
            double value_11x14 = units_11x14 * price_11x14;
            txt11x14.Text = String.Format("{0:0.00}", value_11x14);
        }

        private void num11x17_ValueChanged(object sender, EventArgs e)
        {
            var units_11x17 = (int)num11x17.Value;
            double price_11x17 = 24.95;
            double value_11x17 = units_11x17 * price_11x17;
            txt11x17.Text = String.Format("{0:0.00}", value_11x17);
        }

        private void num12x12_ValueChanged(object sender, EventArgs e)
        {
            var units_12x12 = (int)num10x10.Value;
            double price_12x12 = 19.95;
            double value_12x12 = units_12x12 * price_12x12;
            txt12x12.Text = String.Format("{0:0.00}", value_12x12);
        }

        private void num12x18_ValueChanged(object sender, EventArgs e)
        {
            var units_12x18 = (int)num12x18.Value;
            double price_12x18 = 28.95;
            double value_12x18 = units_12x18 * price_12x18;
            txt12x18.Text = String.Format("{0:0.00}", value_12x18);
        }

        private void num16x16_ValueChanged(object sender, EventArgs e)
        {
            var units_16x16 = (int)num16x16.Value;
            double price_16x16 = 89.99;
            double value_16x16 = units_16x16 * price_16x16;
            txt16x16.Text = String.Format("{0:0.00}", value_16x16);
        }

        private void num16x20_ValueChanged(object sender, EventArgs e)
        {
            var units_16x20 = (int)num16x20.Value;
            double price_16x20 = 49.95;
            double value_16x20 = units_16x20 * price_16x20;
            txt16x20.Text = String.Format("{0:0.00}", value_16x20);
        }

        private void num16x24_ValueChanged(object sender, EventArgs e)
        {
            var units_16x24 = (int)num16x24.Value;
            double price_16x24 = 59.95;
            double value_16x24 = units_16x24 * price_16x24;
            txt16x24.Text = String.Format("{0:0.00}", value_16x24);
        }

        private void num20x20_ValueChanged(object sender, EventArgs e)
        {
            var units_20x20 = (int)num20x20.Value;
            double price_20x20 = 59.95;
            double value_20x20 = units_20x20 * price_20x20;
            txt20x20.Text = String.Format("{0:0.00}", value_20x20);
        }

        private void num20x24_ValueChanged(object sender, EventArgs e)
        {
            var units_20x24 = (int)num20x24.Value;
            double price_20x24 = 74.95;
            double value_20x24 = units_20x24 * price_20x24;
            txt20x24.Text = String.Format("{0:0.00}", value_20x24);
        }

        private void num20x30_ValueChanged(object sender, EventArgs e)
        {
            var units_20x30 = (int)num20x30.Value;
            double price_20x30 = 94.95;
            double value_20x30 = units_20x30 * price_20x30;
            txt20x30.Text = String.Format("{0:0.00}", value_20x30);
        }

        private void num24x24_ValueChanged(object sender, EventArgs e)
        {
            var units_24x24 = (int)num24x24.Value;
            double price_24x24 = 89.95;
            double value_24x24 = units_24x24 * price_24x24;
            txt24x24.Text = String.Format("{0:0.00}", value_24x24);
        }

        private void num24x30_ValueChanged(object sender, EventArgs e)
        {
            var units_24x30 = (int)num24x30.Value;
            double price_24x30 = 149.95;
            double value_24x30 = units_24x30 * price_24x30;
            txt24x30.Text = String.Format("{0:0.00}", value_24x30);
        }

        private void num24x36_ValueChanged(object sender, EventArgs e)
        {
            var units_24x36 = (int)num24x36.Value;
            double price_24x36 = 139.95;
            double value_24x36 = units_24x36 * price_24x36;
            txt24x36.Text = String.Format("{0:0.00}", value_24x36);
        }

        private void num30x30_ValueChanged(object sender, EventArgs e)
        {
            var units_30x30 = (int)num30x30.Value;
            double price_30x30 = 169.95;
            double value_30x30 = units_30x30 * price_30x30;
            txt30x30.Text = String.Format("{0:0.00}", value_30x30);
        }

        private void num30x40_ValueChanged(object sender, EventArgs e)
        {
            var units_30x40 = (int)num16x24.Value;
            double price_30x40 = 269.95;
            double value_30x40 = units_30x40 * price_30x40;
            txt30x40.Text = String.Format("{0:0.00}", value_30x40);
        }

        // Checkout to calculate Order Total
        private void btnTotal_Click(object sender, EventArgs e)
        {
            /// Popular print sizes
            double _4x6_Pop, _5x7_Pop, _8x10_Pop, _11x14_Pop;
            // Large print sizes
            double _16x20_Lg, _20x24_Lg, _20x30_Lg, _24x30_Lg, _30x40_Lg;
            // All print sizes
            double _3x5, _4x5, _4x6, _4x12, _5x5, _5x7, _6x9, _6x18, _8x10, _8x12, _8x11, _9x12, _10x10, _10x13, _10x15, _11x14, 
                _11x17, _12x12, _12x18, _16x16, _16x20, _16x24, _20x20, _20x24, _20x30, _24x24, _24x30, _24x36, _30x30, _30x40;
            double discount, subtotal, tax, grandTotal;

            // Casting line total text into a double
            // Popular print sizes
            Double.TryParse(txt4x6_Pop.Text, out _4x6_Pop);
            Double.TryParse(txt5x7_Pop.Text, out _5x7_Pop);
            Double.TryParse(txt8x10_Pop.Text, out _8x10_Pop);
            Double.TryParse(txt11x14_Pop.Text, out _11x14_Pop);

            // Large print size
            Double.TryParse(txt16x20_Lg.Text, out _16x20_Lg);
            Double.TryParse(txt20x24_Lg.Text, out _20x24_Lg);
            Double.TryParse(txt20x30_Lg.Text, out _20x30_Lg);
            Double.TryParse(txt24x30_Lg.Text, out _24x30_Lg);
            Double.TryParse(txt30x40_Lg.Text, out _30x40_Lg);

            // All print sizes
            Double.TryParse(txt3x5.Text, out _3x5);
            Double.TryParse(txt4x5.Text, out _4x5);
            Double.TryParse(txt4x6.Text, out _4x6);
            Double.TryParse(txt4x12.Text, out _4x12);
            Double.TryParse(txt5x5.Text, out _5x5);
            Double.TryParse(txt5x7.Text, out _5x7);
            Double.TryParse(txt6x9.Text, out _6x9);
            Double.TryParse(txt6x18.Text, out _6x18);
            Double.TryParse(txt8x10.Text, out _8x10);
            Double.TryParse(txt8x12.Text, out _8x12);
            Double.TryParse(txt8x11.Text, out _8x11);
            Double.TryParse(txt9x12.Text, out _9x12);
            Double.TryParse(txt10x10.Text, out _10x10);
            Double.TryParse(txt10x13.Text, out _10x13);
            Double.TryParse(txt10x15.Text, out _10x15);
            Double.TryParse(txt11x14.Text, out _11x14);
            Double.TryParse(txt11x17.Text, out _11x17);
            Double.TryParse(txt12x12.Text, out _12x12);
            Double.TryParse(txt12x18.Text, out _12x18);
            Double.TryParse(txt16x16.Text, out _16x16);
            Double.TryParse(txt16x20.Text, out _16x20);
            Double.TryParse(txt16x24.Text, out _16x24);
            Double.TryParse(txt20x20.Text, out _20x20);
            Double.TryParse(txt20x24.Text, out _20x24);
            Double.TryParse(txt24x30.Text, out _20x30);
            Double.TryParse(txt24x24.Text, out _24x24);
            Double.TryParse(txt24x30.Text, out _24x30);
            Double.TryParse(txt24x36.Text, out _24x36);
            Double.TryParse(txt30x30.Text, out _30x30);
            Double.TryParse(txt30x40.Text, out _30x40);
            Double.TryParse(txtDiscount.Text, out discount);
            Double.TryParse(txtTax.Text, out tax);

            subtotal = _4x6_Pop + _5x7_Pop + _8x10_Pop + _11x14_Pop + _16x20_Lg + _20x24_Lg + _20x30_Lg + _24x30_Lg + _30x40_Lg + _3x5 +
                _4x5 + _4x6 + _4x12 + _5x5 + _5x7 + _6x9 + _6x18 + _8x10 + _8x12 + _8x11 + _9x12 + _10x10 + _10x13 + _10x15 + _11x14 +
                _11x17 + _12x12 + _12x18 + _16x16 + _16x20 + _16x24 + _20x20 + _20x24 + _20x30 + _24x24 + _24x30 + _24x36 + _30x30 + _30x40 - discount;
            txtSubtotal.Text = subtotal.ToString();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            // This will clear any receipt loaded in the receipt area before displaying the new one
            rtfReceipt.Clear();

            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t\t" + "JP Studio Pro " + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------------------------------------" +
                Environment.NewLine + Environment.NewLine);
        }

        // Reset the Form
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Popular prints
            chk4x6_Pop.Checked = false;
            chk5x7_Pop.Checked = false;
            chk8x10_Pop.Checked = false;
            chk11x14_Pop.Checked = false;

            // Large prints
            chk16x20_Lg.Checked = false;
            chk20x30_Lg.Checked = false;
            chk24x30_Lg.Checked = false;
            chk30x40_Lg.Checked = false;

            // All prints
            chk3x5.Checked = false;
            chk4x5.Checked = false;
            chk4x6.Checked = false;
            chk4x12.Checked = false;
            chk5x5.Checked = false;
            chk5x7.Checked = false;
            chk6x9.Checked = false;
            chk6x18.Checked = false;
            chk8x10.Checked = false;
            chk8x12.Checked = false;
            chk8x11.Checked = false;
            chk9x12.Checked = false;
            chk10x10.Checked = false;
            chk10x13.Checked = false;
            chk10x15.Checked = false;
            chk11x14.Checked = false;
            chk11x17.Checked = false;
            chk12x12.Checked = false;
            chk12x18.Checked = false;
            chk16x16.Checked = false;
            chk16x20.Checked = false;
            chk16x24.Checked = false;
            chk20x20.Checked = false;
            chk20x24.Checked = false;
            chk20x30.Checked = false;
            chk24x24.Checked = false;
            chk24x30.Checked = false;
            chk24x30.Checked = false;
            chk24x36.Checked = false;
            chk30x30.Checked = false;
            chk30x40.Checked = false;

        }
        // Exits the Application when clicking on the Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Print Receipt
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        // Open existing receipts (text files)
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            // This code will open text Files
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*txt)|*.txt|All files (*.*|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        // Save receipts (text files)
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // This code will save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Text Files (*txt)|*.txt|All files (*.*|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

    }
}