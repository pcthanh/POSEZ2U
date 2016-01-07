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
    public partial class frmChooseeTableJoin : Form
    {
        public frmChooseeTableJoin()
        {
            InitializeComponent();
            KeyPadChosseTable.txtResult = this.txtNoTable;
        }
        public int TableNo = 0;
        private void txtNoTable_TextChanged(object sender, EventArgs e)
        {
            lblNoTable.Text = txtNoTable.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TableNo = Convert.ToInt32(this.lblNoTable.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
