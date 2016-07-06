
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
using POSEZ2U.Class;
namespace POSEZ2U
{
    public partial class frmOrder : Form
    {

        public frmOrder()
        {
            InitializeComponent();

            posPrinter.printDocument.PrintPage += printDocument_PrintPage;
        }

        public POSEZ2U.frmFloor.CallBackStatusOrder CallBackStatusOrder;
        public POSEZ2U.frmFloor.CallBackStatusOrderCancel CallBackStatusOrderCancel;
        public POSEZ2U.frmFloor.CallBackStatusOrderPrintBill CallBackStatusOrderPrintBill;
        public POSEZ2U.frmTakeAway.CallBackStatusOrderTKA CallBackStatusOrderTKA;
        POSPrinter posPrinter = new POSPrinter();
        POSEZ2U.Class.MoneyFortmat money = new POSEZ2U.Class.MoneyFortmat(POSEZ2U.Class.MoneyFortmat.AU_TYPE);
        CatalogueModel CatalogueMain;
        int CategoryIDMain;
        int indexOfUcSeat;
        int countItemOfSeat;
        int flagUcSeatClick;
        int numSeat;
        int PRINTBILL = 2;
        private int PgSize = 21;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;
        List<SeatModel> lstSeat = new List<SeatModel>();
        private int PgSizeModi = 21;
        private int CurrentPageIndexModi = 1;
        private int TotalPageModi = 0;
        string colorName = "";
        UCMenuOfGroup ucMenuOfGroup;
        frmSecondDisplay frmse;
        List<PrinterModel> PrintData = new List<PrinterModel>();
        OrderDateModel OrderMain;
        private int flags;
        OrderDetailModel ItemMain = new OrderDetailModel();
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

        private IInvoiceService _invoiceService;
        private IInvoiceService InvoiceService
        {
            get { return _invoiceService ?? (_invoiceService = new InvoiceService()); }
            set { _invoiceService = value; }
        }

        private IPrinterService _printService;
        private IPrinterService PrintService
        {
            get { return _printService ?? (_printService = new PrinterService()); }
            set { _printService = value; }
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
            if (OrderMain != null)
                this.lblTable.Text = OrderMain.FloorID.ToString();
            frmse = new frmSecondDisplay();
            frmse.ShowCustomerDisplay();
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
            var margin = btnBack.Margin;
            margin.All = 1;
            btnBack.Margin = margin;
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

            var margin = btnBackSubItem.Margin;
            margin.All = 1;
            btnBackSubItem.Margin = margin;
            btnBackSubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBackSubItem.Click += btnBackSubItem_Click;
            flowLayoutPanel1.Controls.Add(btnBackSubItem);
        }

        void btnBackSubItem_Click(object sender, EventArgs e)
        {
            // this.LoadItemOfGroup();
            try
            {
                LoadItemOfGroup(CategoryIDMain, CurrentPageIndex);
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
            var margin = btnOpenItemItem.Margin;
            margin.All = 1;
            btnOpenItemItem.Margin = margin;
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
            btnOpenItemSubItem.FlatStyle = FlatStyle.Flat;
            var margin = btnOpenItemSubItem.Margin;
            margin.All = 1;
            btnOpenItemSubItem.Margin = margin;
            btnOpenItemSubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOpenItemSubItem.Click += btnOpenItemSubItem_Click;
            flowLayoutPanel1.Controls.Add(btnOpenItemSubItem);
        }

        void btnOpenItemSubItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOpenItem frm = new frmOpenItem(1);
                if (frmOpacity.ShowDialog(this, frm) == System.Windows.Forms.DialogResult.OK)
                {
                    //Order.Item itemTemp = new Order.Item();
                    OrderDetailModel itemTemp = new OrderDetailModel();

                    OrderOpenItemModel OpenItem = new OrderOpenItemModel();
                    OpenItem.ItemNameDesc = frm.items.ProductName;
                    OpenItem.ItemNameShort = frm.items.ProductName;
                    OpenItem.UnitPrice = Convert.ToInt32(frm.items.Price);
                    int resul = OrderService.InsertOpenItem(OpenItem);
                    if (resul == 1)
                    {
                        frm.items.DynID = OrderService.LastDynID();
                        frm.items.OrderID = OrderMain.OrderID;
                        frm.items.Qty = 1;
                        if (seat > 0)
                            frm.items.Seat = seat;
                        if (flagUcSeatClick == 1)
                            frm.items.Seat = numSeat;
                        itemTemp = frm.items;
                        OrderDetailModifireModel modifierTemp = new OrderDetailModifireModel();
                        modifierTemp.ModifireName = itemTemp.ProductName;
                        modifierTemp.Price = itemTemp.Price;
                        modifierTemp.OrderID = itemTemp.OrderID;
                        modifierTemp.ProductID = itemTemp.ProductID;
                        modifierTemp.DynID = itemTemp.DynID;
                        modifierTemp.Seat = itemTemp.Seat;
                        modifierTemp.ChangeStatus = 1;

                        OrderMain.addModifierToList(modifierTemp, keyItemTemp);
                        UCItemModifierOfMenu ucItemModifierOfMenu = new UCItemModifierOfMenu();
                        this.addModifreToOrder(ucItemModifierOfMenu, modifierTemp);
                    }
                    //Order.Modifier modifierTemp = new Order.Modifier();

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
            if (this.CurrentPageIndexModi > 1)
            {
                CurrentPageIndexModi--;
                LoadModifrieOfMenu(CurrentPageIndex);
            }
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
            if (this.CurrentPageIndexModi < this.TotalPageModi)
            {
                CurrentPageIndexModi++;
                LoadModifrieOfMenu(CurrentPageIndexModi);
            }
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
            var margin = btnBackItem.Margin;
            margin.All = 1;
            btnBackItem.Margin = margin;
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
            var margin = btnNextItem.Margin;
            margin.All = 1;
            btnNextItem.Margin = margin;
            btnNextItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnNextItem.Click += btnNextItem_Click;
            flowLayoutPanel1.Controls.Add(btnNextItem);
        }
        private void CalculateTotalPages(int rowCount)
        {

            this.TotalPage = rowCount / PgSize;
            if (rowCount % PgSize > 0) // if remainder is more than  zero 
            {
                this.TotalPage += 1;
            }
        }

        private void CalculateTotalPagesModi(int rowCount)
        {

            this.TotalPageModi = rowCount / PgSizeModi;
            if (rowCount % PgSizeModi > 0) // if remainder is more than  zero 
            {
                this.TotalPageModi += 1;
            }
        }
        void btnNextItem_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.TotalPage)
            {
                CurrentPageIndex++;
                LoadItemOfGroup(CategoryIDMain, CurrentPageIndex);
            }
        }

