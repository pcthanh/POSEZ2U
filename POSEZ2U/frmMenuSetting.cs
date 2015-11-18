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
    public partial class frmMenuSetting : Form
    {
        public frmMenuSetting()
        {
            InitializeComponent();
        }
        int flag = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnDetail.Controls.Clear();
            UCMenu ucMenu = new UCMenu();
            ucMenu.Dock = DockStyle.Fill;
            pnDetail.Controls.Add(ucMenu);
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loadDataProductSetting()
        {
            flpProdutcSetting.Controls.Clear();
            int i = 1;
            string [] lstProduct= {"Menu List","Group List","Item List","Modifier List","Price List"};
            foreach (string str in lstProduct)
            {
               
                UCProductSetting ucProduct = new UCProductSetting();
                ucProduct.lblNameProductSetting.Text = str;
                ucProduct.Tag = i;
                ucProduct.Click += ucProduct_Click;
                flpProdutcSetting.Controls.Add(ucProduct);
                i++;
            }
        }

        void ucProduct_Click(object sender, EventArgs e)
        {
            
            UCProductSetting ucProduct = (UCProductSetting)sender;
            int tag = Convert.ToInt32(ucProduct.Tag);
            foreach (Control ctr in flpProdutcSetting.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    ctr.BackColor = Color.FromArgb(255,255,255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucProduct.BackColor = Color.FromArgb(0, 102, 204);
            ucProduct.ForeColor = Color.FromArgb(255, 255, 255);
            addMenuList("Menu List", tag);
        }
        private void addMenuList(string lblName,int i)
        {
            flpMenuList.Controls.Clear();
            int index = 1;
            string[] str = { "FOOD", "BEVEGARE", "ENTREE", "DESSERT" };
            if (i == 1)
            {
                txtNameMenuList.Visible = true;
                txtNameMenuList.lblMenuListName.Text = lblName;
                txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (string strList in str)
                {
                    UCMenuList ucMenuList = new UCMenuList();
                    ucMenuList.lblMenuListName.Text = strList;
                    ucMenuList.Tag = index;
                    ucMenuList.Click += ucMenuList_Click;
                    flpMenuList.Controls.Add(ucMenuList);
                    index++;
                }
            }
            else
            {
                flpMenuList.Controls.Clear();
                pnDetail.Controls.Clear();
                txtNameMenuList.Visible = false;
            }
        }

        void ucMenuList_Click(object sender, EventArgs e)
        {
            UCMenuList ucProduct = (UCMenuList)sender;
            int tag = Convert.ToInt32(ucProduct.Tag);
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucProduct.BackColor = Color.FromArgb(0, 153, 51);
            ucProduct.ForeColor = Color.FromArgb(255, 255, 255);
            addMenuListDetail(tag);
        }
        private void addMenuListDetail(int i)
        {
            pnDetail.Controls.Clear();
            UCMenu ucMenu = new UCMenu();
            ucMenu.Dock = DockStyle.Fill;
            if (i == 2)
            {
                pnDetail.Controls.Add(ucMenu);
            }
            else
            {
                pnDetail.Controls.Clear();
            }
        }
        private void frmMenuSetting_Load(object sender, EventArgs e)
        {
            loadDataProductSetting();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UCMenu ucMenu = (UCMenu)this.pnDetail.Controls[0];
            UCGroup ucGroup = null;
            string str = null;
            int count = ucMenu.flpIncludesGroup.Controls.Count-1;
            for (int i =0; i <count; i++)
            {
                ucGroup = (UCGroup)ucMenu.flpIncludesGroup.Controls[i];
                str += ucGroup.lblNameGroup.Text;
            }

              
            
           

            MessageBox.Show(ucMenu.txtMenuName.Text + "-----"+ ucMenu.cbColor.SelectedItem.ToString()+"----"+ str);
            
        }
        
    }
}
