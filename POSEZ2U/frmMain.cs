﻿using System;
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
using SystemLog;
using ModelPOS.ModelEntity;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmMain : Form
    {
        private int userid = 0;
        
         private POSEZ2UEntities _context;
        ORDER_DATE orderDate = new ORDER_DATE();
        public int DynID;
       
        public frmMain ()
        {
            InitializeComponent();
            _context = new POSEZ2UEntities();
          
        }

        public frmMain(POSEZ2UEntities context)
        {
            _context = context;
        }

        public void SetProxyCreationEnabled(bool proxyCreationEnabled)
        {
            _context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }

        #region Variables & Constructors

        private IPermissionService _permissionService;
        private IPermissionService PermissionService
        {
            get { return _permissionService ?? (_permissionService = new PermissionService()); }
            set { _permissionService = value; }
        }


        #endregion

        
        private IOrderService _orderService;
        private IOrderService OrderService
        {
            get { return _orderService ?? (_orderService = new OrderService()); }
            set { _orderService = value; }
        }

        private IShiftService _shiftService;
        private IShiftService ShiftService
        {
            get { return _shiftService ?? (_shiftService = new ShiftService()); }
            set { _shiftService = value; }
        }
        private void btnEatIn_Click(object sender, EventArgs e)
        {
            try
            {
                Button EatIn = (Button)sender;
                var menuid = Convert.ToInt32(EatIn.Tag);
                var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
                var shiftid = UserLoginModel.ShiffID;
                var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
                //frmFloor frm = new frmFloor();
                //frm.Show();
                if (result > 0)
                {
                    if (shiftid > 0)
                    {
                        frmFloor frm = new frmFloor();
                        frm.Show();
                    }
                    else
                    {
                        frmAgainShift frm = new frmAgainShift();
                        if (frmOpacity.ShowDialog(this,frm) == System.Windows.Forms.DialogResult.OK)
                        {
                            this.picWarning.Show();
                            this.lbWarning.Show();
                            frmFloor frm1 = new frmFloor();
                            frm1.Show();
                        }
                    }


                }
                else
                {
                    frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
                    frmOpacity.ShowDialog(this, frm);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmMmain:::::::::::::::::::::::btnEatIn_Click:::::::::::::::::" + ex.Message);
            }
           
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                //UserLoginModel.UserLoginInfo= new StaffModel();
                //Form1 frm = new Form1();
                //this.Hide();
                //frm.ShowDialog();
                frmDailogExit frm = new frmDailogExit();
                // frmOpacity.ShowDialog(this, frm);
                if (frmOpacity.ShowDialog(this, frm) == System.Windows.Forms.DialogResult.OK)
                {
                    UserLoginModel.UserLoginInfo = new StaffModel();
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("frmMain::::::::::::::::btnLogOut_Click:::::::::::::::::::" + ex.Message);
            }
        }

        private void btnSettingAll_Click(object sender, EventArgs e)
        {
            try
            {
                Button SettingAll = (Button)sender;
                var menuid = Convert.ToInt32(SettingAll.Tag);
                var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
                var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
                //frmSettingAll frm = new frmSettingAll();
                //frm.ShowDialog();
                if (result > 0)
                {
                    frmSettingAll frm = new frmSettingAll();
                    frm.ShowDialog();
                }
                else
                {
                    frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
                    frmOpacity.ShowDialog(this, frm);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmMain::::::::::::::::::::::::btnSettingAll_Click:::::::::::::::::::" + ex.Message);
            }
        }

        private void btnTakeAway_Click_1(object sender, EventArgs e)
        {
            try
            {
                Button TakeAway = (Button)sender;
                var menuid = Convert.ToInt32(TakeAway.Tag);
                var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
                var shiftid = UserLoginModel.ShiffID;
                var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
                //frmTakeAway frm = new frmTakeAway();
                //frm.ShowDialog();
                if (result > 0)
                {
                    if (shiftid > 0)
                    {
                        frmTakeAway frm = new frmTakeAway();
                        this.picWarning.Show();
                        this.lbWarning.Show();
                        frm.ShowDialog();
                    }
                    else
                    {
                        frmAgainShift frm = new frmAgainShift();
                        if (frmOpacity.ShowDialog(this,frm) == System.Windows.Forms.DialogResult.OK)
                        {
                            frmTakeAway frm1 = new frmTakeAway();
                            this.picWarning.Show();
                            this.lbWarning.Show();
                            frm1.ShowDialog();
                        }
                    }

                }
                else
                {
                    frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
                    frmOpacity.ShowDialog(this, frm);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmMain:::::::::::::::::::::::::::::::btnTakeAway_Click_1::::::::::::::::::::::;" + ex.Message);
            }

        }

        private void btnWorkingPeriod_Click(object sender, EventArgs e)
        {
            Button SettingAll = (Button)sender;
            var menuid = Convert.ToInt32(SettingAll.Tag);
            var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
            var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
            if (result > 0)
            {
                frmShift frm = new frmShift();
                frm.ShowDialog();
            }
            else
            {
                frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
                frmOpacity.ShowDialog(this, frm);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 frmLogin = new Form1();
                frmLogin.CheckCallform = 1;
                
                if (frmLogin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Button SettingAll = (Button)sender;
                    var menuid = Convert.ToInt32(SettingAll.Tag);
                    var departmentid = UserLoginModel.UserLoginInfo.DepartmentID;
                    var result = PermissionService.GetPermissionByDepartment(departmentid, menuid);
                    // frmReport frm = new frmReport();
                    //// this.Close();
                    // frm.ShowDialog();
                    if (result > 0)
                    {
                        frmReport frm = new frmReport();

                        frm.ShowDialog();
                        frmLogin.CheckCallform = 0;
                    }
                    else
                    {
                        frmMessager frm = new frmMessager("Messenger", "You can not accept. Please contact admin");
                        frmOpacity.ShowDialog(this, frm);
                    }
                }
            }
            catch(Exception ex)
            {
                SystemLog.LogPOS.WriteLog("frmMain::::::::::::::::::::::::::::::btnReport_Click:::::::::::::::::::::::::" + ex.Message);
            }
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
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

                    var shiftid = UserLoginModel.ShiffID;
                    if (shiftid > 0)
                    {
                        this.picWarning.Show();
                        this.lbWarning.Show();
                    }
                    else
                    {
                        this.picWarning.Hide();
                        this.lbWarning.Hide();
                    }

                    btnEatIn.Tag = 1;


                    btnTakeAway.Tag = 2;


                    btnStore.Tag = 3;

                    btnWorkingPeriod.Tag = 4;


                    btnReport.Tag = 5;

                    btnSettingAll.Tag = 6;

                    this.lblNameUser.Text = UserLoginModel.UserLoginInfo.UserName;

                    UpdateToServer();
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmMain::::::::::::::::frmMain_Load:::::::::::::::::::::::" + ex.Message);
            }
            

        }
        private void UpdateToServer()
        {
            try
            {
                var result = _context.Database.ExecuteSqlCommand("EXEC  UpdateToServer");
                if (_context.ORDER_DATE.Count() == 0)
                {
                    _context.Database.ExecuteSqlCommand("truncate table ORDER_DATE;");

                }
                if (_context.ORDER_DETAIL_DATE.Count() == 0)
                {
                    _context.Database.ExecuteSqlCommand("truncate table ORDER_DETAIL_MODIFIRE_DATE;");
                }
                if (_context.ORDER_OPEN_ITEM.Count() == 0)
                {
                    _context.Database.ExecuteSqlCommand("truncate table ORDER_OPEN_ITEM;");
                }
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("frmMain::::::::::::::::::::frmLoad:::::::::::::::UpdateToServer" + ex.Message);
            }
        }

        private void btnEatIn_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Font drawFont = new Font("Arial", 20);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                PointF drawPoint = new PointF(185.0F, 12.0F);
                String drawString = OrderService.CountTotalEaIn() + "";
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmMain:::::::::::::::::btnEatIn_Paint::::::::::::::::::::::" + ex.Message);
            }
            
        }

        private void btnTakeAway_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Font drawFont = new Font("Arial", 20);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                PointF drawPoint = new PointF(185.0F, 12.0F);
                String drawString = OrderService.CountTotalTKA() + "";
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmMain:::::::::::::::::::::btnTakeAway_Paint::::::::::::::::::::::::" + ex.Message);
            }
            
        }

        private void btnStore_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkingPeriod_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Font drawFont = new Font("Arial", 20);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                PointF drawPoint = new PointF(185.0F, 12.0F);
                String drawString = ShiftService.CountShiftWorking() + "";
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmMain::::::::::::::btnWorkingPeriod_Paint:::::::::::::::::::::;" + ex.Message);
            }
        }
    }
}
