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
            Close();
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
                ucTKA.lblCusName .Text= "Thanh";
                ucTKA.lblCusPhone .Text= "0972641947";
                ucTKA.lblNo.Text = i + "";
                ucTKA.lblTotal.Text = money.Format2(item.Total);
                ucTKA.lblWait.Text = item.Waiting.ToString();
                ucTKA.Width = flpTkAInfor.Width;
                ucTKA.Tag = item;
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
            LoadItemTKA();
        }
        private void LoadItemTKA()
        {
            flpTKAItem.Controls.Clear();
            foreach (OrderDetailModel item in OrderMain.ListOrderDetail)
            {
                UCTKADetail ucTKADetail = new UCTKADetail();
                ucTKADetail.lblItemName .Text= item.ProductName;
                ucTKADetail.lblItemPrice .Text=money.Format2(item.Price??0);
                ucTKADetail.lblItemQty.Text = item.Qty + "";
                ucTKADetail.Width = flpTKAItem.Width;
                flpTKAItem.Controls.Add(ucTKADetail);
            }
            lblSubTotal.Text = "$" + money.Format2(OrderMain.SubTotal());
        }
        private void frmTakeAway_Shown(object sender, EventArgs e)
        {
            
            //System.Threading.Thread.Sleep(3000);
           // GetDataTKA();
           
           

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
                frm.LoadOrderTKA(TKAID,"");
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmTakeAway:::::::::::::::::::::::::::btnDetail_Click:::::::::::::::" + ex.Message);
            }
        }
    }
}
