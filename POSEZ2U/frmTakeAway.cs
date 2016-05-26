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
using ServicePOS.Model;
using POSEZ2U.Class;
using ServicePOS;
using SystemLog;
namespace POSEZ2U
{
    public partial class frmTakeAway : Form
    {
        public frmTakeAway()
        {
            InitializeComponent();
            this.Activated += frmTakeAway_Activated;
        }

        void frmTakeAway_Activated(object sender, EventArgs e)
        {
            if(isCancel!=1)
                GetDataTKA();
        }
        public delegate void CallBackStatusOrderTKA(OrderDateModel orderMain);
        MoneyFortmat money = new MoneyFortmat(MoneyFortmat.AU_TYPE);
        OrderDateModel OrderMain;
        string TKAID = string.Empty;
        int indexControl;
        private IOrderService _orderService;
        public int isCancel = 0;
        private IOrderService OrderService
        {
            get { return _orderService ?? (_orderService = new OrderService()); }
            set { _orderService = value; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTKAOrder frm = new frmTKAOrder();
            isCancel = 0;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                isCancel = 1;
            }
        }
        private void Test(OrderDateModel or)
        {
            MessageBox.Show("hjvj");
        }
        private string GetLongTime(string time)
        {
            try
            {
                DateTime now = DateTime.Now;
                DateTime time3 = Convert.ToDateTime(string.Concat(new object[] { now.Year, "-", now.Month, "-", now.Day, " ", now.ToLongTimeString() }));
                DateTime time4 = Convert.ToDateTime(time);
                TimeSpan span = (TimeSpan)(time3 - time4);
                int totalSeconds = (int)span.TotalSeconds;
                string str = (totalSeconds / 3600).ToString();
                if (str.Length == 1)
                {
                    str = "0" + str;
                }
                string str2 = ((totalSeconds / 60) % 60).ToString();
                if (str2.Length == 1)
                {
                    str2 = "0" + str2;
                }
                string str3 = (totalSeconds % 60).ToString();
                if (str3.Length == 1)
                {
                    str3 = "0" + str3;
                }
                return (str + ":" + str2 + ":" + str3);
            }
            catch (Exception exception)
            {

                LogPOS.WriteLog("GetLongTime:::::::::::::::::::::::::::::::" + exception.Message);
            }
            return null;
        }
        private void frmTakeAway_Load(object sender, EventArgs e)
        {
            //GetDataTKA();
            //for (int i = 0; i < 10; i++)
            //{
            //    UCTakeAway ucTKA = new UCTakeAway();

            //    ucTKA.Width = flpTkAInfor.Width;
            //    if (i % 2 == 0)
            //        ucTKA.BackColor = Color.Black;
            //    flpTkAInfor.Controls.Add(ucTKA);
            //}
            //GetDataTKA();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetDataTKA()
        {
            this.flpTkAInfor.Controls.Clear();
            flpTKAItem.Controls.Clear();
            lblSubTotal.Text = string.Empty;
            List<OrderTKAModel> ListTKA = new List<OrderTKAModel>();
            ListTKA = OrderService.GetStatusOrderTKA();
            int i = 1;
            foreach (OrderTKAModel item in ListTKA)
            {
                UCTakeAway ucTKA = new UCTakeAway();
                ucTKA.lblCusName.Text = item.CusName;
                ucTKA.lblCusPhone .Text= item.CusPhone;
                ucTKA.lblNo.Text = i + "";
                ucTKA.lblTotal.Text = money.Format2(item.Total);
                ucTKA.lblWait.Text = item.Waiting.ToString();
                ucTKA.Width = flpTkAInfor.Width;
                ucTKA.Tag = item;
                if (i % 2 == 0)
                    ucTKA.BackColor = Color.FromArgb(255, 255, 255);
                else
                    ucTKA.BackColor = Color.FromArgb(242, 242, 242);
                ucTKA.Click += ucTKA_Click;
                flpTkAInfor.Controls.Add(ucTKA);
                i++;
            }
            flpTkAInfor.Refresh();
            this.Refresh();
        }

        void ucTKA_Click(object sender, EventArgs e)
        {
            UCTakeAway ucTKA = (UCTakeAway)sender;
            OrderTKAModel TKA = (OrderTKAModel)ucTKA.Tag;
            TKAID = TKA.TKAID;
            foreach (Control ctr in flpTkAInfor.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucTKA.BackColor = Color.FromArgb(0, 153, 51);
            ucTKA.ForeColor = Color.FromArgb(255, 255, 255);
            OrderMain = OrderService.GetOrderByTKA(TKA.TKAID, "");
            LoadOrderTKA(TKAID,"");
        }
        
        private void addOrder(OrderDetailModel items)
        {
            try
            {

                UCOrder ucOrder = new UCOrder();
                ucOrder.lblNameItem.Text = items.ProductName;
                ucOrder.Tag = items;
                ucOrder.lblPriceItem.Text = money.Format2(items.Price.ToString());
                ucOrder.Width = flpTKAItem.Width;
                LogPOS.WriteLog("addOrder::::::::::Item::::::" + items.ProductName + ":::::" + items.Price);
                flpTKAItem.Controls.Add(ucOrder);
                
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("addOrder:::::::::::::::::::::::::" + ex.Message);
            }
        }
        public void LoadOrderTKA(string TableID, string ClientID)
        {
            indexControl = 1;
            flpTKAItem.Controls.Clear();
            try
            {
                OrderMain = new OrderDateModel();
                OrderMain = OrderService.GetOrderByTKA(TableID, "");
                OrderMain.isTKA = 1;
                lblSubTotal.Text = money.Format2(Convert.ToDouble(OrderMain.TotalAmount));
                if (OrderMain.Seat > 0)
                {
                    OrderMain.IsLoadFromData = true;
                    //lblSeat.Text = OrderMain.Seat.ToString();
                    for (int seat = 1; seat <= OrderMain.Seat; seat++)
                    {
                        UCSeat ucSeat = new UCSeat();
                        ucSeat.lblSeat.Text = "Seat " + seat.ToString();
                       
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
                                       
                                        addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                        indexControl++;
                                    }
                                }
                            }
                        }
                        else
                        {
                            OrderMain.FloorID = TableID + "" + (OrderService.CountOrder() + 1);

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
                                
                                addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                indexControl++;
                            }
                        }
                    }
                    else
                    {
                        OrderMain.FloorID = TableID + "" + (OrderService.CountOrder() + 1);
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
        private void addModifreToOrder(UCItemModifierOfMenu ucMdifireOfMenu, OrderDetailModifireModel modifier)
        {
            try
            {

                ucMdifireOfMenu.lblNameItenModifierMenu.Text = modifier.ModifireName;
                ucMdifireOfMenu.lblPriceItenModifierMenu.Text = money.Format2(modifier.Price.ToString());
                ucMdifireOfMenu.lblQtyItenModifierMenu.Text = "1";
                ucMdifireOfMenu.Width = flpTKAItem.Width;
                flpTKAItem.Controls.Add(ucMdifireOfMenu);
                flpTKAItem.Controls.SetChildIndex(ucMdifireOfMenu, indexControl + 1);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("addModifreToOrder:::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void frmTakeAway_Shown(object sender, EventArgs e)
        {
            
        }
        protected override void OnShown(EventArgs e)
        {
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < flpTkAInfor.Controls.Count; i++)
                {
                    UCTakeAway ucTKA = (UCTakeAway)flpTkAInfor.Controls[i];
                    if (ucTKA.Tag != null)
                    {
                        OrderTKAModel st = (OrderTKAModel)ucTKA.Tag;
                        ucTKA.lblWait.Text = GetLongTime(st.Waiting.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("timer1_Tick:::::::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            try
            {
                frmOrder frm = new frmOrder();
                frm.LoadOrderTKA(TKAID,0);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmTakeAway:::::::::::::::::::::::::::btnDetail_Click:::::::::::::::" + ex.Message);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frmOpacity.ShowDialog(this, frm);
        }
    }
}
