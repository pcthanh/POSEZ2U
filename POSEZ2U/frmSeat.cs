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

namespace POSEZ2U
{
    public partial class frmSeat : Form
    {
        public frmSeat()
        {
            InitializeComponent();
        }
        public delegate void SendTableNO(int TableNO);
        List<SeatModel> lstSeat = new List<SeatModel>();
        OrderDateModel OrderMain;
        int Seat;
        OrderDateModel OrderSlpitOld = new OrderDateModel();
        OrderDateModel OrderSlpitNew = new OrderDateModel();
        private IOrderService _orderService;
        private IOrderService OrderService
        {
            get { return _orderService ?? (_orderService = new OrderService()); }
            set { _orderService = value; }
        }
        private void TableNo(int ID)
        {
            if (lblTable.Text == "#")
                lblTable.Text = string.Empty;
            if (ID == -1)
            {
                if (lblTable.Text.Length > 0)
                    lblTable.Text = lblTable.Text.Remove(lblTable.Text.Length - 1, 1);
            }
            else
                lblTable.Text += ID.ToString();
        }
        private void lblTable_Click(object sender, EventArgs e)
        {
            frmKeyPadTransferTable frm = new frmKeyPadTransferTable(lblTable,1);
            frm.SendTableSeat = new SendTableNO(this.TableNo);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                flpOldOrder.Controls.Clear();
                LoadOrder(this.lblTable.Text, 0, flpOldOrder);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int result = OrderService.InsertOrder(OrderSlpitNew);
                if (result == 1)
                    this.Close();
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmSeat::::::::::::::::::::::::btnOK_Click::::::::::::::::::::" + ex.Message);
            }
        }
        public void LoadOrder(string TableID, int orderID, FlowLayoutPanel flp)
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
                        flp.Controls.Add(ucSeat);
                        indexControl = flp.Controls.Count;
                        if (OrderMain.ListOrderDetail.Count > 0)
                        {
                            for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                            {
                                if (OrderMain.ListOrderDetail[i].Seat == seat.Seat)
                                {
                                    addOrder(OrderMain.ListOrderDetail[i], flp);
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
                            addOrder(OrderMain.ListOrderDetail[i], flp);
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
        private void addOrder(OrderDetailModel items, FlowLayoutPanel flp)
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
                ucMdifireOfMenu.Width = flp.Width;
                flp.Controls.Add(ucMdifireOfMenu);

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("addModifreToOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void btnAddSeat_Click(object sender, EventArgs e)
        {
            frmAddSeat frm = new frmAddSeat();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Seat = frm.NumberSeat;
                SeatModel seatAdd = new SeatModel();
                seatAdd.Seat = Seat;
                lstSeat.Add(seatAdd);
                OrderSlpitNew.ListSeatOfOrder = lstSeat;
                UCSeat ucSeat = new UCSeat();
                ucSeat.lblSeat.Text = "Seat " + Seat;
                //ucSeat.Click += ucSeat_Click;
                lblSeat.Text = Seat.ToString();
                flpNewTable.Controls.Add(ucSeat);
            }
        }
        private void RefeshOrderMain(OrderDateModel OrderRefesh, FlowLayoutPanel flp)
        {
            //flp.Controls.Clear();
            if (flp == flpOldOrder)
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
        private void CopyOrder()
        {
            OrderSlpitNew.InvoiceID = OrderMain.InvoiceID;
            OrderSlpitNew.OrderID = OrderMain.OrderID;
            OrderSlpitNew.OrderNumber = OrderMain.OrderNumber;
            OrderSlpitNew.ClientID = OrderMain.ClientID;
            OrderSlpitNew.FloorID = OrderMain.FloorID;
            OrderSlpitNew.Status = OrderMain.Status;
            OrderSlpitNew.TotalAmount = OrderMain.TotalAmount;
            OrderSlpitNew.CreateBy = OrderMain.CreateBy;
            OrderSlpitNew.CreateDate = OrderMain.CreateDate;
            OrderSlpitNew.UpdateBy = OrderMain.UpdateBy;
            OrderSlpitNew.Seat = OrderMain.Seat;
            OrderSlpitNew.IsLoadFromData = OrderMain.IsLoadFromData;
            OrderSlpitNew.ShiftID = OrderMain.ShiftID;
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (Seat == 0)
                {
                    frmMessager frm = new frmMessager("Messager", "Input Number Seat");
                    frmOpacity.ShowDialog(this, frm);
                }
                else
                {
                    OrderSlpitOld = new OrderDateModel();
                    CopyOrder();
                    OrderSlpitNew.addSeat(Seat);
                    foreach (Control ctr in flpOldOrder.Controls)
                    {
                        if (ctr is UCOrder)
                        {
                            UCOrder ucOrder = (UCOrder)ctr;
                            if (ucOrder.BackColor == Color.FromArgb(0, 102, 204))
                            {
                                OrderDetailModel item = (OrderDetailModel)ucOrder.Tag;
                                item.Seat = Seat;
                                
                                if (item.ListOrderDetailModifire.Count > 0)
                                {
                                    for (int i = 0; i < item.ListOrderDetailModifire.Count; i++)
                                    {
                                        item.ListOrderDetailModifire[i].Seat = Seat;
                                    }
                                }
                                OrderSlpitNew.addItemToListAddSeat(item);
                                OrderSlpitOld.addItemToListAddSeat(item);
                                OrderMain.ListOrderDetail.Remove(item);

                            }
                        }
                    }
                    RefeshOrderMain(OrderSlpitOld, flpNewTable);
                    RefeshOrderMain(OrderMain, flpOldOrder);
                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmSeat::::::::::::::::::btnLeft_Click::::::::::::::::::::" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
       

    }
}
