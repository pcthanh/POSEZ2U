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
        int productPriceListID;
        public ProductPriceModel productPrice = new ProductPriceModel();
        public frmEditProductPriceList(int _productPriceListID)
        {
            InitializeComponent();
            productPriceListID = _productPriceListID;
            productPrice = ProductPriceService.GetDetailProductPrice(productPriceListID).SingleOrDefault();
            btnSave.Tag = productPrice;
            txtProductName.Text = productPrice.ProductNameDesc;
            txtProductName.Enabled = false;
            txtProductPrice.Text = Convert.ToString(productPrice.CurrentPrice);
            txtProductSize.Text = productPrice.Portions;
            txtProductSize.Enabled = false;
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
                ProductPriceModel dataProductPrice = (ProductPriceModel)(btn.Tag);
                var txtPrice = txtProductPrice.Text;
                string message_error = "";

                if (dataProductPrice == null)
                {
                    dataProductPrice = new ProductPriceModel();
                }
                if (txtPrice == "")
                {
                    message_error = "Price is not empty";
                }

                if (message_error == "")
                {
                    dataProductPrice.CurrentPrice = Int32.Parse(txtPrice);
                    var result = ProductPriceService.EditProductPrice(dataProductPrice);
                    if (result == 1)
                    {
                        frmMessager frmMessager = new frmMessager("Edit Product Price", "Success");
                        frmMessager.ShowDialog();
                        this.Hide();
                        frmMenuSetting frmMenuSetting = new frmMenuSetting();
                        frmMenuSetting.flpMenuList.Controls.Clear();
                        frmMenuSetting.addPriceList(5);
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
