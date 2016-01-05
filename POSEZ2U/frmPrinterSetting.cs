using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLog;
using POSEZ2U.Class;
using ServicePOS;
using POSEZ2U.UC;
using ServicePOS.Model;
namespace POSEZ2U
{
    public partial class frmPrinterSetting : Form
    {
        private int userid = 0;
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
            userid = UserLoginModel.UserLoginInfo.StaffID;

            //MessageBox.Show("userid", userid.ToString());
            if (userid == 0)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                this.LoadPrinterSetting();
            }

            
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
        private void LoadPriterJob()
        {
            flpPrintList.Controls.Clear();
            UCPrinterList ucPListJob = new UCPrinterList();
            ucPListJob.lblPrintList.Text = "Print Receipt";
            ucPListJob.Click += ucPListJob_Click;
            flpPrintList.Controls.Add(ucPListJob);
        }

        void ucPListJob_Click(object sender, EventArgs e)
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

            pDetail.Controls.Clear();
            UCPrinterJobDetail ucJob = new UCPrinterJobDetail();
            ucJob.Dock = DockStyle.Fill;
            pDetail.Controls.Add(ucJob);
            ucJob.LoadPriterMapp();
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

            switch (flag)
            {
                case 1:
                    lblTitle.Text = "Printer";
                    LoadDataOfPrinter();
                    pDetail.Controls.Clear();
                    break;
                case 2:
                    lblTitle.Text = "Print Jobs";
                    LoadPriterJob();
                    pDetail.Controls.Clear();
                    break;
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

                    uc.btnRemove.Show();

                    uc.lblTitle.Text = item.PrintName;
                    uc.txtPrintName.Text = item.PrintName;
                    uc.cbPrintType.SelectedItem = item.PrinterType;
                    uc.cbSharePrint.SelectedItem = item.PrinterName;
                    uc.btnRemove.Click += btnRemove_Click;
                    uc.btnRemove.Tag = item;

                    uc.btnSave.Click += btnSaveInforPrinter_Click;
                    uc.btnSave.Tag = item;

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

                ucPrinter.btnSave.Click += btnSaveInforPrinter_Click;
                ucPrinter.btnSave.Tag = item;
            }
        }

        void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Button btntag = (Button)sender;
                PrinterModel item = (PrinterModel)btntag.Tag;
                item.Status = 0;
                item.UpdateBy = userid;
                item.UpdateDate = DateTime.Now;
                int result = PrinterService.UpdatePrinter(item);

                var messenger = "Delete "+ item.PrintName +" fail. ";
                if (result == 1)
                {
                    messenger = "Delete " + item.PrintName + " successful. ";
                    LoadDataOfPrinter();
                    pDetail.Controls.Clear();
                }
                frmMessager frm = new frmMessager("Messenger", messenger);
                frm.ShowDialog();
                   
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPrinterSetting:::::::::::::::::::btnRemove_Click::::::::::::::::" + ex.Message);
            }
        }

        void btnSaveInforPrinter_Click(object sender, EventArgs e)
        {
            try
            {
              
                Button btntag = (Button)sender;
                PrinterModel item = (PrinterModel)btntag.Tag;

                UCPrinter uc = (UCPrinter)pDetail.Controls[0];

                if (item != null && item.ID>0)
                {
                    item.PrintName = uc.txtPrintName.Text??"";
                    item.PrinterName = uc.cbSharePrint.Text??"";
                    item.PrinterType = uc.cbPrintType.Text??"";
                    item.Status = 1;
                    item.UpdateBy = userid;
                    item.UpdateDate = DateTime.Now;
                    var messenger = "";

                    if (item.PrintName == "")
                    {
                        messenger = messenger + "Printer Name isn't empty. ";
                    }
                    if (item.PrinterName == "")
                    {
                        messenger = messenger + "Shared Printer / Port  isn't empty. ";
                    }
                    if (item.PrinterType == "")
                    {
                        messenger = messenger + "Printer Type isn't empty. ";
                    }

                    if (messenger == "")
                    {
                        int result = PrinterService.UpdatePrinter(item);

                        messenger = "Update " + item.PrintName + " fail. ";
                        if (result == 1)
                        {
                            messenger = "Update " + item.PrintName + " successful. ";
                            LoadDataOfPrinter();
                        }
                        frmMessager frm = new frmMessager("Messenger", messenger);
                        frm.ShowDialog();
                    }
                    else
                    {
                        frmMessager frm = new frmMessager("Messenger", messenger+"Please input data.");
                        frm.ShowDialog();
                    }
                    
                        
                }
                else
                {
                    item= new PrinterModel();
                    item.PrintName = uc.txtPrintName.Text??"";
                    item.PrinterName = uc.cbSharePrint.Text??"";
                    item.PrinterType = uc.cbPrintType.Text??"";
                    item.Status = 1;
                    item.CreateBy = userid;
                    item.CreateDate = DateTime.Now;
                    int result = PrinterService.InsertPrinter(item);
                     var messenger = "";

                    if (item.PrintName == "")
                    {
                        messenger = messenger + "Printer Name isn't empty. ";
                    }
                    if (item.PrinterName == "")
                    {
                        messenger = messenger + "Shared Printer / Port  isn't empty. ";
                    }
                    if (item.PrinterType == "")
                    {
                        messenger = messenger + "Printer Type isn't empty. ";
                    }

                    if (messenger == "")
                    {
                        messenger = "Add new " + item.PrintName + " fail. ";

                        if (result == 1)
                        {
                            messenger = "Add new " + item.PrintName + " successful. ";
                            LoadDataOfPrinter();
                            pDetail.Controls.Clear();

                        }
                        frmMessager frm = new frmMessager("Messenger", messenger);
                        frm.ShowDialog();
                    }
                    else
                    {
                        frmMessager frm = new frmMessager("Messenger", messenger + "Please input data.");
                        frm.ShowDialog();
                    }
                }
                
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPrinterSetting:::::::::::::::::::btnSaveInforPrinter_Click::::::::::::::::" + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            switch (flag)
            {
                case 1:
                    pDetail.Controls.Clear();
                    UCPrinter ucPrinter = new UCPrinter();
                    ucPrinter.Dock = DockStyle.Fill;

                    ucPrinter.btnRemove.Hide();
                    
                    ucPrinter.btnSave.Click += btnSaveInforPrinter_Click;

                    ucPrinter.ResetPrinterList = new ResetPrinterList(this.ResetPriter);

                    pDetail.Controls.Add(ucPrinter);

                    break;
                case 2:
                    pDetail.Controls.Clear();
                    UCPrinterJobDetail ucJob = new UCPrinterJobDetail();
                    ucJob.Dock = DockStyle.Fill;
                    pDetail.Controls.Add(ucJob);
                    ucJob.LoadPriterMapp();
                    break;
            }
        }
        private void ResetPriter(int i)
        {
            LoadDataOfPrinter();
        }
        
    }
}
