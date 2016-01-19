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
    public partial class frmChangePrice : Form
    {
        public frmChangePrice(OrderDetailModel Item)
        {
            InitializeComponent();
            ucKeyPadOrder1.txtResult = txtHiden;
            ItemMain = Item;
        }
        /// <summary>
        /// PriceType
        ///  1.%
        ///  2.New Price
        ///  3.Orther
        /// </summary>
        public int PriceType;
        public OrderDetailModel ItemMain;
        POSEZ2U.Class.MoneyFortmat money = new Class.MoneyFortmat(POSEZ2U.Class.MoneyFortmat.AU_TYPE);
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (PriceType == 1)
            {

                lblTotal.Text = txtHiden.Text;
                double Newprice = (Convert.ToDouble(ItemMain.Price) * (Convert.ToDouble(lblTotal.Text))) / 100.0;
                ItemMain.Price = Newprice;
            }
            else
            {
                if (PriceType == 2)
                {

                    ItemMain.Price = Convert.ToDouble(txtHiden.Text) *1000;
                }
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtHiden_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = txtHiden.Text;
            
        }

        private void frmChangePrice_Load(object sender, EventArgs e)
        {
            this.lblPriceType.Text = "%";
            PriceType = 1;
            this.txtItemName.Text = ItemMain.ProductName;
            this.txtPrice.Text =money.Format2(ItemMain.Price??0);
            this.txtQty.Text = ItemMain.Qty.ToString();
            btnPer.BackColor = Color.FromArgb(0, 204, 0);
        }

        private void btnNewPrice_Click(object sender, EventArgs e)
        {
            btnNewPrice.BackColor = Color.FromArgb(0, 204, 0);
            btnPer.BackColor = Color.FromArgb(228, 228, 228);
            btnOrther.BackColor = Color.FromArgb(228, 228, 228);
            lblPriceType.Text = "$";
            PriceType = 2;
        }

        private void btnOrther_Click(object sender, EventArgs e)
        {
            btnOrther.BackColor = Color.FromArgb(0, 204, 0);
            btnPer.BackColor = Color.FromArgb(228, 228, 228);
            btnNewPrice.BackColor = Color.FromArgb(228, 228, 228);
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            btnPer.BackColor = Color.FromArgb(0, 204, 0);
            btnNewPrice.BackColor = Color.FromArgb(228, 228, 228);
            btnOrther.BackColor = Color.FromArgb(228, 228, 228);
            lblPriceType.Text = "%";
            PriceType = 1;
        }
    }
}
