using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.Class;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmNewShift : Form
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

        private string fname = "";
        public frmNewShift()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmNewShift_Load(object sender, EventArgs e)
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
                fname = UserLoginModel.UserLoginInfo.UserName;

                var historyshift = ShiftService.GetListShiftHistoryByUserid(userid, 1).FirstOrDefault();

                double startcash = 0;
                if (historyshift != null)
                {
                    startcash = (historyshift.CashEnd??0) - (historyshift.SafeDrop??0);
                }

                MoneyFortmat Fomat = new MoneyFortmat(1);
                startcash = Fomat.getValue(startcash);

                var data = ShiftService.GetAllStaffActive().ToList();

                this.cbStaff.DisplayMember = "Value";
                this.cbStaff.ValueMember = "Key";

                foreach (var item in data)
                {
                    var temp = new KeyValueModel();
                    temp.Key = item.StaffID;
                    temp.Value = item.UserName;
                    this.cbStaff.Items.Add(temp);
                }

                this.cbStaff.Text = fname;
                this.txtCashStart.Text = startcash.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var model = new ShiftHistoryModel();
            model.ShiftName = this.txtShiftName.Text ?? "";
            model.StaffID = 0;

            var cbStaff = (KeyValueModel)this.cbStaff.SelectedItem;

            if (cbStaff != null)
            {
                model.StaffID = cbStaff.Key;
            }

            model.CashStart = 0;

            if (this.txtCashStart.Text != "")
            {
                model.CashStart = double.Parse(this.txtCashStart.Text);
            }

            MoneyFortmat Fomat= new MoneyFortmat(1);
            model.CashStart = Fomat.getFortMat(model.CashStart??0);

            model.CreateBy = userid;

            var messenger = "";
            if (model.ShiftName == "")
                messenger = messenger + "Shift Name isn't empty. ";

            if (model.StaffID == 0)
                messenger = messenger + "Staff Name isn't empty. ";

            if (model.CashStart == 0)
                messenger = messenger + "Cash Start isn't empty. ";

            if (messenger == "")
            {
                var result = ShiftService.InsertDataShiftHistory(model);
                messenger = "Save data new shift fail.";
                if (result >0)
                {
                    UserLoginModel.ShiffID = result;
                    messenger = "Save data new shift successful.";
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
}
