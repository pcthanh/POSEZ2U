using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicePOS.Model;
using ServicePOS;
using SystemLog;

namespace POSEZ2U.UC
{
    public partial class UCPrinter : UserControl
    {
        public UCPrinter()
        {
            InitializeComponent();
            this.LoadPrinterMachine();
            this.LoadPrinterType();
        }
        public frmPrinterSetting.ResetPrinterList ResetPrinterList;
        private IPrinterService _printerService;
        private IPrinterService PrinterService
        {
            get { return _printerService ?? (_printerService = new PrinterService()); }
            set { _printerService = value; }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.InsertPrinter();
        }
        private void LoadPrinterMachine()
        {
            foreach (string s in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbSharePrint.Items.Add(s);
            }
        }
        private void LoadPrinterType()
        {
            cbPrintType.Items.Add("Ticket Printer");
        }
        private void InsertPrinter()
        {
            try
            {
                
                PrinterModel item = new PrinterModel();
                item.PrintName = this.txtPrintName.Text;
                item.PrinterName = this.cbSharePrint.Text;
                item.PrinterType = this.cbPrintType.Text;
                item.Status = 1;
                int result= PrinterService.InsertPrinter(item);
                if (result == 1)
                {
                    ResetPrinterList(1);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("UCPrinter:::::::::::::::::::::InsertPrinter:::::::::" + ex.Message);
            }
        }

        private void UCPrinter_Load(object sender, EventArgs e)
        {
           
        }
    }
}
