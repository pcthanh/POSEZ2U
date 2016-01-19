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

        #region
        private IProductPriceService _productPriceService;
        private IProductPriceService ProductPriceService
        {
            get { return _productPriceService ?? (_productPriceService = new ProductPriceService()); }
            set { _productPriceService = value; }
        }
        #endregion


        public frmMenuSetting()
        {
            InitializeComponent();
        }
        int flag;
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
                    ucMenu.btnSave.Click += ucMenuList_btnSave_Click;
                    ucMenu.btnRemove.Hide();
                    pnDetail.Controls.Add(ucMenu);
                    break;
                case 2:
                    UCGroupList ucGroupItem = new UCGroupList();
                    ucGroupItem.Dock = DockStyle.Fill;
                    ucGroupItem.btnSave.Click += ucGroupList_btnSave_Click;
                    ucGroupItem.btnRemove.Hide();
                    pnDetail.Controls.Add(ucGroupItem);
                    break;
                case 3:
                    UCItemList ucItemList = new UCItemList();
                    ucItemList.Dock = DockStyle.Fill;
                    ucItemList.btnSave.Click += ucItemList_btnSave_Click;
                    ucItemList.btnRemove.Visible = false;
                    ucItemList.btnAddProtions.Visible = false;

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
            string[] lstProduct = { "Menu List", "Group List", "Item List", "Modifier List", "Price List" };
            txtSearch.Visible = false;
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
                    addItemList("ItemList", tag);
                    break;
                case 4:
                    addModifier("Modifier List", tag);
                    break;
                case 5:
                    addPriceList(tag);
                    break;
            }


        }
        private void addMenuList(string lblName, int i)
        {
            if (btnAdd.Visible == false)
            {
                btnAdd.Visible = true;
            }
            txtSearch.Visible = false;
            txtSearch.Tag = i;
            btnAdd.Tag = i;
            ResizeToOthder();
            int index = 1;

            //string[] str = { "FOOD", "BEVEGARE", "ENTREE", "DESSERT" };
            if (i == 1)
            {
                var dataCatalogue = CatalogeService.GetCatalogueList().ToList();
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
        private void addModifier(string lblName, int i)
        {
            if (btnAdd.Visible == false)
            {
                btnAdd.Visible = true;
            }
            txtSearch.Visible = true;
            txtSearch.Tag = i;
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
        private void addGroupList(string lblName, int i)
        {
            if (btnAdd.Visible == false)
            {
                btnAdd.Visible = true;
            }
            txtSearch.Visible = true;
            txtSearch.Tag = i;
            btnAdd.Tag = i;
            int index = 1;
            // string[] str = { "COM", "PHO", "HU TIEU", "CHAO", "Coffee", "Tea", "Smoothie" };
            if (i == 2)
            {

                var dataCategory = CatalogeService.GetListCategory().ToList();
                flpMenuList.Controls.Clear();
                //txtNameMenuList.Visible = true;
                txtNameMenuList.lblMenuListName.Text = lblName;
                txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (var item in dataCategory)
                {
                    UCGroupListItem ucGroupListItem = new UCGroupListItem();
                    ucGroupListItem.lblGroupListItemName.Text = item.CategoryName;
                    ucGroupListItem.Tag = item;
                    ucGroupListItem.Click += ucGroupListItem_Click;
                    flpMenuList.Controls.Add(ucGroupListItem);
                    index++;
                }
            }

        }

        private void addItemList(string lblName, int i)
        {
            if (btnAdd.Visible == false)
            {
                btnAdd.Visible = true;
            }
            txtSearch.Visible = true;
            txtSearch.Tag = i;
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
                    ucItem.lblItem.Text = data.ProductNameDesc;
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

        public void addPriceList(int i)
        {
            txtSearch.Visible = false;
            btnAdd.Visible = false;
            var data = ProductPriceService.GetListProductPrice().ToList();
            if (i == 5)
            {
                this.ResizeTopriceList();
                flpMenuList.Controls.Clear();
                // txtNameMenuList.Visible = false;
                ucPriceListTitle.Visible = true;
                ucPriceListTitle.BackColor = Color.FromArgb(0, 102, 204);
                ucPriceListTitle.ForeColor = Color.FromArgb(255, 255, 255);
                ucPriceListTitle.Dock = DockStyle.Fill;
                foreach (var strPriceList in data)
                {
                    UCPriceList ucPriceList = new UCPriceList();
                    ucPriceList.lblPriceNameProduct.Text = strPriceList.ProductNameDesc;
                    ucPriceList.lblPriceSizeProduct.Text = strPriceList.Portions;
                    ucPriceList.lblPriceProduct.Text = Convert.ToString(strPriceList.CurrentPrice);
                    ucPriceListTitle.Size = new System.Drawing.Size(NewWidthPn2, ucPriceList.Height);
                    //ucPriceList.Dock = DockStyle.Fill;
                    ucPriceList.Tag = strPriceList.ProductPriceID;
                    ucPriceList.Click += ucPriceList_Click;
                    flpMenuList.Controls.Add(ucPriceList);
                }
                addButtonPriceList(0);
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
            pnDetail.Controls.Clear();
            addButtonPriceList(tag);
        }
        private void addButtonPriceList(int tag)
        {
            int i = 1;
            FlowLayoutPanel flpButtonPriceList = new FlowLayoutPanel();
            flpButtonPriceList.Dock = DockStyle.Fill;
            flpButtonPriceList.BackColor = Color.FromArgb(215, 214, 216);
            pnDetail.Controls.Add(flpButtonPriceList);
            string[] strlst = { "Search", "Edit", "Go To Product" };
            foreach (string str in strlst)
            {
                Button btnGoToProduct = new Button();
                btnGoToProduct.Width = 115;
                btnGoToProduct.Height = 67;
                btnGoToProduct.FlatStyle = FlatStyle.Flat;
                btnGoToProduct.FlatAppearance.BorderSize = 0;
                btnGoToProduct.Dock = DockStyle.Top;
                btnGoToProduct.Text = str;
                btnGoToProduct.Tag = str + '_' + tag;
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
            var data = btn.Tag.ToString().Split('_');
            if (data[1] == "0")
            {
                string title = "Waring.";
                string description = "Please choose product.";
                frmMessager frmMessager = new frmMessager(title, description);
                frmMessager.ShowDialog();
            }
            else
            {
                if (data[0] == "Edit")
                {
                    frmEditProductPriceList frmEditProductPriceList = new frmEditProductPriceList(Int32.Parse(data[1]));
                    frmEditProductPriceList.ShowDialog();
                }
            }
        }


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

        void ucGroupListItem_Click(object sender, EventArgs e)
        {
            UCGroupListItem ucGroupListItem = (UCGroupListItem)sender;
            CategoryModel tag = (CategoryModel)(ucGroupListItem.Tag);
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
            addMenuListDetail(tag);
        }
        private void addMenuListDetail(CatalogueModel cata)
        {
            pnDetail.Controls.Clear();
            UCMenu ucMenu = new UCMenu();
            ucMenu.Dock = DockStyle.Fill;

            if (cata.CatalogueID > 0)
            {
                ucMenu.TilteMenu.Text = cata.CatalogueName;
                ucMenu.txtMenuName.Text = cata.CatalogueName;

                ucMenu.addUcMenuGroup(cata.CatalogueID);
                ucMenu.addButton(cata.CatalogueID);


                ucMenu.btnSave.Tag = cata;
                ucMenu.btnSave.Click += ucMenuList_btnSave_Click;

                ucMenu.btnRemove.Tag = cata;
                ucMenu.btnRemove.Click += ucMenuList_btnRemove_Click;

                pnDetail.Controls.Add(ucMenu);

                ucMenu = (UCMenu)pnDetail.Controls[0];
                ucMenu.cbColor.SelectedItem = cata.Color;

            }
            else
            {
                pnDetail.Controls.Clear();
            }
        }

        void ucMenuList_btnSave_Click(object sender, EventArgs e)
        {
            Button catalogue = (Button)sender;
            CatalogueModel tag = (CatalogueModel)(catalogue.Tag);

            var ucMenu = (UCMenu)pnDetail.Controls[0];
            if (tag == null)
            {
                tag = new CatalogueModel();
            }

            tag.CatalogueName = ucMenu.txtMenuName.Text;
            tag.Color = ucMenu.cbColor.Text ?? "";

            if (tag.CatalogueName != "")
            {
                var result = CatalogeService.SavaDataCatalogue(tag);
                var message = "";
                if (result == 1)
                {
                    addMenuList("Menu List", 1);
                    message = "Save data menu successful";
                }
                else
                {
                    if (result == -1)
                    {
                        message = "Menu name already exists. Please change menu name";
                    }
                    else
                    {
                        message = "Save data menu fail";
                    }
                }
                frmMessager frm = new frmMessager("Messager", message);
                frm.ShowDialog();
            }
            else
            {
                frmMessager frm = new frmMessager("Messager","Menu name isn't empty.");
                frm.ShowDialog();
            }


        }

        void ucMenuList_btnRemove_Click(object sender, EventArgs e)
        {
            frmConfirm frmcon = new frmConfirm("Warning", "Do you want remove this menu ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Button btnRemove = (Button)sender;
                CatalogueModel tag = (CatalogueModel)(btnRemove.Tag);
                if (tag.CatalogueID > 0)
                {
                    var result = CatalogeService.RemoveCatalogue(tag.CatalogueID, 0);
                    if (result == 1)
                    {
                        addMenuList("Menu List", 1);
                        pnDetail.Controls.Clear();
                        frmMessager frm = new frmMessager("Messenger", "Delete menu successful.");
                        frm.ShowDialog();
                    }
                    else
                    {
                        frmMessager frm = new frmMessager("Messenger", "Delete menu fail.");
                        frm.ShowDialog();
                    }
                }
            }
        }


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
            frmConfirm frmcon = new frmConfirm("Warning", "Do you want remove this modifier ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Button modifier = (Button)sender;
                ModifireModel dataModifier = (ModifireModel)(modifier.Tag);
                var result = ModifireService.Delete(dataModifier);
                if (result == 1)
                {
                    addModifier("Modifier List", 4);
                    pnDetail.Controls.Clear();
                    frmMessager frm = new frmMessager("Messenger", "Delete modifire success.");
                    frm.ShowDialog();
                }
                else
                {
                    frmMessager frm = new frmMessager("Messenger", "Delete modifire fail.");
                    frm.ShowDialog();
                }
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
                var message = "";
                if (result == 1)
                {
                    addModifier("Modifier List", 4);
                    pnDetail.Controls.Clear();
                    message = "Save modifier Successful";
                }
                else
                {
                    if (result == -1)
                    {
                        message = "Modifier name already exist. Please change modifire name.";
                    }
                    else
                    {
                        message = "Save modifier fail";
                    }
                    frmMessager frm = new frmMessager("Messenger", message);
                    frm.ShowDialog();
                }
            }
            else
            {
                frmMessager frm = new frmMessager("Messenger", message_error);
                frm.ShowDialog();
            }
        }

        private void addGroupListDetail(CategoryModel cate)
        {
            pnDetail.Controls.Clear();
            UCGroupList ucGroupList = new UCGroupList();
            ucGroupList.Dock = DockStyle.Fill;
            if (cate.CategoryID > 0)
            {


                ucGroupList.lblTilte.Text = cate.CategoryName;
                ucGroupList.txtGroupNameDesc.Text = cate.CategoryName;
                ucGroupList.txtGroupNameSort.Text = cate.CategoryNameSort;

                ucGroupList.btnSave.Tag = cate;
                ucGroupList.btnSave.Click += ucGroupList_btnSave_Click;

                ucGroupList.btnRemove.Tag = cate;
                ucGroupList.btnRemove.Click += ucGroupList_btnRemove_Click;

                ucGroupList.addUcMenuGroup(cate.CategoryID);
                ucGroupList.addButton(cate.CategoryID);

                pnDetail.Controls.Add(ucGroupList);


                ucGroupList = (UCGroupList)pnDetail.Controls[0];
                ucGroupList.cbGroupColor.SelectedItem = cate.Color;
                ucGroupList.cbProductColor.SelectedItem = cate.ProductColor;
            }
            else
            {
                pnDetail.Controls.Clear();
            }
        }

        void ucGroupList_btnSave_Click(object sender, EventArgs e)
        {
            Button btnSaveGroup = (Button)sender;
            CategoryModel tag = (CategoryModel)(btnSaveGroup.Tag);

            var ucGroupItem = (UCGroupList)pnDetail.Controls[0];

            if (tag == null)
            {
                tag = new CategoryModel();
            }

            tag.CategoryName = ucGroupItem.txtGroupNameDesc.Text;
            tag.CategoryNameSort = ucGroupItem.txtGroupNameSort.Text ?? "";
            tag.Color = ucGroupItem.cbGroupColor.Text ?? "";
            tag.ProductColor = ucGroupItem.cbProductColor.Text ?? "";
            if (tag.CategoryName != "")
            {
                var result = CatalogeService.SaveDataCategory(tag);
                var message = "";
                if (result == 1)
                {

                    addGroupList("Group List", 2);
                    message = "Save data group successful.";
                }
                else
                {
                    if (result == -1)
                    {
                        message = "Menu name already exist. Please change group name.";
                    }
                    else
                    {
                        message = "Save data group fail";
                    }

                }
                frmMessager frm = new frmMessager("Messenger", message);
                frm.ShowDialog();
            }
            else
            {
                frmMessager frm = new frmMessager("Messenger", "Group name isn't empty.");
                frm.ShowDialog();
            }

        }

        void ucGroupList_btnRemove_Click(object sender, EventArgs e)
        {
            frmConfirm frmcon = new frmConfirm("Warning", "Do you want remove this group ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Button btnRemoveGroup = (Button)sender;
                CategoryModel tag = (CategoryModel)(btnRemoveGroup.Tag);
                if (tag.CategoryID > 0)
                {
                    var result = CatalogeService.RemoveCategory(tag.CategoryID, 0);
                    var messenge = "";
                    if (result == 1)
                    {
                        addGroupList("Group List", 2);
                        pnDetail.Controls.Clear();
                        messenge = "Remove group successful.";
                    }
                    else
                    {
                        messenge = "Remove group fail.";
                    }
                    frmMessager frm = new frmMessager("Messenger", messenge);
                    frm.ShowDialog();
                }
            }
        }
        private void addItemListDetail(ProductionModel productData)
        {
            pnDetail.Controls.Clear();
            UCItemList ucItemList = new UCItemList();
            ucItemList.Dock = DockStyle.Fill;
            if (productData.ProductID > 0)
            {
                ucItemList.lbProductName.Text = productData.ProductNameDesc;
                ucItemList.txtNameDesc.Text = productData.ProductNameDesc;
                ucItemList.txtNameSort.Text = productData.ProductNameSort;
                ucItemList.txtPrice.Text = Convert.ToString(productData.CurrentPrice);
                ucItemList.btnSave.Tag = productData;
                ucItemList.btnSave.Click += ucItemList_btnSave_Click;
                ucItemList.btnRemove.Click += ucItemList_btnRemove_Click;
                ucItemList.btnRemove.Tag = productData;
                ucItemList.btnAddProtions.Visible = false;
                ucItemList.lbPortions.Visible = false;
                ucItemList.Tag = productData;
                ucItemList.addUcMenuGroup(productData.ProductID);
                ucItemList.addButton(productData.ProductID);
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
            frmConfirm frmcon = new frmConfirm("Warning", "Do you want remove this item ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Button product = (Button)sender;
                ProductionModel dataProduct = (ProductionModel)(product.Tag);
                var result = ProductService.Delete(dataProduct);
                if (result == 1)
                {
                    addItemList("Item List", 3);
                    pnDetail.Controls.Clear();
                    frmMessager frm = new frmMessager("Messenger", "Delete product success");
                    frm.ShowDialog();
                }
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
                dataProduct.ProductNameDesc = productNameDesc;
                dataProduct.ProductNameSort = productNameSort;
                dataProduct.Color = productColor;
                dataProduct.CurrentPrice = double.Parse(productPrice);
                var result = ProductService.Created(dataProduct);
                var message = "";
                if (result == 1)
                {
                    addItemList("Item List", 3);
                    pnDetail.Controls.Clear();
                    message = "Save Product Successful.";
                }
                else
                {
                    if (result == -1)
                    {
                        message = "Product name already exist. Please change product name.";
                    }
                    else
                    {
                        message = "Save product fail.";
                    }
                }
                frmMessager frm_item = new frmMessager("Messenger", message);
                frm_item.ShowDialog();
            }
            else
            {
                frmMessager frm_item = new frmMessager("Messenger", messageError);
                frm_item.ShowDialog();
            }
        }
        private void frmMenuSetting_Load(object sender, EventArgs e)
        {
            loadDataProductSetting();
        }

        private void ucTextBoxKeyBoard1_TextChanged(object sender, EventArgs e)
        {
            TextBox addNew = (TextBox)sender;
            int tag = Convert.ToInt32(addNew.Tag);
            string textSearch = txtSearch.Text;
            switch (tag)
            {
                case 1:
                    UCMenu ucMenu = new UCMenu();
                    ucMenu.Dock = DockStyle.Fill;
                    ucMenu.btnSave.Click += ucMenuList_btnSave_Click;
                    ucMenu.btnRemove.Hide();
                    pnDetail.Controls.Add(ucMenu);
                    break;
                case 2:
                    btnAdd.Tag = tag;
                    int index_group = 1;
                    // string[] str = { "COM", "PHO", "HU TIEU", "CHAO", "Coffee", "Tea", "Smoothie" };
                    if (tag == 2)
                    {

                        var dataCategory = CatalogeService.searchProduct(textSearch, 2).ToList();
                        flpMenuList.Controls.Clear();
                        //txtNameMenuList.Visible = true;
                        txtNameMenuList.lblMenuListName.Text = "Group List";
                        txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                        txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                        foreach (var item in dataCategory)
                        {
                            UCGroupListItem ucGroupListItem = new UCGroupListItem();
                            ucGroupListItem.lblGroupListItemName.Text = item.CategoryName;
                            ucGroupListItem.Tag = item;
                            ucGroupListItem.Click += ucGroupListItem_Click;
                            flpMenuList.Controls.Add(ucGroupListItem);
                            index_group++;
                        }
                    }
                    break;
                case 3:
                    btnAdd.Tag = tag;
                    ResizeToOthder();
                    int index_item = 1;
                    //string[] str = { "Ice coffee", "VNam Coffee", "Mocha", "Latte", "White Coffee", "Green Tea", "Apple Juice" };
                    var dataProduct = ProductService.searchProduct(textSearch,3).ToList();
                    if (tag == 3)
                    {
                        flpMenuList.Controls.Clear();
                        txtNameMenuList.lblMenuListName.Text = "ItemList";
                        txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                        txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                        foreach (var data in dataProduct)
                        {
                            UCItem ucItem = new UCItem();
                            ucItem.lblItem.Text = data.ProductNameDesc;
                            ucItem.Tag = data;
                            ucItem.Click += ucItem_Click;
                            flpMenuList.Controls.Add(ucItem);
                            index_item++;
                        }
                    }
                    else
                    {
                        flpMenuList.Controls.Clear();
                        pnDetail.Controls.Clear();
                    }
                    break;
                case 4:
                    btnAdd.Tag = tag;
                    ResizeToOthder();
                    int index_modifier = 1;
                    //string[] str = { "No Sugar", "More Sugar", "More Ice", "Less Ice", "More Milk", "Them Bun", "Them Thit" };
                    var dataModifire = ModifireService.searchProduct(textSearch,4).ToList();
                    if (tag == 4)
                    {
                        flpMenuList.Controls.Clear();
                        //txtNameMenuList.Visible = true;
                        txtNameMenuList.lblMenuListName.Text = "Modifier List";
                        txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                        txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                        foreach (var data in dataModifire)
                        {
                            UCModifierItem ucModifierItem = new UCModifierItem();
                            ucModifierItem.lblModifierItemName.Text = data.ModifireName;
                            ucModifierItem.Tag = data;
                            ucModifierItem.Click += ucModifierItem_Click;
                            flpMenuList.Controls.Add(ucModifierItem);
                            index_modifier++;
                        }
                    }
                    else
                    {
                        flpMenuList.Controls.Clear();
                        pnDetail.Controls.Clear();
                    }
                    break;
                case 5:
                    break;
            }
        }


    }
}