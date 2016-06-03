using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.Class;
using POSEZ2U.UC;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmShift : Form
    {

        #region Variables & Constructors

        private IShiftService _shiftService;
        private IShiftService ShiftService
        {
            get { return _shiftService ?? (_shiftService = new ShiftService()); }
            set { _shiftService = value; }
        }


        #endregion

        private int userid = 0;
        public frmShift()
        {
            InitializeComponent();
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Button EndShift = (Button)sender;
            ShiftHistoryModel shiftmodel = (ShiftHistoryModel)(EndShift.Tag);

            if (shiftmodel != null)
            {
                frmEndShift frm = new frmEndShift(shiftmodel);
                frm.ShowDialog();

                if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    addOnDutyList("On Duty", 1);
                    frm.Close();
                }
            }
            else
            {
                frmMessager frm = new frmMessager("Messenger", "Please select row befor end shift.");
                frmOpacity.ShowDialog(this, frm);
            }
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var data = ShiftService.GetListShiftHistoryByUserid(userid, 0).ToList().FirstOrDefault();

            if (data != null)
            {
                frmMessager frm = new frmMessager("Warning", "Only one working period can be used. To create a new working period, please end the current.");
                frm.ShowDialog();
                //if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
                //{
                //    UserLoginModel.ShiffID = data.ShiftHistoryID;
                //}
            }
            else
            {
                frmNewShift frm = new frmNewShift();
                frm.ShowDialog();

                if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    addOnDutyList("On Duty", 1);
                    frm.Close();
                }
            }
        
          
        }

        private void AddShiffSetting()
        {
            string[] str = { "On Duty", "History" };
            var i = 1;
            foreach (string strList in str)
            {
                UCUserSetting ucUserSetting = new UCUserSetting();
                ucUserSetting.lblUserSetting.Text = strList;
                ucUserSetting.Tag = i;
                ucUserSetting.Click += ucShiftSetting_Click;
                ucUserSetting.Width = flpShift.Width;
                flpShift.Controls.Add(ucUserSetting);
                i = i + 1;
            }
        }


        void ucShiftSetting_Click(object sender, EventArgs e)
        {

            UCUserSetting ucProduct = (UCUserSetting)sender;
            int tag = Convert.ToInt32(ucProduct.Tag);
            foreach (Control ctr in flpShift.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucProduct.BackColor = Color.FromArgb(0, 102, 204);
            ucProduct.ForeColor = Color.FromArgb(255, 255, 255);



            flpShiftDetail.Controls.Clear();

            switch (tag)
            {
                case 1:
                    addOnDutyList("On Duty", tag);
                    break;
                case 2:
                    addHistoryList("History", tag);
                    break;

            }


        }


        public void addOnDutyList(string lblName, int i)
        {
            try 
            {
                flpShiftDetail.Controls.Clear();

                if (i == 1)
                {
                    this.btnAdd.Show();
                    this.btnEnd.Show();
                    var data = ShiftService.GetListShiftHistoryByUserid(userid, 0).ToList();

                    double totalsafe = 0;

                    foreach (var item in data)
                    {
                        var ucShift = new UCShiftItem();

                        //ucShift.Dock = DockStyle.Fill;
                        MoneyFortmat Fomat = new MoneyFortmat(1);

                        totalsafe = totalsafe + item.SafeDrop ?? 0;

                        ucShift.lblNo.Text = item.ShiftName;
                        ucShift.lblStaff.Text = item.UserName;
                        ucShift.lblStart.Text = (item.StartShift ?? DateTime.Now).ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                        ucShift.lblEnd.Text = " ";
                        if (item.EndShift != null)
                            ucShift.lblEnd.Text = (item.EndShift ?? DateTime.Now).ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                        ucShift.lblCashstart.Text = Fomat.getValue(item.CashStart ?? 0).ToString("C");
                        ucShift.lblCashend.Text = Fomat.getValue(item.CashEnd ?? 0).ToString("C");
                        ucShift.lblSfaedrop.Text = Fomat.getValue(item.SafeDrop ?? 0).ToString("C");

                        ucShift.Size = new System.Drawing.Size(flpShiftDetail.Width - 5, ucShift.Height);

                        ucShift.Tag = item;
                        ucShift.Click += UCShiftItem_Click;
                        ucShift.Width = flpShiftDetail.Width;
                        flpShiftDetail.Controls.Add(ucShift);
                    }

                    this.lblTotalSafeDrop.Text = totalsafe.ToString("C");

                }
                else
                {
                    flpShiftDetail.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("frmShift::::::::::::::::addOnDutyList:::::::::::::" + ex.Message);
            }
            
        }


        void UCShiftItem_Click(object sender, EventArgs e)
        {
            UCShiftItem ucShift = (UCShiftItem)sender;
            ShiftHistoryModel tag = (ShiftHistoryModel)(ucShift.Tag);

            btnEnd.Tag = tag;

            foreach (Control ctr in flpShiftDetail.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucShift.BackColor = Color.FromArgb(0, 153, 51);
            ucShift.ForeColor = Color.FromArgb(255, 255, 255);
        }

        public void addHistoryList(string lblName, int i)
        {
           
            if (i == 2)
            {
                this.btnAdd.Hide();
                this.btnEnd.Hide();
                var data = ShiftService.GetListShiftHistoryByUserid(userid, 1).ToList();

                double totalsafe = 0;

                foreach (var item in data)
                {
                    var ucShift = new UCShiftItem();

                    //ucShift.Dock = DockStyle.Fill;

                    totalsafe = totalsafe + item.SafeDrop ?? 0;
                    MoneyFortmat Fomat = new MoneyFortmat(1);

                    ucShift.lblNo.Text = item.ShiftName;
                    ucShift.lblStaff.Text = item.UserName;
                    ucShift.lblStart.Text = (item.StartShift??DateTime.Now).ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    ucShift.lblEnd.Text = " ";
                    if (item.EndShift != null)
                        ucShift.lblEnd.Text = (item.EndShift ?? DateTime.Now).ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    ucShift.lblCashstart.Text = Fomat.getValue(item.CashStart ?? 0).ToString("C");
                    ucShift.lblCashend.Text = Fomat.getValue(item.CashEnd ?? 0).ToString("C");
                    ucShift.lblSfaedrop.Text = Fomat.getValue(item.SafeDrop ?? 0).ToString("C");

                    ucShift.Size = new System.Drawing.Size(flpShiftDetail.Width-5, ucShift.Height);

                    flpShiftDetail.Controls.Add(ucShift);
                }

                this.lblTotalSafeDrop.Text = totalsafe.ToString("C");
            }
            else
            {
                flpShiftDetail.Controls.Clear();
            }
        }

      

        private void frmShift_Load(object sender, EventArgs e)
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
                this.AddShiffSetting();
            }

        }
    }
}
