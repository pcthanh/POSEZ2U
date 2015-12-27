﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;
using System.Runtime.InteropServices;
using ServicePOS.Model;
using POSEZ2U.UC;
using POSEZ2U.Class;
using ServicePOS;
using ServicePOS.Model;
using SystemLog;
namespace POSEZ2U
{
    public partial class frmFloor : Form
    {
        OrderDateModel orderMain;
        public frmFloor(OrderDateModel _orderMain)
        {
            InitializeComponent();
            orderMain = _orderMain;
        }
        public frmFloor()
        {
            InitializeComponent();

        }
        private IOrderService _orderService;
        private IOrderService OrderService
        {
            get { return _orderService ?? (_orderService = new OrderService()); }
            set { _orderService = value; }
        }
        MoneyFortmat monetFormat = new MoneyFortmat(MoneyFortmat.AU_TYPE);
        OrderDateModel OrderMain = new OrderDateModel();
        public delegate void CallBackStatusOrder(OrderDateModel orderMain);
        private delegate void ChangeTextCallback(string text, Control control);
        const int AW_HOR_POSITIVE = 1;
        const int AW_HOR_NEGATIVE = 2;
        const int AW_VER_POSITIVE = 4;
        const int AW_VER_NEGATIVE = 8;
        const int AW_HIDE = 65536;
        const int AW_ACTIVATE = 131072;
        const int AW_SLIDE = 262144;
        const int AW_BLEND = 524288;

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        private void paintFloor()
        {
            for (int i = 1; i < 40; i++)
            {
                UC.UCTable ucTable = new UC.UCTable();
                ucTable.lbTableNo.Text = i.ToString();
                ucTable.Click += ucTable_Click;
                flowLayoutPanel1.Controls.Add(ucTable);
            }
        }

        void ucTable_Click(object sender, EventArgs e)
        {
            try
            {
                UCTable ucTable = (UCTable)sender;
                frmOrder frm = new frmOrder();
                frm.LoadOrder(ucTable.lbTableNo.Text, 0);
                frm.CallBackStatusOrder = new CallBackStatusOrder(this.CallBackOrder);
                frm.Show();
                
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("ucTable_Click::::::::::::::::::::::::::::::::::::::::::" + ex.Message);
            }
           
        }
        public void SetText(string text, Control control)
        {
            if (control.InvokeRequired)
            {
                ChangeTextCallback method = new ChangeTextCallback(this.SetText);
                control.Invoke(method, new object[] { text, control });
            }
            else
            {
                control.Text = text;
            }
        }
        private void CallBackOrder(OrderDateModel orderCallBack)
        {
            
            CheckStatusTable();
            
        }
        private void CheckStatusTable()
        {
            try
            {
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    UCTable ucTable = (UCTable)flowLayoutPanel1.Controls[i];
                    StatusTable statusTable = OrderService.GetStatusTable(ucTable.lbTableNo.Text);
                    if (statusTable.Complete == 0)
                    {
                        ucTable.BackColor = Color.Green;
                        ucTable.ForeColor = Color.White;
                        ucTable.lbTime.Text = statusTable.Time;
                        ucTable.Tag = statusTable;
                        SetText("$" + monetFormat.Format(Convert.ToDouble(statusTable.SubTotal)), ucTable.lbSubTotal);
                    } 
                    if (statusTable.Complete == -1)
                    {
                        ucTable.BackColor = Color.FromArgb(242, 242, 242);
                        ucTable.ForeColor = Color.Black;
                        ucTable.Tag = null;
                        SetText("", ucTable.lbTime);
                       SetText("", ucTable.lbSubTotal);
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("CheckStatusTable::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void frmFloor_Load(object sender, EventArgs e)
        {

            this.paintFloor();
            AnimateWindow(Handle, 10000, AW_BLEND | AW_ACTIVATE);
            CheckStatusTable();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
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


        private void frmFloor_Shown(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    UCTable ucTable = (UCTable)flowLayoutPanel1.Controls[i];
                    if (ucTable.Tag != null)
                    {
                        StatusTable st = (StatusTable)ucTable.Tag;
                        ucTable.lbTime.Text = GetLongTime(st.Time);
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
