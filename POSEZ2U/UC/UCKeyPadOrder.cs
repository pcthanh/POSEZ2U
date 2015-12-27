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
    public partial class UCKeyPadOrder : UserControl
    {
        public UCKeyPadOrder()
        {
            InitializeComponent();
        }
        public TextBox txtResult { get; set; }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("4");
        }

        private void bn5_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("8");
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult == null)
            {
                return;
            }
            txtResult.Focus();
            SendKeys.Send("0");
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (this.txtResult != null)
            {
                this.txtResult.Focus();
                if (this.txtResult.Text.Length == 0)
                {
                    SendKeys.Send("0");
                    SendKeys.Send(".");
                }
                else if (!this.txtResult.Text.Contains<char>('.'))
                {
                    SendKeys.Send(".");
                }
            }           
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                string text = txtResult.Text;
                txtResult.Text = text.Remove(text.Length - 1, 1);
            }
        }

    }
}
