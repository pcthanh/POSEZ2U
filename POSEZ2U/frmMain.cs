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
    public partial class frmMain : Form
    {
        private int userid = 0;
        
         

        #region Variables & Constructors

        private IPermissionService _permissionService;
        private IPermissionService PermissionService
        {
            get { return _permissionService ?? (_permissionService = new PermissionService()); }
            set { _permissionService = value; }
        }


        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEatIn_Click(object sender, EventArgs e)
        {
            Button EatIn = (Button)sender;
            var menuid = Convert.ToInt32(EatIn.Tag);
            var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
            var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
            if (result > 0)
            {
                frmFloor frm = new frmFloor();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
                frm.ShowDialog();
            }
           
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserLoginModel.UserLoginInfo= new StaffModel();
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnSettingAll_Click(object sender, EventArgs e)
        {
            Button SettingAll = (Button)sender;
            var menuid = Convert.ToInt32(SettingAll.Tag);
            var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
            var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
            frmSettingAll frm = new frmSettingAll();
            frm.ShowDialog();
            //if (result > 0)
            //{
            //    frmSettingAll frm = new frmSettingAll();
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
            //    frm.ShowDialog();
            //}
        }

        private void btnTakeAway_Click_1(object sender, EventArgs e)
        {
            Button TakeAway = (Button)sender;
            var menuid = Convert.ToInt32(TakeAway.Tag);
            var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
            var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
            frmTakeAway frm = new frmTakeAway();
            frm.ShowDialog();
            //if (result > 0)
            //{
            //    frmFloor frm = new frmFloor();
            //    this.Hide();
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
            //    frm.ShowDialog();
            //}


        }

        private void btnWorkingPeriod_Click(object sender, EventArgs e)
        {
            Button SettingAll = (Button)sender;
            var menuid = Convert.ToInt32(SettingAll.Tag);
            var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
            var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
            if (result > 0)
            {
                frmMessager frm = new frmMessager("Messenger", "Ban co quyen truy cap");
                frm.ShowDialog();
            }
            else
            {
                frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
                frm.ShowDialog();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Button SettingAll = (Button)sender;
            var menuid = Convert.ToInt32(SettingAll.Tag);
            var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
            var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
            frmReportAll frm = new frmReportAll();
            this.Close();
            frm.ShowDialog();
            //if (result > 0)
            //{
            //    frmReportAll frm = new frmReportAll();
            //    this.Close();
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
            //    frm.ShowDialog();
            //}
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            userid = UserLoginModel.UserLoginInfo.StaffID;
            if (userid == 0)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                btnEatIn.Tag = 1;


                btnTakeAway.Tag = 2;


                btnStore.Tag = 3;

                btnWorkingPeriod.Tag = 4;


                btnReport.Tag = 5;

                btnSettingAll.Tag = 6;

                this.lblNameUser.Text =UserLoginModel.UserLoginInfo.UserName;
            }

        }

       
    }
}
