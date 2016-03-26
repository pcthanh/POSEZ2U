using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.UC;
using SystemLog;
using POSEZ2U.Class;
using ServicePOS;
using ServicePOS.Model;
using System.Globalization;

namespace POSEZ2U
{
    public partial class frmReport : Form
    {

        private List<ExportExcelToDataTable> DataPrinter = new List<ExportExcelToDataTable>();

        #region Variables & Constructors

        private IReportService _reportService;

        private IReportService ReportService
        {
            get { return _reportService ?? (_reportService = new ReportService()); }
            set { _reportService = value; }
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


        #region Innit From

        public frmReport()
        {
            InitializeComponent();

        }

        private void LoadTitleReport()
        {
            try
            {
                flpReport.Controls.Clear();
                string[] str = { "Shift report", "Daily Sale report", "Weekly report" };
                int i = 1;
                foreach (string strReport in str)
                {
                    UCReport ucReportTitle = new UCReport();
                    ucReportTitle.lblTitleReport.Text = strReport;
                    ucReportTitle.Width = flpReport.Width;
                    ucReportTitle.Click += ucReportTitle_Click;
                    ucReportTitle.Tag = i;
                    i++;
                    flpReport.Controls.Add(ucReportTitle);
                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmReport:::::::::::::::::::::::::LoadTitleReport:::::::::::::::::" + ex.Message);
            }
        }

        private void ucReportTitle_Click(object sender, EventArgs e)
        {
            UCReport ucReport = (UCReport)sender;
            int tag = Convert.ToInt32(ucReport.Tag);
            foreach (Control ctr in flpReport.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucReport.BackColor = Color.FromArgb(0, 102, 204);
            ucReport.ForeColor = Color.FromArgb(255, 255, 255);

            switch (tag)
            {
                case 1:
                    pDetail.Controls.Clear();
                    flpReportList.Controls.Clear();
                    LoadShiftReport();
                    break;
                case 2:
                    pDetail.Controls.Clear();
                    flpReportList.Controls.Clear();
                    LoadReportDaiLy();
                    break;
                case 3:
                    pDetail.Controls.Clear();
                    flpReportList.Controls.Clear();
                    LoadReportWekky();
                    break;
                default:
                    pDetail.Controls.Clear();
                    flpReportList.Controls.Clear();
                    break;
            }


        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            dateSelect.Format = DateTimePickerFormat.Custom;
            dateSelect.CustomFormat = "dd-MMM-yyyy";

            //var data =Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");


            this.LoadTitleReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Close();
            frm.ShowDialog();
        }



        #endregion Innit From


        #region Daily Report

        private void LoadReportDaiLy()
        {
            flpReportList.Controls.Clear();
            int i = 1;
            string[] str =
            {
                "Summary", "Quantity Sale by Group", "Quantity Sale by Item", "Sale by Staff",
                "Total Account", "Payment Details"
            };
            foreach (string strDaily in str)
            {
                UCReportItem ucReportItem = new UCReportItem();
                ucReportItem.lblTitelReportItem.Text = strDaily;
                ucReportItem.Tag = i;
                i++;
                ucReportItem.Width = flpReportList.Width;
                ucReportItem.Click += ucReportItem_Click;
                flpReportList.Controls.Add(ucReportItem);
            }
        }

        private void ucReportItem_Click(object sender, EventArgs e)
        {
            UCReportItem ucReportItem = (UCReportItem)sender;
            int tag = Convert.ToInt32(ucReportItem.Tag);
            foreach (Control ctr in flpReportList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 0))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucReportItem.BackColor = Color.FromArgb(0, 153, 0);
            ucReportItem.ForeColor = Color.FromArgb(255, 255, 255);


            switch (tag)
            {
                case 1:
                    pDetail.Controls.Clear();
                    LoadReportDetail();
                    break;
                case 2:
                    pDetail.Controls.Clear();
                    LoadReportQtyGroupDetail();
                    break;
                case 3:
                    pDetail.Controls.Clear();
                    LoadReportQtyItemDetail();
                    break;
                case 4:
                    pDetail.Controls.Clear();
                    LoadReportSaleByStaffDetail();
                    break;
                case 5:
                    pDetail.Controls.Clear();
                    LoadReportAccountSaleDetail();
                    break;
                case 6:
                    pDetail.Controls.Clear();
                    LoadReportCardSaleDetail();
                    break;
                default:
                    pDetail.Controls.Clear();
                    break;
            }



        }

        private void LoadReportDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleSumaryReport ucDailyReport = new UCDailySaleSumaryReport();
            ucDailyReport.Dock = DockStyle.Fill;

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataSummaryReport(dateselect, 0).FirstOrDefault();
            if (data != null)
            {
                SetDataSummary(ucDailyReport, data);
            }


            pDetail.Controls.Add(ucDailyReport);
        }

        private void LoadReportQtyGroupDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataQTYGroupReport(dateselect, 0).ToList();

            var export = new List<ExportExcelToDataTable>();
            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.CategoryName;
                ucitem.lbtotal.Text = item.TotalQty.ToString("N0");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);


                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.CategoryName;
                temp.Value = item.TotalQty.ToString("N0");
                export.Add(temp);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }

            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;


        }

        private void LoadReportQtyItemDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataQTYItemReport(dateselect, 0).ToList();

            var export = new List<ExportExcelToDataTable>();
            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.ProductNameDesc;
                ucitem.lbtotal.Text = item.TotalQty.ToString("N0");

                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.ProductNameDesc;
                temp.Value = item.TotalQty.ToString("N0");
                export.Add(temp);

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }
            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;

        }

        private void LoadReportSaleByStaffDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataStaffSaleReport(dateselect, 0).ToList();

            var export = new List<ExportExcelToDataTable>();
            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.UserName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.UserName;
                temp.Value = fomat.getValue(item.Total).ToString("N2");
                export.Add(temp);

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }
            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;

        }

        private void LoadReportCardSaleDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataCardSaleReport(dateselect, 0).ToList();

            var export = new List<ExportExcelToDataTable>();
            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.CardName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.CardName;
                temp.Value = fomat.getValue(item.Total).ToString("N2");
                export.Add(temp);

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }
            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;

        }

        private void LoadReportAccountSaleDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataAccountSaleReport(dateselect, 0).ToList();
            var export = new List<ExportExcelToDataTable>();
            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.FullName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.FullName;
                temp.Value = fomat.getValue(item.Total).ToString("N2");
                export.Add(temp);

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }
            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;

        }

        #endregion Daily Report


        #region Weekly Report

        private void LoadReportWekky()
        {
            flpReportList.Controls.Clear();
            int i = 1;
            string[] str =
            {
                "Summary", "Quantity Sale by Group", "Quantity Sale by Item", "Sale by Staff",
                "Total Account", "Payment Details"
            };
            foreach (string strDaily in str)
            {
                UCReportItem ucReportItem = new UCReportItem();
                ucReportItem.lblTitelReportItem.Text = strDaily;
                ucReportItem.Tag = i;
                i++;
                ucReportItem.Width = flpReportList.Width;
                ucReportItem.Click += ucWeeklyReportItem_Click;
                flpReportList.Controls.Add(ucReportItem);
            }
        }

        private void ucWeeklyReportItem_Click(object sender, EventArgs e)
        {
            UCReportItem ucReportItem = (UCReportItem)sender;
            int tag = Convert.ToInt32(ucReportItem.Tag);
            foreach (Control ctr in flpReportList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 0))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucReportItem.BackColor = Color.FromArgb(0, 153, 0);
            ucReportItem.ForeColor = Color.FromArgb(255, 255, 255);


            switch (tag)
            {
                case 1:
                    pDetail.Controls.Clear();
                    LoadWeeklyReportDetail();
                    break;
                case 2:
                    pDetail.Controls.Clear();
                    LoadReportWeeklyQtyGroupDetail();
                    break;
                case 3:
                    pDetail.Controls.Clear();
                    LoadReportWeeklyQtyItemDetail();
                    break;
                case 4:
                    pDetail.Controls.Clear();
                    LoadReportWeeklySaleByStaffDetail();
                    break;
                case 5:
                    pDetail.Controls.Clear();
                    LoadReportWeeklyAccountSaleDetail();
                    break;
                case 6:
                    pDetail.Controls.Clear();
                    LoadReportWeeklyCardSaleDetail();
                    break;
                default:
                    pDetail.Controls.Clear();
                    break;
            }


        }

        private void LoadWeeklyReportDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleSumaryReport ucDailyReport = new UCDailySaleSumaryReport();
            ucDailyReport.Dock = DockStyle.Fill;

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataSummaryReport(dateselect, 1).FirstOrDefault();
            if (data != null)
            {
                SetDataSummary(ucDailyReport, data);
            }


            pDetail.Controls.Add(ucDailyReport);
        }

        private void LoadReportWeeklyQtyGroupDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();
            UCQTYReport.Dock = DockStyle.Fill;
            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataQTYGroupReport(dateselect, 1).ToList();

            var export = new List<ExportExcelToDataTable>();


            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.CategoryName;
                ucitem.lbtotal.Text = item.TotalQty.ToString("N0");

                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.CategoryName;
                temp.Value = item.TotalQty.ToString("N0");
                export.Add(temp);

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }

            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;


        }

        private void LoadReportWeeklyQtyItemDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();
            UCQTYReport.Dock = DockStyle.Fill;
            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataQTYItemReport(dateselect, 1).ToList();

            var export = new List<ExportExcelToDataTable>();
            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.ProductNameDesc;
                ucitem.lbtotal.Text = item.TotalQty.ToString("N0");

                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.ProductNameDesc;
                temp.Value = item.TotalQty.ToString("N0");
                export.Add(temp);

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }
            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;

        }

        private void LoadReportWeeklySaleByStaffDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataStaffSaleReport(dateselect, 1).ToList();

            var export = new List<ExportExcelToDataTable>();
            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.UserName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.UserName;
                temp.Value = fomat.getValue(item.Total).ToString("N2");
                export.Add(temp);

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }
            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;

        }

        private void LoadReportWeeklyCardSaleDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataCardSaleReport(dateselect, 1).ToList();

            var export = new List<ExportExcelToDataTable>();
            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.CardName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.CardName;
                temp.Value = fomat.getValue(item.Total).ToString("N2");
                export.Add(temp);

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }
            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;

        }

        private void LoadReportWeeklyAccountSaleDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataAccountSaleReport(dateselect, 1).ToList();

            var export = new List<ExportExcelToDataTable>();
            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.FullName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                var temp = new ExportExcelToDataTable();
                temp.Tilte = item.FullName;
                temp.Value = fomat.getValue(item.Total).ToString("N2");
                export.Add(temp);

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }
            UCQTYReport.btnExport.Tag = export;
            UCQTYReport.btnExport.Click += ExportExcel_Click;

            UCQTYReport.btnPrint.Tag = export;
            UCQTYReport.btnPrint.Click += PrinterClick_Click;

        }

        #endregion Weekly Report



        #region Shift Report

        private void LoadShiftReport()
        {
            flpReportList.Controls.Clear();

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataShiftReport(dateselect).ToList();

            //string[] str = { "Shift 1", "Shift 2", "Shift All" };
            foreach (var shift in data)
            {
                UCReportItem ucReportItemShift = new UCReportItem();

                ucReportItemShift.lblTitelReportItem.Text = shift.ShiftName;
                ucReportItemShift.Tag = shift;
                ucReportItemShift.Width = flpReportList.Width;
                ucReportItemShift.Click += ucReportItemShift_Click;
                flpReportList.Controls.Add(ucReportItemShift);
            }
        }

        private void ucReportItemShift_Click(object sender, EventArgs e)
        {
            UCReportItem ucReportItem = (UCReportItem)sender;
            ShiftReportModel tag = (ShiftReportModel)(ucReportItem.Tag);
            foreach (Control ctr in flpReportList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 0))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucReportItem.BackColor = Color.FromArgb(0, 153, 0);
            ucReportItem.ForeColor = Color.FromArgb(255, 255, 255);


            pDetail.Controls.Clear();
            LoadShiftReportDetail(tag);

        }

        private void LoadShiftReportDetail(ShiftReportModel data)
        {
            if (data != null)
            {
                pDetail.Controls.Clear();
                UCShiftReport shift = new UCShiftReport();
                shift.Dock = DockStyle.Fill;

                var fomat = new MoneyFortmat(1);

                shift.lblShiftNo.Text = data.ShiftName ?? "";
                shift.lblStaff.Text = data.UserName ?? "";
                shift.lblStartTime.Text = (data.StartShift ?? DateTime.Now).ToString("dd/MM/yyyy hh:mm:ss",
                    CultureInfo.InvariantCulture);
                shift.lblEndTime.Text = (data.EndShift ?? DateTime.Now).ToString("dd/MM/yyyy hh:mm:ss",
                    CultureInfo.InvariantCulture);
                shift.lblStartCash.Text = "$" + fomat.getValue(data.CashStart).ToString("N2");
                shift.lblEndCash.Text = "$" + fomat.getValue(data.CashEnd).ToString("N2");
                shift.lblSafeDrop.Text = "$" + fomat.getValue(data.SafeDrop).ToString("N2");
                shift.lblTotal.Text = "$" + fomat.getValue(data.TotalCash).ToString("N2");
                shift.lblVariation.Text = "$" +
                                          fomat.getValue(data.CashEnd - data.CashStart - data.TotalCash).ToString("N2");
                shift.lblTotalNetSalse.Text = "$" + fomat.getValue(data.TotalSale).ToString("N2");


                var export = new List<ExportExcelToDataTable>();

                var temp1 = new ExportExcelToDataTable();
                temp1.Tilte = "Shift No";
                temp1.Value = data.ShiftName ?? "";
                export.Add(temp1);

                var temp2 = new ExportExcelToDataTable();
                temp2.Tilte = "Staff";
                temp2.Value = data.UserName ?? "";
                export.Add(temp2);

                var temp3 = new ExportExcelToDataTable();
                temp3.Tilte = "Start Time";
                temp3.Value = (data.StartShift ?? DateTime.Now).ToString("dd/MM/yyyy hh:mm:ss",
                    CultureInfo.InvariantCulture);
                export.Add(temp3);

                var temp4 = new ExportExcelToDataTable();
                temp4.Tilte = "End Time";
                temp4.Value = (data.EndShift ?? DateTime.Now).ToString("dd/MM/yyyy hh:mm:ss",
                    CultureInfo.InvariantCulture);
                export.Add(temp4);

                var temp5 = new ExportExcelToDataTable();
                temp5.Tilte = "Start Cash(Cash float in)";
                temp5.Value = fomat.getValue(data.CashStart).ToString("N2");
                export.Add(temp5);

                var temp6 = new ExportExcelToDataTable();
                temp6.Tilte = "End Cash(Counted by Staff)";
                temp6.Value = fomat.getValue(data.CashEnd).ToString("N2");
                export.Add(temp6);

                var temp7 = new ExportExcelToDataTable();
                temp7.Tilte = "Total Cash by Report";
                temp7.Value = fomat.getValue(data.TotalCash).ToString("N2");
                export.Add(temp7);

                var temp8 = new ExportExcelToDataTable();
                temp8.Tilte = "Variation";
                temp8.Value = fomat.getValue(data.CashEnd - data.CashStart - data.TotalCash).ToString("N2");
                export.Add(temp8);

                var temp9 = new ExportExcelToDataTable();
                temp9.Tilte = "Safe drop";
                temp9.Value = fomat.getValue(data.SafeDrop).ToString("N2");
                export.Add(temp9);

                var temp10 = new ExportExcelToDataTable();
                temp10.Tilte = "Total Net Sale by Shift";
                temp10.Value = fomat.getValue(data.TotalSale).ToString("N2");
                export.Add(temp10);

                shift.btnExport.Tag = export;
                shift.btnExport.Click += ExportExcel_Click;

                shift.btnPrint.Tag = export;
                shift.btnPrint.Click += PrinterClick_Click;


                pDetail.Controls.Add(shift);
            }


        }

        #endregion Shift Report


        #region Function all

        public void SetDataSummary(UCDailySaleSumaryReport ucDailyReport, DailyReportModel data)
        {
            var fomat = new MoneyFortmat(1);
            ucDailyReport.lblNetSalse.Text = fomat.getValue(data.NetSale).ToString("C");
            ucDailyReport.lblGST.Text = fomat.getValue(data.GST).ToString("C");
            ucDailyReport.lblDiscount.Text = fomat.getValue(data.Discount).ToString("C");
            ucDailyReport.lblRefund.Text = fomat.getValue(data.Refund).ToString("C");
            ucDailyReport.lblTotakReceiva.Text = "$" +
                                                 fomat.getValue(data.NetSale + data.GST - data.Discount).ToString("N2");
            ucDailyReport.lblTotakCash.Text = "$" + fomat.getValue(data.CashTotal).ToString("N2");
            ucDailyReport.lblTotalCard.Text = fomat.getValue(data.CardTotal).ToString("C");
            ucDailyReport.lblTotalAccount.Text = fomat.getValue(data.AccountTotal).ToString("C");

            var export = new List<ExportExcelToDataTable>();

            var temp1 = new ExportExcelToDataTable();
            temp1.Tilte = "Net Sale";
            temp1.Value = fomat.getValue(data.NetSale).ToString("N2");
            export.Add(temp1);

            var temp2 = new ExportExcelToDataTable();
            temp2.Tilte = "GST";
            temp2.Value = fomat.getValue(data.GST).ToString("N2");
            export.Add(temp2);

            var temp3 = new ExportExcelToDataTable();
            temp3.Tilte = "Discount";
            temp3.Value = fomat.getValue(data.Discount).ToString("N2");
            export.Add(temp3);

            var temp4 = new ExportExcelToDataTable();
            temp4.Tilte = "Refund";
            temp4.Value = fomat.getValue(data.Refund).ToString("N2");
            export.Add(temp4);

            var temp5 = new ExportExcelToDataTable();
            temp5.Tilte = "Total Receivable";
            temp5.Value = fomat.getValue(data.NetSale + data.GST - data.Discount).ToString("N2");
            export.Add(temp5);

            var temp6 = new ExportExcelToDataTable();
            temp6.Tilte = "Total CASH";
            temp6.Value = fomat.getValue(data.CashTotal).ToString("N2");
            export.Add(temp6);

            var temp7 = new ExportExcelToDataTable();
            temp7.Tilte = "Total CARD";
            temp7.Value = fomat.getValue(data.CardTotal).ToString("N2");
            export.Add(temp7);

            var temp8 = new ExportExcelToDataTable();
            temp8.Tilte = "Total ACCOUNT";
            temp8.Value = fomat.getValue(data.AccountTotal).ToString("N2");
            export.Add(temp8);

          

            ucDailyReport.btnExport.Tag = export;
            ucDailyReport.btnExport.Click += ExportExcel_Click;

            ucDailyReport.btnPrint.Tag = export;
            ucDailyReport.btnPrint.Click += PrinterClick_Click;


        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            Button ucReportItem = (Button)sender;
            List<ExportExcelToDataTable> tag = (List<ExportExcelToDataTable>)(ucReportItem.Tag);

            if (tag != null)
            {
                ExportExcelToDataTable.WriteExcelToFrom(tag);
            }


        }

        private void PrinterClick_Click(object sender, EventArgs e)
        {
            Button ucReportItem = (Button)sender;
            List<ExportExcelToDataTable> tag = (List<ExportExcelToDataTable>)(ucReportItem.Tag);

            if (tag != null)
            {
                DataPrinter = new List<ExportExcelToDataTable>();
                DataPrinter = tag;
                GetListPrinter();
                foreach (PrinterModel item in PrintData)
                {
                    Header = item.Header;
                    posPrinter.SetPrinterName(item.PrinterName);
                    posPrinter.printDocument.PrintPage += printDocument_PrintPage;
                    posPrinter.Print();
                }
            }


        }

        #endregion Function all

        private void dateSelect_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control ctr in flpReport.Controls)
            {
                ctr.BackColor = Color.FromArgb(255, 255, 255);
                ctr.ForeColor = Color.FromArgb(51, 51, 51);
            }
            flpReportList.Controls.Clear();
            pDetail.Controls.Clear();
        }


        #region Printer

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
