using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSEZ2U
{
    public partial class frmCashOut : Form
    {
        public frmCashOut()
        {
            InitializeComponent();
        }
        public double CashOut;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            this.txtCashOut.Text = "50";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            this.txtCashOut.Text = "100";
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            this.txtCashOut.Text = "200";
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            this.txtCashOut.Text = "300";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CashOut = Convert.ToDouble(txtCashOut.Text)*1000;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
