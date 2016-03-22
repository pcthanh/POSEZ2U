using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using POSEZ2U.Class;
using POSEZ2U.UC;
using ServicePOS;
using ServicePOS.Model;
namespace POSEZ2U
{
    public partial class frmEditProductPriceList : Form
    {
        #region Variables & Constructors
        private IProductService _productService;
        private IProductService ProductService
        {
            get { return _productService ?? (_productService = new ProductService()); }
            set { _productService = value; }
        }
        #endregion

        #region Variables & Constructors
        private IModifireService _modifireService;
        private IModifireService ModifireService
        {
            get { return _modifireService ?? (_modifireService = new ModifireService()); }
            set { _modifireService = value; }
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
                txtProductPrice.Text = Convert.ToString(_pricelist.CurrentPrice);
                txtProductSize.Text = _pricelist.Portions;
                txtProductSize.Enabled = false;
                cbColor.Text = _pricelist.Color;
                label1.Text = "Modifire Name";
                label2.Text = "Modifire Size";
                label3.Text = "Modifire Price";
                label5.Text = "Modifire Color";
            }
            else
            {
                btnSave.Tag = _pricelist;
                txtProductName.Text = _pricelist.NameDesc;
                txtProductPrice.Text = Convert.ToString(_pricelist.CurrentPrice);
                txtProductSize.Text = _pricelist.Portions;
                cbColor.Text = _pricelist.Color;
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
                var txtName = txtProductName.Text;
                var comboColor = cbColor.Text;
                string message_error = "";

                if (txtPrice == "")
                {
                    message_error = "Price is not empty";
                }
                if (txtName == "")
                {
                    message_error = "Name is not empty";
                }

                if (message_error == "")
                {
                    dataPriceList.CurrentPrice = Int32.Parse(txtPrice);
                    dataPriceList.NameDesc = txtName;
                    if(comboColor == ""){
                        dataPriceList.Color = dataPriceList.Color;
                    } else {
                        dataPriceList.Color = comboColor;
                    }
                    var result = 0;
                    if (dataPriceList.Type == "MODIFIRE")
                    {
                        ModifireModel modifire = new ModifireModel();
                        modifire.ModifireID = dataPriceList.ID;
                        modifire.CurrentPrice = dataPriceList.CurrentPrice;
                        modifire.ModifireName = dataPriceList.NameDesc;
                        modifire.Color = dataPriceList.Color;
                        result = ModifireService.Created(modifire);
                    } else {
                        ProductionModel product = new ProductionModel();
                        product.ProductID = dataPriceList.ID;
                        product.CurrentPrice = dataPriceList.CurrentPrice;
                        product.ProductNameDesc = dataPriceList.NameDesc;
                        product.ProductNameSort = dataPriceList.NameSort;
                        product.Color = dataPriceList.Color;
                        result = ProductService.Created(product);
                    }
                    if (result == 1)
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        frmMessager frmMessager = new frmMessager("Edit Product Price", "Error");
                        frmOpacity.ShowDialog(this, frmMessager);
                        this.Hide();
                    }
                }
                else
                {
                    frmMessager frmMessager = new frmMessager("Edit Product Price", message_error);
                    frmOpacity.ShowDialog(this, frmMessager);
                }
            }
        }

        private void cbColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X + 30, rect.Top);
                int Rect_left = e.Bounds.X + 1;
                int Rect_top = e.Bounds.Y + 1;
                Rectangle rct = new Rectangle(Rect_left, Rect_top, 20, e.Bounds.Height - 2);
                g.DrawRectangle(Pens.Black, rct);
                g.FillRectangle(b, rct);
            }
        }

        private void frmEditProductPriceList_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cbColor.Items.Add(c.Name);
            }
        }
    }
}
