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
using ModelPOS;
using ServicePOS.Model;
namespace POSEZ2U
{
    public partial class frmNote : Form
    {
        public frmNote()
        {
            InitializeComponent();
        }
        public string Note;
        public int PrinterNote;
        private IPrinterService _printService;
        private IPrinterService PrintService
        {
            get { return _printService ?? (_printService = new PrinterService()); }
            set { _printService = value; }
        }
        private void LoadPrinter()
        {
            var data = PrintService.GetListPrinterNote();


            List<PrinterModel> lst = new List<PrinterModel>();
            foreach (PrinterModel item in data)
            {
                lst.Add(item);
            }
            cblistPrinter.DataSource = lst;
            cblistPrinter.DisplayMember = "PrintName";
            cblistPrinter.SelectedValue = "ID";

        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            LoadPrinter();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtTextNote.Text!=string.Empty)
            {
                 PrinterModel Printer = (PrinterModel)cblistPrinter.SelectedValue;
                 Note = txtTextNote.Text;
                 if (Printer.PrinterType == 0)
                     PrinterNote = 0;
                else
                    PrinterNote = Printer.ID;
                 this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
