using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicePOS.Model;
using POSEZ2U.UC;
namespace POSEZ2U
{
    public partial class frmSecondDisplay : Form
    {
        POSEZ2U.Class.MoneyFortmat money = new POSEZ2U.Class.MoneyFortmat(POSEZ2U.Class.MoneyFortmat.AU_TYPE);
        public int Second { get; set; }
        int indexControl;
        int mTimeCount = 0;
        public frmSecondDisplay()
        {
            InitializeComponent();
        }

        private void frmSecondDisplay_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
            Second = 30;
            timer1.Start();
            fullScreen();
            imageViewer1.SizeMode = PictureBoxSizeMode.Zoom;
            imageViewer1.Start();
        }
        public void ShowCustomerDisplay()
        {
            try
            {
                Screen[] sc;
                sc = Screen.AllScreens;
                //frmCustomer = new frmCustomerDisplay(money);
                SystemLog.LogPOS.WriteLog("frmsecondDisplay:::::::::::::::::::::ShowCustomerDisplay::::::::::::::" + sc.Length);
                if (sc.Length >= 2)
                {
                    //get all the screen width and heights
                    //frmCustomer = new frmCustomerDisplay(money);
                    //f.FormBorderStyle = FormBorderStyle.None;
                    this.Left = sc[1].Bounds.Width;
                    this.Top = sc[1].Bounds.Height;
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = sc[1].Bounds.Location;
                    Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
                    this.Location = p;
                    this.WindowState = FormWindowState.Maximized;
                    // Duc
                    //frmCustomer.Show();
                    //}
                    //frmCustomer = new frmCustomerDisplay(money);
                    //frmCustomer.Show();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("POS::frmCustomerDisplay::ShowCustomerDisplay::" + ex.Message);
            }
            imageViewer1.Start();
        }

        public void BindOrder(OrderDateModel OrderMain)
        {
            try
            {
                detailScreen();
                if (OrderMain.ListSeatOfOrder.Count > 0)
                {
                    OrderMain.IsLoadFromData = true;
                    
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
                                       
                                        flowLayoutPanel1.Controls.Add(ucSeat);
                                        indexControl = flowLayoutPanel1.Controls.Count;
                                        addSet = false;
                                    }
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
                                           
                                            addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                            indexControl++;
                                        }
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
                        
                        for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
                        {
                            addOrder(OrderMain.ListOrderDetail[i]);
                            
                            for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                            {
                                UCItemModifierOfMenu uc = new UCItemModifierOfMenu();
                                uc.Tag = OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j];
                                
                                addModifreToOrder(uc, OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j]);
                                
                            }
                        }
                    }
                    
                }
                this.lblSubtotal.Text = money.Format2(OrderMain.SubTotal());
                this.lblTax.Text = "N/A";
                this.lblTotal.Text = money.Format2(OrderMain.SubTotal());
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("POS::frmCustomerDisplay:::::::::::::::::::" + ex.Message);
            }
        }
        private void addModifreToOrder(UCItemModifierOfMenu ucMdifireOfMenu, OrderDetailModifireModel modifier)
        {
            try
            {

                ucMdifireOfMenu.lblNameItenModifierMenu.Text = modifier.ModifireName;
                ucMdifireOfMenu.lblPriceItenModifierMenu.Text = money.Format2(modifier.Price.ToString());
                ucMdifireOfMenu.lblQtyItenModifierMenu.Text = modifier.Qty.ToString();
                ucMdifireOfMenu.Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.Add(ucMdifireOfMenu);
                flowLayoutPanel1.Controls.SetChildIndex(ucMdifireOfMenu, indexControl + 1);
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("addModifreToOrder:::::::::::::::::::::::::::::::::" + ex.Message);
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
              
                SystemLog. LogPOS.WriteLog("addOrder::::::::::Item::::::" + items.ProductName + ":::::" + items.Price);
                ucOrder.Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.Add(ucOrder);
                //if (flagUcSeatClick > 0)
                //{
                //    if (indexOfUcSeat == 0)
                //        flpOrder.Controls.SetChildIndex(ucOrder, 1 + countItemOfSeat);
                //    else
                //        flpOrder.Controls.SetChildIndex(ucOrder, indexOfUcSeat + countItemOfSeat);
                //}
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("addOrder:::::::::::::::::::::::::" + ex.Message);
            }
        }
        public void fullScreen()
        {
            flowLayoutPanel1.Controls.Clear();
            splitContainer1.Panel2Collapsed = true;

        }
        private void detailScreen()
        {
            splitContainer1.Panel2Collapsed = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mTimeCount < Second)
            {
                if (flowLayoutPanel1.Controls.Count == 0)
                {
                    fullScreen();
                }
                else
                {
                    detailScreen();
                }
            }
            else if (mTimeCount == Second)
            {
                if (flowLayoutPanel1.Controls.Count == 0)
                {
                    fullScreen();
                }
                else
                {
                    detailScreen();
                }
                
            }
            
        }
    }
}
