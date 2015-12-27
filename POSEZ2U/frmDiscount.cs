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
    public partial class frmDiscount : Form
    {
        public DiscountModel Discount;
        public frmDiscount(DiscountModel _Discount)
        {
            InitializeComponent();
            Discount = _Discount;
            ucKeyPadOrder1.txtResult = txtTotal;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnPe_Click(object sender, EventArgs e)
        {
            Discount.DiscountType = 1;
            Discount.DiscountName = btnPe.Text;
            lblType.Text = "%";
        }

        private void btnFixDiscount_Click(object sender, EventArgs e)
        {
            Discount.DiscountType = 2;
            Discount.DiscountName = btnFixDiscount.Text;
            lblType.Text = "$";
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = txtTotal.Text;
        }

        private void btnFixPrice_Click(object sender, EventArgs e)
        {
            Discount.DiscountType = 3;
            Discount.DiscountName = btnFixPrice.Text;
            lblType.Text = "$";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Discount.DiscountType == 1)
            {
                Discount.DiscountName = this.lblTotal.Text;
                Discount.Total = Convert.ToInt32(Convert.ToDouble(lblTotal.Text) * 100);
            }
            else
            {
                Discount.Total = Convert.ToInt32(Convert.ToDouble(lblTotal.Text) * 1000);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
