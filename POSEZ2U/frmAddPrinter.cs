using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelPOS.ModelEntity;
using ServicePOS.Model;
using ServicePOS;

namespace POSEZ2U
{
    public partial class frmAddPrinter : Form
    {
        /// <summary>
        /// PrintType
        /// 0.In ra may in tong khi SendOrder
        /// 1.In ra tung may in khi lay SendOrder
        /// 2.In khi Jointable
        /// 3.In khi TransferTable
        /// 4.In khi Tinh tien Order
        /// </summary>
        public frmAddPrinter(PrinterModel _PrinterMain)
        {
            InitializeComponent();
            PrinterMain = _PrinterMain;
        }
        PrinterModel PrinterMain;
        private IPrinterSettingServer _printService;
        private IPrinterSettingServer PrintService
        {
            get { return _printService ?? (_printService = new PrinterSettingServer()); }
            set { _printService = value; }
        }
        private void frmAddPrinter_Load(object sender, EventArgs e)
        {
            LoadPrinterMachine();
            if (PrinterMain.ID>0)
            {
                txtPrintName.Text = PrinterMain.PrintName;
                txtHeader.Text = PrinterMain.Header;
                cbPrinter.SelectedItem = PrinterMain.PrinterName;
                cbPrintType.SelectedIndex = PrinterMain.PrinterType;
                txtNumberOfTicket.Text = PrinterMain.NumberOfTicket.ToString();
            }
            
        }
        private void LoadPrinterMachine()
        {
            foreach (string s in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbPrinter.Items.Add(s);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            PrinterModel item = new PrinterModel();
            item.PrinterName = cbPrinter.SelectedItem.ToString();
            item.PrintName = txtPrintName.Text;
            item.Header = txtHeader.Text;
            item.PrinterType = cbPrintType.SelectedIndex;
            item.NumberOfTicket = Convert.ToInt32(txtNumberOfTicket.Text);
            
            if (PrinterMain.ID==0)
            {
                int result = PrintService.InsertPrinter(item);
                if (result == 1)
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                item.ID = PrinterMain.ID;
                item.Status = PrinterMain.Status;
                int result = PrintService.UpdatePrinter(item);
                if (result == 1)
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
