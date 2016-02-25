using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicePOS;
using ServicePOS.Model;
using SystemLog;

namespace POSEZ2U
{
    public partial class frmAccountDebit : Form
    {
        public frmAccountDebit()
        {
            InitializeComponent();
        }
        POSEZ2U.Class.MoneyFortmat money = new Class.MoneyFortmat(POSEZ2U.Class.MoneyFortmat.AU_TYPE);

        public CustomerModel itemS;
        private IAccountPaymentService _accountService;
        private IAccountPaymentService AccountService
        {
            get { return _accountService ?? (_accountService = new AccountPaymentService()); }
            set { _accountService = value; }
        }


        private ICustomerService _customerService;
        private ICustomerService CustomerService
        {
            get { return _customerService ?? (_customerService = new CustomerService()); }
            set { _customerService = value; }
        }
        private void LoadCustomer()
        {
            flpListCus.Controls.Clear();
            var listCustomer = CustomerService.GetCustomer();
            int i = 0;
            foreach (CustomerModel item in listCustomer)
            {
                UCCustomerItem ucCusItem = new UCCustomerItem();
                ucCusItem.lblCusID.Text = item.ClientID.ToString();
                ucCusItem.lblCusName.Text = item.Fname + " " + item.Lname;
                ucCusItem.lblCusPhone.Text = item.Phone;
                if (item.Balance != 0)
                    ucCusItem.lblBalance.Text = money.Format2(item.Balance);
                else
                    ucCusItem.lblBalance.Text = "0";
                ucCusItem.lblDetail.Text = "View";
                ucCusItem.Click += ucCusItem_Click;
                ucCusItem.Width = flpListCus.Width;
                ucCusItem.Tag = item;
                if (i % 2 == 0)
                    ucCusItem.BackColor = Color.FromArgb(255, 255, 255);
                else
                    ucCusItem.BackColor = Color.FromArgb(242, 242, 242);
                flpListCus.Controls.Add(ucCusItem);
                i++;

            }
        }

        void ucCusItem_Click(object sender, EventArgs e)
        {
            UCCustomerItem cus = (UCCustomerItem)sender;
            CustomerModel item = (CustomerModel)cus.Tag;
            foreach (Control ctr in flpListCus.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 0))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            cus.BackColor = Color.FromArgb(0, 153, 0);
            cus.ForeColor = Color.FromArgb(255, 255, 255);
            if (item.Balance != 0)
                this.txtBalan.Text = money.Format2(item.Balance);
            else
                this.txtBalan.Text = "0";
            itemS = item;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccountDebit_Load(object sender, EventArgs e)
        {
            this.LoadCustomer();
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemS != null)
                {
                    AccountPaymentModel item = new AccountPaymentModel();
                    if (txtCard.Text != string.Empty)
                        item.Card =Convert.ToInt32(Convert.ToDouble(this.txtCard.Text) * 1000);
                    else
                        item.Card = 0;
                    if (txtCash.Text != string.Empty)
                        item.Cash = Convert.ToInt32(Convert.ToDouble(this.txtCash.Text) * 1000);
                    else
                        item.Cash = 0;
                    item.SubTotal = (item.Cash + item.Card);
                    item.CusNo = itemS.ClientID;
                    if (item.Cash != 0 || item.Card != 0)
                    {
                        int result = AccountService.InsertDebitAccount(item);
                        if (result == 1)
                            LoadCustomer();
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmAccountDebit:::::::::::::::::::::::btnDebit_Click::::::::::::::::" + ex.Message);
            }
        }

        private void txtSearchCus_TextChanged(object sender, EventArgs e)
        {
            flpListCus.Controls.Clear();
            var listCustomer = CustomerService.GetCustomerSearch(txtSearchCus.Text);
            int i = 0;
            foreach (CustomerModel item in listCustomer)
            {
                UCCustomerItem ucCusItem = new UCCustomerItem();
                ucCusItem.lblCusID.Text = item.ClientID.ToString();
                ucCusItem.lblCusName.Text = item.Fname + " " + item.Lname;
                ucCusItem.lblCusPhone.Text = item.Phone;
                ucCusItem.lblBalance.Text = money.Format2(item.Balance);
                ucCusItem.lblDetail.Text = "View";
                ucCusItem.Click += ucCusItem_Click;
                ucCusItem.Width = flpListCus.Width;
                ucCusItem.Tag = item;
                if (i % 2 == 0)
                    ucCusItem.BackColor = Color.FromArgb(255, 255, 255);
                else
                    ucCusItem.BackColor = Color.FromArgb(242, 242, 242);
                flpListCus.Controls.Add(ucCusItem);
                i++;

            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistoryAccPayment frm = new frmHistoryAccPayment(itemS);
            frm.ShowDialog();
        }
    }
}
