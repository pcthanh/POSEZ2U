using System;
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
namespace POSEZ2U
{
    public partial class frmFloor : Form
    {
        ServicePOS.Model.OrderModel orderMain;
        public frmFloor(ServicePOS.Model.OrderModel _orderMain)
        {
            InitializeComponent();
            orderMain = _orderMain;
        }
        public frmFloor()
        {
            InitializeComponent();

        }
        MoneyFortmat monetFormat = new MoneyFortmat(MoneyFortmat.AU_TYPE);
        ServicePOS.Model.OrderModel OrderMain = new ServicePOS.Model.OrderModel();
        public delegate void CallBackStatusOrder(ServicePOS.Model.OrderModel orderMain);
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
                //ftpEatIn.Controls.Add(ucTable);
                flowLayoutPanel1.Controls.Add(ucTable);
            }
        }

        void ucTable_Click(object sender, EventArgs e)
        {
            UCTable ucTable = (UCTable)sender;
            OrderMain.FloorID = Convert.ToInt32(ucTable.lbTableNo.Text);
           
            frmOrder frm = new frmOrder(OrderMain);
            frm.CallBackStatusOrder = new CallBackStatusOrder(this.CallBackOrder);
            frm.ShowDialog();    
           
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
        private void CallBackOrder(ServicePOS.Model.OrderModel orderCallBack)
        {
            OrderMain = orderCallBack;
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                UCTable ucTable = (UCTable)flowLayoutPanel1.Controls[i];
                if (ucTable.lbTableNo.Text == OrderMain.FloorID.ToString())
                {
                    ucTable.BackColor = Color.Green;
                    ucTable.ForeColor = Color.White;
                    SetText("$"+monetFormat.Format(OrderMain.SubTotal()), ucTable.lbSubTotal);
                }

            }
            
        }
        private void frmFloor_Load(object sender, EventArgs e)
        {

            this.paintFloor();
            AnimateWindow(Handle, 10000, AW_BLEND | AW_ACTIVATE);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void frmFloor_Shown(object sender, EventArgs e)
        {


        }

    }
}
