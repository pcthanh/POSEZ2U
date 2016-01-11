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
using ServicePOS;
using POSEZ2U.Class;
using SystemLog;

namespace POSEZ2U
{
    public partial class frmJoinTable : Form
    {
        public frmJoinTable()
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }
        MoneyFortmat monetFormat = new MoneyFortmat(MoneyFortmat.AU_TYPE);
        public frmFloor.CallBackStatusOrder CallBackOrder;
        private delegate void ChangeTextCallback(string text, Control control);
        List<OrderJoinTableModel> lstJoinTable = new List<OrderJoinTableModel>();
        private IOrderService _orderService;
        private IOrderService OrderService
        {
            get { return _orderService ?? (_orderService = new OrderService()); }
            set { _orderService = value; }
        }
        private void paintFloor()
        {
            for (int i = 1; i < 41; i++)
            {
                UC.UCTable ucTable = new UC.UCTable();
                ucTable.lbTableNo.Text = i.ToString();
                ucTable.Click += ucTable_Click;
                flpJoinTable.Controls.Add(ucTable);
            }
        }

        void ucTable_Click(object sender, EventArgs e)
        {
            try
            {
                UCTable ucTable = (UCTable)sender;
                if (ucTable.BackColor == Color.FromArgb(0, 204, 15))
                {
                    ucTable.BackColor = Color.FromArgb(242, 242, 242);
                }
                else
                    ucTable.BackColor = Color.FromArgb(0, 204, 15);

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmJoinTable:::::::::::::::::::::ucTable_Click::::::::::::::::" + ex.Message);
            }
        }

        private void frmJoinTable_Load(object sender, EventArgs e)
        {
            paintFloor();
            CheckStatusTable();
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
        private void CheckStatusTable()
        {
            try
            {
                for (int i = 0; i < flpJoinTable.Controls.Count; i++)
                {
                    UCTable ucTable = (UCTable)flpJoinTable.Controls[i];
                    StatusTable statusTable = OrderService.GetStatusTable(ucTable.lbTableNo.Text);
                    if (statusTable.Complete == 0)
                    {
                        //ucTable.BackColor = Color.Green;
                        ucTable.ForeColor = Color.Green;
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < flpJoinTable.Controls.Count; i++)
                {
                    UCTable ucTable = (UCTable)flpJoinTable.Controls[i];
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

        private void btnJoin_Click(object sender, EventArgs e)
        {
            try
            {
                frmChooseeTableJoin frm = new frmChooseeTableJoin();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (Control ctr in flpJoinTable.Controls)
                    {
                        UCTable ucTableJoin = (UCTable)ctr;
                        if (ucTableJoin.BackColor == Color.FromArgb(0, 204, 15))
                        {
                            StatusTable st = (StatusTable)ucTableJoin.Tag;
                            OrderJoinTableModel JoinTable = new OrderJoinTableModel();
                            JoinTable.OrderID = st.OrderID;
                            JoinTable.TableID =Convert.ToInt32(st.TableID);
                            JoinTable.SubTotalTable =Convert.ToDouble(st.SubTotal);
                            JoinTable.TableIDNew = frm.TableNo;
                            lstJoinTable.Add(JoinTable);
                        }
                    }
                    if (lstJoinTable.Count > 0)
                    {
                        int result = OrderService.JoinTable(lstJoinTable);
                        if (result == 1)
                        {
                            this.Close();
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmJoinTable:::::::::::::::::btnJoin_Click::::::::::::::::;;" + ex.Message);
            }
        }
    }
}
