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
using POSEZ2U.UC;
using ServicePOS;
using ServicePOS.Model;
namespace POSEZ2U
{
    public partial class frmEditProductPriceList : Form
    {
        #region Variables & Constructors
        private IProductPriceService _productPriceService;
        private IProductPriceService ProductPriceService
        {
            get { return _productPriceService ?? (_productPriceService = new ProductPriceService()); }
            set { _productPriceService = value; }
        }
        #endregion

        #region Variables & Constructors
        private IModifireService _modifirePriceService;
        private IModifireService ModifirePriceService
        {
            get { return _modifirePriceService ?? (_modifirePriceService = new ModifireService()); }
            set { _modifirePriceService = value; }
        }
        #endregion
        public PriceListModel pricelist = new PriceListModel();
        public frmEditProductPriceList(PriceListModel _pricelist)
        {
            InitializeComponent();
            if (_pricelist.Type == "MODIFIRE")
            {
                btnSave.Tag = _pricelist;
                txtProductName.Text = _pricelist.NameDesc;
                txtProductName.Enabled = false;
                txtProductPrice.Text = Convert.ToString(_pricelist.CurrentPrice);
                txtProductSize.Text = _pricelist.Portions;
                txtProductSize.Enabled = false;
                label1.Text = "Modifire Name";
                label2.Text = "Modifire Size";
                label3.Text = "Modifire Price";
            }
            else
            {
                btnSave.Tag = _pricelist;
                txtProductName.Text = _pricelist.NameDesc;
                txtProductName.Enabled = false;
                txtProductPrice.Text = Convert.ToString(_pricelist.CurrentPrice);
                txtProductSize.Text = _pricelist.Portions;
                txtProductSize.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmConfirm frmcon = new frmConfirm("Messenger", "Do you want edit info price of product ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Button btn = (Button)sender;
                PriceListModel dataPriceList = (PriceListModel)(btn.Tag);
                var txtPrice = txtProductPrice.Text;
                string message_error = "";

                if (txtPrice == "")
                {
                    message_error = "Price is not empty";
                }

                if (message_error == "")
                {
                    dataPriceList.CurrentPrice = Int32.Parse(txtPrice);
                    var result = 0;
                    if (dataPriceList.Type == "MODIFIRE")
                    {
                        ModifirePriceModel modifirePrice = new ModifirePriceModel();
                        modifirePrice.ModifirePriceID = dataPriceList.PriceID;
                        modifirePrice.CurrentPrice = dataPriceList.CurrentPrice;
                        result = ModifirePriceService.EditModifirePrice(modifirePrice);
                    } else {
                        ProductPriceModel productPrice = new ProductPriceModel();
                        productPrice.ProductPriceID = dataPriceList.PriceID;
                        productPrice.CurrentPrice = dataPriceList.CurrentPrice;
                        result = ProductPriceService.EditProductPrice(productPrice);
                    }
                    if (result == 1)
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        frmMessager frmMessager = new frmMessager("Edit Product Price", "Error");
                        frmMessager.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    frmMessager frmMessager = new frmMessager("Edit Product Price", message_error);
                    frmMessager.ShowDialog();
                }
            }
        }
    }
}
