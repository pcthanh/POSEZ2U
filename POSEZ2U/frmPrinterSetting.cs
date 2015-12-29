using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLog;
using ServicePOS;
using POSEZ2U.UC;
using ServicePOS.Model;
namespace POSEZ2U
{
    public partial class frmPrinterSetting : Form
    {
        public frmPrinterSetting()
        {
            InitializeComponent();
        }
        int flag;
        public delegate void ResetPrinterList(int i);
        private IPrinterService _printerService;
        private IPrinterService PrinterService
        {
            get { return _printerService ?? (_printerService = new PrinterService()); }
            set { _printerService = value; }
        }
        private void frmPrinterSetting_Load(object sender, EventArgs e)
        {
            LoadPrinterSetting();
        }
        private void LoadPrinterSetting()
        {
            try
            {
                string []str={"Printer","Print Jobs"};
                int i = 1;
                foreach (string item in str)
                {
                    UCPrintSetting ucPSetting = new UCPrintSetting();
                    ucPSetting.lblPrintSetting.Text = item;
                    ucPSetting.Tag = i +"";
                    i++;
                    ucPSetting.Width = flpPrintSetting.Width;
                    ucPSetting.Click += ucPSetting_Click;
                    flpPrintSetting.Controls.Add(ucPSetting);
                   
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPrinterSetting:::::::::::::::::::LoadPrinterSetting::::::::::::::::" + ex.Message);
            }
        }
        private void LoadDataOfPrinter()
        {
            flpPrintList.Controls.Clear();
            var listData = PrinterService.GetListPrinter();
            if (listData.Count() == 0)
            {
                UCPrinterList ucPList = new UCPrinterList();
                ucPList.lblPrintList.Text = "List empty";
                flpPrintList.Controls.Add(ucPList);
            }
            else
            {
                foreach (PrinterModel item in listData)
                {
                    UCPrinterList ucPList = new UCPrinterList();
                    ucPList.lblPrintList.Text = item.PrintName;
                    ucPList.Tag = item;
                    ucPList.Click += ucPList_Click;
                    ucPList.Width = flpPrintList.Width;
                    flpPrintList.Controls.Add(ucPList);
                }
            }
           
        }
        void ucPSetting_Click(object sender, EventArgs e)
        {
            UCPrintSetting ucP = (UCPrintSetting)sender;
            flag = Convert.ToInt32(ucP.Tag);
            foreach (Control ctr in flpPrintSetting.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucP.BackColor = Color.FromArgb(0, 153, 51);
            ucP.ForeColor = Color.FromArgb(255, 255, 255);
            if (flag == 1)
            {
                lblTitle.Text = "Printer";
                LoadDataOfPrinter();
            }
            else
            {
                lblTitle.Text = "Print Jobs"; 
            }

        }

        void ucPList_Click(object sender, EventArgs e)
        {
            UCPrinterList ucPList = (UCPrinterList)sender;
            PrinterModel item = (PrinterModel)ucPList.Tag;
            foreach (Control ctr in flpPrintList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucPList.BackColor = Color.FromArgb(0, 153, 51);
            ucPList.ForeColor = Color.FromArgb(255, 255, 255);
            if (pDetail.Controls.Count > 0)
            {
                if (pDetail.Controls[0] is UCPrinter)
                {
                    UCPrinter uc = (UCPrinter)pDetail.Controls[0];
                    uc.lblTitle.Text = item.PrintName;
                    uc.txtPrintName.Text = item.PrintName;
                    uc.cbPrintType.SelectedItem = item.PrinterType;
                    uc.cbSharePrint.SelectedItem = item.PrinterName;
                    uc.btnRemove.Click += btnRemove_Click;
                    uc.btnRemove.Tag = item;
                }
            }
            else
            {
                UCPrinter ucPrinter = new UCPrinter();
               
                ucPrinter.Width = pDetail.Width;
                ucPrinter.Dock = DockStyle.Fill;
                pDetail.Controls.Add(ucPrinter);
                ucPrinter.lblTitle.Text = item.PrintName;
                ucPrinter.txtPrintName.Text = item.PrintName;
                ucPrinter.cbPrintType.SelectedItem = item.PrinterType;
                ucPrinter.cbSharePrint.SelectedItem = item.PrinterName;
                ucPrinter.btnRemove.Click += btnRemove_Click;
                ucPrinter.btnRemove.Tag = item;
            }
        }

        void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Button btntag = (Button)sender;
                PrinterModel item = (PrinterModel)btntag.Tag;
                item.Status = 0;
                int result = PrinterService.UpdatePrinter(item);
                if (result == 1)
                    LoadDataOfPrinter();
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPrinterSetting:::::::::::::::::::btnRemove_Click::::::::::::::::" + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                UCPrinter ucPrinter = new UCPrinter();
                ucPrinter.Dock = DockStyle.Fill;
                ucPrinter.ResetPrinterList = new ResetPrinterList(this.ResetPriter);
                pDetail.Controls.Add(ucPrinter);
            }
        }
        private void ResetPriter(int i)
        {
            LoadDataOfPrinter();
        }
        
    }
}
