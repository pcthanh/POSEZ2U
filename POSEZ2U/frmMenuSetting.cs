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
        int OldWidthPn2 = 262;
        int NewWidthPn2 = Screen.PrimaryScreen.WorkingArea.Width - 400;
        private void ResizeTopriceList()
        {
            pn2.MaximumSize = new Size(NewWidthPn2, pn2.Height);
            pn2.Size = new Size(NewWidthPn2, pn2.Height);
           
        }
        private void ResizeToOthder()
        {
            this.ucPriceListTitle.Visible = false;
            pn2.MaximumSize = new Size(OldWidthPn2, pn2.Height);
            pn2.Size = new Size(OldWidthPn2, pn2.Height);
            
        }
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
            addModifier("Modifier List", tag);
            addGroupList("Group List", tag);
            addItemList("ItemList", tag);
            addPriceList(tag);
            
        }
        private void addMenuList(string lblName,int i)
        {
            ResizeToOthder();
            int index = 1;
            string[] str = { "FOOD", "BEVEGARE", "ENTREE", "DESSERT" };
            if (i == 1)
            {
                flpMenuList.Controls.Clear();
                //txtNameMenuList.Visible = true;
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
                //txtNameMenuList.Visible = false;
            }
        }
        private void addModifier(string lblName, int i)
        {
            ResizeToOthder();
            int index = 1;
            string[] str = { "No Sugar", "More Sugar", "More Ice", "Less Ice", "More Milk", "Them Bun", "Them Thit" };
            if (i == 4)
            {
                flpMenuList.Controls.Clear();
                //txtNameMenuList.Visible = true;
                txtNameMenuList.lblMenuListName.Text = lblName;
                txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (string strList in str)
                {
                    UCModifierItem ucModifierItem = new UCModifierItem();
                    ucModifierItem.lblModifierItemName.Text = strList;
                    ucModifierItem.Tag = index;
                    ucModifierItem.Click += ucModifierItem_Click;
                    flpMenuList.Controls.Add(ucModifierItem);
                    index++;
                }
            }
           
        }
        private void addGroupList(string lblName, int i)
        {

            int index = 1;
            string[] str = { "COM", "PHO", "HU TIEU", "CHAO", "Coffee", "Tea", "Smoothie" };
            if (i == 2)
            {
                flpMenuList.Controls.Clear();
                //txtNameMenuList.Visible = true;
                txtNameMenuList.lblMenuListName.Text = lblName;
                txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (string strList in str)
                {
                    UCGroupListItem ucGroupListItem = new UCGroupListItem();
                    ucGroupListItem.lblGroupListItemName.Text = strList;
                    ucGroupListItem.Tag = index;
                    ucGroupListItem.Click += ucGroupListItem_Click;
                    flpMenuList.Controls.Add(ucGroupListItem);
                    index++;
                }
            }

        }

        private void addItemList(string lblName, int i)
        {
            ResizeToOthder();
            int index = 1;
            string[] str = { "Ice coffee", "VNam Coffee", "Mocha", "Latte", "White Coffee", "Green Tea", "Apple Juice" };
            if (i == 3)
            {
                flpMenuList.Controls.Clear();
                //txtNameMenuList.Visible = true;
                txtNameMenuList.lblMenuListName.Text = lblName;
                txtNameMenuList.BackColor = Color.FromArgb(0, 102, 204);
                txtNameMenuList.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (string strList in str)
                {
                    UCItem ucItem = new UCItem();
                    ucItem.lblItem.Text = strList;
                    ucItem.Tag = index;
                    ucItem.Click += ucItem_Click;
                    flpMenuList.Controls.Add(ucItem);
                    index++;
                }
            }

        }

        private void addPriceList(int i)
        {
            
            string[] str = { "Ice coffee", "VNam Coffee", "Mocha", "Latte", "White Coffee", "Green Tea", "Apple Juice" };
            if (i == 5)
            {
                this.ResizeTopriceList();
                flpMenuList.Controls.Clear();
               // txtNameMenuList.Visible = false;
                ucPriceListTitle.Visible = true;
                ucPriceListTitle.BackColor = Color.FromArgb(0, 102, 204);
                ucPriceListTitle.ForeColor = Color.FromArgb(255, 255, 255);
                ucPriceListTitle.Dock = DockStyle.Fill;
                foreach (string strPriceList in str)
                {
                    UCPriceList ucPriceList = new UCPriceList();
                    ucPriceList.lblPriceNameProduct.Text = strPriceList;
                    ucPriceList.lblPriceSizeProduct.Text = "Regular";
                    ucPriceList.lblPriceProduct.Text= "10.00";
                    ucPriceListTitle.Size = new System.Drawing.Size(NewWidthPn2, ucPriceList.Height);
                    //ucPriceList.Dock = DockStyle.Fill;
                    ucPriceList.Click += ucPriceList_Click;
                    flpMenuList.Controls.Add(ucPriceList);
                }
                addButtonPriceList();
            }
            
        }

        void ucPriceList_Click(object sender, EventArgs e)
        {
            UCPriceList ucPriceList = (UCPriceList)sender;
            int tag = Convert.ToInt32(ucPriceList.Tag);
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucPriceList.BackColor = Color.FromArgb(0, 153, 51);
            ucPriceList.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void addButtonPriceList()
        {
            



            
            ////////////////////////
            int i = 1;
            FlowLayoutPanel flpButtonPriceList = new FlowLayoutPanel();
            flpButtonPriceList.Dock = DockStyle.Fill;
            flpButtonPriceList.BackColor = Color.FromArgb(215, 214, 216);
            pnDetail.Controls.Add(flpButtonPriceList);
            string[] strlst = { "Search","Edit","Go To Product" };
            foreach (string str in strlst)
            {
                Button btnGoToProduct = new Button();
                btnGoToProduct.Width = 115;
                btnGoToProduct.Height = 67;
                btnGoToProduct.FlatStyle = FlatStyle.Flat;
                btnGoToProduct.FlatAppearance.BorderSize = 0;
                btnGoToProduct.Dock = DockStyle.Top;
                btnGoToProduct.Text = str;
                btnGoToProduct.Tag = str;
                btnGoToProduct.BackColor = Color.FromArgb(51, 51, 51);
                btnGoToProduct.ForeColor = Color.FromArgb(255, 255, 255);
                btnGoToProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnGoToProduct.Click += btnGoToProduct_Click;
                i++;
                flpButtonPriceList.Controls.Add(btnGoToProduct);
            }

        }

        void btnGoToProduct_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Tag.ToString());
        }

        
        void ucItem_Click(object sender, EventArgs e)
        {
            UCItem ucItem = (UCItem)sender;
            int tag = Convert.ToInt32(ucItem.Tag);
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucItem.BackColor = Color.FromArgb(0, 153, 51);
            ucItem.ForeColor = Color.FromArgb(255, 255, 255);
            addItemListDetail(tag);
        }

        void ucGroupListItem_Click(object sender, EventArgs e)
        {
            UCGroupListItem ucGroupListItem = (UCGroupListItem)sender;
            int tag = Convert.ToInt32(ucGroupListItem.Tag);
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucGroupListItem.BackColor = Color.FromArgb(0, 153, 51);
            ucGroupListItem.ForeColor = Color.FromArgb(255, 255, 255);
            addGroupListDetail(tag);
        }
        void ucModifierItem_Click(object sender, EventArgs e)
        {
            UCModifierItem ucModifierItem = (UCModifierItem)sender;
            int tag = Convert.ToInt32(ucModifierItem.Tag);
            foreach (Control ctr in flpMenuList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucModifierItem.BackColor = Color.FromArgb(0, 153, 51);
            ucModifierItem.ForeColor = Color.FromArgb(255, 255, 255);
            addModifierItemDetail(tag);
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
        private void addModifierItemDetail(int i)
        {
            pnDetail.Controls.Clear();
            UCModifier ucModifier = new UCModifier();
            ucModifier.Dock = DockStyle.Fill;
            if (i == 5)
            {
                pnDetail.Controls.Add(ucModifier);
            }
            else
            {
                pnDetail.Controls.Clear();
            }
        }
        private void addGroupListDetail(int i)
        {
            pnDetail.Controls.Clear();
            UCGroupList ucGroupList = new UCGroupList();
            ucGroupList.Dock = DockStyle.Fill;
            if (i == 5)
            {
                pnDetail.Controls.Add(ucGroupList);
            }
            else
            {
                pnDetail.Controls.Clear();
            }
        }
        private void addItemListDetail(int i)
        {
            pnDetail.Controls.Clear();
            UCItemList ucGroupList = new UCItemList();
            ucGroupList.Dock = DockStyle.Fill;
            if (i == 5)
            {
                pnDetail.Controls.Add(ucGroupList);
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
    }
}
