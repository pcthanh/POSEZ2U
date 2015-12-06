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

namespace POSEZ2U
{
    public partial class frmFloor : Form
    {
        Order orderMain;
        public frmFloor(Order _orderMain)
        {
            InitializeComponent();
            orderMain = _orderMain;
        }
        public frmFloor()
        {
            InitializeComponent();
           
        }
        Order OrderMain = new Order();
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
                ucTable.lbTime.Text = "03/11/2015";
                ucTable.lbSubTotal.Text = "20,000";
                ucTable.Click += ucTable_Click;
                //ftpEatIn.Controls.Add(ucTable);
                if (i == 7 || i == 15 || i == 28)
                {
                    ucTable.BackColor = Color.Green;
                }
                flowLayoutPanel1.Controls.Add(ucTable);
            }
        }

        void ucTable_Click(object sender, EventArgs e)
        {
            UCTable ucTable = (UCTable)sender;
            OrderMain.FloorID =Convert.ToInt32(ucTable.lbTableNo.Text);
            frmOrder frm = new frmOrder(OrderMain);
            frm.ShowDialog();
            this.Hide();
        }
        

        private void frmFloor_Load(object sender, EventArgs e)
        {
          
            this.paintFloor();
            AnimateWindow(Handle, 10000, AW_BLEND | AW_ACTIVATE);
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void frmFloor_Shown(object sender, EventArgs e)
        {
            

        }

    }
}
