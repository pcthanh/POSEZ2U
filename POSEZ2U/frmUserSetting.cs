using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.UC;

namespace POSEZ2U
{
    public partial class frmUserSetting : Form
    {
        public frmUserSetting()
        {
            InitializeComponent();
        }
        private void AddUserSetting()
        {
            string[] str = { "User Role", "User List" };
            foreach (string strList in str)
            {
                UCUserSetting ucUserSetting = new UCUserSetting();
                ucUserSetting.lblUserSetting.Text = strList;
                ucUserSetting.Tag = strList;
                ucUserSetting.Click += ucUserSetting_Click;
                flpUserSetting.Controls.Add(ucUserSetting);
            }
        }

        void ucUserSetting_Click(object sender, EventArgs e)
        {
            UCUserList ucUserList = new UCUserList();
            lblTitle.Text = "User List";
            ucUserList.Click += ucUserList_Click;
            flpUserList.Controls.Add(ucUserList);
        }

        void ucUserList_Click(object sender, EventArgs e)
        {
            
            UCUserListDetail ucUserListDetail = new UCUserListDetail();
            ucUserListDetail.Dock = DockStyle.Fill;
            ucUserListDetail.lblNameUser.Text = "Thien";
            pDetail.Controls.Add(ucUserListDetail);
        }

        private void frmUserSetting_Load(object sender, EventArgs e)
        {
            this.AddUserSetting();
        }
    }
}
