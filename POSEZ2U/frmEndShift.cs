using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        #region Variables & Constructors

        private IShiftService _shiftService;
        private IShiftService ShiftService
        {
            get { return _shiftService ?? (_shiftService = new ShiftService()); }
            set { _shiftService = value; }
        }


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
                if (modelShift == null)
                {
                    
                    modelShift= new ShiftHistoryModel();
                    modelShift.ShiftHistoryID = 6;
                    modelShift.ShiftName = "6";
                    modelShift.UserName = "Thien";
                    modelShift.CashStart = 900;
                }

                if (modelShift != null)
                {
                    this.txtShiftName.Text = modelShift.ShiftName ?? "";
                    this.txtStaffName.Text = modelShift.UserName ?? "";
                    this.txtStartTime.Text = (modelShift.StartShift ?? DateTime.Now).ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    this.txtEndTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    this.txtCashStart.Text = (modelShift.CashStart ?? 0).ToString("C");
                    this.txtCashEnd.Text = (modelShift.CashEnd ?? 0).ToString("C");
                    this.txtSafeDrop.Text = (modelShift.SafeDrop ?? 0).ToString("C");
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

            var safeDrop = this.txtSafeDrop.Text.Replace("$", "");
            modelShift.SafeDrop = double.Parse(safeDrop);

            var result = ShiftService.UpdateDataShiftHistory(modelShift);
            var messenger = "Save data end shift fail.";
            if (result == 1)
            {
                messenger = "Save data end shift successful.";
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }

            frmMessager frm = new frmMessager("Messenger", messenger);
            frm.ShowDialog();


        }
    }
}
