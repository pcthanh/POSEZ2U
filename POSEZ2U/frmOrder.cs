
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.UC;
using SystemLog;
using ServicePOS;
using ModelPOS;
using ServicePOS.Model;
using Printer;

namespace POSEZ2U
{
    public partial class frmOrder : Form
    {
        OrderModel OrderMain;
        public frmOrder(OrderModel _orderMain)
        {
            InitializeComponent();
            OrderMain = _orderMain;
            posPrinter.printDocument.PrintPage += printDocument_PrintPage;
        }
        public POSEZ2U.frmFloor.CallBackStatusOrder CallBackStatusOrder;
        POSPrinter posPrinter = new POSPrinter();
        POSEZ2U.Class.MoneyFortmat money = new POSEZ2U.Class.MoneyFortmat(POSEZ2U.Class.MoneyFortmat.AU_TYPE);
        CatalogueModel CatalogueMain;
        int CategoryIDMain;
        int indexOfUcSeat;
        int countItemOfSeat;
        int flagUcSeatClick;

        private ICatalogueService _catalogeService;
        private ICatalogueService CatalogeService
        {
            get { return _catalogeService ?? (_catalogeService = new CatalogueService()); }
            set { _catalogeService = value; }
        }
       
        private IProductService _productService;
        private IProductService ProductService
        {
            get { return _productService ?? (_productService = new ProductService()); }
            set { _productService = value; }
        }
        
       
        private IModifireService _modifireService;
        private IModifireService ModifireService
        {
            get { return _modifireService ?? (_modifireService = new ModifireService()); }
            set { _modifireService = value; }
        }

        private IOrderService _orderService;
        private IOrderService OrderService
        {
            get { return _orderService ?? (_orderService = new OrderService()); }
            set { _orderService = value; }
        }

        List<OrderDetailModel> ListOrderDetail = new List<OrderDetailModel>();
        List<OrderDetailModifireModel> ListOrderModifire = new List<OrderDetailModifireModel>();
        int keyItemTemp;
        int indexControl;
        int seat = 0;
        int flagClick = 0;
        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadMenuGroup();
            this.SelectGroupMenu();
            this.lblTable.Text = OrderMain.FloorID.ToString();
        }
        
        private void AddButtonOpenItem()
        {
            Button btn = new Button();
            btn.Width = 137;
            btn.Height = 72;
            btn.Name = "btnOpenItem";
            btn.Text = "Open Item";
            btn.BackColor = Color.FromArgb(0, 102, 204);
            btn.ForeColor = Color.FromArgb(255, 255, 255);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Click += btn_Click;
            flowLayoutPanel1.Controls.Add(btn);
        }
        private void AddButtonBackItem()
        {
            Button btnBack = new Button();
            btnBack.Width = 137;
            btnBack.Height = 68;
            btnBack.Name = "btnOpenItem";
            btnBack.Text = "BACK...";
            btnBack.BackColor = Color.FromArgb(0, 51, 51);
            btnBack.ForeColor = Color.FromArgb(255, 255, 255);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBack.Click += btnBack_Click;
            flowLayoutPanel1.Controls.Add(btnBack);
        }
        private void AddButtonBackSubItem()
        {
            Button btnBackSubItem = new Button();
            btnBackSubItem.Width = 137;
            btnBackSubItem.Height = 68;
            btnBackSubItem.Name = "btnOpenItem";
            btnBackSubItem.Text = "BACK...";
            btnBackSubItem.BackColor = Color.FromArgb(228, 228, 228);
            btnBackSubItem.ForeColor = Color.FromArgb(0, 0, 0);
            btnBackSubItem.FlatAppearance.BorderSize = 0;
            btnBackSubItem.FlatStyle = FlatStyle.Flat;
            btnBackSubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBackSubItem.Click += btnBackSubItem_Click;
            flowLayoutPanel1.Controls.Add(btnBackSubItem);
        }

