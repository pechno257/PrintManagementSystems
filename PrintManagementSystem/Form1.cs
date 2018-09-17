﻿using System;
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

        // Enabling numericUpDown's and Textboxes when corresponding checkbox is checked
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
                txt11x14.Enabled = true;
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
                num20x30_Lg.Enabled = true;
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
        private void chk30x36_Lg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk30x36_Lg.Checked)
            {
                num30x36_Lg.Enabled = true;
                txt30x36_Lg.Enabled = true;
                num30x36_Lg.Focus();
                num30x36_Lg.Select(0, num30x36_Lg.Text.Length);
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

        private void chk30x36_CheckedChanged(object sender, EventArgs e)
        {
            if (chk30x36.Checked)
            {
                num30x36.Enabled = true;
                txt30x36.Enabled = true;
                num30x36.Focus();
                num30x36.Select(0, num30x36.Text.Length);
            }
            else
            {
                num30x36.Enabled = false;
                txt30x36.Enabled = false;
                num30x36.Value = 0;
                txt30x36.Text = "0";
            }
        }

        // Calculate line item total when NumericUpDown value changes
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

        private void num3x5_ValueChanged(object sender, EventArgs e)
        {
            var units_3x5 = (int)num3x5.Value;
            double price_3x5 = 2.95;
            double value_3x5 = units_3x5 * price_3x5;
            txt3x5.Text = value_3x5.ToString();
        }

        private void num4x5_ValueChanged(object sender, EventArgs e)
        {
            var units_4x5 = (int)num4x5.Value;
            double price_4x5 = 3.95;
            double value_4x5 = units_4x5 * price_4x5;
            txt4x5.Text = value_4x5.ToString();
        }

        private void num4x6_ValueChanged(object sender, EventArgs e)
        {
            var units_4x6 = (int)num4x6.Value;
            double price_4x6 = 4.95;
            double value_4x6 = units_4x6 * price_4x6;
            txt4x6.Text = value_4x6.ToString();
        }

        private void num4x12_ValueChanged(object sender, EventArgs e)
        {
            var units_4x12 = (int)num4x12.Value;
            double price_4x12 = 0;
            double value_4x12 = units_4x12 * price_4x12;
            txt4x12.Text = value_4x12.ToString();
        }

        private void num5x5_ValueChanged(object sender, EventArgs e)
        {
            var units_5x5 = (int)num5x5.Value;
            double price_5x5 = 0;
            double value_5x5 = units_5x5 * price_5x5;
            txt5x5.Text = value_5x5.ToString();
        }

        private void num5x7_ValueChanged(object sender, EventArgs e)
        {
            var units_5x7 = (int)num4x6.Value;
            double price_5x7 = 5.95;
            double value_5x7 = units_5x7 * price_5x7;
            txt5x7.Text = value_5x7.ToString();
        }

        private void num6x9_ValueChanged(object sender, EventArgs e)
        {
            var units_6x9 = (int)num6x9.Value;
            double price_6x9 = 0;
            double value_6x9 = units_6x9 * price_6x9;
            txt6x9.Text = value_6x9.ToString();
        }

        private void num6x18_ValueChanged(object sender, EventArgs e)
        {
            var units_6x18 = (int)num6x18.Value;
            double price_6x18 = 0;
            double value_6x18 = units_6x18 * price_6x18;
            txt6x18.Text = value_6x18.ToString();
        }

        private void num8x10_ValueChanged(object sender, EventArgs e)
        {
            var units_8x10 = (int)num4x6.Value;
            double price_8x10 = 9.95;
            double value_8x10 = units_8x10 * price_8x10;
            txt8x10.Text = value_8x10.ToString();
        }

        private void num8x12_ValueChanged(object sender, EventArgs e)
        {
            var units_4x12 = (int)num4x12.Value;
            double price_4x12 = 0;
            double value_4x12 = units_4x12 * price_4x12;
            txt4x12.Text = value_4x12.ToString();
        }

        private void num8x11_ValueChanged(object sender, EventArgs e)
        {
            var units_8x11 = (int)num8x11.Value;
            double price_8x11 = 0;
            double value_8x11 = units_8x11 * price_8x11;
            txt8x11.Text = value_8x11.ToString();
        }

        private void num9x12_ValueChanged(object sender, EventArgs e)
        {
            var units_9x12 = (int)num9x12.Value;
            double price_9x12 = 0;
            double value_9x12 = units_9x12 * price_9x12;
            txt9x12.Text = value_9x12.ToString();
        }

        private void num10x10_ValueChanged(object sender, EventArgs e)
        {
            var units_10x10 = (int)num10x10.Value;
            double price_10x10 = 0;
            double value_10x10 = units_10x10 * price_10x10;
            txt10x10.Text = value_10x10.ToString();
        }

        private void num10x13_ValueChanged(object sender, EventArgs e)
        {
            var units_10x13 = (int)num10x13.Value;
            double price_10x13 = 0;
            double value_10x13 = units_10x13 * price_10x13;
            txt10x13.Text = value_10x13.ToString();
        }

        private void num10x15_ValueChanged(object sender, EventArgs e)
        {
            var units_10x15 = (int)num10x15.Value;
            double price_10x15 = 0;
            double value_10x15 = units_10x15 * price_10x15;
            txt10x15.Text = value_10x15.ToString();
        }

        private void num11x14_ValueChanged(object sender, EventArgs e)
        {
            var units_11x14 = (int)num11x14.Value;
            double price_11x14 = 19.95;
            double value_11x14 = units_11x14 * price_11x14;
            txt11x14.Text = value_11x14.ToString();
        }

        private void num11x17_ValueChanged(object sender, EventArgs e)
        {
            var units_11x17 = (int)num11x17.Value;
            double price_11x17 = 0;
            double value_11x17 = units_11x17 * price_11x17;
            txt11x17.Text = value_11x17.ToString();
        }

        private void num12x12_ValueChanged(object sender, EventArgs e)
        {
            var units_12x12 = (int)num10x10.Value;
            double price_12x12 = 0;
            double value_12x12 = units_12x12 * price_12x12;
            txt12x12.Text = value_12x12.ToString();
        }

        private void num12x18_ValueChanged(object sender, EventArgs e)
        {
            var units_12x18 = (int)num12x18.Value;
            double price_12x18 = 0;
            double value_12x18 = units_12x18 * price_12x18;
            txt12x18.Text = value_12x18.ToString();
        }

        private void num16x16_ValueChanged(object sender, EventArgs e)
        {
            var units_16x16 = (int)num16x16.Value;
            double price_16x16 = 0;
            double value_16x16 = units_16x16 * price_16x16;
            txt16x16.Text = value_16x16.ToString();
        }

        private void num16x20_ValueChanged(object sender, EventArgs e)
        {
            var units_16x20 = (int)num16x20.Value;
            double price_16x20 = 49.95;
            double value_16x20 = units_16x20 * price_16x20;
            txt16x20.Text = value_16x20.ToString();
        }

        private void num16x24_ValueChanged(object sender, EventArgs e)
        {
            var units_16x24 = (int)num16x24.Value;
            double price_16x24 = 0;
            double value_16x24 = units_16x24 * price_16x24;
            txt16x24.Text = value_16x24.ToString();
        }

        private void num20x20_ValueChanged(object sender, EventArgs e)
        {
            var units_20x20 = (int)num20x20.Value;
            double price_20x20 = 0;
            double value_20x20 = units_20x20 * price_20x20;
            txt20x20.Text = value_20x20.ToString();
        }

        private void num20x24_ValueChanged(object sender, EventArgs e)
        {
            var units_20x24 = (int)num20x24.Value;
            double price_20x24 = 0;
            double value_20x24 = units_20x24 * price_20x24;
            txt20x24.Text = value_20x24.ToString();
        }

        private void num20x30_ValueChanged(object sender, EventArgs e)
        {
            var units_20x30 = (int)num20x30.Value;
            double price_20x30 = 94.95;
            double value_20x30 = units_20x30 * price_20x30;
            txt20x30.Text = value_20x30.ToString();
        }

        private void num24x24_ValueChanged(object sender, EventArgs e)
        {
            var units_24x24 = (int)num24x24.Value;
            double price_24x24 = 0;
            double value_24x24 = units_24x24 * price_24x24;
            txt24x24.Text = value_24x24.ToString();
        }

        private void num24x30_ValueChanged(object sender, EventArgs e)
        {
            var units_24x30 = (int)num24x30.Value;
            double price_24x30 = 0;
            double value_24x30 = units_24x30 * price_24x30;
            txt24x30.Text = value_24x30.ToString();
        }

        private void num24x36_ValueChanged(object sender, EventArgs e)
        {
            var units_24x36 = (int)num24x36.Value;
            double price_24x36 = 0;
            double value_24x36 = units_24x36 * price_24x36;
            txt24x36.Text = value_24x36.ToString();
        }

        private void num30x30_ValueChanged(object sender, EventArgs e)
        {
            var units_30x30 = (int)num30x30.Value;
            double price_30x30 = 0;
            double value_30x30 = units_30x30 * price_30x30;
            txt30x30.Text = value_30x30.ToString();
        }

        private void num30x36_ValueChanged(object sender, EventArgs e)
        {
            var units_30x36 = (int)num16x24.Value;
            double price_30x36 = 0;
            double value_30x36 = units_30x36 * price_30x36;
            txt30x36.Text = value_30x36.ToString();
        }
    }
}