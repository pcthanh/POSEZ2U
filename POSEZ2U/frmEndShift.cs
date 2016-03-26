using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.Class;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmEndShift : Form
    {
        private List<ExportExcelToDataTable> DataPrinter = new List<ExportExcelToDataTable>();
        #region Variables & Constructors

        private IShiftService _shiftService;
        private IShiftService ShiftService
        {
            get { return _shiftService ?? (_shiftService = new ShiftService()); }
            set { _shiftService = value; }
        }

        private IPrinterService _printService;

        private IPrinterService PrintService
        {
            get { return _printService ?? (_printService = new PrinterService()); }
            set { _printService = value; }
        }

        private Printer.POSPrinter posPrinter = new Printer.POSPrinter();
        private List<PrinterModel> PrintData = new List<PrinterModel>();
        private string Header = string.Empty;
        private string TableNew = string.Empty;


        #endregion

        private int userid = 0;

        private ShiftHistoryModel modelShift= new ShiftHistoryModel();
        public frmEndShift(ShiftHistoryModel data)
        {
            InitializeComponent();

            modelShift = data;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmEndShift_Load(object sender, EventArgs e)
        {
             userid = UserLoginModel.UserLoginInfo.StaffID;

            if (userid == 0)
            {
                Form1 frm = new Form1();
                this.Close();
                frm.ShowDialog();
            }
            else
            {
                if (modelShift != null)
                {
                    MoneyFortmat Fomat = new MoneyFortmat(1);

                    this.txtShiftName.Text = modelShift.ShiftName ?? "";
                    this.txtStaffName.Text = modelShift.UserName ?? "";
                    this.txtStartTime.Text = (modelShift.StartShift ?? DateTime.Now).ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    this.txtEndTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    this.txtCashStart.Text = Fomat.getValue(modelShift.CashStart ?? 0).ToString("C");
                    this.txtCashEnd.Text = Fomat.getValue(modelShift.CashEnd ?? 0).ToString("C");
                    this.txtSafeDrop.Text = Fomat.getValue(modelShift.SafeDrop ?? 0).ToString("C");
                }
               
            }
        }

        private void btnDropAll_Click(object sender, EventArgs e)
        {
            this.txtSafeDrop.Text = this.txtCashEnd.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          

            modelShift.UpdateBy = userid;
            modelShift.UpdateDate = DateTime.Now;
            modelShift.EndShift = DateTime.Now;

            var cashEnd = this.txtCashEnd.Text.Replace("$", "");
            modelShift.CashEnd = double.Parse(cashEnd);

            MoneyFortmat Fomat = new MoneyFortmat(1);
            modelShift.CashEnd = Fomat.getFortMat(modelShift.CashEnd??0);

            var safeDrop = this.txtSafeDrop.Text.Replace("$", "");
            modelShift.SafeDrop = double.Parse(safeDrop);
            modelShift.SafeDrop = Fomat.getFortMat(modelShift.SafeDrop ?? 0);

            if (modelShift.CashEnd < modelShift.CashStart)
            {
                frmMessager frm = new frmMessager("Messenger", "Cash end isn't less than cash start. ");
                frmOpacity.ShowDialog(this, frm);
            }
            else
            {
                var result = ShiftService.UpdateDataShiftHistory(modelShift);
                var messenger = "Save data end shift fail.";
                if (result > 0)
                {
                    AddDataPrinter();
                    GetListPrinter();
                    foreach (PrinterModel item in PrintData)
                    {
                        Header = item.Header;
                        posPrinter.SetPrinterName(item.PrinterName);
                        posPrinter.printDocument.PrintPage += printDocument_PrintPage;
                        posPrinter.Print();
                    }
                    UserLoginModel.ShiffID = 0;
                    messenger = "Save data end shift successful.";
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }

                frmMessager frm = new frmMessager("Messenger", messenger);
                frmOpacity.ShowDialog(this, frm);
            }
            


        }


        #region Printer

        public void AddDataPrinter()
        {
            MoneyFortmat Fomat = new MoneyFortmat(1);
            DataPrinter = new List<ExportExcelToDataTable>();

            var temp1 = new ExportExcelToDataTable();
            temp1.Tilte = "Shift Name";
            temp1.Value = modelShift.ShiftName ?? "";
            DataPrinter.Add(temp1);

            var temp2 = new ExportExcelToDataTable();
            temp2.Tilte = "Staff Name";
            temp2.Value = modelShift.UserName ?? "";
            DataPrinter.Add(temp2);

            var temp3 = new ExportExcelToDataTable();
            temp3.Tilte = "Start Time";
            temp3.Value = (modelShift.StartShift ?? DateTime.Now).ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            DataPrinter.Add(temp3);

            var temp4 = new ExportExcelToDataTable();
            temp4.Tilte = "End Time";
            temp4.Value = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            DataPrinter.Add(temp4);

            var temp5 = new ExportExcelToDataTable();
            temp5.Tilte = "Cash Start";
            temp5.Value = Fomat.getValue(modelShift.CashStart ?? 0).ToString("C");
            DataPrinter.Add(temp5);

            var temp6 = new ExportExcelToDataTable();
            temp6.Tilte = "Cash End";
            temp6.Value = Fomat.getValue(modelShift.CashEnd ?? 0).ToString("C");
            DataPrinter.Add(temp6);

            var temp7 = new ExportExcelToDataTable();
            temp7.Tilte = "Safe Drop";
            temp7.Value = Fomat.getValue(modelShift.SafeDrop ?? 0).ToString("C");
            DataPrinter.Add(temp7);
            
        }

        private void GetListPrinter()
        {
            PrintData.Clear();
            var listPrinter = PrintService.GetListPrinterReport();
            foreach (PrinterModel item in listPrinter)
            {
                PrinterModel print = new PrinterModel();
                print.PrinterName = item.PrinterName;
                print.PrintName = item.PrintName;
                print.PrinterType = item.PrinterType;
                print.Header = item.Header;
                print.ID = item.ID;
                PrintData.Add(print);
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float l_y = 0;
            l_y = posPrinter.DrawString(Header, e, new Font("Arial", 14, FontStyle.Italic), l_y, 2);
            l_y += posPrinter.GetHeightPrinterLine() / 10;
            l_y = posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
            l_y = posPrinter.DrawString(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), e,
                new Font("Arial", 14, FontStyle.Italic), l_y, 1);
            l_y += posPrinter.GetHeightPrinterLine() / 10;
            l_y = posPrinter.DrawString("OPERATOR#MANAGER", e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);

            foreach (var item in DataPrinter)
            {
                string textstring = item.Tilte + " : " + item.Value;
                l_y = posPrinter.DrawString(textstring, e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
            }


            l_y += posPrinter.GetHeightPrinterLine() / 2;
            l_y = posPrinter.DrawString("www.bires.com.au", e, new Font("Arial", 10), l_y, 2);
            l_y = posPrinter.DrawString("Eat.Drink.Laugh-A touch of Laos", e, new Font("Arial", 10), l_y, 2);
            l_y = posPrinter.DrawString("Thank you,see you soon", e, new Font("Arial", 10), l_y, 2);
        }


        #endregion
    }
}
