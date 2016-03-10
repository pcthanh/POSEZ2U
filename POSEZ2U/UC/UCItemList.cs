using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicePOS;
using ServicePOS.Model;
using System.Reflection;

namespace POSEZ2U.UC
{
    public partial class UCItemList : UserControl
    {
        #region Variables & Constructors
        private IModifireService _modifireService;
        private IModifireService ModifireService
        {
            get { return _modifireService ?? (_modifireService = new ModifireService()); }
            set { _modifireService = value; }
        }
        #endregion
        private int totalPage = 0;
        private int CurrentPage = 1;
        private int pageSize = 10;
        public UCItemList()
        {
            InitializeComponent();
        }
        public void addUcMenuGroup(int productID, int CurrentPage)
        {

            if (productID > 0)
            {
                if (this.totalPage == 0)
                {
                    this.totalPage = ModifireService.GetListModifireToProduct(productID).Count();
                }
                var modifireList = ModifireService.GetListModifireToProduct(productID, CurrentPage).ToList();
                this.CurrentPage = CurrentPage;
                if (modifireList.Count > 0)
                {
                    flpItemList.Controls.Clear();
                    foreach (var item in modifireList)
                    {
                        UCItemListButton ucItemListButton = new UCItemListButton();
                        ucItemListButton.lblItemListButton.Text = item.ModifireName;
                        ucItemListButton.Tag = item;
                        flpItemList.Controls.Add(ucItemListButton);
                    }
                    addButton(productID);
                    backButton(productID);
                    nextButton(productID);
                }
                else
                {
                    addButton(productID);
                }
            }
        }
        public void addButton(int productID)
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
            btn.Click += btn_Click;
            btn.Tag = productID;
            flpItemList.Controls.Add(btn);

        }
        void btn_Click(object sender, EventArgs e)
        {
            Button addnewGroup = (Button)sender;
            int tag = Convert.ToInt16(addnewGroup.Tag);
            frmMenuAddItemList frmMenuAddItemList = new frmMenuAddItemList(tag);
            if (frmMenuAddItemList.ShowDialog() == DialogResult.OK)
            {
                flpItemList.Controls.Clear();
                addUcMenuGroup(tag, this.CurrentPage);
            }
        }
        public void nextButton(int categoryID)
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
            btn.Tag = categoryID;
            btn.Click += btnNext_Click;
            flpItemList.Controls.Add(btn);
        }

        public void backButton(int categoryID)
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
            btn.Tag = categoryID;
            btn.Click += btnBack_Click;
            flpItemList.Controls.Add(btn);
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
        void UCItemList_Click(object sender, EventArgs e)
        {
            UCItemListButton ucItemListButton = (UCItemListButton)sender;
        }

        private void cbProductColor_DrawItem(object sender, DrawItemEventArgs e)
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
        private void UCItemList_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cbProductColor.Items.Add(c.Name);
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtNameDesc_TextChanged(object sender, EventArgs e)
        {
            txtNameSort.Text = txtNameDesc.Text;
        }
    }
}
