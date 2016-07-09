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
using SystemLog;
using System.Drawing.Printing;

namespace POSEZ2U
{
    public partial class frmTransferTable : Form
    {
        public frmTransferTable()
        {
            InitializeComponent();
        }

        public delegate void SendTableNO(int TableNO);
        OrderDateModel OrderMain;
        OrderDateModel OrderSlpitOld = new OrderDateModel();
        OrderDateModel OrderSlpitNew = new OrderDateModel();
        List<PrinterModel> PrintData = new List<PrinterModel>();
        Printer.POSPrinter posPrinter = new Printer.POSPrinter();
        ConfigModel cofig = new ServicePOS.Model.ConfigModel();
        string tableOld;
        private IPrinterService _printService;
        private IPrinterService PrintService
        {
            get { return _printService ?? (_printService = new PrinterService()); }
            set { _printService = value; }
        }
        string Header = string.Empty;
        private IOrderService _orderService;
        private IOrderService OrderService
        {
            get { return _orderService ?? (_orderService = new OrderService()); }
            set { _orderService = value; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private IConfigService _configService;
        private IConfigService ConfigService
        {
            get { return _configService ?? (_configService = new ConfigService()); }
            set { _configService = value; }
        }
        private void TableNo(int ID)
        {
            if (lblNoTable.Text == "#")
                lblNoTable.Text = string.Empty;
            if (ID == -1)
            {
                if (lblNoTable.Text.Length > 0)
                     lblNoTable.Text= lblNoTable.Text.Remove(lblNoTable.Text.Length - 1, 1);
            }
            else
                lblNoTable.Text +=ID.ToString();
        }
        private void TableNoNew(int ID)
        {
            if (lblNewTable.Text == "#")
                lblNewTable.Text = string.Empty;
            if (ID == -1)
            {
                if (lblNewTable.Text.Length > 0)
                    lblNewTable.Text = lblNewTable.Text.Remove(lblNewTable.Text.Length - 1, 1);
            }
            else
                lblNewTable.Text += ID.ToString();
        }
        private void addOrder(OrderDetailModel items,FlowLayoutPanel flp)
        {
            try
            {
                
                UCOrder ucOrder = new UCOrder();
                ucOrder.lblNameItem.Text = items.ProductName;
                ucOrder.Tag = items;
                ucOrder.lblPriceItem.Text = items.Qty.ToString();
                ucOrder.Click += ucOrder_Click;
                LogPOS.WriteLog("addOrder::::::::::Item::::::" + items.ProductName + ":::::" + items.Price);
                ucOrder.Width = flp.Width;
                flp.Controls.Add(ucOrder);
               
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
                foreach (Control ctr in flpOldTable.Controls)
                {
                    if (ctr is UCOrder)
                    {
                        if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                        {
                            ctr.BackColor = Color.FromArgb(255, 255, 255);
                            ctr.ForeColor = Color.FromArgb(51, 51, 51);
                        }
                    }
                }
                ucOder.BackColor = Color.FromArgb(0, 102, 204);
                ucOder.ForeColor = Color.FromArgb(255, 255, 255);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmTransferTable::::::::::::::::::::::::addOrder::::::::::::::" + ex.Message);
            }
        }
        private void addModifreToOrder(UCItemModifierOfMenu ucMdifireOfMenu, OrderDetailModifireModel modifier,FlowLayoutPanel flp)
        {
            try
            {

                ucMdifireOfMenu.lblNameItenModifierMenu.Text = modifier.ModifireName;
                //ucMdifireOfMenu.lblPriceItenModifierMenu.Text = "1";
                ucMdifireOfMenu.Width = flpOldTable.Width;
                flp.Controls.Add(ucMdifireOfMenu);
                
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("addModifreToOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        public void LoadOrder(string TableID, int orderID,FlowLayoutPanel flp)
        {
            int indexControl = 1;
            try
            {
                
                OrderMain = OrderService.GetOrderByTable(TableID, 0);
                
                if (OrderMain.ListSeatOfOrder.Count>0)
                {
                    OrderMain.IsLoadFromData = true;
                    //lblSeat.Text = OrderMain.Seat.ToString();
                    foreach (SeatModel seat in OrderMain.ListSeatOfOrder)
                    {
                        UCSeat ucSeat = new UCSeat();
                        ucSeat.lblSeat.Text = "Seat " + seat.Seat.ToString();
                       // ucSeat.Click += ucSeat_Click;
                        flpOldTable.Controls.Add(ucSeat);
                        indexControl = flpOldTable.Controls.Count;
                        if (OrderMain.ListOrderDetail.Count > 0)
                        {
                            for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                            {
                                if (OrderMain.ListOrderDetail[i].Seat == seat.Seat)
                                {
                                    addOrder(OrderMain.ListOrderDetail[i],flp);
                                    indexControl++;
                                    for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                                    {
                                        UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                        uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                        //uc.Click += ucItemModifierOfMenu_Click;
                                        addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j],flp);
                                        indexControl++;
                                    }
                                }
                            }
                        }
                        else
                        {
                            OrderMain.FloorID = TableID;
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
                            addOrder(OrderMain.ListOrderDetail[i],flp);
                            indexControl++;
                            for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                            {
                                UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                //uc.Click += ucItemModifierOfMenu_Click;
                                addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j],flp);
                                indexControl++;
                            }
                        }
                    }
                    else
                    {
                        OrderMain.FloorID = TableID;
                        int OrderID = OrderService.CountOrder() + 1;
                        OrderMain.OrderID = OrderID;
                    }
                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmTranferTable:::::::::::::::::::LoadOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void lblNoTable_Click(object sender, EventArgs e)
        {
            frmKeyPadTransferTable frm = new frmKeyPadTransferTable(lblNoTable,2);
            frm.SendTable = new SendTableNO(this.TableNo);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                flpOldTable.Controls.Clear();
                LoadOrder(lblNoTable.Text, 0,flpOldTable);
            }
        }

        private void lblNewTable_Click(object sender, EventArgs e)
        {
            frmKeyPadTransferTable frm = new frmKeyPadTransferTable(lblNewTable,2);
            frm.SendTable = new SendTableNO(this.TableNoNew);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OrderSlpitNew.FloorID = lblNewTable.Text;
            }
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            try
            {
                flpOldTable.Controls.Clear();
                LoadOrder(lblNoTable.Text, 0,flpNewTable);
                OrderSlpitNew = OrderMain;
                OrderSlpitNew.FloorID = lblNewTable.Text;
                OrderMain.isTransferTableAll = 1;
                tableOld = this.lblNoTable.Text;
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmTransferTable:::::::::::::::::::::::::ebtnLeftAll_Click:::::::::::::::" + ex.Message);
            }
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            try
            {
                flpNewTable.Controls.Clear();
                flpOldTable.Controls.Clear();
                LoadOrder(lblNoTable.Text, 0, flpOldTable);
                OrderMain.isTransferTableAll = 0;
                OrderSlpitNew.ListOrderDetail.Clear();
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmTransferTable:::::::::::::::::btnRightAll_Click:::::::::::::::::::" + ex.Message);
            }
        }
        private void RefeshOrderMain(OrderDateModel OrderRefesh,FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            if (OrderRefesh.ListOrderDetail.Count > 0)
            {
                for (int i = 0; i < OrderRefesh.ListOrderDetail.Count; i++)
                {

                    addOrder(OrderRefesh.ListOrderDetail[i], flp);

                        for (int j = 0; j < OrderRefesh.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                        {
                            UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                            uc.Tag = OrderRefesh.ListOrderDetail[i].ListOrderDetailModifire[j];
                            //uc.Click += ucItemModifierOfMenu_Click;
                            addModifreToOrder(uc, OrderRefesh.ListOrderDetail[i].ListOrderDetailModifire[j],flp);
                            
                        }
                    
                }
            }
        }
       
        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control ctr in flpOldTable.Controls)
                {

                    if (ctr is UCOrder)
                    {
                        UCOrder ucOrder = (UCOrder)ctr;
                        if (ucOrder.BackColor == Color.FromArgb(0, 102, 204))
                        {
                            OrderDetailModel itemOrder = (OrderDetailModel)ucOrder.Tag;
                            OrderSlpitNew.FloorID = lblNewTable.Text;
                            OrderSlpitNew.ShiftID = OrderMain.ShiftID;
                            OrderSlpitNew.addItemToList(itemOrder);
                            OrderMain.ListOrderDetail.Remove(itemOrder);
                            OrderSlpitNew.SubTotal();
                            OrderMain.SubTotal();
                            OrderMain.isTransferTableAll = 0;
                            RefeshOrderMain(OrderMain, flpOldTable);
                            RefeshOrderMain(OrderSlpitNew, flpNewTable);

                        }
                    }
                    
                }
               
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmTransferTable::::::::::::::::::btnLeft_Click::::::::::::::::::::" + ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                if (flpNewTable.Controls.Count > 0)
                {
                    if (OrderSlpitNew.FloorID == "#" ||Convert.ToInt32(OrderSlpitNew.FloorID)>40)
                    {
                        frmMessager frm = new frmMessager("Messager", "TableNo is unavailable");
                        frmOpacity.ShowDialog(this, frm);
                    }
                    else
                    {
                        GetListPrinter();
                        OrderMain.Seat = 0;
                        for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                        {
                            OrderMain.ListOrderDetail[i].Seat = 0;
                        }
                        OrderDateModel OrderTemp = OrderService.GetOrderByTKA(lblNewTable.Text, "");
                        if (OrderTemp.ListOrderDetail.Count > 0)
                        {
                            foreach (OrderDetailModel item in OrderSlpitNew.ListOrderDetail)
                            {
                                item.OrderID = OrderTemp.OrderID;
                                OrderTemp.ListOrderDetail.Add(item);
                            }
                            result = result + OrderService.InsertOrder(OrderTemp);
                        }
                        else
                        {
                            result = result + OrderService.InsertOrder(OrderSlpitNew);
                        }
                       
                        if (OrderMain.isTransferTableAll == 1)
                        {
                             result =result+ OrderService.DeleteJoinTableAll(OrderMain);
                            
                        }
                        else
                        {
                            if(OrderMain.ListOrderDetail.Count>0)
                                result=result+ OrderService.InsertOrder(OrderMain);
                            else
                                result = result + OrderService.DeleteTransferTableAll(OrderMain);

                        }
                        if (result >= 2)
                        {
                            var list = ConfigService.GetConfig();
                            foreach (ConfigModel item in list)
                            {
                                cofig.ABN = item.ABN;
                                cofig.Name = item.Name;
                                cofig.Tel = item.Tel;
                                cofig.Web = item.Web;
                                cofig.Logan = item.Logan;
                                cofig.Note = item.Note;
                                cofig.Address = item.Address;
                            }
                            foreach (PrinterModel item in PrintData)
                            {
                                Header = item.Header;
                                posPrinter.SetPrinterName(item.PrinterName);
                                posPrinter.printDocument.PrintPage += printDocument_PrintPage;
                                posPrinter.Print();
                            }
                        }
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmTransferTable::::::::::::::::::::::btnOK_Click::::::::::::::::;;" + ex.Message);
            }
        }

        void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (OrderMain.isTransferTableAll == 1 || OrderMain.ListOrderDetail.Count==0)
            {
                string tableNew = "FROM TABLE " + lblNoTable.Text + " TO TABLE " + OrderSlpitNew.FloorID;
                printnTransferTableAll(tableNew, e);
            }
            else
            {
                printnTransferTableNotAll(OrderSlpitNew,e);
            }
        }

        public void printnTransferTableAll(string TransferTable, PrintPageEventArgs e)
        {
            float l_y = 0;
            l_y = posPrinter.DrawString(Header, e, new Font("Arial", 14, FontStyle.Italic), l_y, 2);
            l_y += posPrinter.GetHeightPrinterLine() / 10;
            l_y = posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
            l_y = posPrinter.DrawString(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
            l_y += posPrinter.GetHeightPrinterLine() / 10;
            l_y = posPrinter.DrawString("OPERATOR#MANAGER", e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
            l_y = posPrinter.DrawString(TransferTable, e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
            l_y += posPrinter.GetHeightPrinterLine() / 2;
            l_y = posPrinter.DrawString(cofig.Web, e, new Font("Arial", 10), l_y, 2);
            l_y = posPrinter.DrawString(cofig.Logan, e, new Font("Arial", 10), l_y, 2);
            l_y = posPrinter.DrawString(cofig.Note, e, new Font("Arial", 10), l_y, 2);

        }
        public float printnTransferTableNotAll(OrderDateModel Order, PrintPageEventArgs e)
        {
            float l_y = 0;
           l_y = posPrinter.DrawString(Header, e, new Font("Arial", 14, FontStyle.Italic), l_y, 2);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           l_y=posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y = posPrinter.DrawString(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           l_y = posPrinter.DrawString("OPERATOR#MANAGER", e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
           posPrinter.DrawString("Table# " + Order.FloorID, e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("Order#" + Order.OrderID, e, new Font("Arial", 14), l_y, 3);
           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           int countItem =0;
           for (int i = 0; i < Order.ListOrderDetail.Count; i++)
           {
               float yStart  = l_y;

               if (Order.ListOrderDetail[i].ChangeStatus == 2)
               {
                   l_y = posPrinter.DrawString(Order.ListOrderDetail[i].ProductName, e, new Font("Arial", 14), l_y, 1);
                   posPrinter.DrawCancelLine(e, yStart, l_y);
               }
               else
               {
                   if (Order.ListOrderDetail[i].ChangeStatus == 1)
                   {
                       l_y = posPrinter.DrawString("--Add  " + Order.ListOrderDetail[i].ProductName, e, new Font("Arial", 14), l_y, 1);
                   }
                   else
                   {
                       countItem++;
                       l_y = posPrinter.DrawString(Order.ListOrderDetail[i].Qty.ToString() + " " + Order.ListOrderDetail[i].ProductName, e, new Font("Arial", 14), l_y, 1);
                   }
               }
               //l_y = posPrinter.DrawString(OrderMain.ListOrderDetail[i].Qty.ToString(), e, new Font("Arial", 14), l_y, 2);
               //posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].Price.ToString()), e, new Font("Arial", 14), yStart, 3);

               if (Order.ListOrderDetail[i].ListOrderDetailModifire.Count > 0)
               {
                   for (int j = 0; j < Order.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                   {
                       if (Order.ListOrderDetail[i].ListOrderDetailModifire[j].ChangeStatus == 2)
                       {
                           l_y = posPrinter.DrawString(Order.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 10), l_y, 1);
                           posPrinter.DrawCancelLine(e, yStart, l_y);
                       }
                       else
                       {
                           if (Order.ListOrderDetail[i].ListOrderDetailModifire[j].ChangeStatus == 1)
                           {
                               l_y = posPrinter.DrawString("--Add" + Order.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
                           }
                           else
                           {
                               if(!OrderMain.IsLoadFromData)
                                    l_y = posPrinter.DrawString("--" + Order.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
                           }
                       }
                       //l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].Price.ToString()), e, new Font("Arial", 14), l_y, 3);
                   }
               }
           }
           l_y += posPrinter.GetHeightPrinterLine() / 10;

           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y = posPrinter.DrawString("", e, new Font("Arial", 14), l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           posPrinter.DrawString("Total item: "+countItem, e, new Font("Arial", 14, FontStyle.Bold), l_y, 1);
           //l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.SubTotal()), e, new Font("Arial", 14, FontStyle.Bold), l_y, 3);
           l_y += posPrinter.GetHeightPrinterLine()/2;
           return l_y;
       
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control ctr in flpNewTable.Controls)
                {

                    UCOrder ucOrder = (UCOrder)ctr;
                    if (ucOrder.BackColor == Color.FromArgb(0, 102, 204))
                    {
                        OrderDetailModel itemOrder = (OrderDetailModel)ucOrder.Tag;
                        OrderSlpitNew.FloorID = lblNewTable.Text;
                        OrderSlpitNew.ShiftID = OrderMain.ShiftID;
                        OrderSlpitNew.ListOrderDetail.Remove(itemOrder);
                        OrderMain.addItemToList(itemOrder);
                        OrderSlpitNew.SubTotal();
                        OrderMain.SubTotal();
                        OrderMain.isTransferTableAll = 0;
                        RefeshOrderMain(OrderMain, flpOldTable);
                        RefeshOrderMain(OrderSlpitNew, flpNewTable);

                    }

                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmTransferTable::::::::::::::::::btnLeft_Click::::::::::::::::::::" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void GetListPrinter()
        {
            PrintData.Clear();
            var listPrinter = PrintService.GetListPrinterTransferTable();
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
    }
}
