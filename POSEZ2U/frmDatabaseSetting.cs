using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using POSEZ2U.Class;
using POSEZ2U.UC;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmDatabaseSetting : Form
    {

        #region Variables & Constructors

        private IReportService _reportService;
        private IReportService ReportService
        {
            get { return _reportService ?? (_reportService = new ReportService()); }
            set { _reportService = value; }
        }


        #endregion

        private int userid = 0;


        public frmDatabaseSetting()
        {
            InitializeComponent();
        }
        private void AddDataSettingShow()
        {
            string[] str = { "Backup", "Connection" };
            var i = 1;
            foreach (string strList in str)
            {
                UCUserSetting ucUserSetting = new UCUserSetting();
                ucUserSetting.lblUserSetting.Text = strList;
                ucUserSetting.Tag = i;
                ucUserSetting.Click += ucDataSettingShow_Click;
                flpUserSetting.Controls.Add(ucUserSetting);
                i = i + 1;
            }
        }


        void ucDataSettingShow_Click(object sender, EventArgs e)
        {

            UCUserSetting ucProduct = (UCUserSetting)sender;
            int tag = Convert.ToInt32(ucProduct.Tag);
            foreach (Control ctr in flpUserSetting.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucProduct.BackColor = Color.FromArgb(0, 102, 204);
            ucProduct.ForeColor = Color.FromArgb(255, 255, 255);

            flpUserList.Controls.Clear();

            pDetail.Controls.Clear();

            switch (tag)
            {
                case 1:
                    AddBackup("Backup", tag);
                    break;
                case 2:
                    AddConnection("Connection", tag);
                    break;

            }


        }


        private void AddBackup(string lblName, int i)
        {
           
            if (i == 1)
            {
               
                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();

                lblTitle.Text = lblName;
                lblTitle.BackColor = Color.FromArgb(0, 102, 204);
                lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
               
            }
            else
            {
                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();
            }
        }


        private void AddConnection(string lblName, int i)
        {
          
            if (i == 2)
            {
               
               

                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();

                lblTitle.Text = lblName;
                lblTitle.BackColor = Color.FromArgb(0, 102, 204);
                lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
               
            }
            else
            {
                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();
            }
        }

     
     

        private void frmUserSetting_Load(object sender, EventArgs e)
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
                this.AddDataSettingShow();
            }

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            frmMain frm = new frmMain();
            this.Close();
            frm.ShowDialog();
        }

       

      

       
    }
}
