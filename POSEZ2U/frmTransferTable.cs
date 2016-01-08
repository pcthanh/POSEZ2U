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
    public partial class frmTransferTable : Form
    {
        public frmTransferTable()
        {
            InitializeComponent();
        }

        public delegate void SendTableNO(int TableNO);
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
        private void addOrder(OrderDetailModel items)
        {
            try
            {
                
                UCOrder ucOrder = new UCOrder();
                ucOrder.lblNameItem.Text = items.ProductName;
                ucOrder.Tag = items;
                ucOrder.lblPriceItem.Text = items.Qty.ToString();
                //ucOrder.Click += ucOrder_Click;
                LogPOS.WriteLog("addOrder::::::::::Item::::::" + items.ProductName + ":::::" + items.Price);
                ucOrder.Width = flpOldTable.Width;
                flpOldTable.Controls.Add(ucOrder);
               
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("addOrder:::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void addModifreToOrder(UCItemModifierOfMenu ucMdifireOfMenu, OrderDetailModifireModel modifier)
        {
            try
            {

                ucMdifireOfMenu.lblNameItenModifierMenu.Text = modifier.ModifireName;
                //ucMdifireOfMenu.lblPriceItenModifierMenu.Text = "1";
                ucMdifireOfMenu.Width = flpOldTable.Width;
                flpOldTable.Controls.Add(ucMdifireOfMenu);
                
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("addModifreToOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        public void LoadOrder(string TableID, int orderID)
        {
            int indexControl = 1;
            try
            {
                OrderDateModel OrderMain = new OrderDateModel();
                OrderMain = OrderService.GetOrderByTable(TableID, 0);
                
                if (OrderMain.Seat > 0)
                {
                    OrderMain.IsLoadFromData = true;
                    //lblSeat.Text = OrderMain.Seat.ToString();
                    for (int seat = 1; seat <= OrderMain.Seat; seat++)
                    {
                        UCSeat ucSeat = new UCSeat();
                        ucSeat.lblSeat.Text = "Seat " + seat.ToString();
                       // ucSeat.Click += ucSeat_Click;
                        flpOldTable.Controls.Add(ucSeat);
                        indexControl = flpOldTable.Controls.Count;
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
                                        //uc.Click += ucItemModifierOfMenu_Click;
                                        addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
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
                            addOrder(OrderMain.ListOrderDetail[i]);
                            indexControl++;
                            for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                            {
                                UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                //uc.Click += ucItemModifierOfMenu_Click;
                                addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
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
                LogPOS.WriteLog("LoadOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void lblNoTable_Click(object sender, EventArgs e)
        {
            frmKeyPadTransferTable frm = new frmKeyPadTransferTable(lblNoTable);
            frm.SendTable = new SendTableNO(this.TableNo);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                flpOldTable.Controls.Clear();
                LoadOrder(lblNoTable.Text, 0);
            }
        }

        private void lblNewTable_Click(object sender, EventArgs e)
        {
            frmKeyPadTransferTable frm = new frmKeyPadTransferTable(lblNewTable);
            frm.SendTable = new SendTableNO(this.TableNoNew);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            }
        }
    }
}
