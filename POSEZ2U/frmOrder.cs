
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.UC;
using POSEZ2U.Class;
namespace POSEZ2U
{
    public partial class frmOrder : Form
    {
        Order OrderMain;
        public frmOrder(Order _orderMain)
        {
            InitializeComponent();
            OrderMain = _orderMain;
        }
        List<Order.Item> Listitem = new List<Order.Item>();
        List<Order.Modifier> Listmodifier = new List<Order.Modifier>();
        int keyItemTemp;
        int indexControl;
        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadMenuGroup();
            LoadMenuOfGroup();
            this.AddButtonOpenItem();
            this.SelectGroupMenu();
        }
        private void LoadMenuOfGroup()
        {
            string[] str = { "Com", "Pho", "Mi", "Bun", "Hu Tieu", "Chao", "Xao", "Salad", "Lau", "Bun Nuoc", "Them", "Tre em" };
            foreach(string strGroup in str)
            {
                UCMenuOrdercs ucMenuOrder = new UCMenuOrdercs();
                ucMenuOrder.lblNameGroup.Text = strGroup;
                ucMenuOrder.lblCount.Text = "11";
                ucMenuOrder.Tag = strGroup;
                ucMenuOrder.Click += ucMenuOrder_Click;
                flowLayoutPanel1.Controls.Add(ucMenuOrder);
            }
        }
        private void AddButtonOpenItem()
        {
            Button btn = new Button();
            btn.Width = 137;
            btn.Height = 72;
            btn.Name = "btnOpenItem";
            btn.Text = "Open Item";
            btn.BackColor = Color.FromArgb(0, 102, 204);
            btn.ForeColor = Color.FromArgb(255, 255, 255);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Click += btn_Click;
            flowLayoutPanel1.Controls.Add(btn);
        }
        private void AddButtonBackItem()
        {
            Button btnBack = new Button();
            btnBack.Width = 137;
            btnBack.Height = 68;
            btnBack.Name = "btnOpenItem";
            btnBack.Text = "BACK...";
            btnBack.BackColor = Color.FromArgb(0, 51, 51);
            btnBack.ForeColor = Color.FromArgb(255, 255, 255);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBack.Click += btnBack_Click;
            flowLayoutPanel1.Controls.Add(btnBack);
        }
        private void AddButtonOpenItemItem()
        {
            Button btnOpenItemItem = new Button();
            btnOpenItemItem.Width = 137;
            btnOpenItemItem.Height = 68;
            btnOpenItemItem.Name = "btnOpenItem";
            btnOpenItemItem.Text = "Open Item";
            btnOpenItemItem.BackColor = Color.FromArgb(0, 0, 153);
            btnOpenItemItem.ForeColor = Color.FromArgb(255, 255, 255);
            btnOpenItemItem.FlatAppearance.BorderSize = 0;
            btnOpenItemItem.FlatStyle = FlatStyle.Flat;
            btnOpenItemItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOpenItemItem.Click += btnOpenItemItem_Click;
            flowLayoutPanel1.Controls.Add(btnOpenItemItem);
        }
        private void AddButtonBackItemPage()
        {
            Button btnBackItem = new Button();
            btnBackItem.Width = 137;
            btnBackItem.Height = 68;
            btnBackItem.Name = "btnOpenItem";
            btnBackItem.Text = "BACK";
            btnBackItem.BackColor = Color.FromArgb(228, 228, 228);
            btnBackItem.ForeColor = Color.FromArgb(13, 13, 13);
            btnBackItem.FlatAppearance.BorderSize = 0;
            btnBackItem.FlatStyle = FlatStyle.Flat;
            btnBackItem.TextAlign = ContentAlignment.TopLeft;
            btnBackItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBackItem.Click += btnBackItem_Click;
            flowLayoutPanel1.Controls.Add(btnBackItem);
        }
        private void AddButtonMextItemPage()
        {
            Button btnNextItem = new Button();
            btnNextItem.Width = 137;
            btnNextItem.Height = 68;
            btnNextItem.Name = "btnOpenItem";
            btnNextItem.Text = "NEXT";
            btnNextItem.BackColor = Color.FromArgb(228, 228, 228);
            btnNextItem.ForeColor = Color.FromArgb(13, 13, 13);
            btnNextItem.FlatAppearance.BorderSize = 0;
            btnNextItem.FlatStyle = FlatStyle.Flat;
            btnNextItem.TextAlign = ContentAlignment.TopLeft;
            btnNextItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnNextItem.Click += btnNextItem_Click;
            flowLayoutPanel1.Controls.Add(btnNextItem);
        }

