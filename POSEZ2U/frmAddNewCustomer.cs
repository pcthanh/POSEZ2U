using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLog;
using ServicePOS.Model;
using ServicePOS;

namespace POSEZ2U
{
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }
        public frmCustomer.CallBackCustomer CallBackCustomer;
        private ICustomerService _customerService;
        private ICustomerService CustomerService
        {
            get { return _customerService ?? (_customerService = new CustomerService()); }
            set { _customerService = value; }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertCustomer();
        }
        private void InsertCustomer()
        {
            int result = 0;
            try
            {
                CustomerModel item = new CustomerModel();
                item.Fname = txtFristName.Text;
                item.Phone = txtPhoneNumber.Text;
                item.Email = txtEmail.Text;
                item.Note = txtNote.Text;
                item.Status = 1;
                item.Balance = 0;
                result = CustomerService.InsertCustomer(item);
                if (result == 1)
                {
                    CallBackCustomer();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmAddNewCustomer::::::::::::::::::InsertCustomer::::::::::::::::::;" + ex.Message);
            }
        }
    }
}
