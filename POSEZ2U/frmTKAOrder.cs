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
    public partial class frmTKAOrder : Form
    {
        public frmTKAOrder()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrder frm = new frmOrder();
            frm.LoadOrderTKA("TKA-", "");
            frm.ShowDialog();
           
        }
    }
}
