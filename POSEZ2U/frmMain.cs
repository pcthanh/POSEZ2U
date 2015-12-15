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
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmMain : Form
    {
        private int userid = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEatIn_Click(object sender, EventArgs e)
        {
            frmFloor frm = new frmFloor();
            this.Hide();
            frm.ShowDialog();
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
            frmSettingAll frm = new frmSettingAll();
            frm.ShowDialog();
        }

        private void btnTakeAway_Click_1(object sender, EventArgs e)
        {

        }

        private void btnWorkingPeriod_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

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
                this.lblNameUser.Text = UserLoginModel.UserLoginInfo.UserName;
            }

        }

       
    }
}
