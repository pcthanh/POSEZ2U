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


namespace POSEZ2U
{
    public partial class frmOpenItem : Form
    {
        public frmOpenItem(int _flag)
        {
            InitializeComponent();
            Flag = _flag;
        }
        int Flag;
        private IPrinterService _printService;
        private IPrinterService PrintService
        {
            get { return _printService ?? (_printService = new PrinterService()); }
            set { _printService = value; }
        }
        public OrderDetailModel items = new OrderDetailModel();

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOpenitemName.Text != string.Empty)
                {
                    items.ProductName = txtOpenitemName.Text;
                    if (txtOpenItemPrice.Text != string.Empty)
                        items.Price = Convert.ToDouble(txtOpenItemPrice.Text) * 1000;
                    else
                        items.Price = 0;
                    items.OpenItem = 1;
                    //PrinterModel Printer = (PrinterModel)cbPrinter.Tag;
                    PrinteJobDetailModel job = new PrinteJobDetailModel();
                    if (Flag == 0)
                    {
                        items.Printer = Convert.ToInt32(cbPrinter.SelectedValue.ToString());
                        job.PrinterID = Convert.ToInt32(cbPrinter.SelectedValue.ToString());
                    }
                    items.ListPrintJob.Add(job);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("frmOpenItem:::::::::::::::::::::::btnOK_Click:::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void LoadPrinter()
        {
            try
            {
                var data = PrintService.GetListPrinterNotPayment();
                List<PrinterModel> lst = new List<PrinterModel>();
                foreach (PrinterModel item in data)
                {
                    lst.Add(item);
                }
                cbPrinter.DataSource = lst;
                cbPrinter.Tag = lst;
                cbPrinter.DisplayMember = "PrintName";
                cbPrinter.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("frmOpenItem::::::::::::::::::::::::LoadPrinter::::::::::::::::::" + ex.Message);
            }

        }

        private void frmOpenItem_Load(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                cbPrinter.Enabled = false;
            }
            else
            {
                LoadPrinter();
            }

        }
    }
}