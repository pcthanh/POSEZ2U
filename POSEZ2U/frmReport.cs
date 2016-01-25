using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        #region Variables & Constructors

        private IReportService _reportService;
        private IReportService ReportService
        {
            get { return _reportService ?? (_reportService = new ReportService()); }
            set { _reportService = value; }
        }


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

        void ucReportTitle_Click(object sender, EventArgs e)
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
            string[] str = { "Summary", "Quantity Sale by Group", "Quantity Sale by Item", "Sale by Staff", "Total Account", "Payment Details" };
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

        void ucReportItem_Click(object sender, EventArgs e)
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

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.CategoryName;
                ucitem.lbtotal.Text = item.TotalQty.ToString("N0");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }




        }

        private void LoadReportQtyItemDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataQTYItemReport(dateselect, 0).ToList();

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.ProductNameDesc;
                ucitem.lbtotal.Text = item.TotalQty.ToString("N0");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }


        }

        private void LoadReportSaleByStaffDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataStaffSaleReport(dateselect, 0).ToList();

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.UserName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }


        }

        private void LoadReportCardSaleDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataCardSaleReport(dateselect, 0).ToList();

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.CardName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }


        }

        private void LoadReportAccountSaleDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataAccountSaleReport(dateselect, 0).ToList();

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.FullName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }


        }

        #endregion Daily Report


        #region Weekly Report
        private void LoadReportWekky()
        {
            flpReportList.Controls.Clear();
            int i = 1;
            string[] str = { "Summary", "Quantity Sale by Group", "Quantity Sale by Item", "Sale by Staff", "Total Account", "Payment Details" };
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
        void ucWeeklyReportItem_Click(object sender, EventArgs e)
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

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.CategoryName;
                ucitem.lbtotal.Text = item.TotalQty.ToString("N0");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }


        }

        private void LoadReportWeeklyQtyItemDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();
            UCQTYReport.Dock = DockStyle.Fill;
            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataQTYItemReport(dateselect, 1).ToList();

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.ProductNameDesc;
                ucitem.lbtotal.Text = item.TotalQty.ToString("N0");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }


        }

        private void LoadReportWeeklySaleByStaffDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataStaffSaleReport(dateselect, 1).ToList();

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.UserName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }


        }

        private void LoadReportWeeklyCardSaleDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataCardSaleReport(dateselect, 1).ToList();

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.CardName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }


        }

        private void LoadReportWeeklyAccountSaleDetail()
        {
            pDetail.Controls.Clear();
            UCDailySaleQTYReport UCQTYReport = new UCDailySaleQTYReport();

            UCQTYReport.Dock = DockStyle.Fill;

            pDetail.Controls.Add(UCQTYReport);

            var dateselect = Convert.ToDateTime(dateSelect.Text).ToString("yyyy-MM-dd");

            var data = ReportService.GetDataAccountSaleReport(dateselect, 1).ToList();

            var i = 1;
            foreach (var item in data)
            {
                UCItemReport ucitem = new UCItemReport();

                ucitem.lbname.Text = item.FullName;

                var fomat = new MoneyFortmat(1);

                ucitem.lbtotal.Text = fomat.getValue(item.Total).ToString("C");

                ucitem.Size = new System.Drawing.Size(UCQTYReport.PDetail.Width - 5, ucitem.Height);

                if (i % 2 == 0)
                {
                    ucitem.BackColor = Color.FromArgb(221, 221, 221);
                }

                UCQTYReport.PDetail.Controls.Add(ucitem);
                i++;
            }


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
        void ucReportItemShift_Click(object sender, EventArgs e)
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
                shift.lblStartTime.Text = (data.StartShift ?? DateTime.Now).ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                shift.lblEndTime.Text = (data.EndShift ?? DateTime.Now).ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                shift.lblStartCash.Text = data.CashStart.ToString("C");
                shift.lblEndCash.Text = data.CashEnd.ToString("C");
                shift.lblSafeDrop.Text = data.SafeDrop.ToString("C");
                shift.lblTotal.Text = fomat.getValue(data.TotalCash).ToString("C");
                shift.lblVariation.Text = "$" + (data.CashEnd - data.CashStart-fomat.getValue(data.TotalCash)).ToString("N");
                shift.lblTotalNetSalse.Text = fomat.getValue(data.TotalSale).ToString("C");

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
            ucDailyReport.lblTotakReceiva.Text = fomat.getValue(data.NetSale + data.GST - data.Discount).ToString("C");
            ucDailyReport.lblTotakCash.Text = fomat.getValue(data.CashTotal).ToString("C");
            ucDailyReport.lblTotalCard.Text = fomat.getValue(data.CardTotal).ToString("C");
            ucDailyReport.lblTotalAccount.Text = fomat.getValue(data.AccountTotal).ToString("C");
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
    }
}
