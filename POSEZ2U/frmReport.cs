﻿using System;
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

namespace POSEZ2U
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        
        private void LoadTitleReport()
        {
            try
            {
                flpReport.Controls.Clear();
                string [] str ={"Shift report","Daily Sale report","Weekly report"};
                int i = 1;
                foreach(string strReport in str)
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
            if (tag == 2)
                LoadReportDaiLy();
            else
                flpReportList.Controls.Clear();
        }

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
            if (tag == 1)
                LoadReportDetail();
            else
                pDetail.Controls.Clear();
        }
        private void LoadReportDetail()
        {
            UCDailySaleSumaryReport ucDailyReport = new UCDailySaleSumaryReport();
            ucDailyReport.Dock = DockStyle.Fill;
            pDetail.Controls.Add(ucDailyReport);
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            this.LoadTitleReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
