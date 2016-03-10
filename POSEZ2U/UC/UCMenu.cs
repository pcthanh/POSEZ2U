
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;

using System.Windows.Forms;
using System.Reflection;
using POSEZ2U.Class;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U.UC
{
    public partial class UCMenu : UserControl
    {
        #region Variables & Constructors
        private ICatalogueService _catalogeService;
        private ICatalogueService CatalogeService
        {
            get { return _catalogeService ?? (_catalogeService = new CatalogueService()); }
            set { _catalogeService = value; }
        }
        #endregion


        //int flagAddNewGroup = 0;
        //string[] array = { "Coffee", "Smoothie", "Juice" };
        //List<CategoryModel> lst = new List<CategoryModel>();
        private int totalPage = 0;
        private int CurrentPage = 1;
        private int pageSize = 10;
        public UCMenu()
        {
            InitializeComponent();
        }
       
        private void UCMenu_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cbColor.Items.Add(c.Name);
            }
            //addUcMenuGroup();
            //addButton();
            
        }

        public void addUcMenuGroup(int catalogueid, int CurrentPage)
        {

            if (catalogueid > 0)
            {
                if (this.totalPage == 0)
                {
                    this.totalPage = CatalogeService.GetCategoryByCatalogueID(catalogueid).Count();
                }
                var data = CatalogeService.GetCategoryByCatalogueID(catalogueid, CurrentPage);
                this.CurrentPage = CurrentPage;
                if (data.Count() > 0)
                {
                    flpIncludesGroup.Controls.Clear();
                    foreach (var item in data)
                    {
                        UCGroup ucGroup = new UCGroup();
                        ucGroup.lblNameGroup.Text = item.CategoryName;
                        ucGroup.Tag = item;
                        flpIncludesGroup.Controls.Add(ucGroup);
                    }
                    addButton(catalogueid);
                    backButton(catalogueid);
                    nextButton(catalogueid);
                }
                else
                {
                    addButton(catalogueid);
                }
            }
        }

        public void addButton(int catalogueid)
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
            btn.Tag = catalogueid;
            btn.Click += btn_Click;
            flpIncludesGroup.Controls.Add(btn);

        }

        public void nextButton(int catalogueid)
        {
            Button btn = new Button();
            btn.Width = 107;
            btn.Height = 44;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(192, 192, 192);
            btn.ForeColor = Color.White;
            btn.Name = "btnNext";
            btn.Text = "Next";
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Tag = catalogueid;
            btn.Click += btnNext_Click;
            flpIncludesGroup.Controls.Add(btn);
        }

        public void backButton(int catalogueid)
        {
            Button btn = new Button();
            btn.Width = 107;
            btn.Height = 44;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(192, 192, 192);
            btn.ForeColor = Color.White;
            btn.Name = "btnBack";
            btn.Text = "Back";
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Tag = catalogueid;
            btn.Click += btnBack_Click;
            flpIncludesGroup.Controls.Add(btn);
        }

        void btnNext_Click(object sender, EventArgs e)
        {
            Button addnewGroup = (Button)sender;
            int tag = Convert.ToInt16(addnewGroup.Tag);
            double GroupCount = (double)((decimal)totalPage / Convert.ToDecimal(pageSize));
            if (this.CurrentPage < GroupCount)
            {
                this.CurrentPage++;
                addUcMenuGroup(tag, this.CurrentPage);
            }
        }

        void btnBack_Click(object sender, EventArgs e)
        {
            Button addnewGroup = (Button)sender;
            int tag = Convert.ToInt16(addnewGroup.Tag);
            if (this.CurrentPage == 1)
            {
                return;
            }
            CurrentPage--;
            addUcMenuGroup(tag, this.CurrentPage);
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button addnewGroup = (Button)sender;
            int tag = Convert.ToInt16(addnewGroup.Tag);
            frmMenuAdd frmMenuAdd = new frmMenuAdd(tag);
            if (frmMenuAdd.ShowDialog() == DialogResult.OK)
            {
                flpIncludesGroup.Controls.Clear();
                addUcMenuGroup(tag, 1);
            }
        }
       private void UCGroup_Click(object sender, EventArgs e)
        {
           // UCGroup ucGroup = (UCGroup)sender;
            
        }


        private void cbColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X + 30, rect.Top);
                int Rect_left = e.Bounds.X + 1;
                int Rect_top = e.Bounds.Y + 1;
                Rectangle rct = new Rectangle(Rect_left, Rect_top, 20, e.Bounds.Height - 2);
                g.DrawRectangle(Pens.Black, rct);
                g.FillRectangle(b, rct);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
