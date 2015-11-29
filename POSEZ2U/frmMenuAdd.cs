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
namespace POSEZ2U
{
    public partial class frmMenuAdd : Form
    {
       public List<MenuGroup> lst;
        public frmMenuAdd(List<MenuGroup>_lst)
        {
            InitializeComponent();
            lst = _lst;
        }
        string[] str = { "Green Tea" };
        private void LoadThisGroupItems()
        {
            flpThisgroupitems.Controls.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                UCMenuAdd ucMenuAdd = new UCMenuAdd();
                ucMenuAdd.lblGroupName.Text = lst[i].nameGroup;
                flpThisgroupitems.Controls.Add(ucMenuAdd);
            }
        }
        private void LoadAllItem()
        {
            foreach (string item in str)
            {
                UCMenuAdd ucMenuAddAll = new UCMenuAdd();
                ucMenuAddAll.lblGroupName.Text = item;
                ucMenuAddAll.Tag = item;
                ucMenuAddAll.Click += ucMenuAddAll_Click;
                flpAllitems.Controls.Add(ucMenuAddAll);
            }
        }

        void ucMenuAddAll_Click(object sender, EventArgs e)
        {
            UCMenuAdd ucMenuAll = (UCMenuAdd)sender;
            ucMenuAll.BackColor = Color.FromArgb(0, 102, 204);
            ucMenuAll.ForeColor = Color.FromArgb(255, 255, 255);
           // MessageBox.Show(ucMenuAll.Tag.ToString());
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmMenuAdd_Load(object sender, EventArgs e)
        {
            this.LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in flpAllitems.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    UCMenuAdd ucMenuGet = (UCMenuAdd)ctr;
                    MenuGroup item = new MenuGroup();
                    item.nameGroup = ucMenuGet.Tag.ToString();
                    lst.Add(item);
                }
            }
            this.LoadThisGroupItems();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