        void btnBackItem_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                CurrentPageIndex--;
                LoadItemOfGroup(CategoryIDMain, CurrentPageIndex);
            }
        }

        void btnOpenItemItem_Click(object sender, EventArgs e)
        {
            frmOpenItem frm = new frmOpenItem(0);
            if (frmOpacity.ShowDialog(this, frm) == System.Windows.Forms.DialogResult.OK)
            {
                int resul = 0;
                OrderOpenItemModel OpenItem = new OrderOpenItemModel();
                OpenItem.ItemNameDesc = frm.items.ProductName;
                OpenItem.ItemNameShort = frm.items.ProductName;
                OpenItem.UnitPrice = Convert.ToInt32(frm.items.Price);
                OpenItem.PrintType = frm.items.Printer;
                OpenItem.PrinterID = frm.items.Printer;
                resul = OrderService.InsertOpenItem(OpenItem);
                if (resul == 1)
                {
                    frm.items.DynID = OrderService.GetIDLastInsertOpenItem();
                    frm.items.OrderID = OrderMain.OrderID;
                    frm.items.Qty = 1;
                    if (seat > 0)
                        frm.items.Seat = seat;
                    if (flagUcSeatClick == 1)
                        frm.items.Seat = numSeat;
                    frm.items.ChangeStatus = 1;
                    OrderMain.addItemToList(frm.items);
                    addOrder(frm.items);
                    lblSubtotal.Text = "$" + money.Format2(OrderMain.SubTotal().ToString());
                }
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
                frmOpenItem frm = new frmOpenItem(1);
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

        private void OrderCompleted()
        {
            frmMessager frm = new frmMessager("Order", "Order Completed");
            frmOpacity.ShowDialog(this, frm);
        }
        void ucMenuOfGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderMain.Status == 1)
                {
                    OrderCompleted();
                }
                else
                {
                    ucMenuOfGroup = (UCMenuOfGroup)sender;
                    OrderDetailModel item = new OrderDetailModel();
                    if (seat > 0)
                        item.Seat = seat;
                    ProductionModel itemProduct = (ProductionModel)ucMenuOfGroup.Tag;
                    colorName = itemProduct.Color;
                    item.ProductName = itemProduct.ProductNameSort;
                    item.Price = Convert.ToDouble(itemProduct.CurrentPrice);
                    item.ProductID = itemProduct.ProductID;
                    item.Qty = 1;
                    item.OrderID = OrderMain.OrderID;
                    if (flagUcSeatClick == 1)
                        item.Seat = numSeat;
                    if (OrderMain.IsLoadFromData)
                        item.ChangeStatus = 1;

                    //ProductionModel itemPrint = new ProductionModel();
                    //itemPrint = ProductService.GetPrinterType(itemProduct.ProductID);
                    //if (itemPrint != null)
                    //{
                    //    item.Printer = itemPrint.Printer;
                    //    item.PrintJob = itemPrint.PrinterJob;
                    //}
                    //else
                    //{
                    //    itemPrint = ProductService.GetPrinterTypeByCate(itemProduct.CategoryID);
                    //    if (itemPrint != null)
                    //    {;
                    //        item.Printer = itemPrint.Printer;
                    //        item.PrintJob = itemPrint.PrinterJob;
                    //    }
                    //}
                    var dataPrint = ProductService.GetListPrintJob(itemProduct.ProductID);
                    foreach (PrinteJobDetailModel itemPrint in dataPrint)
                    {
                        PrinteJobDetailModel p = new PrinteJobDetailModel();
                        p.ProductID = itemPrint.ProductID;
                        p.PrinterID = itemPrint.PrinterID;
                        item.ListPrintJob.Add(p);
                    }
                    OrderMain.addItemToList(item);
                    addOrder(item);
                    lblSubtotal.Text = "$" + money.Format2(OrderMain.SubTotal().ToString());
                    ucMenuOfGroup.lblNameMenuOfGroup.BackColor = Color.FromArgb(0, 122, 204);
                    timeChangeColor.Enabled = true;
                    timeChangeColor.Start();
                }
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
                ucOrder.lblQuanityItem.Text = "1";
                ucOrder.Tag = items;
                ucOrder.lblPriceItem.Text = money.Format2(items.Price.ToString());
                ucOrder.Click += ucOrder_Click;
                LogPOS.WriteLog("addOrder::::::::::Item::::::" + items.ProductName + ":::::" + items.Price);
                ucOrder.Width = flpOrder.Width;
                flpOrder.Controls.Add(ucOrder);
                if (flagUcSeatClick > 0)
                {
                    if (indexOfUcSeat == 0)
                        flpOrder.Controls.SetChildIndex(ucOrder, 1 + countItemOfSeat);
                    else
                        flpOrder.Controls.SetChildIndex(ucOrder, indexOfUcSeat + countItemOfSeat);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("addOrder:::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void LoadModifrieOfMenu(int Page)
        {
            var listModifire = ModifireService.GetModifireByProduct(ItemMain.ProductID, Page);
            if (listModifire.Count() > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                this.AddButtonBackSubItem();
                keyItemTemp = ItemMain.KeyItem;
                int Row = 1;
                foreach (ModifireModel Modififer in listModifire)
                {
                    Row++;
                    UCModifierOfMenu ucModifierOfMenu = new UCModifierOfMenu();
                    ucModifierOfMenu.lblModifierOfMenu.Text = Modififer.ModifireName;
                    ucModifierOfMenu.lblModifierOfMenu.BackColor = Color.FromName(Modififer.Color);
                    ucModifierOfMenu.Tag = Modififer;
                    ucModifierOfMenu.Click += ucModifierOfMenu_Click;
                    flowLayoutPanel1.Controls.Add(ucModifierOfMenu);
                }
                CalculateTotalPagesModi(Row);
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
        void ucOrder_Click(object sender, EventArgs e)
        {
            try
            {
                UCOrder ucOder = (UCOrder)sender;
                OrderDetailModel item = (OrderDetailModel)ucOder.Tag;
                ItemMain = item;
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
                LoadModifrieOfMenu(CurrentPageIndexModi);
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
                if (modifier.Price > 0)
                {
                    modifier.Price = 0;
                }
                else
                {

                    modifier.Price = Convert.ToDouble(itemsModifre.CurrentPrice);
                }

                modifier.ModifireID = itemsModifre.ModifireID;
                modifier.OrderID = OrderMain.OrderID;
                modifier.Qty = 1;
                if (OrderMain.IsLoadFromData)
                    modifier.ChangeStatus = 1;
                OrderMain.addModifierToList(modifier, keyItemTemp);
                UCItemModifierOfMenu ucItemModifierOfMenu = new UCItemModifierOfMenu();
                ucItemModifierOfMenu.Tag = modifier;
                ucItemModifierOfMenu.Click += ucItemModifierOfMenu_Click;
                addModifreToOrder(ucItemModifierOfMenu, modifier);
                lblSubtotal.Text = money.Format2(OrderMain.SubTotal());
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucModifierOfMenu_Click:::::::::::::::::::::::::" + ex.Message);
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
        private void addModifreToOrder(UCItemModifierOfMenu ucMdifireOfMenu, OrderDetailModifireModel modifier)
        {
            try
            {

                ucMdifireOfMenu.lblNameItenModifierMenu.Text = modifier.ModifireName;
                ucMdifireOfMenu.lblPriceItenModifierMenu.Text = money.Format2(modifier.Price.ToString());
                ucMdifireOfMenu.lblQtyItenModifierMenu.Text = modifier.Qty.ToString();
                ucMdifireOfMenu.Width = flpOrder.Width;
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
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("loadCategoryOfCatalogue:::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void LoadItemOfGroup(int CategoryId, int PageSki)
        {
            try
            {
                this.flowLayoutPanel1.Controls.Clear();
                this.AddButtonBackItem();
                int keyItem = 1;
                var dataPrduct = ProductService.GetProdutcByCategory(CategoryId, PageSki);
                int RowCount = 1;

                foreach (ProductionModel itemProductionModel in dataPrduct)
                {
                    keyItem++;
                    RowCount++;
                    UCMenuOfGroup ucMenuOfGroup = new UCMenuOfGroup();
                    ucMenuOfGroup.lblNameMenuOfGroup.Text = itemProductionModel.ProductNameSort;
                    ucMenuOfGroup.Tag = itemProductionModel;
                    ucMenuOfGroup.lblNameMenuOfGroup.BackColor = Color.FromName(itemProductionModel.Color);
                    ucMenuOfGroup.Click += ucMenuOfGroup_Click;
                    flowLayoutPanel1.Controls.Add(ucMenuOfGroup);

                }
                CalculateTotalPages(RowCount);
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
                LoadItemOfGroup(item.CategoryID, CurrentPageIndex);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucMenuOrder_Click:::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.Close();
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

                if (frmOpacity.ShowDialog(this, frm) == System.Windows.Forms.DialogResult.OK)
                {

                    seat = frm.NumberSeat;
                    //OrderMain.addSeat(seat);
                    SeatModel seatAdd = new SeatModel();
                    seatAdd.Seat = seat;
                    lstSeat.Add(seatAdd);
                    OrderMain.ListSeatOfOrder.Add(seatAdd);
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
                string[] splitStr = textSeat.Split(' ');
                numSeat = Convert.ToInt32(splitStr[1]);
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
            bool isStopVoid = false;
            int countChangeStatus = 0;
            try
            {
                if (OrderMain.Status == 1)
                {
                    OrderCompleted();
                }
                else
                {
                    UCOrder ucOrder;
                    UCItemModifierOfMenu ucItemModifireOfMenu;
                    OrderDetailModifireModel modifier = null;
                    OrderDetailModel items = null;
                    UCSeat ucSeat = null;
                    int CountIndexitemOfSeat = 0;
                    for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                    {
                        if (OrderMain.ListOrderDetail[i].ChangeStatus == 0)
                            countChangeStatus++;

                    }
                    if (countChangeStatus == 1)
                        isStopVoid = true;
                    if (!isStopVoid)
                    {
                        if (flagClick == 1)
                        {

                            ucItemModifireOfMenu = (UCItemModifierOfMenu)flpOrder.Controls[indexControl];
                            modifier = (OrderDetailModifireModel)ucItemModifireOfMenu.Tag;
                        }

                        else
                        {
                            if (numSeat > 0)
                            {
                                ucSeat = (UCSeat)flpOrder.Controls[indexOfUcSeat];
                            }
                            else
                            {
                                ucOrder = (UCOrder)flpOrder.Controls[indexControl];
                                items = (OrderDetailModel)ucOrder.Tag;
                            }
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

                                    //OrderMain.ListOrderDetail.RemoveAt(i);
                                    OrderMain.ListOrderDetail[i].ChangeStatus = 2;
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
                                    if (modifier.KeyModi == OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].KeyModi && modifier.ModifireID == OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireID)
                                    {
                                        //OrderMain.ListOrderDetail[i].ListOrderDetailModifire.RemoveAt(j);
                                        OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ChangeStatus = 2;
                                    }
                                }
                            }
                            flpOrder.Controls.RemoveAt(indexControl);

                        }
                        if (numSeat > 0)
                        {
                            for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                            {

                                if (numSeat == OrderMain.ListOrderDetail[i].Seat && OrderMain.ListOrderDetail[i].ChangeStatus != 2)
                                {
                                    CountIndexitemOfSeat++;
                                    OrderMain.ListOrderDetail[i].ChangeStatus = 2;
                                }
                            }
                            for (int remove = 0; remove < OrderMain.ListSeatOfOrder.Count; remove++)
                            {
                                if (OrderMain.ListSeatOfOrder[remove].Seat == numSeat)
                                {
                                    OrderMain.ListSeatOfOrder[remove].ChangeStatus = 2;
                                }
                            }
                            for (int count = CountIndexitemOfSeat + indexOfUcSeat; count > indexOfUcSeat; count--)
                            {
                                flpOrder.Controls.RemoveAt(count);
                            }

                            flpOrder.Controls.RemoveAt(indexOfUcSeat);
                            numSeat = 0;
                        }
                        else
                        {
                            //flpOrder.Controls.RemoveAt(indexControl);
                            flagClick = 0;
                        }
                        lblSubtotal.Text = "$" + money.Format2(OrderMain.SubTotalVoid());
                        if (OrderMain.IsLoadFromData)
                            OrderService.VoidItemHistory(OrderMain);
                    }
                    else
                    {

                        frmMessager frm = new frmMessager("Void Order", "Can not void");
                        frmOpacity.ShowDialog(this, frm);

                    }
                }
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
                if (OrderMain.Status == 1)
                    OrderCompleted();
                else
                {
                    if (OrderMain.IsLoadFromData)
                    {
                        frmMessager frm = new frmMessager("Meesager", "Can not delete Order");
                        frmOpacity.ShowDialog(this, frm);
                    }
                    else
                    {
                        flpOrder.Controls.Clear();
                        OrderMain.ListOrderDetail.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btnVoidAll_Click::::::::::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private Boolean CheckSeatIsExits(int NoSeat)
        {
            Boolean flag = true;
            try
            {
                int ina = flowLayoutPanel1.Controls.Count;
                foreach (Control ctr in flowLayoutPanel1.Controls)
                {
                    if (ctr is UCSeat)
                    {
                        UCSeat ucSeat = (UCSeat)ctr;
                        if (Convert.ToInt32(ucSeat.Tag) == NoSeat)
                        {
                            flag = true;
                        }
                        else
                            flag = false;
                    }

                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmOrder:::::::::::::::::::::::::::::CheckSeatExits:::::::::::::::::::::" + ex.Message);

            }
            return flag;

        }
        public void LoadOrder(string TableID, int orderID)
        {
            indexControl = 1;
            try
            {
                OrderMain = new OrderDateModel();
                OrderMain = OrderService.GetOrderByTable(TableID, 0);
                OrderMain.ListOrderDetail = OrderMain.ListOrderDetail.OrderBy(x => x.OrderDetailID).ToList();
                if (OrderMain.TotalAmount > 0)
                {
                    lblSubtotal.Text = money.Format2(Convert.ToDouble(OrderMain.TotalAmount));
                }
                else
                {
                    lblSubtotal.Text = "0.0";
                }
                if (OrderMain.ListSeatOfOrder.Count > 0)
                {
                    OrderMain.IsLoadFromData = true;
                    lblSeat.Text = OrderMain.Seat.ToString();
                    lblStatus.Text = "OLD";
                    Boolean addSet;
                    foreach (SeatModel seat in OrderMain.ListSeatOfOrder)
                    {
                        addSet = true;
                        if (OrderMain.ListOrderDetail.Count > 0)
                        {
                            for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                            {
                                if (OrderMain.ListOrderDetail[i].Seat == seat.Seat)
                                {
                                    if (addSet)
                                    {
                                        UCSeat ucSeat = new UCSeat();
                                        ucSeat.lblSeat.Text = "Seat " + seat.Seat.ToString();
                                        ucSeat.Tag = seat.Seat;
                                        ucSeat.Click += ucSeat_Click;
                                        flpOrder.Controls.Add(ucSeat);
                                        indexControl = flpOrder.Controls.Count;
                                        addSet = false;
                                    }
                                    addOrder(OrderMain.ListOrderDetail[i]);
                                    indexControl++;
                                    for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                                    {
                                        UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                        uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                        uc.Click += ucItemModifierOfMenu_Click;
                                        addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                        indexControl++;
                                    }
                                }
                                else
                                {
                                    if (OrderMain.ListOrderDetail[i].Seat == 0)
                                    {
                                        addOrder(OrderMain.ListOrderDetail[i]);
                                        indexControl++;
                                        for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                                        {
                                            UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                            uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                            uc.Click += ucItemModifierOfMenu_Click;
                                            addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                            indexControl++;
                                        }
                                    }
                                }

                            }
                        }
                        else
                        {
                            OrderMain.FloorID = TableID;
                            OrderMain.ShiftID = UserLoginModel.ShiffID;
                            OrderMain.CreateBy = UserLoginModel.UserLoginInfo.StaffID;
                            OrderMain.UpdateBy = UserLoginModel.UserLoginInfo.StaffID;
                            int OrderID = OrderService.CountOrder() + 1;
                            OrderMain.OrderID = OrderID;
                            lblStatus.Text = "NEW";
                        }
                    }
                }
                else
                {
                    if (OrderMain.ListOrderDetail.Count > 0)
                    {
                        OrderMain.IsLoadFromData = true;
                        lblStatus.Text = "OLD";
                        for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                        {
                            addOrder(OrderMain.ListOrderDetail[i]);
                            indexControl++;
                            for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                            {
                                UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                uc.Click += ucItemModifierOfMenu_Click;
                                addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                indexControl++;
                            }
                        }
                    }
                    else
                    {
                        OrderMain.FloorID = TableID;
                        OrderMain.ShiftID = UserLoginModel.ShiffID;
                        OrderMain.CreateBy = UserLoginModel.UserLoginInfo.StaffID;
                        OrderMain.UpdateBy = UserLoginModel.UserLoginInfo.StaffID;
                        int OrderID = OrderService.CountOrder() + 1;
                        OrderMain.OrderID = OrderID;
                        lblStatus.Text = "NEW";
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmOrder:::::::::::::::::::::::LoadOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        public void LoadOrderTKA(string TableID, int ClientID)
        {
            indexControl = 1;
            try
            {
                OrderMain = new OrderDateModel();
                OrderMain = OrderService.GetOrderByTKA(TableID, "");
                OrderMain.isTKA = 1;
                lblSubtotal.Text = money.Format2(Convert.ToDouble(OrderMain.TotalAmount));
                if (OrderMain.Seat > 0)
                {
                    OrderMain.IsLoadFromData = true;
                    lblSeat.Text = OrderMain.Seat.ToString();
                    for (int seat = 1; seat <= OrderMain.Seat; seat++)
                    {
                        UCSeat ucSeat = new UCSeat();
                        ucSeat.lblSeat.Text = "Seat " + seat.ToString();
                        ucSeat.Click += ucSeat_Click;
                        flpOrder.Controls.Add(ucSeat);
                        indexControl = flpOrder.Controls.Count;
                        if (OrderMain.ListOrderDetail.Count > 0)
                        {
                            for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                            {
                                if (OrderMain.ListOrderDetail[i].Seat == seat)
                                {
                                    addOrder(OrderMain.ListOrderDetail[i]);
                                    indexControl++;
                                    for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                                    {
                                        UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                        uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                        uc.Click += ucItemModifierOfMenu_Click;
                                        addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                        indexControl++;
                                    }
                                }
                            }
                        }
                        else
                        {
                            OrderMain.FloorID = TableID + "" + (OrderService.CountOrder() + 1);
                            if (ClientID > 0)
                                OrderMain.ClientID = ClientID;
                            else
                                OrderMain.ClientID = 0;
                            OrderMain.ShiftID = UserLoginModel.ShiffID;
                            OrderMain.CreateBy = UserLoginModel.UserLoginInfo.StaffID;
                            OrderMain.UpdateBy = UserLoginModel.UserLoginInfo.StaffID;
                            int OrderID = OrderService.CountOrder() + 1;
                            OrderMain.OrderID = OrderID;
                        }
                    }
                }
                else
                {
                    if (OrderMain.ListOrderDetail.Count > 0)
                    {
                        OrderMain.IsLoadFromData = true;
                        for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                        {
                            addOrder(OrderMain.ListOrderDetail[i]);
                            indexControl++;
                            for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                            {
                                UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                uc.Click += ucItemModifierOfMenu_Click;
                                addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                indexControl++;
                            }
                        }
                    }
                    else
                    {
                        OrderMain.FloorID = TableID + "" + (OrderService.CountOrder() + 1);
                        OrderMain.ClientID = ClientID;
                        OrderMain.ShiftID = UserLoginModel.ShiffID;
                        OrderMain.CreateBy = UserLoginModel.UserLoginInfo.StaffID;
                        OrderMain.UpdateBy = UserLoginModel.UserLoginInfo.StaffID;
                        int OrderID = OrderService.CountOrder() + 1;
                        OrderMain.OrderID = OrderID;
                    }
                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("LoadOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderMain == null)
                {

                }
                else
                {
                    GetListPrinter();
                    if (OrderMain.Status == PRINTBILL)
                    {
                        OrderCompleted();
                    }
                    else
                    {
                        if (OrderMain.ListOrderDetail.Count > 0)
                        {
                            int result = 0;
                            OrderMain.PrintType = 1;

                            result = OrderService.InsertOrder(OrderMain);
                            if (result == 1)
                            {
                                PrinterServer printServer = new PrinterServer();
                                printServer.PrintData(OrderMain, PrintData);
                                if (OrderMain.isTKA == 1)
                                {
                                    frmTakeAway frm = new frmTakeAway();
                                    //CallBackStatusOrderTKA(OrderMain);
                                    //frm.Show();
                                    this.Close();
                                }
                                else
                                {
                                    //CallBackStatusOrder(OrderMain);
                                    CallBackStatusOrderCancel();
                                    this.Close();
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("btnSendOrder_Click::::::::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float l_y = 0;
            PrintOrder(e, l_y);
        }
        private float PrintOrder(System.Drawing.Printing.PrintPageEventArgs e, float l_y)
        {
            l_y = posPrinter.DrawString("Date :" + DateTime.Now.ToShortDateString(), e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
            l_y = posPrinter.DrawString("Table:" + OrderMain.FloorID, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
            l_y = posPrinter.DrawString("No # Seat:" + OrderMain.Seat, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);

            l_y += posPrinter.GetHeightPrinterLine() / 10;

            for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
            {
                float yStart = l_y;
                if (OrderMain.ListOrderDetail[i].ChangeStatus == 2)
                {
                    posPrinter.DrawString("--Remove  " + OrderMain.ListOrderDetail[i].ProductName, e, new Font("Arial", 10), l_y, 1);
                }
                else
                {
                    posPrinter.DrawString(OrderMain.ListOrderDetail[i].ProductName, e, new Font("Arial", 10), l_y, 1);
                }
                l_y = posPrinter.DrawString(OrderMain.ListOrderDetail[i].Qty.ToString(), e, new Font("Arial", 10), l_y, 2);
                posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].Price.ToString()), e, new Font("Arial", 10), yStart, 3);

                if (OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count > 0)
                {
                    for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                    {
                        if (OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ChangeStatus == 2)
                        {
                            posPrinter.DrawString("---Remove  " + OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 10), l_y, 1);
                        }
                        else
                        {
                            posPrinter.DrawString("--" + OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);

                        }
                        l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].Price.ToString()), e, new Font("Arial", 10), l_y, 3);
                    }
                }
            }
            posPrinter.DrawLine("", new Font("Arial", 10), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
            l_y = posPrinter.DrawString("", e, new Font("Arial", 10), l_y, 1);
            l_y += posPrinter.GetHeightPrinterLine() / 10;
            posPrinter.DrawString("Total:", e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
            l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.SubTotal()), e, new Font("Arial", 10, FontStyle.Bold), l_y, 3);

            return l_y;
        }

        private void btnPayMent_Click(object sender, EventArgs e)
        {
            //flags = WinAPI.AW_ACTIVATE | WinAPI.AW_HOR_POSITIVE;
            try
            {
                if (OrderMain.Status == 1)
                    OrderCompleted();
                else
                {
                    if (OrderMain.ListOrderDetail.Count > 0)
                    {
                        frmse.BindOrder(OrderMain);
                        frmPayMent frm = new frmPayMent(OrderMain, 1000, 131073);
                        if (frmOpacity.ShowDialog(this, frm) == System.Windows.Forms.DialogResult.OK)
                        {
                            GetListPaymentPrinter();
                            int result = 0;
                            OrderMain = frm.OrderMain;
                            OrderMain.PrintType = 2;
                            result = InvoiceService.InsertInvoice(OrderMain);

                            if (result == 1)
                            {
                                if (OrderMain.isNoPrintBill == 1)
                                {
                                    if (OrderMain.isTKA == 1)
                                    {
                                        this.Close();
                                        frmTakeAway frmTKA = new frmTakeAway();
                                        frmTKA.Show();

                                    }
                                    else
                                    {
                                        CallBackStatusOrderCancel();
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    PrinterServer printServer = new PrinterServer();
                                    printServer.PrintData(OrderMain, PrintData);
                                    if (OrderMain.isTKA == 1)
                                    {
                                        this.Close();
                                        frmTakeAway frmTKA = new frmTakeAway();
                                        frmTKA.Show();

                                    }
                                    else
                                    {
                                        frmse.fullScreen();
                                        CallBackStatusOrderCancel();
                                        this.Close();
                                    }
                                }
                            }
                           
                        }
                    }
                    else
                    {
                        frmMessager frm = new frmMessager("PayMent", "Order empty");
                        frmOpacity.ShowDialog(this, frm);
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmOrder:::::::::::::::::::::::btnPayMent_Click::::::::::::::::;" + ex.Message);
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            btnOpenItemItem_Click(sender, e);
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (OrderMain.isPrevOrder == 1)
            {
                GetListPaymentPrinter();
                OrderMain.PrintType = 2;
                PrinterServer print = new PrinterServer();
                print.PrintData(OrderMain, PrintData);
            }
            else
            {
                if (OrderMain.ListOrderDetail.Count > 0)
                {
                    int result = OrderService.UpdateOrder(OrderMain);
                    if (result == 1)
                    {

                        CallBackStatusOrderCancel();
                        this.Close();
                    }
                }
                else
                {
                    frmMessager frm = new frmMessager("Print Bill", "Order is empty");
                    frmOpacity.ShowDialog(this, frm);
                }
            }
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            GetListPrinter();
            if (OrderMain.isPrevOrder == 1)
                OrderCompleted();
            else
            {
                OrderMain.PrintType = 1;
                OrderMain.IsPrePrint = true;
                OrderMain.IsLoadFromData = false;
                if (OrderMain.ListOrderDetail.Count > 0)
                {
                    PrinterServer printServer = new PrinterServer();
                    printServer.PrintData(OrderMain, PrintData);
                }
                else
                {
                    frmMessager frm = new frmMessager("Print Bill", "Order is empty");
                    frmOpacity.ShowDialog(this, frm);
                }
            }
        }
        public void LoadOrderPrev(int orderID)
        {
            indexControl = 1;
            try
            {
                OrderMain = new OrderDateModel();
                OrderMain = OrderService.GetListOrderPrevOrder("", orderID, DateTime.Now.Date);
                lblSubtotal.Text = money.Format2(Convert.ToDouble(OrderMain.TotalAmount));
                if (OrderMain.Seat > 0)
                {
                    OrderMain.IsLoadFromData = true;
                    lblSeat.Text = OrderMain.Seat.ToString();
                    lblStatus.Text = "OLD";
                    for (int seat = 1; seat <= OrderMain.Seat; seat++)
                    {
                        UCSeat ucSeat = new UCSeat();
                        ucSeat.lblSeat.Text = "Seat " + seat.ToString();
                        ucSeat.Click += ucSeat_Click;
                        flpOrder.Controls.Add(ucSeat);
                        indexControl = flpOrder.Controls.Count;
                        if (OrderMain.ListOrderDetail.Count > 0)
                        {
                            for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                            {
                                if (OrderMain.ListOrderDetail[i].Seat == seat)
                                {
                                    addOrder(OrderMain.ListOrderDetail[i]);
                                    indexControl++;
                                    for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                                    {
                                        UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                        uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                        uc.Click += ucItemModifierOfMenu_Click;
                                        addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                        indexControl++;
                                    }
                                }
                            }
                        }

                    }
                }
                else
                {
                    if (OrderMain.ListOrderDetail.Count > 0)
                    {
                        OrderMain.IsLoadFromData = true;
                        lblStatus.Text = "OLD";
                        for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                        {
                            addOrder(OrderMain.ListOrderDetail[i]);
                            indexControl++;
                            for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                            {
                                UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                uc.Click += ucItemModifierOfMenu_Click;
                                addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                indexControl++;
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("LoadOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void btnPrevOrder_Click(object sender, EventArgs e)
        {
            try
            {

                frmPrevOrder frm = new frmPrevOrder();
                if (frmOpacity.ShowDialog(this, frm) == System.Windows.Forms.DialogResult.OK)
                {
                    LoadOrderPrev(frm.OrderID);
                    OrderMain.isPrevOrder = 1;
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmOrder:::::::::::::::::::::::::btnPrevOrder_Click::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void GetListPrinter()
        {
            PrintData.Clear();
            var listPrinter = PrintService.GetListPrinterMapping();
            foreach (PrinterModel item in listPrinter)
            {
                PrinterModel print = new PrinterModel();
                print.PrinterName = item.PrinterName;
                print.PrintName = item.PrintName;
                print.PrinterType = item.PrinterType;
                print.Header = item.Header;
                print.ID = item.ID;
                PrintData.Add(print);
            }
        }
        private void GetListPaymentPrinter()
        {
            PrintData.Clear();
            var listPrinter = PrintService.GetListPaymentprinter();

            foreach (PrinterModel item in listPrinter)
            {
                PrinterModel print = new PrinterModel();
                print.PrinterName = item.PrinterName;
                print.PrintName = item.PrintName;
                print.PrinterType = item.PrinterType;
                print.ID = item.ID;
                PrintData.Add(print);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderMain.ListOrderDetail.Count > 0)
                {
                    frmConfirm frm = new frmConfirm("Order", "Are You sure CANCEL ORDER???");
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        int result = OrderService.CancelOrder(OrderMain);
                        if (result == 1)
                        {
                            CallBackStatusOrderCancel();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmOrder:::::::::::::::::btnCancelOrder_Click:::::::::::::::::::" + ex.Message);
            }
        }

        private void ModifireItemInOrder(OrderDateModel Order, OrderDetailModel Item)
        {
            for (int i = 0; i < Order.ListOrderDetail.Count; i++)
            {
                if (Order.ListOrderDetail[i].KeyItem == Item.KeyItem)
                {
                    Order.ListOrderDetail[i].Price = Item.Price;
                }
            }
        }
        private void btnPrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderMain.Status == PRINTBILL)
                    OrderCompleted();
                else
                {
                    frmChangePrice frm = new frmChangePrice(ItemMain);
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        ItemMain.Price = frm.ItemMain.Price;
                        foreach (Control ctr in flpOrder.Controls)
                        {
                            if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                            {
                                UCOrder uc = (UCOrder)ctr;
                                OrderDetailModel itemUc = (OrderDetailModel)uc.Tag;
                                ModifireItemInOrder(OrderMain, ItemMain);
                                uc.lblPriceItem.Text = money.Format2(Convert.ToDouble(ItemMain.Price));
                            }
                        }
                        OrderMain.SubTotal();
                        lblSubtotal.Text = "$" + money.Format2(OrderMain.SubTotal().ToString());

                    }

                }
            }

            catch (Exception ex)
            {
                LogPOS.WriteLog("frmOrder::::::::::::::::::btnPrice_Click::::::::::::::::::" + ex.Message);
            }
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            frmNote frm = new frmNote();
            if (frmOpacity.ShowDialog(this, frm) == System.Windows.Forms.DialogResult.OK)
            {
                OrderMain.Note = frm.Note;
                OrderMain.PrinterNote = frm.PrinterNote;
            }
        }

        private void timeChangeColor_Tick(object sender, EventArgs e)
        {
            ucMenuOfGroup.lblNameMenuOfGroup.BackColor = Color.FromName(colorName);
            timeChangeColor.Stop();
        }

        private void ucSendOrder_Click(object sender, EventArgs e)
        {

        }

        private void ucSendOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
