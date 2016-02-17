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

namespace POSEZ2U
{
    public partial class frmPaymentAcc : Form
    {
        public frmPaymentAcc()
        {
            InitializeComponent();
        }
        public CustomerModel itemS;
        private ICustomerService _customerService;
        private ICustomerService CustomerService
        {
            get { return _customerService ?? (_customerService = new CustomerService()); }
            set { _customerService = value; }
        }

        private void LoadCustomer()
        {
            flpListAcc.Controls.Clear();
            var listCustomer = CustomerService.GetCustomer();
            int i = 0;
            foreach (CustomerModel item in listCustomer)
            {
                UCCustomerItem ucCusItem = new UCCustomerItem();
                ucCusItem.lblCusID.Text = item.ClientID.ToString();
                ucCusItem.lblCusName.Text = item.Fname + " " + item.Lname;
                ucCusItem.lblCusPhone.Text = item.Phone;
                ucCusItem.lblDetail.Text = "View";
                ucCusItem.Click += ucCusItem_Click;
                ucCusItem.Width = flpListAcc.Width;
                ucCusItem.Tag = item;
                if (i % 2 == 0)
                    ucCusItem.BackColor = Color.FromArgb(255, 255, 255);
                else
                    ucCusItem.BackColor = Color.FromArgb(242, 242, 242);
                flpListAcc.Controls.Add(ucCusItem);
                i++;

            }
        }

        void ucCusItem_Click(object sender, EventArgs e)
        {
            UCCustomerItem ucCus = (UCCustomerItem)sender;
            itemS = (CustomerModel)ucCus.Tag;
            foreach (Control ctr in flpListAcc.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 0))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucCus.BackColor = Color.FromArgb(0, 153, 0);
            ucCus.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void frmPaymentAcc_Load(object sender, EventArgs e)
        {
            this.LoadCustomer();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
