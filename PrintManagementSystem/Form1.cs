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
            }
        }

        private void chk3x5_CheckedChanged(object sender, EventArgs e)
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
            }
        }

        private void chk4x5_CheckedChanged(object sender, EventArgs e)
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
            }
        }

        private void chk4x6_CheckedChanged(object sender, EventArgs e)
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
            }
        }

        private void chk4x12_CheckedChanged(object sender, EventArgs e)
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
            }
        }

        private void chk5x5_CheckedChanged(object sender, EventArgs e)
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
            }
        }

        private void chk5x7_CheckedChanged(object sender, EventArgs e)
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
            }
        }

        private void chk8x12_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8x12.Checked)
            {
                num8x12.Enabled = true;
                txt8x12.Enabled = true;
            }
            else
            {
                num8x12.Enabled = false;
                txt8x12.Enabled = false;
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
            }
        }
    }
}