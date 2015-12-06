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
using POSEZ2U.Class;
using SystemLog;
using ServicePOS;
using ModelPOS;
using ServicePOS.Model;
using Printer;
namespace POSEZ2U
{
    public partial class frmOrder : Form
    {
        Order OrderMain;
        public frmOrder(Order _orderMain)
        {
            InitializeComponent();
            OrderMain = _orderMain;
            posPrinter.printDocument.PrintPage += printDocument_PrintPage;
        }


        POSPrinter posPrinter = new POSPrinter();
        MoneyFortmat money = new MoneyFortmat(1);
        CatalogueModel CatalogueMain;
        int CategoryIDMain;
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

        List<Order.Item> Listitem = new List<Order.Item>();
        List<Order.Modifier> Listmodifier = new List<Order.Modifier>();
        int keyItemTemp;
        int indexControl;
        int seat = 0;
        int flagClick = 0;
        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadMenuGroup();
            //LoadMenuOfGroup();
            this.SelectGroupMenu();
            this.lblTable.Text = OrderMain.TableId;
        }
        private void LoadMenuOfGroup()
        {
            string[] str = { "Com", "Pho", "Mi", "Bun", "Hu Tieu", "Chao", "Xao", "Salad", "Lau", "Bun Nuoc", "Them", "Tre em" };
            foreach (string strGroup in str)
            {
                UCMenuOrdercs ucMenuOrder = new UCMenuOrdercs();
                ucMenuOrder.lblNameGroup.Text = strGroup;
                ucMenuOrder.lblCount.Text = "11";
                ucMenuOrder.Tag = strGroup;
                ucMenuOrder.Click += ucMenuOrder_Click;
                flowLayoutPanel1.Controls.Add(ucMenuOrder);
            }

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
            frmOpenItem frm = new frmOpenItem();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Order.Item itemTemp = new Order.Item();
                itemTemp = frm.items;
                Order.Modifier modifierTemp = new Order.Modifier();
                modifierTemp.ModifierName = itemTemp.ItemName;
                modifierTemp.Price = itemTemp.Price;
                OrderMain.addModifierToList(modifierTemp, keyItemTemp);
                UCItemModifierOfMenu ucItemModifierOfMenu = new UCItemModifierOfMenu();
                this.addModifreToOrder(ucItemModifierOfMenu, modifierTemp);
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
                lblSubtotal.Text = money.Format2(OrderMain.SubTotal().ToString());
            }
        }

        void btnBack_Click(object sender, EventArgs e)
        {

            //Work Here 
            this.flowLayoutPanel1.Controls.Clear();
            loadCategoryOfCatalogue(CatalogueMain.CatalogueID);

        }

        void btn_Click(object sender, EventArgs e)
        {
            frmOpenItem frm = new frmOpenItem();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OrderMain.addItemToList(frm.items);
                addOrder(frm.items);
                lblSubtotal.Text = money.Format2(OrderMain.SubTotal().ToString());
            }
        }
        private void LoadMenuGroup()
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
                Order.Item item = new Order.Item();
                if (seat > 0)
                    item.Seat = seat;
                ProductionModel itemProduct = (ProductionModel)ucMenuOfGroup.Tag;
                item.ItemName = itemProduct.ProductNameSort;
                item.Price = Convert.ToDouble(itemProduct.CurrentPrice);
                item.ItemId = itemProduct.ProductID;
                item.Qunatity = 1;
                OrderMain.addItemToList(item);
                addOrder(item);
                lblSubtotal.Text = money.Format2(OrderMain.SubTotal().ToString());
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucMenuOfGroup_Click:::::::::::::::::::::::::::::" + ex.Message);
            }

        }
        private void addOrder(Order.Item items)
        {
            try
            {
                UCOrder ucOrder = new UCOrder();
                ucOrder.lblNameItem.Text = items.ItemName;
                ucOrder.Tag = items;
                ucOrder.lblPriceItem.Text = money.Format2(items.Price);
                ucOrder.Click += ucOrder_Click;
                LogPOS.WriteLog("Item::::::" + items.ItemName + ":::::" + items.Price);
                flpOrder.Controls.Add(ucOrder);
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
                Order.Item item = (Order.Item)ucOder.Tag;
                indexControl = flpOrder.Controls.GetChildIndex(ucOder);
                var listModifire = ModifireService.GetModifireByProduct(item.ItemId);
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
                Order.Modifier modifier = new Order.Modifier();
                ModifireModel itemsModifre = (ModifireModel)ucModifierOfMenu.Tag;
                modifier.ModifierName = itemsModifre.ModifireName;
                modifier.Price = Convert.ToDouble(itemsModifre.CurrentPrice);
                modifier.ModifireId = itemsModifre.ModifireID;
                OrderMain.addModifierToList(modifier, keyItemTemp);
                UCItemModifierOfMenu ucItemModifierOfMenu = new UCItemModifierOfMenu();
                ucItemModifierOfMenu.Tag = modifier;
                ucItemModifierOfMenu.Click += ucItemModifierOfMenu_Click;
                addModifreToOrder(ucItemModifierOfMenu, modifier);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucModifierOfMenu_Click:::::::::::::::::::::::::" + ex.Message);
            }

        }

        void ucItemModifierOfMenu_Click(object sender, EventArgs e)
        {
            flagClick = 1;
            UCItemModifierOfMenu ucItemModifierOfMenu = (UCItemModifierOfMenu)sender;
            indexControl = flpOrder.Controls.GetChildIndex(ucItemModifierOfMenu);
        }
        private void addModifreToOrder(UCItemModifierOfMenu ucMdifireOfMenu, Order.Modifier modifier)
        {
            ucMdifireOfMenu.lblNameItenModifierMenu.Text = modifier.ModifierName;
            ucMdifireOfMenu.lblPriceItenModifierMenu.Text = money.Format2(modifier.Price);
            flpOrder.Controls.Add(ucMdifireOfMenu);
            flpOrder.Controls.SetChildIndex(ucMdifireOfMenu, indexControl + 1);
        }

        void AddControlToFlowLayoutPanel(FlowLayoutPanel flowlayoutpanel, Control ctrl)
        {
            flowlayoutpanel.Controls.Add(ctrl);

            // SetChildIndex does the trick
            if (flowlayoutpanel.Controls.Count > 2)
                flowlayoutpanel.Controls.SetChildIndex(ctrl, flowlayoutpanel.Controls.Count - 2);
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

        private void LoadItemOfGroup(int CategoryId)
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
            Application.Exit();
        }

        private void btnAddSeat_Click(object sender, EventArgs e)
        {
            frmAddSeat frm = new frmAddSeat();

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                seat = frm.NumberSeat;
                OrderMain.addSeat(seat);
                UCSeat ucSeat = new UCSeat();
                ucSeat.lblSeat.Text = "Seat " + seat;
                lblSeat.Text = seat.ToString();
                flpOrder.Controls.Add(ucSeat);

            }

        }

        private void flpOrder_Scroll(object sender, ScrollEventArgs e)
        {
            // flpOrder.Controls.OfType<VScrollBar>().First().Width = 20; 
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            UCOrder ucOrder;
            UCItemModifierOfMenu ucItemModifireOfMenu;
            Order.Modifier modifier = null;
            Order.Item items = null;
            if (flagClick == 1)
            {

                ucItemModifireOfMenu = (UCItemModifierOfMenu)flpOrder.Controls[indexControl];
                modifier = (Order.Modifier)ucItemModifireOfMenu.Tag;
            }
            else
            {
                ucOrder = (UCOrder)flpOrder.Controls[indexControl];
                items = (Order.Item)ucOrder.Tag;
            }
            if (items != null)
            {
                for (int i = 0; i < OrderMain.ListItem.Count; i++)
                {
                    if (items.KeyItem == OrderMain.ListItem[i].KeyItem)
                    {
                        if (OrderMain.ListItem[i].ListModifier.Count > 0)
                        {
                            for (int indexOfModifier = OrderMain.ListItem[i].ListModifier.Count; indexOfModifier > 0; indexOfModifier--)
                            {
                                flpOrder.Controls.RemoveAt(indexControl + indexOfModifier);
                            }
                            OrderMain.ListItem[i].ListModifier.Clear();
                        }

                        OrderMain.ListItem.RemoveAt(i);
                    }

                }

                flpOrder.Controls.RemoveAt(indexControl);

            }
            if (modifier != null)
            {
                for (int i = 0; i < OrderMain.ListItem.Count; i++)
                {
                    for (int j = 0; j < OrderMain.ListItem[i].ListModifier.Count; j++)
                    {
                        if (modifier.KeyItem == OrderMain.ListItem[i].ListModifier[j].KeyItem)
                        {
                            OrderMain.ListItem[i].ListModifier.RemoveAt(j);
                        }
                    }
                }
                flpOrder.Controls.RemoveAt(indexControl);
                flagClick = 0;
            }
            lblSubtotal.Text = money.Format2(OrderMain.SubTotal());

        }

        private void btnVoidAll_Click(object sender, EventArgs e)
        {
            flpOrder.Controls.Clear();
            OrderMain.ListItem.Clear();
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            if (OrderMain.ListItem.Count >= 0)
            {
                posPrinter.printDocument.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
                posPrinter.printDocument.Print();
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
            l_y = posPrinter.DrawString("Table:" + OrderMain.TableId, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
            l_y = posPrinter.DrawString("No # Seat:" + OrderMain.Seat, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);

            l_y += posPrinter.GetHeightPrinterLine() / 10;

            for (int i = 0; i < OrderMain.ListItem.Count; i++)
            {
                float yStart = l_y;
                posPrinter.DrawString(OrderMain.ListItem[i].ItemName, e, new Font("Arial", 10), l_y, 1);
                l_y = posPrinter.DrawString(OrderMain.ListItem[i].Qunatity.ToString(), e, new Font("Arial", 10), l_y, 2);
                posPrinter.DrawString("$" + money.Format2(OrderMain.ListItem[i].Price.ToString()), e, new Font("Arial", 10), yStart, 3);

                if (OrderMain.ListItem[i].ListModifier.Count > 0)
                {
                    for (int j = 0; j < OrderMain.ListItem[i].ListModifier.Count; j++)
                    {
                        posPrinter.DrawString(OrderMain.ListItem[i].ListModifier[j].ModifierName, e, new Font("Arial", 10), l_y, 1);
                        l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListItem[i].ListModifier[j].Price.ToString()), e, new Font("Arial", 10), l_y, 3);

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
    }
}