        void btnBackSubItem_Click(object sender, EventArgs e)
        {
           // this.LoadItemOfGroup();
            try
            {
                LoadItemOfGroup(CategoryIDMain);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btnBackSubItem_Click::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void AddButtonOpenItemItem()
        {
            Button btnOpenItemItem = new Button();
            btnOpenItemItem.Width = 137;
            btnOpenItemItem.Height = 68;
            btnOpenItemItem.Name = "btnOpenItem";
            btnOpenItemItem.Text = "Open Item";
            btnOpenItemItem.BackColor = Color.FromArgb(0, 0, 153);
            btnOpenItemItem.ForeColor = Color.FromArgb(255, 255, 255);
            btnOpenItemItem.FlatAppearance.BorderSize = 0;
            btnOpenItemItem.FlatStyle = FlatStyle.Flat;
            btnOpenItemItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOpenItemItem.Click += btnOpenItemItem_Click;
            flowLayoutPanel1.Controls.Add(btnOpenItemItem);
        }
        private void AddButtonOpenItemSubItem()
        {
            Button btnOpenItemSubItem = new Button();
            btnOpenItemSubItem.Width = 137;
            btnOpenItemSubItem.Height = 68;
            btnOpenItemSubItem.Name = "btnOpenItem";
            btnOpenItemSubItem.Text = "Open Item";
            btnOpenItemSubItem.BackColor = Color.FromArgb(0, 0, 153);
            btnOpenItemSubItem.ForeColor = Color.FromArgb(255, 255, 255);
            btnOpenItemSubItem.FlatAppearance.BorderSize = 0;
            btnOpenItemSubItem.FlatStyle = FlatStyle.Flat;
            btnOpenItemSubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOpenItemSubItem.Click += btnOpenItemSubItem_Click;
            flowLayoutPanel1.Controls.Add(btnOpenItemSubItem);
        }

        void btnOpenItemSubItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOpenItem frm = new frmOpenItem();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Order.Item itemTemp = new Order.Item();
                    OrderDetailModel itemTemp = new OrderDetailModel();
                    itemTemp = frm.items;
                    //Order.Modifier modifierTemp = new Order.Modifier();
                    OrderDetailModifireModel modifierTemp = new OrderDetailModifireModel();
                    modifierTemp.ModifireName = itemTemp.ProductName;
                    modifierTemp.Price = itemTemp.Price;
                    OrderMain.addModifierToList(modifierTemp, keyItemTemp);
                    UCItemModifierOfMenu ucItemModifierOfMenu = new UCItemModifierOfMenu();
                    this.addModifreToOrder(ucItemModifierOfMenu, modifierTemp);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btnOpenItemSubItem_Click::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void AddButtonBackSubItemPage()
        {
            Button btnBackSubItemPage = new Button();
            btnBackSubItemPage.Width = 137;
            btnBackSubItemPage.Height = 68;
            btnBackSubItemPage.Name = "btnOpenItem";
            btnBackSubItemPage.Text = "BACK";
            btnBackSubItemPage.TextAlign = ContentAlignment.MiddleCenter;
            btnBackSubItemPage.BackColor = Color.FromArgb(228, 228, 228);
            btnBackSubItemPage.ForeColor = Color.FromArgb(13, 13, 13);
            btnBackSubItemPage.FlatAppearance.BorderSize = 0;
            btnBackSubItemPage.FlatStyle = FlatStyle.Flat;
            
            btnBackSubItemPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBackSubItemPage.Click += btnBackSubItemPage_Click;
            flowLayoutPanel1.Controls.Add(btnBackSubItemPage);
        }

        void btnBackSubItemPage_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        private void AddButtonNextSubItemPage()
        {
            Button btnNextSubItemPage = new Button();
            btnNextSubItemPage.Width = 137;
            btnNextSubItemPage.Height = 68;
            btnNextSubItemPage.Name = "btnOpenItem";
            btnNextSubItemPage.Text = "NEXT";
            btnNextSubItemPage.TextAlign = ContentAlignment.MiddleCenter;
            btnNextSubItemPage.BackColor = Color.FromArgb(228, 228, 228);
            btnNextSubItemPage.ForeColor = Color.FromArgb(13, 13, 13);
            btnNextSubItemPage.FlatAppearance.BorderSize = 0;
            btnNextSubItemPage.FlatStyle = FlatStyle.Flat;
            
            btnNextSubItemPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnNextSubItemPage.Click += btnNextSubItemPage_Click;
            flowLayoutPanel1.Controls.Add(btnNextSubItemPage);
        }

        void btnNextSubItemPage_Click(object sender, EventArgs e)
        {
           
        }
        private void AddButtonBackItemPage()
        {
            Button btnBackItem = new Button();
            btnBackItem.Width = 137;
            btnBackItem.Height = 68;
            btnBackItem.Name = "btnOpenItem";
            btnBackItem.Text = "BACK";
            btnBackItem.BackColor = Color.FromArgb(228, 228, 228);
            btnBackItem.ForeColor = Color.FromArgb(13, 13, 13);
            btnBackItem.FlatAppearance.BorderSize = 0;
            btnBackItem.FlatStyle = FlatStyle.Flat;
            
            btnBackItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBackItem.Click += btnBackItem_Click;
            flowLayoutPanel1.Controls.Add(btnBackItem);
        }
        private void AddButtonMextItemPage()
        {
            Button btnNextItem = new Button();
            btnNextItem.Width = 137;
            btnNextItem.Height = 68;
            btnNextItem.Name = "btnOpenItem";
            btnNextItem.Text = "NEXT";
            btnNextItem.BackColor = Color.FromArgb(228, 228, 228);
            btnNextItem.ForeColor = Color.FromArgb(13, 13, 13);
            btnNextItem.FlatAppearance.BorderSize = 0;
            btnNextItem.FlatStyle = FlatStyle.Flat;
           
            btnNextItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnNextItem.Click += btnNextItem_Click;
            flowLayoutPanel1.Controls.Add(btnNextItem);
        }

        void btnNextItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NEXT Page");
        }

        void btnBackItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back Page");
        }

