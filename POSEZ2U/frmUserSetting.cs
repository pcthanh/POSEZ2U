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
    public partial class frmUserSetting : Form
    {

        #region Variables & Constructors

        private IUserService _userService;
        private IUserService UserService
        {
            get { return _userService ?? (_userService = new UserService()); }
            set { _userService = value; }
        }


        #endregion

        private int userid = 0;


        public frmUserSetting()
        {
            InitializeComponent();
        }
        private void AddUserSetting()
        {
            string[] str = { "User Role", "User List" };
            var i = 1;
            foreach (string strList in str)
            {
                UCUserSetting ucUserSetting = new UCUserSetting();
                ucUserSetting.lblUserSetting.Text = strList;
                ucUserSetting.Tag = i;
                ucUserSetting.Click += ucUserSetting_Click;
                flpUserSetting.Controls.Add(ucUserSetting);
                i = i + 1;
            }
        }


        void ucUserSetting_Click(object sender, EventArgs e)
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
                    addDepartmentList("User Role", tag);
                    break;
                case 2:
                    addUserList("User List", tag);
                    break;

            }


        }


        private void addDepartmentList(string lblName, int i)
        {
            btnAdd.Tag = i;
            if (i == 1)
            {
                var data = UserService.GetListDepartment().ToList();
                flpUserList.Controls.Clear();

                lblTitle.Text = lblName;
                lblTitle.BackColor = Color.FromArgb(0, 102, 204);
                lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (var item in data)
                {
                    UCUserList ucDepartment = new UCUserList();
                    ucDepartment.lblUserList.Text = item.DepartmentName;
                    ucDepartment.Tag = item;
                    ucDepartment.Click += ucDepartmentList_Click;
                    flpUserList.Controls.Add(ucDepartment);
                }
            }
            else
            {
                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();
            }
        }

        private void addUserList(string lblName, int i)
        {
            btnAdd.Tag = i;
            if (i == 2)
            {
                flpUserList.Controls.Clear();
                var data = UserService.GetListStaff().ToList();

                lblTitle.Text = lblName;
                lblTitle.BackColor = Color.FromArgb(0, 102, 204);
                lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (var item in data)
                {
                    UCUserList ucUser = new UCUserList();
                    ucUser.lblUserList.Text = item.Fname + " " + item.Lname;
                    ucUser.Tag = item;
                    ucUser.Click += ucUserList_Click;
                    flpUserList.Controls.Add(ucUser);
                }
            }
            else
            {
                flpUserList.Controls.Clear();
                pDetail.Controls.Clear();
            }
        }

        void ucDepartmentList_Click(object sender, EventArgs e)
        {
            UCUserList ucDepartmentListItem = (UCUserList)sender;
            DepartmentModel tag = (DepartmentModel)(ucDepartmentListItem.Tag);
            foreach (Control ctr in flpUserList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucDepartmentListItem.BackColor = Color.FromArgb(0, 153, 51);
            ucDepartmentListItem.ForeColor = Color.FromArgb(255, 255, 255);
            addDepartmentDetail(tag);
        }

        void addDepartmentDetail(DepartmentModel data)
        {
            pDetail.Controls.Clear();

            if (data.DepartmentID > 0)
            {
                UCDepartmentListDetail ucDepartmentDetail = new UCDepartmentListDetail();

                ucDepartmentDetail.Dock = DockStyle.Fill;

                ucDepartmentDetail.lbTilte.Text = data.DepartmentName;

                ucDepartmentDetail.txtRoleName.Text = data.DepartmentName;

                ucDepartmentDetail.addButton(data.DepartmentID);

                ucDepartmentDetail.btnSave.Tag = data;
                ucDepartmentDetail.btnSave.Click += btnSaveDepartment_Click;

                ucDepartmentDetail.btnDelete.Tag = data;
                ucDepartmentDetail.btnDelete.Click += btnDeleteDepartment_Click;

                pDetail.Controls.Add(ucDepartmentDetail);
            }
        }

        void btnSaveDepartment_Click(object sender, EventArgs e)
        {
            frmConfirm frmcon = new frmConfirm("Messenger", "Do you want save info role ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Button btnSave = (Button)sender;
                DepartmentModel data = (DepartmentModel)(btnSave.Tag);

                var viewData = (UCDepartmentListDetail)pDetail.Controls[0];

                if (data == null)
                {
                    data = new DepartmentModel();
                }
                data.DepartmentName = viewData.txtRoleName.Text ?? "";
                if (data.DepartmentName != "")
                {
                    data.UpdateBy = userid;
                    var result = UserService.SaveDataDeparment(data);
                    var messenger = "Save data role fail.";
                    if (result == 1)
                    {
                        addDepartmentList("User Role", 1);
                        messenger = "Save data Role successful.";
                    }
                    if (result == -1)
                    {
                        messenger = "Role name is exist. Please change role name.";
                    }
                    frmConfirm frm = new frmConfirm("Messenger", messenger);
                    frm.btnOk.Hide();
                    frm.btnCancel.Text = "OK";
                    frm.ShowDialog();

                }
                else
                {
                    frmConfirm frm = new frmConfirm("Messenger", "Role name is't empty.Please input data.");
                    frm.btnOk.Hide();
                    frm.btnCancel.Text = "OK";
                    frm.ShowDialog();
                }
            }


        }

        void ucUserList_Click(object sender, EventArgs e)
        {
            UCUserList ucDepartmentListItem = (UCUserList)sender;
            StaffModel tag = (StaffModel)(ucDepartmentListItem.Tag);
            foreach (Control ctr in flpUserList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucDepartmentListItem.BackColor = Color.FromArgb(0, 153, 51);
            ucDepartmentListItem.ForeColor = Color.FromArgb(255, 255, 255);
            addStaffDetail(tag);
        }
        void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            frmConfirm frmcon = new frmConfirm("Messenger", "Do you want delete Role ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                Button btnDelete = (Button)sender;
                DepartmentModel data = (DepartmentModel)(btnDelete.Tag);

                if (data.DepartmentID > 0)
                {
                    var result = UserService.RemoveDepartment(data.DepartmentID, userid);
                    var messenger = "Delete role fail.";
                    if (result == 1)
                    {
                        addDepartmentList("User Role", 1);
                        pDetail.Controls.Clear();
                        messenger = "Delete role successful.";
                    }
                    frmConfirm frm = new frmConfirm("Messenger", messenger);
                    frm.btnOk.Hide();
                    frm.btnCancel.Text = "OK";
                    frm.ShowDialog();
                }
            }

        }


        void addStaffDetail(StaffModel data)
        {
            pDetail.Controls.Clear();

            if (data.StaffID > 0)
            {
                UCUserListDetail ucUserDetail = new UCUserListDetail();

                ucUserDetail.Dock = DockStyle.Fill;

                ucUserDetail.lbTitle.Text = data.Fname + " " + data.Lname;

                ucUserDetail.txtFname.Text = data.Fname;

                ucUserDetail.txtLname.Text = data.Lname;

                ucUserDetail.txtUserName.Text = data.UserName;

                ucUserDetail.txtPinCode.Text = StaffModel.Decrypt(data.Password);

                var department = UserService.GetListDepartment().ToList();

                ucUserDetail.cbRole.DisplayMember = "Value";
                ucUserDetail.cbRole.ValueMember = "Key";

                var textDefault = "";

                foreach (var item in department)
                {
                    if (item.DepartmentID == data.DepartmentID)
                    {
                        textDefault = item.DepartmentName;
                    }

                    var temp = new KeyValueModel();
                    temp.Key = item.DepartmentID;
                    temp.Value = item.DepartmentName;
                    ucUserDetail.cbRole.Items.Add(temp);

                }

                if (textDefault != "")
                {
                    ucUserDetail.cbRole.Text = textDefault;
                }
                else
                {
                    ucUserDetail.cbRole.SelectedIndex = 0;
                }




                ucUserDetail.btnSave.Tag = data;
                ucUserDetail.btnSave.Click += btnSaveUser_Click;

                ucUserDetail.btnDelete.Tag = data;
                ucUserDetail.btnDelete.Click += btnDeleteUser_Click;

                pDetail.Controls.Add(ucUserDetail);
            }
        }


        void btnSaveUser_Click(object sender, EventArgs e)
        {
            frmConfirm frmcon = new frmConfirm("Messenger", "Do you want save info user ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                Button btnSave = (Button)sender;
                StaffModel data = (StaffModel)(btnSave.Tag);

                var viewData = (UCUserListDetail)pDetail.Controls[0];

                if (data == null)
                {
                    data = new StaffModel();
                }
                data.Fname = viewData.txtFname.Text ?? "";
                data.Lname = viewData.txtLname.Text ?? "";
                data.UserName = viewData.txtUserName.Text ?? "";
                data.Password = viewData.txtPinCode.Text ?? "";

                var cbDepartment = (KeyValueModel)viewData.cbRole.SelectedItem;
                if (cbDepartment != null)
                {
                    data.DepartmentID = cbDepartment.Key;
                }
                var messenger = "";
                if (data.Fname == "")
                    messenger = messenger + "First Name isn't empty. ";
                if (data.Lname == "")
                    messenger = messenger + "Last Name isn't empty. ";
                if (data.UserName == "")
                    messenger = messenger + "User Name isn't empty. ";
                if (data.Password == "")
                    messenger = messenger + "Pin Code isn't empty. ";
                if (data.DepartmentID == 0)
                    messenger = messenger + "Please select role. ";
                if (messenger == "")
                {
                    data.UpdateBy = userid;
                    var result = UserService.SaveDataStaff(data);
                    messenger = "Save data role fail.";
                    if (result == 1)
                    {
                        addUserList("User List", 2);
                        messenger = "Save data info user successful.";
                    }
                    if (result == -1)
                    {
                        messenger = "User name is exist. Please change user name.";
                    }
                    frmConfirm frm = new frmConfirm("Messenger", messenger);
                    frm.btnOk.Hide();
                    frm.btnCancel.Text = "OK";
                    frm.ShowDialog();
                }
                else
                {
                    frmConfirm frm = new frmConfirm("Messenger", messenger + "Please input data.");
                    frm.btnOk.Hide();
                    frm.btnCancel.Text = "OK";
                    frm.ShowDialog();
                }


            }

        }

        void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmConfirm frmcon = new frmConfirm("Messenger", "Do you want delete user ?");
            frmcon.ShowDialog();
            if (frmcon.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                Button btnDelete = (Button)sender;
                StaffModel data = (StaffModel)(btnDelete.Tag);

                if (data.StaffID > 0)
                {
                    var result = UserService.RemoveStaff(data.StaffID, userid);
                    var messenger = "Delete user fail.";
                    if (result == 1)
                    {
                        addUserList("User List", 2);
                        pDetail.Controls.Clear();
                        messenger = "Delete user successful.";
                    }
                    frmConfirm frm = new frmConfirm("Messenger", messenger);
                    frm.btnOk.Hide();
                    frm.btnCancel.Text = "OK";
                    frm.ShowDialog();
                }
            }

        }


        private void frmUserSetting_Load(object sender, EventArgs e)
        {
            this.AddUserSetting();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pDetail.Controls.Clear();
            Button addNew = (Button)sender;
            int tag = Convert.ToInt32(addNew.Tag);

            switch (tag)
            {
                case 1:
                    UCDepartmentListDetail ucDepartment = new UCDepartmentListDetail();
                    ucDepartment.Dock = DockStyle.Fill;
                    ucDepartment.btnSave.Click += btnSaveDepartment_Click;
                    ucDepartment.btnDelete.Hide();
                    pDetail.Controls.Add(ucDepartment);
                    break;
                case 2:
                    UCUserListDetail ucUser = new UCUserListDetail();
                    ucUser.Dock = DockStyle.Fill;
                    ucUser.btnSave.Click += btnSaveUser_Click;
                    ucUser.btnDelete.Hide();

                    ucUser.cbRole.DisplayMember = "Value";
                    ucUser.cbRole.ValueMember = "Key";
                    var department = UserService.GetListDepartment().ToList();
                    foreach (var item in department)
                    {
                        var temp = new KeyValueModel();
                        temp.Key = item.DepartmentID;
                        temp.Value = item.DepartmentName;
                        ucUser.cbRole.Items.Add(temp);

                    }
                    //ucUser.cbRole.SelectedIndex = 0;
                    pDetail.Controls.Add(ucUser);
                    break;

            }
        }
    }
}