        void btnNextItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NEXT Page");
        }

        void btnBackItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back Page");
        }

        void btnOpenItemItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Ite Item");
        }

        void btnBack_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            this.LoadMenuOfGroup();
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Item");
        }
        private void LoadMenuGroup()
        {
            string[] str = { "Breakfast", "Lunch", "Beverage", "Dessert", "All" };
            foreach (string strMenuGroup in str)
            {
                UCGroupMenuOrder ucGroupMenuOrder = new UCGroupMenuOrder();
                ucGroupMenuOrder.lblGroupNameMenuOrder.Text = strMenuGroup;
                ucGroupMenuOrder.Tag = strMenuGroup;
                ucGroupMenuOrder.Click += ucGroupMenuOrder_Click;;
                flpGroupMenu.Controls.Add(ucGroupMenuOrder);
            }
        }
        private void SelectGroupMenu()
        {
            UCGroupMenuOrder ucGroupMenuOrder = new UCGroupMenuOrder();
            ucGroupMenuOrder = (UCGroupMenuOrder)flpGroupMenu.Controls[0];
            ucGroupMenuOrder.BackColor = Color.FromArgb(0, 102, 0);
            ucGroupMenuOrder.ForeColor = Color.FromArgb(255, 255, 255);
            //MessageBox.Show(ucGroupMenuOrder.Tag.ToString());
        }
        private void LoadItemOfGroup()
        {
            this.flowLayoutPanel1.Controls.Clear();
            this.AddButtonBackItem();
            
            string[] str = { "Com Suon", "Com Dac Biet", "Com Ca Chien", "Com Chien Don", "Com Tay Cam", "Com Vit Kho", "Com Chay", "Com ABC", "Com XYZ","Com Xao","Com Duong Chau",
                           "Com Suon", "Com Dac Biet", "Com Ca Chien", "Com Chien Don", "Com Tay Cam", "Com Vit Kho", "Com Chay", "Com ABC", "Com XYZ","Com Xao","Com Duong Chau"};
            int keyItem = 1;
            foreach (string strlst in str)
            {
                keyItem++;
                UCMenuOfGroup ucMenuOfGroup = new UCMenuOfGroup();
                ucMenuOfGroup.lblNameMenuOfGroup.Text = strlst;
                
                ucMenuOfGroup.Tag = strlst;
                ucMenuOfGroup.Click += ucMenuOfGroup_Click;
                flowLayoutPanel1.Controls.Add(ucMenuOfGroup);
            }
            this.AddButtonOpenItemItem();
            this.AddButtonBackItemPage();
            this.AddButtonMextItemPage();
        }

        void ucMenuOfGroup_Click(object sender, EventArgs e)
        {
            UCMenuOfGroup ucMenuOfGroup = (UCMenuOfGroup)sender;
            Order.Item item = new Order.Item();
            item.ItemName = ucMenuOfGroup.Tag.ToString();
            OrderMain.addItemToList(item);
            addOrderToFlp(item);

        }
        private void addOrderToFlp(Order.Item items)
        {
            UCOrder ucOrder = new UCOrder();
            ucOrder.lblNameItem.Text = items.ItemName;
            ucOrder.Tag = items;
            ucOrder.Click+=ucOrder_Click;
            
            flpOrder.Controls.Add(ucOrder);
        }

        void ucOrder_Click(object sender, EventArgs e)
        {
            UCOrder ucOder = (UCOrder)sender;
            Order.Item item = (Order.Item)ucOder.Tag;
            indexControl = flpOrder.Controls.GetChildIndex(ucOder);
            if (item.ItemName == "Com Suon")
            {
                flowLayoutPanel1.Controls.Clear();
                string[] str = { "Khong hanh", "It com", "Khong thit" };
                keyItemTemp = item.KeyItem;
                foreach (string Modififer in str)
                {
                    UCModifierOfMenu ucModifierOfMenu = new UCModifierOfMenu();
                    ucModifierOfMenu.lblModifierOfMenu.Text = Modififer;
                    ucModifierOfMenu.Tag = Modififer;
                    ucModifierOfMenu.Click += ucModifierOfMenu_Click;
                    flowLayoutPanel1.Controls.Add(ucModifierOfMenu);
                }
                //MessageBox.Show(item.ItemName);
            }
        }

        void ucModifierOfMenu_Click(object sender, EventArgs e)
        {

            UCModifierOfMenu ucModifierOfMenu = (UCModifierOfMenu)sender;
            Order.Modifier modifier = new Order.Modifier();
            modifier.ModifierName = ucModifierOfMenu.Tag.ToString();
            OrderMain.addModifierToList(modifier,keyItemTemp);
            UCItemModifierOfMenu ucItemModifierOfMenu = new UCItemModifierOfMenu();
            ucItemModifierOfMenu.lblNameItenModifierMenu.Text = modifier.ModifierName;
            flpOrder.Controls.Add(ucItemModifierOfMenu);
            flpOrder.Controls.SetChildIndex(ucItemModifierOfMenu, keyItemTemp );
           
        }

        void AddControlToFlowLayoutPanel(FlowLayoutPanel flowlayoutpanel, Control ctrl)
        {
            flowlayoutpanel.Controls.Add(ctrl);

            // SetChildIndex does the trick
            if (flowlayoutpanel.Controls.Count > 2)
                flowlayoutpanel.Controls.SetChildIndex(ctrl, flowlayoutpanel.Controls.Count - 2);
        }
        void ucGroupMenuOrder_Click(object sender, EventArgs e)
        {
            UCGroupMenuOrder ucGroupMenuOrder = (UCGroupMenuOrder)sender;
            MessageBox.Show(ucGroupMenuOrder.Tag.ToString());
        }

        void ucMenuOrder_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            UCMenuOrdercs ucGroup = (UCMenuOrdercs)sender;
            string tag = ucGroup.Tag.ToString();
            if (tag == "Com") 
            {
                LoadItemOfGroup();
            }


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
