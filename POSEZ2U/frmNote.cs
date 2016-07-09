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
            try
            {
                var data = PrintService.GetListPrinterNotPayment();
                List<PrinterModel> lst = new List<PrinterModel>();
                foreach (PrinterModel item in data)
                {
                    lst.Add(item);
                }
                cblistPrinter.DataSource = lst;
                cblistPrinter.Tag = lst;
                cblistPrinter.DisplayMember = "PrintName";
                cblistPrinter.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("frmOpenItem::::::::::::::::::::::::LoadPrinter::::::::::::::::::" + ex.Message);
            }

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
            try
            {
                if (txtTextNote.Text != string.Empty)
                {
                    //PrinterModel Printer = (PrinterModel)cblistPrinter.SelectedValue;
                    int selectValue =Convert.ToInt32(cblistPrinter.SelectedValue.ToString());
                    Note = txtTextNote.Text;
                    if (selectValue == 0)
                        PrinterNote = 0;
                    else
                        PrinterNote = selectValue;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("frmNote:::::::::::::::::btnOK_Click:::::::::::::::::::::" + ex.Message);
            }
        }
    }
}
