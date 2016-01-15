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
    public partial class frmAgainShift : Form
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

        private int shiftid = 0;
       
        public frmAgainShift()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmEndShift_Load(object sender, EventArgs e)
        {
             userid = UserLoginModel.UserLoginInfo.StaffID;

            var modelShift = ShiftService.GetListShiftHistoryByUserid(userid, 0).FirstOrDefault();

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

                    shiftid = modelShift.ShiftHistoryID;

                    this.txtShiftName.Text = modelShift.ShiftName ?? "";
                    this.txtStaffName.Text = modelShift.UserName ?? "";
                    this.txtStartTime.Text = (modelShift.StartShift ?? DateTime.Now).ToString("dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    this.txtCashStart.Text = (modelShift.CashStart ?? 0).ToString("C");
                 
                }
                else
                {
                    frmMessager frm = new frmMessager("Messenger", "Please create new shift. ");
                    this.Close();
                    frm.ShowDialog();
                }
               
            }
        }

      
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserLoginModel.ShiffID = shiftid;
            frmMain frm= new frmMain();
            this.Close();
            frm.ShowDialog();
        }
    }
}
