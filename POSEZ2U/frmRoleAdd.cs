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
using POSEZ2U.UC;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmRoleAdd : Form
    {
        private int userid = 0;
        #region Variables & Constructors
        private IUserService _userService;
        private IUserService UserService
        {
            get { return _userService ?? (_userService = new UserService()); }
            set { _userService = value; }
        }
        #endregion


        public int department = 0;
        public List<SubMenuModel> listmap = new List<SubMenuModel>();
        public List<SubMenuModel> listall = new List<SubMenuModel>();
        public frmRoleAdd(int _department)
        {
            InitializeComponent();
            department = _department;
            listmap = UserService.GetSubMenuByDepartment(department).ToList();
            listall = UserService.GetAllListSubMenuByDepartment(department).ToList();
        }
        //string[] str = { "Green Tea" };
        private void LoadThisGroupItems()
        {
            flpThisgroupitems.Controls.Clear();

            for (int i = 0; i < listmap.Count; i++)
            {
                UCMenuAdd ucMenuAdd = new UCMenuAdd();
                ucMenuAdd.lblGroupName.Text = listmap[i].SubMenuName;
                ucMenuAdd.Tag = listmap[i];
                ucMenuAdd.Click += flpThisgroupitems_Click;
                flpThisgroupitems.Controls.Add(ucMenuAdd);
            }
        }
        private void LoadAllItem()
        {
            flpAllitems.Controls.Clear();
            foreach (var item in listall)
            {
                    UCMenuAdd ucMenuAddAll = new UCMenuAdd();
                    ucMenuAddAll.lblGroupName.Text = item.SubMenuName;
                    ucMenuAddAll.Tag = item;
                    ucMenuAddAll.Click += ucMenuAddAll_Click;
                    flpAllitems.Controls.Add(ucMenuAddAll);
            }
        }

        void ucMenuAddAll_Click(object sender, EventArgs e)
        {
            UCMenuAdd ucMenuAll = (UCMenuAdd)sender;
            if (ucMenuAll.BackColor == Color.FromArgb(0, 102, 204))
            {
                ucMenuAll.BackColor = DefaultBackColor;
                ucMenuAll.ForeColor = DefaultForeColor;
            }
            else
            {
                ucMenuAll.BackColor = Color.FromArgb(0, 102, 204);
                ucMenuAll.ForeColor = Color.FromArgb(255, 255, 255);
            }
            
        }
        void flpThisgroupitems_Click(object sender, EventArgs e)
        {
            UCMenuAdd ucMenuAll = (UCMenuAdd)sender;
            if (ucMenuAll.BackColor == Color.FromArgb(0, 102, 204))
            {
                ucMenuAll.BackColor = DefaultBackColor;
                ucMenuAll.ForeColor = DefaultForeColor;
            }
            else
            {
                ucMenuAll.BackColor = Color.FromArgb(0, 102, 204);
                ucMenuAll.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmMenuAdd_Load(object sender, EventArgs e)
        {
            userid = UserLoginModel.UserLoginInfo.StaffID;

            //MessageBox.Show("userid", userid.ToString());
            if (userid == 0)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                LoadThisGroupItems();
                LoadAllItem();
            }

          
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in flpAllitems.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    UCMenuAdd ucMenuGet = (UCMenuAdd)ctr;
                    SubMenuModel itemlef = (SubMenuModel)(ucMenuGet.Tag);
                    SubMenuModel item = new SubMenuModel();
                    item.SubMenuID = itemlef.SubMenuID;
                    item.SubMenuName = itemlef.SubMenuName;
                    listmap.Add(item);
                    var index = -1;
                    for(int i=0;i<listall.Count;i++)
                    {
                        if (listall[i].SubMenuID == item.SubMenuID)
                        {
                            index = i;
                        }
                    }
                    if (index> - 1)
                    {
                        listall.RemoveAt(index);
                    }
                }
            }
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmConfirm frmcon = new frmConfirm("Messenger", "Do you want add permission ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var messenger = "";
                var result = UserService.SaveMapPermission(listmap, department, userid);
                if (result == 1)
                {
                    messenger = "Save permission successful.";
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                  
                }
                else
                {
                    messenger = "Save permission fail. Please save again.";
                }

                frmConfirm frm = new frmConfirm("Messenger", messenger);
                frm.btnOk.Hide();
                frm.btnCancel.Text = "OK";
                frm.ShowDialog();
            }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in flpThisgroupitems.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    UCMenuAdd ucMenuGet = (UCMenuAdd)ctr;
                    SubMenuModel itemlef = (SubMenuModel)(ucMenuGet.Tag);
                    SubMenuModel item = new SubMenuModel();
                    item.SubMenuID = itemlef.SubMenuID;
                    item.SubMenuName = itemlef.SubMenuName;
                    listall.Add(item);
                    var index = -1;
                    for (int i = 0; i < listmap.Count; i++)
                    {
                        if (listmap[i].SubMenuID == item.SubMenuID)
                        {
                            index = i;
                        }
                    }
                    if (index > -1)
                    {
                        listmap.RemoveAt(index);
                    }
                }
            }
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            foreach (var item in listall)
            {
                listmap.Add(item);
            }
            listall = new List<SubMenuModel>();
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            foreach (var item in listmap)
            {
                listall.Add(item);
            }
            listmap = new List<SubMenuModel>();
            LoadThisGroupItems();
            LoadAllItem();
        }
    }
}
