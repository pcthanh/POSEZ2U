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
        }
        public delegate void CallBackStatusOrderTKA(OrderDateModel orderMain);
        MoneyFortmat money = new MoneyFortmat(MoneyFortmat.AU_TYPE);
        private IOrderService _orderService;
        private IOrderService OrderService
        {
            get { return _orderService ?? (_orderService = new OrderService()); }
            set { _orderService = value; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTKAOrder frm = new frmTKAOrder();
           
            frmOrder frmOrder = new frmOrder();
            frmOrder.CallBackStatusOrderTKA = new CallBackStatusOrderTKA(this.Test);
            
            frm.ShowDialog();
           
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
            GetDataTKA();
            //for (int i = 0; i < 10; i++)
            //{
            //    UCTakeAway ucTKA = new UCTakeAway();

            //    ucTKA.Width = flpTkAInfor.Width;
            //    if (i % 2 == 0)
            //        ucTKA.BackColor = Color.Black;
            //    flpTkAInfor.Controls.Add(ucTKA);
            //}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GetDataTKA()
        {
            List<OrderTKAModel> ListTKA = new List<OrderTKAModel>();
            ListTKA = OrderService.GetStatusOrderTKA();
            for (int i = 0; i < ListTKA.Count; i++)
            {
                UCTakeAway ucTKA = new UCTakeAway();
                ucTKA.lblCusName .Text= "Thanh";
                ucTKA.lblCusPhone .Text= "0972641947";
                ucTKA.lblNo.Text = i + 1+"";
                ucTKA.lblTotal.Text =money.Format2( ListTKA[i].Total);
                ucTKA.lblWait.Text = ListTKA[i].Waiting.ToString();
                ucTKA.Width = flpTkAInfor.Width;
                ucTKA.Tag = ListTKA[i];
                flpTkAInfor.Controls.Add(ucTKA);
            }
            flpTkAInfor.Refresh();
            this.Refresh();
        }
        private void frmTakeAway_Shown(object sender, EventArgs e)
        {
            
            //System.Threading.Thread.Sleep(3000);
           // GetDataTKA();
           
           

        }
        protected override void OnShown(EventArgs e)
        {
            //GetDataTKA();
            base.OnShown(e);
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
    }
}
