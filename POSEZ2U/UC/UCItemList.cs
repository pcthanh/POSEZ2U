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
        public UCItemList()
        {
            InitializeComponent();
        }
        public void addUcMenuGroup(int productID)
        {

            if (productID > 0)
            {
                var modifireList = ModifireService.GetListModifireToProduct(productID).ToList();
                if (modifireList.Count > 0)
                {
                    UCItemListButton[] ucItemListButton = new UCItemListButton[modifireList.Count];
                    for (int i = 0; i < modifireList.Count; i++)
                    {
                        ucItemListButton[i] = new UCItemListButton();
                        ucItemListButton[i].lblItemListButton.Text = modifireList[i].ModifireName.ToString();
                        ucItemListButton[i].Tag = modifireList[i];
                        ucItemListButton[i].Click += UCItemList_Click;
                        flpItemList.Controls.AddRange(ucItemListButton);
                    }
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
                addUcMenuGroup(tag);
                addButton(tag);

            }
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
    }
}
