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
using ServicePOS;
using ModelPOS.ModelEntity;
using SystemLog;
using POSEZ2U.UC;

namespace POSEZ2U
{
    public partial class frmHistoryAccPayment : Form
    {
        CustomerModel CustomerItem;
        POSEZ2U.Class.MoneyFortmat money = new Class.MoneyFortmat(1);
        private IAccountPaymentService _accountService;
        private IAccountPaymentService AccountService
        {
            get { return _accountService ?? (_accountService = new AccountPaymentService()); }
            set { _accountService = value; }
        }
        public frmHistoryAccPayment(CustomerModel _item)
        {
            InitializeComponent();
            CustomerItem = _item;
        }

        private void frmHistoryAccPayment_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void InitData()
        {
            this.lblCusName.Text = CustomerItem.Fname;
            this.lblCurenbalance.Text = money.Format2(CustomerItem.Balance);
        }

        private void GetDataHistory()
        {
            try
            {
                var list = AccountService.GetAccPayment(CustomerItem.ClientID, this.dtpFrom.Value.Date, this.dtpTo.Value.Date);
                int i = 0;
                foreach (AccountPaymentModel item in list)
                {
                    UCHistoryAccPayment ucHistory = new UCHistoryAccPayment();
                    ucHistory.lblInvoiceID.Text = item.InvoiceID.ToString();
                    ucHistory.lblInvoiceNum .Text= item.InvoiceNumber.ToString();
                    ucHistory.lblSubtotal.Text = money.Format2(item.SubTotal.ToString());
                    if (item.IsCredit > 0)
                        ucHistory.lblPaymentType.Text = "Credit";
                    if(item.IsDebit>0)
                        ucHistory.lblPaymentType.Text = "Debit";
                    ucHistory.lblTime.Text = item.CreateDate.ToString();
                    if (item.Cash > 0)
                        ucHistory.lblCash.Text = "Cash";
                    
                    if (i % 2 == 0)
                        ucHistory.BackColor = Color.FromArgb(215, 215, 215);
                        
                    else
                        ucHistory.BackColor = Color.FromArgb(242, 242, 242);
                    if (item.Cash > 0)
                        ucHistory.lblCash.Text = money.Format2(item.Cash.ToString());
                    else
                        ucHistory.lblCash.Text = "0";
                    if (item.Card > 0)
                        ucHistory.lblCard.Text = money.Format2(item.Card.ToString());
                    else
                        ucHistory.lblCard.Text = "0";
                    ucHistory.ForeColor = Color.FromArgb(51, 51, 51);
                    ucHistory.Width = flpList.Width;
                    i++;
                    flpList.Controls.Add(ucHistory);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmHistoryAccPayment::::::::::::::::::::GetDataHistory::::::::::::::::::" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.GetDataHistory();
        }
    }
}
