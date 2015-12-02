using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.Class;
namespace POSEZ2U
{
    public partial class frmOpenItem : Form
    {
        public frmOpenItem()
        {
            InitializeComponent();
        }
        public Order.Item items = new Order.Item();

        private void btnOK_Click(object sender, EventArgs e)
        {
            items.ItemName = txtOpenitemName.Text;
            items.Price =Convert.ToDouble(txtOpenItemPrice.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}
