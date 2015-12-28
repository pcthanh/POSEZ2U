using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using POSEZ2U.Class;
using POSEZ2U.UC;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmReportAll : Form
    {

        #region Variables & Constructors

        private IReportService _reportService;
        private IReportService ReportService
        {
            get { return _reportService ?? (_reportService = new ReportService()); }
            set { _reportService = value; }
        }


        #endregion

        private int userid = 0;


        public frmReportAll()
        {
            InitializeComponent();
        }
        private void AddReportShow()
        {
            string[] str = { "Daily Sale", "Weekly Sale" };
            var i = 1;
            foreach (string strList in str)
            {
                UCUserSetting ucUserSetting = new UCUserSetting();
                ucUserSetting.lblUserSetting.Text = strList;
                ucUserSetting.Tag = i;
                ucUserSetting.Click += ucReportShow_Click;
                flpUserSetting.Controls.Add(ucUserSetting);
                i = i + 1;
            }
        }


        void ucReportShow_Click(object sender, EventArgs e)
        {

            UCUserSetting ucProduct = (UCUserSetting)sender;
            int tag = Convert.ToInt32(ucProduct.Tag);
            foreach (Control ctr in flpUserSetting.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucProduct.BackColor = Color.FromArgb(0, 102, 204);
            ucProduct.ForeColor = Color.FromArgb(255, 255, 255);

            flpUserList.Controls.Clear();

            pDetail.Controls.Clear();

            switch (tag)
            {
                case 1:
                    AddDailySaleReport("Daily Sale - PAYMENT", tag);
                    break;
                case 2:
                    AddWeeklySaleReport("Weekly Sale - PAYMENT", tag);
                    break;

            }


        }


        private void AddDailySaleReport(string lblName, int i)
        {
           
            if (i == 1)
            {
                var data = ReportService.GetDataDailyReport().ToList();
                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();

                lblTitle.Text = lblName;
                lblTitle.BackColor = Color.FromArgb(0, 102, 204);
                lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (var item in data)
                {
                    UCUserList ucDepartment1 = new UCUserList();
                    //ucDepartment1.Dock = DockStyle.Fill;
                    ucDepartment1.lblUserList.Text = "Total Sale : " + item.SaleTotal.ToString("C");
                    ucDepartment1.Tag = 0;
                    ucDepartment1.Click += ucShowDailyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment1);


                    UCUserList ucDepartment2 = new UCUserList();
                    // ucDepartment2.Dock = DockStyle.Fill;
                    ucDepartment2.lblUserList.Text = "Total Cash : " + item.CashTotal.ToString("C");
                    ucDepartment2.Tag = 1;
                    ucDepartment2.Click += ucShowDailyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment2);

                    UCUserList ucDepartment3 = new UCUserList();
                    // ucDepartment3.Dock = DockStyle.Fill;
                    ucDepartment3.lblUserList.Text = "Total Card : " + item.CardTotal.ToString("C");
                    ucDepartment3.Tag = 2;
                    ucDepartment3.Click += ucShowDailyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment3);

                    UCUserList ucDepartment4 = new UCUserList();
                    //ucDepartment4.Dock = DockStyle.Fill;
                    ucDepartment4.lblUserList.Text = "Total Cheque : " + item.ChequeTotal.ToString("C");
                    ucDepartment4.Tag = 3;
                    ucDepartment4.Click += ucShowDailyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment4);

                    UCUserList ucDepartment5 = new UCUserList();
                    //ucDepartment4.Dock = DockStyle.Fill;
                    ucDepartment5.lblUserList.Text = "Total Account : " + item.AccountTotal.ToString("C");
                    ucDepartment5.Tag = 4;
                    ucDepartment5.Click += ucShowDailyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment5);

                    UCUserList ucDepartment6 = new UCUserList();
                    //ucDepartment4.Dock = DockStyle.Fill;
                    ucDepartment6.lblUserList.Text = "Total Gift Card : " + item.GrifCardTotal.ToString("C");
                    ucDepartment6.Tag = 5;
                    ucDepartment6.Click += ucShowDailyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment5);
                }
            }
            else
            {
                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();
            }
        }


        void ucShowDailyReportDetail_Click(object sender, EventArgs e)
        {
            UCUserList ucDailyReport = (UCUserList)sender;
            int tag = Convert.ToInt32(ucDailyReport.Tag);
            foreach (Control ctr in flpUserList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucDailyReport.BackColor = Color.FromArgb(0, 153, 51);
            ucDailyReport.ForeColor = Color.FromArgb(255, 255, 255);
            ShowDetailDailyReport(tag);
        }

        void ShowDetailDailyReport(int PaymentTypeID)
        {
            pDetail.Controls.Clear();

            UCReportList ucReportListTitle= new UCReportList();

            //ucReportListTitle.Visible = true;
            ucReportListTitle.BackColor = Color.FromArgb(0, 102, 204);
            ucReportListTitle.ForeColor = Color.FromArgb(255, 255, 255);
            //ucReportListTitle.Dock = DockStyle.Fill;
            pDetail.Controls.Add(ucReportListTitle);


            var dataDetailList = ReportService.GetDataDetailDailyReport(PaymentTypeID).ToList();

            foreach (var item in dataDetailList)
            {
                UCReportList ucReportNew = new UCReportList();
              
                ucReportNew.lblInvoice.Text = item.InvoiceID.ToString();
                ucReportNew.lblIINVNumber.Text = item.InvoiceNumber;
                ucReportNew.lblOrderID.Text = item.OrderID.ToString();
                ucReportNew.lblCreateDate.Text = item.CreateDateString;
                ucReportNew.lblTotal.Text = item.Total.ToString("C");


                pDetail.Controls.Add(ucReportNew);
            }


        }


     

        private void AddWeeklySaleReport(string lblName, int i)
        {
          
            if (i == 2)
            {
               
                var data = ReportService.GetDataWeeklyReport().ToList();

                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();

                lblTitle.Text = lblName;
                lblTitle.BackColor = Color.FromArgb(0, 102, 204);
                lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (var item in data)
                {
                    UCUserList ucDepartment1 = new UCUserList();
                    //ucDepartment1.Dock = DockStyle.Fill;
                    ucDepartment1.lblUserList.Text = "Total Sale : " + item.SaleTotal.ToString("C");
                    ucDepartment1.Tag = 0;
                    ucDepartment1.Click += ucShowWeeklyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment1);


                    UCUserList ucDepartment2 = new UCUserList();
                    // ucDepartment2.Dock = DockStyle.Fill;
                    ucDepartment2.lblUserList.Text = "Total Cash : " + item.CashTotal.ToString("C");
                    ucDepartment2.Tag = 1;
                    ucDepartment2.Click += ucShowWeeklyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment2);

                    UCUserList ucDepartment3 = new UCUserList();
                    // ucDepartment3.Dock = DockStyle.Fill;
                    ucDepartment3.lblUserList.Text = "Total Card : " + item.CardTotal.ToString("C");
                    ucDepartment3.Tag = 2;
                    ucDepartment3.Click += ucShowWeeklyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment3);

                    UCUserList ucDepartment4 = new UCUserList();
                    //ucDepartment4.Dock = DockStyle.Fill;
                    ucDepartment4.lblUserList.Text = "Total Cheque : " + item.ChequeTotal.ToString("C");
                    ucDepartment4.Tag = 3;
                    ucDepartment4.Click += ucShowWeeklyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment4);

                    UCUserList ucDepartment5 = new UCUserList();
                    //ucDepartment4.Dock = DockStyle.Fill;
                    ucDepartment5.lblUserList.Text = "Total Account : " + item.AccountTotal.ToString("C");
                    ucDepartment5.Tag = 4;
                    ucDepartment5.Click += ucShowWeeklyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment5);

                    UCUserList ucDepartment6 = new UCUserList();
                    //ucDepartment4.Dock = DockStyle.Fill;
                    ucDepartment6.lblUserList.Text = "Total Gift Card : " + item.GrifCardTotal.ToString("C");
                    ucDepartment6.Tag = 5;
                    ucDepartment6.Click += ucShowWeeklyReportDetail_Click;
                    flpUserList.Controls.Add(ucDepartment5);
                }
            }
            else
            {
                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();
            }
        }

        void ucShowWeeklyReportDetail_Click(object sender, EventArgs e)
        {
            UCUserList ucDailyReport = (UCUserList)sender;
            int tag = Convert.ToInt32(ucDailyReport.Tag);
            foreach (Control ctr in flpUserList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucDailyReport.BackColor = Color.FromArgb(0, 153, 51);
            ucDailyReport.ForeColor = Color.FromArgb(255, 255, 255);
            ShowDetailWeeklyReport(tag);
        }

        void ShowDetailWeeklyReport(int PaymentTypeID)
        {
            pDetail.Controls.Clear();

            UCReportList ucReportListTitle = new UCReportList();

            //ucReportListTitle.Visible = true;
            ucReportListTitle.BackColor = Color.FromArgb(0, 102, 204);
            ucReportListTitle.ForeColor = Color.FromArgb(255, 255, 255);
            //ucReportListTitle.Dock = DockStyle.Fill;
            pDetail.Controls.Add(ucReportListTitle);


            var dataDetailList = ReportService.GetDataDetailWeeklyReport(PaymentTypeID).ToList();

            foreach (var item in dataDetailList)
            {
                UCReportList ucReportNew = new UCReportList();
              
                ucReportNew.lblInvoice.Text = item.InvoiceID.ToString();
                ucReportNew.lblIINVNumber.Text = item.InvoiceNumber;
                ucReportNew.lblOrderID.Text = item.OrderID.ToString();
                ucReportNew.lblCreateDate.Text = item.CreateDateString;
                ucReportNew.lblTotal.Text = item.Total.ToString("C");

                pDetail.Controls.Add(ucReportNew);
            }


        }
     

        private void frmUserSetting_Load(object sender, EventArgs e)
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
                this.AddReportShow();
            }

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            frmMain frm = new frmMain();
            this.Close();
            frm.ShowDialog();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
