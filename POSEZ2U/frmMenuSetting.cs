using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.UC;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmMenuSetting : Form
    {


        #region Variables & Constructors
        private ICatalogueService _catalogeService;
        private ICatalogueService CatalogeService
        {
            get { return _catalogeService ?? (_catalogeService = new CatalogueService()); }
            set { _catalogeService = value; }
        }
        #endregion

        #region Variables & Constructors Product
        private IProductService _productService;
        private IProductService ProductService
        {
            get { return _productService ?? (_productService = new ProductService()); }
            set { _productService = value; }
        }
        #endregion
        #region Variables & Constructors Product
        private IModifireService _modifireService;
        private IModifireService ModifireService
        {
            get { return _modifireService ?? (_modifireService = new ModifireService()); }
            set { _modifireService = value; }
        }
        #endregion
        
       
        public frmMenuSetting()
        {
            InitializeComponent();
        }
        int flag = 0;
        int OldWidthPn2 = 262;
        int NewWidthPn2 = Screen.PrimaryScreen.WorkingArea.Width - 400;
        private void ResizeTopriceList()
        {
            pn2.MaximumSize = new Size(NewWidthPn2, pn2.Height);
            pn2.Size = new Size(NewWidthPn2, pn2.Height);
           
        }
        private void ResizeToOthder()
        {
            this.ucPriceListTitle.Visible = false;
            pn2.MaximumSize = new Size(OldWidthPn2, pn2.Height);
            pn2.Size = new Size(OldWidthPn2, pn2.Height);
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnDetail.Controls.Clear();

            Button addNew = (Button)sender;
            int tag = Convert.ToInt32(addNew.Tag);

            switch (tag)
            {
                case 1:
            UCMenu ucMenu = new UCMenu();
            ucMenu.Dock = DockStyle.Fill;
                    //ucMenu.btnSave.Click += ucMenuList_btnSave_Click;
            pnDetail.Controls.Add(ucMenu);
                    break;
                case 2:
                    UCGroupList ucGroupItem = new UCGroupList();
                    ucGroupItem.Dock = DockStyle.Fill;
                    //ucGroupItem.btnSave.Click += ucGroupList_btnSave_Click;
                    pnDetail.Controls.Add(ucGroupItem);
                    break;
                case 3 :
                    UCItemList ucItemList = new UCItemList();
                    ucItemList.Dock = DockStyle.Fill;
                    ucItemList.btnSave.Click += ucItemList_btnSave_Click;
                    ucItemList.btnRemove.Visible = false;
                    ucItemList.btnAddProtions.Visible = false;
                    ucItemList.lwPortions.Visible = false;
                    ucItemList.lbPortions.Visible = false;
                    pnDetail.Controls.Add(ucItemList);
                    break;
                case 4:
                    UCModifier ucModifier = new UCModifier();
                    ucModifier.Dock = DockStyle.Fill;
                    ucModifier.btnSave.Click += ucModifier_btnSave_Click;
                    ucModifier.btnRemove.Visible = false;
                    pnDetail.Controls.Add(ucModifier);
                    break;
                case 5:
                    UCPriceList ucPriceList = new UCPriceList();
                    ucPriceList.Dock = DockStyle.Fill;
                    pnDetail.Controls.Add(ucPriceList);
                    break;
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loadDataProductSetting()
        {
            flpProdutcSetting.Controls.Clear();
            int i = 1;
            string [] lstProduct= {"Menu List","Group List","Item List","Modifier List","Price List"};

            foreach (string str in lstProduct)
            {
               
                UCProductSetting ucProduct = new UCProductSetting();
                ucProduct.lblNameProductSetting.Text = str;
                ucProduct.Tag = i;
                ucProduct.Click += ucProduct_Click;
                flpProdutcSetting.Controls.Add(ucProduct);
                i++;
            }
        }

        void ucProduct_Click(object sender, EventArgs e)
        {
            UCProductSetting ucProduct = (UCProductSetting)sender;
            int tag = Convert.ToInt32(ucProduct.Tag);
            foreach (Control ctr in flpProdutcSetting.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucProduct.BackColor = Color.FromArgb(0, 102, 204);
            ucProduct.ForeColor = Color.FromArgb(255, 255, 255);
            pnDetail.Controls.Clear();
            switch (tag)
            {
                case 1:
            addMenuList("Menu List", tag);
                    break;
                case 2:
            addGroupList("Group List", tag);
                    break;
                case 3:
                    addItemList("Item List", tag);
                    break;
                case 4:
                    addModifier("Modifier List", tag);
                    break;
                case 5:
            addPriceList(tag);
                    break;
        }
        }
        private void addMenuList(string lblName,int i)
        {
            ResizeToOthder();
            int index = 1;
            //string[] str = { "FOOD", "BEVEGARE", "ENTREE", "DESSERT" };

            var dataCatalogue = CatalogeService.GetCatalogueList().ToList();
           // CatalogueModel data = (CatalogueModel)dataCatalogue;
            var nlist = dataCatalogue.Count();
            string[] str = new string[nlist];

            //int ilist = 0;
            //foreach (var item in dataCatalogue)
            //{
            //    str[ilist] = item.CatalogueName;
            //    ilist++;
            //}

            if (i == 1)
            {
                flpMenuList.Controls.Clear();
                //txtNameMenuList.Visible = true;
                txtNameMenuList.lblMenuListName.Text = lblName;
                txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (var item in dataCatalogue)
                {
                    UCMenuList ucMenuList = new UCMenuList();
                    ucMenuList.lblMenuListName.Text = item.CatalogueName;
                    ucMenuList.Tag = item;
                    ucMenuList.Click += ucMenuList_Click;
                    flpMenuList.Controls.Add(ucMenuList);
                    index++;
                }
            }
            else
            {
                flpMenuList.Controls.Clear();
                pnDetail.Controls.Clear();
                
            }
        }

        #region Vupl
        // add List Modifier
        private void addModifier(string lblName, int i)
        {
            btnAdd.Tag = i;
            ResizeToOthder();
            int index = 1;
            //string[] str = { "No Sugar", "More Sugar", "More Ice", "Less Ice", "More Milk", "Them Bun", "Them Thit" };
            var dataModifire = ModifireService.GetModifireList().ToList();
            if (i == 4)
            {
                flpMenuList.Controls.Clear();
                //txtNameMenuList.Visible = true;
                txtNameMenuList.lblMenuListName.Text = lblName;
                txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (var data in dataModifire)
                {
                    UCModifierItem ucModifierItem = new UCModifierItem();
                    ucModifierItem.lblModifierItemName.Text = data.ModifireName;
                    ucModifierItem.Tag = data;
                    ucModifierItem.Click += ucModifierItem_Click;
                    flpMenuList.Controls.Add(ucModifierItem);
                    index++;
                }
            }
            else
            {
                flpMenuList.Controls.Clear();
                pnDetail.Controls.Clear();
            }
        }
        #endregion
        private void addGroupList(string lblName, int i)
        {

            int index = 1;
            string[] str = { "COM", "PHO", "HU TIEU", "CHAO", "Coffee", "Tea", "Smoothie" };
            if (i == 2)
            {
                flpMenuList.Controls.Clear();
                //txtNameMenuList.Visible = true;
                txtNameMenuList.lblMenuListName.Text = lblName;
                txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (string strList in str)
                {
                    UCGroupListItem ucGroupListItem = new UCGroupListItem();
                    ucGroupListItem.lblGroupListItemName.Text = strList;
                    ucGroupListItem.Tag = index;
                    ucGroupListItem.Click += ucGroupListItem_Click;
                    flpMenuList.Controls.Add(ucGroupListItem);
                    index++;
                }
            }

        }

        private void addItemList(string lblName, int i)
        {
            btnAdd.Tag = i;
            ResizeToOthder();
            int index = 1;
            //string[] str = { "Ice coffee", "VNam Coffee", "Mocha", "Latte", "White Coffee", "Green Tea", "Apple Juice" };
            var dataProduct = ProductService.GetProductsList().ToList();
            if (i == 3)
            {
                flpMenuList.Controls.Clear();
                txtNameMenuList.lblMenuListName.Text = lblName;
                txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (var data in dataProduct)
                {
                    UCItem ucItem = new UCItem();
                    ucItem.lblItem.Text = data.ProductName;
                    ucItem.Tag = data;
                    ucItem.Click += ucItem_Click;
                    flpMenuList.Controls.Add(ucItem);
                    index++;
                }
            }
            else
            {
                flpMenuList.Controls.Clear();
                pnDetail.Controls.Clear();
            }

        }

        private void addPriceList(int i)
        {
            
            string[] str = { "Ice coffee", "VNam Coffee", "Mocha", "Latte", "White Coffee", "Green Tea", "Apple Juice" };
            if (i == 5)
            {
                this.ResizeTopriceList();
                flpMenuList.Controls.Clear();
               // txtNameMenuList.Visible = false;
                ucPriceListTitle.Visible = true;
                ucPriceListTitle.BackColor = Color.FromArgb(0, 102, 204);
                ucPriceListTitle.ForeColor = Color.FromArgb(255, 255, 255);
                ucPriceListTitle.Dock = DockStyle.Fill;
                foreach (string strPriceList in str)
                {
                    UCPriceList ucPriceList = new UCPriceList();
                    ucPriceList.lblPriceNameProduct.Text = strPriceList;
                    ucPriceList.lblPriceSizeProduct.Text = "Regular";
                    ucPriceList.lblPriceProduct.Text= "10.00";
                    ucPriceListTitle.Size = new System.Drawing.Size(NewWidthPn2, ucPriceList.Height);
                    //ucPriceList.Dock = DockStyle.Fill;
                    ucPriceList.Click += ucPriceList_Click;
                    flpMenuList.Controls.Add(ucPriceList);
                }
                addButtonPriceList();
            }
            
        }

        void ucPriceList_Click(object sender, EventArgs e)
        {
            UCPriceList ucPriceList = (UCPriceList)sender;
            int tag = Convert.ToInt32(ucPriceList.Tag);
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucPriceList.BackColor = Color.FromArgb(0, 153, 51);
            ucPriceList.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void addButtonPriceList()
        {
            
            int i = 1;
            FlowLayoutPanel flpButtonPriceList = new FlowLayoutPanel();
            flpButtonPriceList.Dock = DockStyle.Fill;
            flpButtonPriceList.BackColor = Color.FromArgb(215, 214, 216);
            pnDetail.Controls.Add(flpButtonPriceList);
            string[] strlst = { "Search","Edit","Go To Product" };
            foreach (string str in strlst)
            {
                Button btnGoToProduct = new Button();
                btnGoToProduct.Width = 115;
                btnGoToProduct.Height = 67;
                btnGoToProduct.FlatStyle = FlatStyle.Flat;
                btnGoToProduct.FlatAppearance.BorderSize = 0;
                btnGoToProduct.Dock = DockStyle.Top;
                btnGoToProduct.Text = str;
                btnGoToProduct.Tag = str;
                btnGoToProduct.BackColor = Color.FromArgb(51, 51, 51);
                btnGoToProduct.ForeColor = Color.FromArgb(255, 255, 255);
                btnGoToProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnGoToProduct.Click += btnGoToProduct_Click;
                i++;
                flpButtonPriceList.Controls.Add(btnGoToProduct);
            }

        }

        void btnGoToProduct_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Tag.ToString());
        }

        #region Vupl
        //Click Item list
        void ucItem_Click(object sender, EventArgs e)
        {
            UCItem ucItem = (UCItem)sender;
            ProductionModel dataProduct = (ProductionModel)ucItem.Tag;
            flag = 3;
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucItem.BackColor = Color.FromArgb(0, 153, 51);
            ucItem.ForeColor = Color.FromArgb(255, 255, 255);
            addItemListDetail(dataProduct);
        }
        #endregion
        void ucGroupListItem_Click(object sender, EventArgs e)
        {
            UCGroupListItem ucGroupListItem = (UCGroupListItem)sender;
            int tag = Convert.ToInt32(ucGroupListItem.Tag);
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucGroupListItem.BackColor = Color.FromArgb(0, 153, 51);
            ucGroupListItem.ForeColor = Color.FromArgb(255, 255, 255);
            addGroupListDetail(tag);
        }
        #region Vupl
        //Click Modifier Item
        void ucModifierItem_Click(object sender, EventArgs e)
        {
            UCModifierItem ucModifierItem = (UCModifierItem)sender;
            ModifireModel dataModifire = (ModifireModel)(ucModifierItem.Tag);
            flag = 4;
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucModifierItem.BackColor = Color.FromArgb(0, 153, 51);
            ucModifierItem.ForeColor = Color.FromArgb(255, 255, 255);
            addModifierItemDetail(dataModifire);
        }
        #endregion
        void ucMenuList_Click(object sender, EventArgs e)
        {
            UCMenuList ucProduct = (UCMenuList)sender;
            CatalogueModel tag = (CatalogueModel)(ucProduct.Tag);
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucProduct.BackColor = Color.FromArgb(0, 153, 51);
            ucProduct.ForeColor = Color.FromArgb(255, 255, 255);
            addMenuListDetail(tag.CatalogueID);
        }
        private void addMenuListDetail(int i)
        {
            pnDetail.Controls.Clear();
            UCMenu ucMenu = new UCMenu();
            ucMenu.Dock = DockStyle.Fill;
            if (i == 2)
            {
               
                pnDetail.Controls.Add(ucMenu);
                ucMenu = (UCMenu)pnDetail.Controls[0];
                ucMenu.cbColor.SelectedItem = "Red";
            }
            else
            {
                pnDetail.Controls.Clear();
            }
        }
        #region Vupl
        //add List Modifier
        private void addModifierItemDetail(ModifireModel dataModifire)
        {
            pnDetail.Controls.Clear();
            UCModifier ucModifier = new UCModifier();
            ucModifier.Dock = DockStyle.Fill;
            if (dataModifire.ModifireID > 0)
            {
                ucModifier.lblModifierName.Text = dataModifire.ModifireName;
                ucModifier.txtModifierName.Text = dataModifire.ModifireName;
                ucModifier.txtModifierPrice.Text = Convert.ToString(dataModifire.CurrentPrice);
                ucModifier.btnSave.Tag = dataModifire;
                ucModifier.btnSave.Click += ucModifier_btnSave_Click;
                ucModifier.btnRemove.Tag = dataModifire;
                ucModifier.btnRemove.Click += ucModifier_btnRemove_Click;
                pnDetail.Controls.Add(ucModifier);
                ucModifier = (UCModifier)pnDetail.Controls[0];
                ucModifier.cbColor.SelectedItem = dataModifire.Color;
            }
            else
            {
                pnDetail.Controls.Clear();
            }
        }

        private void ucModifier_btnRemove_Click(object sender, EventArgs e)
        {
            Button modifier = (Button)sender;
            ModifireModel dataModifier = (ModifireModel)(modifier.Tag);
            var result = ModifireService.Delete(dataModifier);
            if (result == 1)
            {
                addModifier("Modifier List", 4);
                pnDetail.Controls.Clear();
                MessageBox.Show("Delete modifire success", "Messenger");
            }
        }

        private void ucModifier_btnSave_Click(object sender, EventArgs e)
        {
            Button modifier = (Button)sender;
            ModifireModel dataModifier = (ModifireModel)(modifier.Tag);
            string message_error = "";
            var ucModifier = (UCModifier)pnDetail.Controls[0];
            var modifierName = ucModifier.txtModifierName.Text;
            var modifierColor = ucModifier.cbColor.Text;
            var modifierPrice = ucModifier.txtModifierPrice.Text;

            if (dataModifier == null)
            {
                dataModifier = new ModifireModel();
            }

            if (modifierName == "")
            {
                message_error += "Modifire name isn't empty.";
            }
            if (modifierColor == "")
            {
                message_error += "Modifire Color isn't empty";
            }
            if (modifierPrice == "")
            {
                message_error += "Modifre price isn't empty";
            }
            if (message_error == "")
            {
                dataModifier.ModifireName = modifierName;
                dataModifier.Color = modifierColor;
                dataModifier.CurrentPrice = double.Parse(modifierPrice);
                var result = ModifireService.Created(dataModifier);
                if (result == 1)
                {
                    addModifier("Modifier List", 4);
                pnDetail.Controls.Clear();
                    MessageBox.Show("Save Modifire Successful", "Messenger");
            }
                else
                {
                    if (result == -1)
                    {
                        MessageBox.Show("Modifire name already exist. Please change modifire name.", "Messenger");
        }
                    else
                    {
                        MessageBox.Show("Save Modifire Fail", "Messenger");
                    }

                }
            }
            else
            {
                MessageBox.Show(message_error,"Messenger");
            }
        }
        #endregion
        private void addGroupListDetail(int i)
        {
            pnDetail.Controls.Clear();
            UCGroupList ucGroupList = new UCGroupList();
            ucGroupList.Dock = DockStyle.Fill;
            if (i == 5)
            {
                pnDetail.Controls.Add(ucGroupList);
            }
            else
            {
                pnDetail.Controls.Clear();
            }
        }
        #region Vupl 
        //author Pham Le Vu
        //add Item Product
        private void addItemListDetail(ProductionModel productData)
        {
            pnDetail.Controls.Clear();
            UCItemList ucItemList = new UCItemList();
            ucItemList.Dock = DockStyle.Fill;
            if (productData.ProductID > 0)
            {
                ucItemList.lbProductName.Text = productData.ProductName;
                ucItemList.txtNameDesc.Text = productData.ProductName;
                ucItemList.txtNameSort.Text = productData.ProductName;
                ucItemList.txtPrice.Text = Convert.ToString(productData.CurrentPrice);
                ucItemList.btnSave.Tag = productData;
                ucItemList.btnSave.Click += ucItemList_btnSave_Click;
                ucItemList.btnRemove.Click += ucItemList_btnRemove_Click;
                ucItemList.btnRemove.Tag = productData;
                ucItemList.btnAddProtions.Visible = false;
                ucItemList.lbPortions.Visible = false;
                ucItemList.lwPortions.Visible = false;
                pnDetail.Controls.Add(ucItemList);
                ucItemList = (UCItemList)pnDetail.Controls[0];
                ucItemList.cbProductColor.SelectedItem = productData.Color;
            }
            else
            {
                pnDetail.Controls.Clear();
            }
        }

        private void ucItemList_btnRemove_Click(object sender, EventArgs e)
        {
            Button product = (Button)sender;
            ProductionModel dataProduct = (ProductionModel)(product.Tag);
            var result = ProductService.Delete(dataProduct);
            if (result == 1)
        {
                addItemList("Item List", 3);
                pnDetail.Controls.Clear();
                MessageBox.Show("Delete product success", "Messenger");
            }
        }

        private void ucItemList_btnSave_Click(object sender, EventArgs e)
        {
            Button product = (Button)sender;
            ProductionModel dataProduct = (ProductionModel)(product.Tag);
            string messageError = "";
            var ucItemList = (UCItemList)pnDetail.Controls[0];
            var productNameDesc = ucItemList.txtNameDesc.Text;
            var productNameSort = ucItemList.txtNameSort.Text;
            var productPrice = ucItemList.txtPrice.Text;
            var productColor = ucItemList.cbProductColor.Text;
     
            if (dataProduct == null)
            {
                dataProduct = new ProductionModel();
            }
            if (productNameDesc == "")
            {
                messageError += "Product name desc isn't empty.";
            }
            if (productNameSort == "")
            {
                messageError += "Product name sort isn't empty.";
            }
            if (productColor == "")
            {
                messageError += "Product Color isn't empty";
            }
            if (productPrice == "")
            {
                messageError += "Product price isn't empty";
            }
            if (messageError == "")
            {
                dataProduct.ProductName = productNameSort;
                dataProduct.Color = productColor;
                dataProduct.CurrentPrice = double.Parse(productPrice);
                var result = ProductService.Created(dataProduct);
                if (result == 1)
                {
                    addItemList("Item List", 3);
                    pnDetail.Controls.Clear();
                    MessageBox.Show("Save Product Successful", "Messenger");
                }
                else
                {
                    if (result == -1)
                    {
                        MessageBox.Show("Product name already exist. Please change product name.", "Messenger");
                    }
                    else
                    {
                        MessageBox.Show("Save Product Fail", "Messenger");
                    }
        
    }
}
            else
            {
                MessageBox.Show(messageError, "Messenger");
            }
        }
        #endregion
        private void frmMenuSetting_Load(object sender, EventArgs e)
        {
            loadDataProductSetting();
        }
     }
}
