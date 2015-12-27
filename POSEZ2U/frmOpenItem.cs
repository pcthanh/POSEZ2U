using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ServicePOS.Model;
namespace POSEZ2U
{
    public partial class frmOpenItem : Form
    {
        public frmOpenItem()
        {
            InitializeComponent();
        }

        public OrderDetailModel items = new OrderDetailModel();

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOpenitemName.Text != string.Empty & txtOpenItemPrice.Text != string.Empty)
            {
                items.ProductName = txtOpenitemName.Text;
                items.Price = Convert.ToDouble(txtOpenItemPrice.Text)*1000;
                items.OpenItem = 1;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}