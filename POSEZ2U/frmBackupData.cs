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
    public partial class frmBackupData : Form
    {

        #region Variables & Constructors

        private IDatabaseSettingService _databaseSettingService;
        private IDatabaseSettingService DatabaseSettingService
        {
            get { return _databaseSettingService ?? (_databaseSettingService = new DatabaseSettingService()); }
            set { _databaseSettingService = value; }
        }


        #endregion

        private int userid = 0;
        public frmBackupData()
        {
            InitializeComponent();
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //BackupDataModel tag = (BackupDataModel)(button.Tag);
            //if (tag != null)
            //{
                frmMessager frm = new frmMessager("Messenger", "Please contact IT support if you want restore database.");
                frmOpacity.ShowDialog(this, frm);
            //}
            //else
            //{
            //    frmMessager frm = new frmMessager("Messenger", "Please select row befor restore data.");
            //    frm.ShowDialog();
            //}
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userid = UserLoginModel.UserLoginInfo.StaffID;
            var result= DatabaseSettingService.BackupDatabaseSetting(userid);
            var text = "Backup database fail.";
            if (result == 1)
            {
                addTodayList("History", 1);
                text = "Backup database successful.";
            }
            frmMessager frm = new frmMessager("Messenger", text);
            frmOpacity.ShowDialog(this, frm);
        }

        private void AddDatabaseSetting()
        {
            string[] str = { "History" };
            var i = 1;
            foreach (string strList in str)
            {
                UCUserSetting ucUserSetting = new UCUserSetting();
                ucUserSetting.lblUserSetting.Text = strList;
                ucUserSetting.Tag = i;
                ucUserSetting.Click += ucDataSetting_Click;
                ucUserSetting.Width = flpDatabase.Width;
                flpDatabase.Controls.Add(ucUserSetting);
                i = i + 1;
            }
        }


        void ucDataSetting_Click(object sender, EventArgs e)
        {

            UCUserSetting ucProduct = (UCUserSetting)sender;
            int tag = Convert.ToInt32(ucProduct.Tag);
            foreach (Control ctr in flpDatabase.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucProduct.BackColor = Color.FromArgb(0, 102, 204);
            ucProduct.ForeColor = Color.FromArgb(255, 255, 255);



            flpDataDetail.Controls.Clear();

            switch (tag)
            {
                case 1:
                    addTodayList("History", tag);
                    break;
            }


        }


        public void addTodayList(string lblName, int i)
        {

            flpDataDetail.Controls.Clear();
           
            if (i == 1)
            {

                var data = DatabaseSettingService.GetDataBackupFile().ToList();

                double totalfile = data.Count;

                foreach (var item in data)
                {
                    var ucBackup = new UCBackupItem();
                    ucBackup.lblDate.Text = item.CreateDate??"";
                    ucBackup.lblFullName.Text = item.FullName??"";
                    ucBackup.lblDes.Text = item.Description ?? "";
                    //ucBackup.lblStatus.Text = item.Status ?? "";

                    ucBackup.Size = new System.Drawing.Size(flpDataDetail.Width - 5, ucBackup.Height);

                    ucBackup.Tag = item;
                    ucBackup.Click += UCDataBackupItemNew_Click;

                    flpDataDetail.Controls.Add(ucBackup);
                }

                this.lblTotalFile.Text = totalfile.ToString();

            }
            else
            {
                flpDataDetail.Controls.Clear();
            }
        }


        void UCDataBackupItemNew_Click(object sender, EventArgs e)
        {
            UCBackupItem ucBackup = (UCBackupItem)sender;
            BackupDataModel tag = (BackupDataModel)(ucBackup.Tag);

            btnRetore.Tag = tag;

            foreach (Control ctr in flpDataDetail.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucBackup.BackColor = Color.FromArgb(0, 153, 51);
            ucBackup.ForeColor = Color.FromArgb(255, 255, 255);
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
                this.AddDatabaseSetting();
            }

        }
    }
}
