using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSEZ2U.UC
{
    public partial class UCPaymentKeyPad : UserControl
    {
        public UCPaymentKeyPad()
        {
            InitializeComponent();
           
        }
        public string Result;
        public Label lbText { get; set; }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("0");
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("{BACKSPACE}");
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();

            if (lbText.Text.Length == 0)
            {
                SendKeys.Send("0");
                SendKeys.Send(".");
            }
            else
            {
                if (lbText.Text.Contains('.'))
                {
                    return;
                }
                else
                {
                    SendKeys.Send(".");
                }
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("10");
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("20");
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("50");
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (lbText == null)
            {
                return;
            }
            lbText.Focus();
            SendKeys.Send("100");
        }


    }
}
