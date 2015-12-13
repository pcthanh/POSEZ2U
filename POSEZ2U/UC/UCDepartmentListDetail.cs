using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using ServicePOS;

namespace POSEZ2U.UC
{
    public partial class UCDepartmentListDetail : UserControl
    {

        #region Variables & Constructors
        private IUserService _userService;
        private IUserService UserService
        {
            get { return _userService ?? (_userService = new UserService()); }
            set { _userService = value; }
        }
        #endregion
        public UCDepartmentListDetail()
        {
            InitializeComponent();
        }


        public void addUcPermission(int departmentid)
        {
            if (departmentid > 0)
            {
                var submenulist = UserService.GetSubMenuByDepartment(departmentid).ToList();
                if (submenulist.Count > 0)
                {
                    UCProductIncl[] subMenuList = new UCProductIncl[submenulist.Count];
                    for (int i = 0; i < submenulist.Count; i++)
                    {
                        subMenuList[i] = new UCProductIncl();
                        subMenuList[i].lblNameGroupIncl.Text = submenulist[i].SubMenuName;
                        subMenuList[i].Tag = submenulist[i];
                       // ucProductIncl[i].Click += UCGroupList_Click;
                        flpPermission.Controls.AddRange(subMenuList);
                    }
                }
            }
        }

        public void addButton(int departmentid)
        {
            Button btn = new Button();
            btn.Width = 107;
            btn.Height = 44;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(0, 153, 0);
            btn.ForeColor = Color.White;
            btn.Name = "btnAdd";
            btn.Text = "Add";
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Tag = departmentid;
            btn.Click += btn_Click;
            flpPermission.Controls.Add(btn);

        }

        public void btn_Click(object sender, EventArgs e)
        {
            Button addnewGroup = (Button)sender;
            int tag = Convert.ToInt16(addnewGroup.Tag);
            frmRoleAdd frmGroupAdd = new frmRoleAdd(tag);
            if (frmGroupAdd.ShowDialog() == DialogResult.OK)
            {
                flpPermission.Controls.Clear();
                addUcPermission(tag);
                addButton(tag);

            }
        }

        private void UCDepartmentListDetail_Load(object sender, EventArgs e)
        {
            //addButton();
        }
       
    }
}