        void btnOpenItemItem_Click(object sender, EventArgs e)
        {
            frmOpenItem frm = new frmOpenItem();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OrderMain.addItemToList(frm.items);
                addOrder(frm.items);
                lblSubtotal.Text = "$" + money.Format2(OrderMain.SubTotal().ToString());
            }
        }

        void btnBack_Click(object sender, EventArgs e)
        {

            //Work Here 
            try
            {
                this.flowLayoutPanel1.Controls.Clear();
                loadCategoryOfCatalogue(CatalogueMain.CatalogueID);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btnBack_Click:::::::::::::::::::::::::::" + ex.Message);
            }
            
        }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                frmOpenItem frm = new frmOpenItem();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    OrderMain.addItemToList(frm.items);
                    addOrder(frm.items);
                    lblSubtotal.Text = "$" + money.Format2(OrderMain.SubTotal().ToString());
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btn_Click:::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void LoadMenuGroup()
        {
            try
            {
                var listCatalogue = CatalogeService.GetCatalogueList();
                foreach (CatalogueModel item in listCatalogue)
                {
                    UCGroupMenuOrder ucGroupMenuOrder = new UCGroupMenuOrder();
                    ucGroupMenuOrder.lblGroupNameMenuOrder.Text = item.CatalogueName;
                    ucGroupMenuOrder.Tag = item;
                    ucGroupMenuOrder.Click += ucGroupMenuOrder_Click; ;
                    flpGroupMenu.Controls.Add(ucGroupMenuOrder);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("LoadMenuGroup::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void SelectGroupMenu()
        {
            try
            {
                UCGroupMenuOrder ucGroupMenuOrder = new UCGroupMenuOrder();
                ucGroupMenuOrder = (UCGroupMenuOrder)flpGroupMenu.Controls[0];
                CatalogueMain = (CatalogueModel)ucGroupMenuOrder.Tag;
                ucGroupMenuOrder.BackColor = Color.FromArgb(0, 102, 0);
                ucGroupMenuOrder.ForeColor = Color.FromArgb(255, 255, 255);
                CatalogueModel item = (CatalogueModel)ucGroupMenuOrder.Tag;
                loadCategoryOfCatalogue(item.CatalogueID);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("SelectGroupMenu::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        

        void ucMenuOfGroup_Click(object sender, EventArgs e)
        {
            try
            {
                UCMenuOfGroup ucMenuOfGroup = (UCMenuOfGroup)sender;
                OrderDetailModel item = new OrderDetailModel();
                if (seat > 0)
                    item.Seat = seat;
                ProductionModel itemProduct = (ProductionModel)ucMenuOfGroup.Tag;
                item.ProductName = itemProduct.ProductNameSort;
                item.Price = Convert.ToDouble(itemProduct.CurrentPrice);
                item.ProductID = itemProduct.ProductID;
                item.Qty = 1;
                OrderMain.addItemToList(item);
                addOrder(item);
                lblSubtotal.Text = "$"+money.Format2(OrderMain.SubTotal().ToString());
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucMenuOfGroup_Click:::::::::::::::::::::::::::::" + ex.Message);
            }

        }
        private void addOrder(OrderDetailModel items)
        {
            try
            {
                
                UCOrder ucOrder = new UCOrder();
                ucOrder.lblNameItem.Text = items.ProductName;
                ucOrder.Tag = items;
                ucOrder.lblPriceItem.Text = money.Format2(items.Price.ToString());
                ucOrder.Click += ucOrder_Click;
                LogPOS.WriteLog("addOrder::::::::::Item::::::" + items.ProductName + ":::::" + items.Price);
                flpOrder.Controls.Add(ucOrder);
                if (flagUcSeatClick > 0)
                {
                    flpOrder.Controls.SetChildIndex(ucOrder,indexOfUcSeat+countItemOfSeat);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("addOrder:::::::::::::::::::::::::" + ex.Message);
            }
        }

        void ucOrder_Click(object sender, EventArgs e)
        {
            try
            {
                UCOrder ucOder = (UCOrder)sender;
                OrderDetailModel item = (OrderDetailModel)ucOder.Tag;
                indexControl = flpOrder.Controls.GetChildIndex(ucOder);
                foreach (Control ctr in flpOrder.Controls)
                {
                    if (ctr is UCOrder || ctr is UCItemModifierOfMenu)
                    {
                        if (ctr.BackColor == Color.FromArgb(0, 102, 204) || ctr.BackColor == Color.FromArgb(27, 162, 97))
                        {
                            ctr.BackColor = Color.FromArgb(215, 214, 216);
                            ctr.ForeColor = Color.FromArgb(51, 51, 51);
                        }
                    }
                }
                ucOder.BackColor = Color.FromArgb(0, 102, 204);
                ucOder.ForeColor = Color.FromArgb(255, 255, 255);
                var listModifire = ModifireService.GetModifireByProduct(item.ProductID);
                
                
                if (listModifire.Count() > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                    this.AddButtonBackSubItem();
                    keyItemTemp = item.KeyItem;
                    foreach (ModifireModel Modififer in listModifire)
                    {
                        UCModifierOfMenu ucModifierOfMenu = new UCModifierOfMenu();
                        ucModifierOfMenu.lblModifierOfMenu.Text = Modififer.ModifireName;
                        ucModifierOfMenu.lblModifierOfMenu.BackColor = Color.FromName(Modififer.Color);
                        ucModifierOfMenu.Tag = Modififer;
                        ucModifierOfMenu.Click += ucModifierOfMenu_Click;
                        flowLayoutPanel1.Controls.Add(ucModifierOfMenu);
                    }
                    this.AddButtonOpenItemSubItem();
                    this.AddButtonBackSubItemPage();
                    this.AddButtonNextSubItemPage();
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    this.AddButtonBackSubItem();
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucOrder_Click:::::::::::::::::::::::::::" + ex.Message);
            }

            
        }

        void ucModifierOfMenu_Click(object sender, EventArgs e)
        {
            try
            {
                UCModifierOfMenu ucModifierOfMenu = (UCModifierOfMenu)sender;
                OrderDetailModifireModel modifier = new OrderDetailModifireModel();
                ModifireModel itemsModifre = (ModifireModel)ucModifierOfMenu.Tag;
                modifier.ModifireName = itemsModifre.ModifireName;
                modifier.Price =Convert.ToDouble(itemsModifre.CurrentPrice);
                modifier.ModifireID = itemsModifre.ModifireID;
                OrderMain.addModifierToList(modifier, keyItemTemp);
                UCItemModifierOfMenu ucItemModifierOfMenu = new UCItemModifierOfMenu();
                ucItemModifierOfMenu.Tag = modifier;
                ucItemModifierOfMenu.Click += ucItemModifierOfMenu_Click;
                addModifreToOrder(ucItemModifierOfMenu, modifier);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucModifierOfMenu_Click:::::::::::::::::::::::::"+ ex.Message);
            }

        }

        void ucItemModifierOfMenu_Click(object sender, EventArgs e)
        {
            try
            {
                flagClick = 1;
                UCItemModifierOfMenu ucItemModifierOfMenu = (UCItemModifierOfMenu)sender;
                indexControl = flpOrder.Controls.GetChildIndex(ucItemModifierOfMenu);
                foreach (Control ctrl in flpOrder.Controls)
                {
                    if (ctrl is UCItemModifierOfMenu || ctrl is UCOrder)
                    {
                        if (ctrl.BackColor == Color.FromArgb(27, 162, 97) || ctrl.BackColor == Color.FromArgb(0, 102, 204))
                        {
                            ctrl.BackColor = Color.FromArgb(215, 214, 216);
                            ctrl.ForeColor = Color.FromArgb(51, 51, 51);
                        }
                    }
                }
                ucItemModifierOfMenu.BackColor = Color.FromArgb(27, 162, 97);
                ucItemModifierOfMenu.ForeColor = Color.FromArgb(255, 255, 255);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucItemModifierOfMenu_Click:::::::::::::::::::::::::::::::::::" + ex.Message);
            }

        }
        private void addModifreToOrder(UCItemModifierOfMenu ucMdifireOfMenu,OrderDetailModifireModel modifier)
        {
            try
            {

                ucMdifireOfMenu.lblNameItenModifierMenu.Text = modifier.ModifireName;
                ucMdifireOfMenu.lblPriceItenModifierMenu.Text = money.Format2(modifier.Price.ToString());
                flpOrder.Controls.Add(ucMdifireOfMenu);
                flpOrder.Controls.SetChildIndex(ucMdifireOfMenu, indexControl + 1);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("addModifreToOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        void AddControlToFlowLayoutPanel(FlowLayoutPanel flowlayoutpanel, Control ctrl)
        {
            try
            {
                flowlayoutpanel.Controls.Add(ctrl);

                // SetChildIndex does the trick
                if (flowlayoutpanel.Controls.Count > 2)
                    flowlayoutpanel.Controls.SetChildIndex(ctrl, flowlayoutpanel.Controls.Count - 2);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("AddControlToFlowLayoutPanel::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        void ucGroupMenuOrder_Click(object sender, EventArgs e)
        {
            
            try
            {

                this.flowLayoutPanel1.Controls.Clear();
                foreach (Control ctrl in flpGroupMenu.Controls)
                {
                    if (ctrl.BackColor == Color.FromArgb(0, 102, 0))
                    {
                        ctrl.BackColor = Color.FromArgb(255, 255, 255);
                        ctrl.ForeColor = Color.FromArgb(51, 51, 51);
                    }
                }
                UCGroupMenuOrder ucGroupMenuOrder = (UCGroupMenuOrder)sender;
                CatalogueMain = (CatalogueModel)ucGroupMenuOrder.Tag;
                ucGroupMenuOrder.BackColor = Color.FromArgb(0, 102, 0);
                ucGroupMenuOrder.ForeColor = Color.FromArgb(255, 255, 255);
                CatalogueModel item = (CatalogueModel)ucGroupMenuOrder.Tag;
                loadCategoryOfCatalogue(item.CatalogueID);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucGroupMenuOrder_Click:::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void loadCategoryOfCatalogue(int CatalogueId)
        {
            try
            {
                var dataGroupMenu = CatalogeService.GetCategoryByCatalogueID(CatalogueId);
                foreach (CategoryModel itemsCategory in dataGroupMenu)
                {
                    UCMenuOrdercs ucMenuOrder = new UCMenuOrdercs();
                    ucMenuOrder.lblNameGroup.Text = itemsCategory.CategoryName;
                    var count = CatalogeService.GetProductByCategoryID(itemsCategory.CategoryID);
                    ucMenuOrder.lblCount.Text = count.Count().ToString();
                    ucMenuOrder.Tag = itemsCategory;
                    ucMenuOrder.Click += ucMenuOrder_Click;
                    flowLayoutPanel1.Controls.Add(ucMenuOrder);
                }
                this.AddButtonOpenItem();
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("loadCategoryOfCatalogue:::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void LoadItemOfGroup(int CategoryId)
        {
            try
            {
                this.flowLayoutPanel1.Controls.Clear();
                this.AddButtonBackItem();
                int keyItem = 1;
                var dataPrduct = ProductService.GetProdutcByCategory(CategoryId);
                foreach (ProductionModel itemProductionModel in dataPrduct)
                {
                    keyItem++;
                    UCMenuOfGroup ucMenuOfGroup = new UCMenuOfGroup();
                    ucMenuOfGroup.lblNameMenuOfGroup.Text = itemProductionModel.ProductNameSort;
                    ucMenuOfGroup.Tag = itemProductionModel;
                    ucMenuOfGroup.lblNameMenuOfGroup.BackColor = Color.FromName(itemProductionModel.Color);
                    ucMenuOfGroup.Click += ucMenuOfGroup_Click;
                    flowLayoutPanel1.Controls.Add(ucMenuOfGroup);

                }
                this.AddButtonOpenItemItem();
                this.AddButtonBackItemPage();
                this.AddButtonMextItemPage();
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("LoadItemOfGroup:::::::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        void ucMenuOrder_Click(object sender, EventArgs e)
        {
            
            try
            {
                UCMenuOrdercs ucGroup = (UCMenuOrdercs)sender;
                CategoryModel item = (CategoryModel)ucGroup.Tag;
                CategoryIDMain = item.CategoryID;
                LoadItemOfGroup(item.CategoryID);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucMenuOrder_Click:::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmFloor frm = new frmFloor();
            frm.ShowDialog();
            this.Visible = false;
        }

        private void ClearBackColorSeat()
        {
            foreach (Control ctr in flpOrder.Controls)
            {
                if (ctr is UCSeat)
                {
                    if (ctr.BackColor == Color.FromArgb(29, 211, 0))
                    {
                        ctr.BackColor = Color.FromArgb(0, 0, 0);
                        ctr.ForeColor = Color.FromArgb(51, 51, 51);
                    }
                }
            }
        }
        private void btnAddSeat_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddSeat frm = new frmAddSeat();

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    seat = frm.NumberSeat;
                    OrderMain.addSeat(seat);
                    UCSeat ucSeat = new UCSeat();
                    ucSeat.lblSeat.Text = "Seat " + seat;
                    ucSeat.Click += ucSeat_Click;
                    lblSeat.Text = seat.ToString();
                    flpOrder.Controls.Add(ucSeat);
                    flagUcSeatClick = 0;
                    ClearBackColorSeat();
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btnAddSeat_Click::::::::::::::::::::::::::::::::" + ex.Message);
            }
            
        }

        void ucSeat_Click(object sender, EventArgs e)
        {
            try
            {
                
                UCSeat ucSeat = (UCSeat)sender;
                flagUcSeatClick = 1;
                indexOfUcSeat = flpOrder.Controls.GetChildIndex(ucSeat);
                foreach (Control ctrl in flpOrder.Controls)
                {
                    if (ctrl is UCSeat)
                    {
                        if (ctrl.BackColor == Color.FromArgb(29, 211, 0))
                        {
                            ctrl.BackColor = Color.FromArgb(0, 0, 0);
                            ctrl.ForeColor = Color.FromArgb(51, 51, 51);
                        }
                    }
                }
                ucSeat.BackColor = Color.FromArgb(29, 211, 0);
                ucSeat.ForeColor = Color.FromArgb(51, 51, 51);
                string textSeat = ucSeat.lblSeat.Text;
                string []splitStr = textSeat.Split(' ');
                int numSeat =Convert.ToInt32(splitStr[1]);
                countItemOfSeat = OrderMain.CountIteminSeat(numSeat);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucSeat_Click:::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void flpOrder_Scroll(object sender, ScrollEventArgs e)
        {
           // flpOrder.Controls.OfType<VScrollBar>().First().Width = 20; 
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                UCOrder ucOrder;
                UCItemModifierOfMenu ucItemModifireOfMenu;
                OrderDetailModifireModel modifier = null;
                OrderDetailModel items = null;
                if (flagClick == 1)
                {

                    ucItemModifireOfMenu = (UCItemModifierOfMenu)flpOrder.Controls[indexControl];
                    modifier = (OrderDetailModifireModel)ucItemModifireOfMenu.Tag;
                }
                else
                {
                    ucOrder = (UCOrder)flpOrder.Controls[indexControl];
                    items = (OrderDetailModel)ucOrder.Tag;
                }
                if (items != null)
                {
                    for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                    {
                        if (items.KeyItem == OrderMain.ListOrderDetail[i].KeyItem)
                        {
                            if (OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count > 0)
                            {
                                for (int indexOfModifier = OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; indexOfModifier > 0; indexOfModifier--)
                                {
                                    flpOrder.Controls.RemoveAt(indexControl + indexOfModifier);
                                }
                                OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Clear();
                            }

                            OrderMain.ListOrderDetail.RemoveAt(i);
                        }

                    }

                    flpOrder.Controls.RemoveAt(indexControl);

                }
                if (modifier != null)
                {
                    for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                    {
                        for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                        {
                            if (modifier.KeyItem == OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].KeyItem)
                            {
                                OrderMain.ListOrderDetail[i].ListOrderDetailModifire.RemoveAt(j);
                            }
                        }
                    }
                    flpOrder.Controls.RemoveAt(indexControl);
                    flagClick = 0;
                }
                lblSubtotal.Text = "$" + money.Format2(OrderMain.SubTotal());
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btnVoid_Click::::e:::::::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        
        }

        private void btnVoidAll_Click(object sender, EventArgs e)
        {
            try
            {
                flpOrder.Controls.Clear();
                OrderMain.ListOrderDetail.Clear();
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btnVoidAll_Click::::::::::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderMain.ListOrderDetail.Count >= 0)
                {
                    int result = 0;
                    result= OrderService.InsertOrder(OrderMain);
                    posPrinter.printDocument.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
                    posPrinter.printDocument.Print();
                    CallBackStatusOrder(OrderMain);
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btnSendOrder_Click::::::::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //throw new NotImplementedException();

            float l_y = 0;
            PrintOrder(e, l_y);
        }
        private float PrintOrder(System.Drawing.Printing.PrintPageEventArgs e, float l_y)
        {
            l_y = posPrinter.DrawString("Date :" + DateTime.Now.ToShortDateString(), e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
            l_y = posPrinter.DrawString("Table:" + OrderMain.FloorID, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
            l_y = posPrinter.DrawString("No # Seat:" + OrderMain.Seat, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
            
            l_y += posPrinter.GetHeightPrinterLine()/10;
            
            for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
            {
                float yStart = l_y;
                posPrinter.DrawString(OrderMain.ListOrderDetail[i].ProductName, e, new Font("Arial", 10), l_y, 1);
                l_y = posPrinter.DrawString(OrderMain.ListOrderDetail[i].Qty.ToString(), e, new Font("Arial", 10), l_y, 2);
                posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].Price.ToString()), e, new Font("Arial", 10), yStart, 3);

                if (OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count > 0)
                {
                    for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                    {
                        posPrinter.DrawString(OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 10), l_y, 1);
                        l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].Price.ToString()), e, new Font("Arial", 10), l_y, 3);
                       
                    }
                }
            }
            posPrinter.DrawLine("", new Font("Arial", 10), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
            l_y=posPrinter.DrawString("", e, new Font("Arial", 10), l_y, 1);
            l_y += posPrinter.GetHeightPrinterLine()/10;
            posPrinter.DrawString("Total:",e, new Font("Arial", 10,FontStyle.Bold), l_y, 1);
            l_y=posPrinter.DrawString("$" + money.Format2(OrderMain.SubTotal()), e, new Font("Arial", 10,FontStyle.Bold), l_y, 3);
           
            return l_y;
        }
    }
}
