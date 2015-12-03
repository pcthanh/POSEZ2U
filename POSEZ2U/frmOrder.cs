
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
using SystemLog;
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
        int seat = 0;
        int flagClick = 0;
        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadMenuGroup();
            LoadMenuOfGroup();
            this.SelectGroupMenu();
            this.lblTable.Text = OrderMain.TableId;
            //flpOrder.Controls.OfType<VScrollBar>().First().Width = 20; 
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
            this.AddButtonOpenItem();
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
        private void AddButtonBackSubItem()
        {
            Button btnBackSubItem = new Button();
            btnBackSubItem.Width = 137;
            btnBackSubItem.Height = 68;
            btnBackSubItem.Name = "btnOpenItem";
            btnBackSubItem.Text = "BACK...";
            btnBackSubItem.BackColor = Color.FromArgb(228, 228, 228);
            btnBackSubItem.ForeColor = Color.FromArgb(0, 0, 0);
            btnBackSubItem.FlatAppearance.BorderSize = 0;
            btnBackSubItem.FlatStyle = FlatStyle.Flat;
            btnBackSubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBackSubItem.Click += btnBackSubItem_Click;
            flowLayoutPanel1.Controls.Add(btnBackSubItem);
        }

        void btnBackSubItem_Click(object sender, EventArgs e)
        {
            this.LoadItemOfGroup();
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
        private void AddButtonOpenItemSubItem()
        {
            Button btnOpenItemSubItem = new Button();
            btnOpenItemSubItem.Width = 137;
            btnOpenItemSubItem.Height = 68;
            btnOpenItemSubItem.Name = "btnOpenItem";
            btnOpenItemSubItem.Text = "Open Item";
            btnOpenItemSubItem.BackColor = Color.FromArgb(0, 0, 153);
            btnOpenItemSubItem.ForeColor = Color.FromArgb(255, 255, 255);
            btnOpenItemSubItem.FlatAppearance.BorderSize = 0;
            btnOpenItemSubItem.FlatStyle = FlatStyle.Flat;
            btnOpenItemSubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOpenItemSubItem.Click += btnOpenItemSubItem_Click;
            flowLayoutPanel1.Controls.Add(btnOpenItemSubItem);
        }

        void btnOpenItemSubItem_Click(object sender, EventArgs e)
        {
            frmOpenItem frm = new frmOpenItem();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Order.Item itemTemp = new Order.Item();
                itemTemp = frm.items;
                Order.Modifier modifierTemp = new Order.Modifier();
                modifierTemp.ModifierName = itemTemp.ItemName;
                modifierTemp.Price = itemTemp.Price;
                OrderMain.addModifierToList(modifierTemp, keyItemTemp);
                UCItemModifierOfMenu ucItemModifierOfMenu = new UCItemModifierOfMenu();
                this.addModifreToOrder(ucItemModifierOfMenu, modifierTemp);
            }
        }
        private void AddButtonBackSubItemPage()
        {
            Button btnBackSubItemPage = new Button();
            btnBackSubItemPage.Width = 137;
            btnBackSubItemPage.Height = 68;
            btnBackSubItemPage.Name = "btnOpenItem";
            btnBackSubItemPage.Text = "BACK";
            btnBackSubItemPage.BackColor = Color.FromArgb(228, 228, 228);
            btnBackSubItemPage.ForeColor = Color.FromArgb(13, 13, 13);
            btnBackSubItemPage.FlatAppearance.BorderSize = 0;
            btnBackSubItemPage.FlatStyle = FlatStyle.Flat;
            btnBackSubItemPage.TextAlign = ContentAlignment.TopLeft;
            btnBackSubItemPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBackSubItemPage.Click += btnBackSubItemPage_Click;
            flowLayoutPanel1.Controls.Add(btnBackSubItemPage);
        }

        void btnBackSubItemPage_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        private void AddButtonNextSubItemPage()
        {
            Button btnNextSubItemPage = new Button();
            btnNextSubItemPage.Width = 137;
            btnNextSubItemPage.Height = 68;
            btnNextSubItemPage.Name = "btnOpenItem";
            btnNextSubItemPage.Text = "BACK";
            btnNextSubItemPage.BackColor = Color.FromArgb(228, 228, 228);
            btnNextSubItemPage.ForeColor = Color.FromArgb(13, 13, 13);
            btnNextSubItemPage.FlatAppearance.BorderSize = 0;
            btnNextSubItemPage.FlatStyle = FlatStyle.Flat;
            btnNextSubItemPage.TextAlign = ContentAlignment.TopLeft;
            btnNextSubItemPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnNextSubItemPage.Click += btnNextSubItemPage_Click;
            flowLayoutPanel1.Controls.Add(btnNextSubItemPage);
        }

        void btnNextSubItemPage_Click(object sender, EventArgs e)
        {
           
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
            frmOpenItem frm = new frmOpenItem();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OrderMain.addItemToList(frm.items);
                addOrder(frm.items);
                lblSubtotal.Text = OrderMain.SubTotal().ToString();
            }
        }

        void btnBack_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            
                this.LoadMenuOfGroup();
            
        }

        void btn_Click(object sender, EventArgs e)
        {
            frmOpenItem frm = new frmOpenItem();
            if(frm.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                OrderMain.addItemToList(frm.items);
                addOrder(frm.items);
                lblSubtotal.Text = OrderMain.SubTotal().ToString();
            }
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
            if (seat > 0)
                item.Seat = seat;
            item.ItemName = ucMenuOfGroup.Tag.ToString();
            item.SubTotal = 4;
            OrderMain.addItemToList(item);
            addOrder(item);
            lblSubtotal.Text = OrderMain.SubTotal().ToString();

        }
        private void addOrder(Order.Item items)
        {
            UCOrder ucOrder = new UCOrder();
            ucOrder.lblNameItem.Text = items.ItemName;
            ucOrder.Tag = items;
            ucOrder.lblPriceItem.Text = "4.00";
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
                this.AddButtonBackSubItem();
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
                this.AddButtonOpenItemSubItem();
                this.AddButtonBackSubItemPage();
                this.AddButtonNextSubItemPage();
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
            ucItemModifierOfMenu.Tag = modifier;
            ucItemModifierOfMenu.Click += ucItemModifierOfMenu_Click;
            addModifreToOrder(ucItemModifierOfMenu,modifier);

        }

        void ucItemModifierOfMenu_Click(object sender, EventArgs e)
        {
            flagClick = 1;
            UCItemModifierOfMenu ucItemModifierOfMenu = (UCItemModifierOfMenu)sender;
            indexControl = flpOrder.Controls.GetChildIndex(ucItemModifierOfMenu);
        }
        private void addModifreToOrder(UCItemModifierOfMenu ucMdifireOfMenu,Order.Modifier modifier)
        {
            ucMdifireOfMenu.lblNameItenModifierMenu.Text = modifier.ModifierName;
            flpOrder.Controls.Add(ucMdifireOfMenu);
            flpOrder.Controls.SetChildIndex(ucMdifireOfMenu, indexControl + 1);
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
            this.flowLayoutPanel1.Controls.Clear();
            LoadMenuOfGroup();
        }

        void ucMenuOrder_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            UCMenuOrdercs ucGroup = (UCMenuOrdercs)sender;
            string tag = ucGroup.Tag.ToString();

            /////kiem tra item co openitem hay khong
            if (tag == "Com")
            {
                LoadItemOfGroup();
            }
                ///neu khong co openitem thi add vao order
            else
            {

                /////////
                Order.Item item = new Order.Item();
                if (seat > 0)
                    item.Seat = seat;
                item.ItemName = ucGroup.Tag.ToString();
                item.SubTotal = 4;
                OrderMain.addItemToList(item);
                addOrder(item);
                lblSubtotal.Text = OrderMain.SubTotal().ToString();

                
            }


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddSeat_Click(object sender, EventArgs e)
        {
            frmAddSeat frm = new frmAddSeat();
           
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                seat = frm.NumberSeat;
                UCSeat ucSeat = new UCSeat();
                ucSeat.lblSeat.Text = "Seat " + seat;
                lblSeat.Text = seat.ToString();
                flpOrder.Controls.Add(ucSeat);
                
            }
            
        }

        private void flpOrder_Scroll(object sender, ScrollEventArgs e)
        {
           // flpOrder.Controls.OfType<VScrollBar>().First().Width = 20; 
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            UCOrder ucOrder;
            UCItemModifierOfMenu ucItemModifireOfMenu;
            Order.Modifier modifier=null;
            Order.Item items = null;
            if (flagClick == 1)
            {
               
                ucItemModifireOfMenu = (UCItemModifierOfMenu)flpOrder.Controls[indexControl];
                modifier = (Order.Modifier)ucItemModifireOfMenu.Tag;
            }
            else
            {
                ucOrder = (UCOrder)flpOrder.Controls[indexControl];
                items = (Order.Item)ucOrder.Tag;
            }
            if (items != null)
            {
                for (int i = 0; i < OrderMain.ListItem.Count; i++)
                {
                    if (items.KeyItem == OrderMain.ListItem[i].KeyItem)
                    {
                        if (OrderMain.ListItem[i].ListModifier.Count  >0)
                        {
                            for (int indexOfModifier = OrderMain.ListItem[i].ListModifier.Count; indexOfModifier >0; indexOfModifier--)
                            {
                                flpOrder.Controls.RemoveAt(indexControl + indexOfModifier);
                            }
                             OrderMain.ListItem[i].ListModifier.Clear();
                        }
                        
                        OrderMain.ListItem.RemoveAt(i);
                    }
                    
                }

                flpOrder.Controls.RemoveAt(indexControl);
                
            }
            if (modifier != null)
            {
                for (int i = 0; i < OrderMain.ListItem.Count; i++)
                {
                    for (int j = 0; j < OrderMain.ListItem[i].ListModifier.Count; j++)
                    {
                        if (modifier.KeyItem == OrderMain.ListItem[i].ListModifier[j].KeyItem)
                        {
                            OrderMain.ListItem[i].ListModifier.RemoveAt(j);
                        }
                    }
                }
                flpOrder.Controls.RemoveAt(indexControl);
                flagClick = 0;
            }
        
        }

        private void btnVoidAll_Click(object sender, EventArgs e)
        {
            flpOrder.Controls.Clear();
            OrderMain.ListItem.Clear();
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            if (OrderMain.ListItem.Count == 0)
            {
                MessageBox.Show("NULL");
            }
        }
    }
}
