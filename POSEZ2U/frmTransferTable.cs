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
        OrderDateModel OrderMain;
        OrderDateModel OrderSlpitOld = new OrderDateModel();
        OrderDateModel OrderSlpitNew = new OrderDateModel();
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
        public void LoadOrder(string TableID, int orderID,FlowLayoutPanel flp)
        {
            int indexControl = 1;
            try
            {
                
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
                                    addOrder(OrderMain.ListOrderDetail[i],flp);
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
                            addOrder(OrderMain.ListOrderDetail[i],flp);
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
                LogPOS.WriteLog("frmTranferTable:::::::::::::::::::LoadOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void lblNoTable_Click(object sender, EventArgs e)
        {
            frmKeyPadTransferTable frm = new frmKeyPadTransferTable(lblNoTable);
            frm.SendTable = new SendTableNO(this.TableNo);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                flpOldTable.Controls.Clear();
                LoadOrder(lblNoTable.Text, 0,flpOldTable);
            }
        }

        private void lblNewTable_Click(object sender, EventArgs e)
        {
            frmKeyPadTransferTable frm = new frmKeyPadTransferTable(lblNewTable);
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
                            addModifreToOrder(uc, OrderRefesh.ListOrderDetail[i].ListOrderDetailModifire[j]);
                            
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
                        RefeshOrderMain(OrderMain,flpOldTable);
                        RefeshOrderMain(OrderSlpitNew, flpNewTable);
                       
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
            if (flpNewTable.Controls.Count > 0)
            {
                if (OrderSlpitNew.FloorID == "#" )
                {
                    frmMessager frm = new frmMessager("Messager", "Input TableNo New");
                    frm.ShowDialog();
                }
                else
                {
                    OrderService.InsertOrder(OrderSlpitNew);
                    if (OrderMain.isTransferTableAll == 1)
                    {
                        OrderService.DeleteJoinTableAll(OrderMain);
                    }
                    else
                    {
                        OrderService.InsertOrder(OrderMain);
                        
                    }
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
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
    }
}
