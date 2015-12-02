using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicePOS;

namespace POSEZ2U.UC
{
    public partial class UCGroupList : UserControl
    {


        #region Variables & Constructors
        private ICatalogueService _catalogeService;
        private ICatalogueService CatalogeService
        {
            get { return _catalogeService ?? (_catalogeService = new CatalogueService()); }
            set { _catalogeService = value; }
        }
        #endregion

        public UCGroupList()
        {
            InitializeComponent();
        }



        public void addUcMenuGroup(int categoryID)
        {

           
            if (categoryID > 0)
            {
                var productlist = CatalogeService.GetProductByCategoryID(categoryID).ToList();
                if (productlist.Count > 0)
                {
                    UCProductIncl[] ucProductIncl = new UCProductIncl[productlist.Count];
                    for (int i = 0; i < productlist.Count; i++)
                    {
                        ucProductIncl[i] = new UCProductIncl();
                        ucProductIncl[i].lblNameGroupIncl.Text = productlist[i].ProductNameDesc;
                        ucProductIncl[i].Tag = productlist[i];
                        ucProductIncl[i].Click += UCGroupList_Click;
                        flpGroup.Controls.AddRange(ucProductIncl);
                    }
                }
            }
           

        }
        public void addButton(int categoryID)
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
            btn.Tag = categoryID;
            btn.Click += btn_Click;
            flpGroup.Controls.Add(btn);

        }
        void btn_Click(object sender, EventArgs e)
        {
            Button addnewGroup = (Button)sender;
            int tag = Convert.ToInt16(addnewGroup.Tag);
            frmGroupAdd frmGroupAdd = new frmGroupAdd(tag);
            if (frmGroupAdd.ShowDialog() == DialogResult.OK)
            {
                flpGroup.Controls.Clear();
                addUcMenuGroup(tag);
                addButton(tag);

            }
        }
        void UCGroupList_Click(object sender, EventArgs e)
        {
            UCProductIncl ucProduct = (UCProductIncl)sender;
            MessageBox.Show(ucProduct.Tag.ToString().ToString());
        }

        private void UCGroupList_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cbGroupColor.Items.Add(c.Name);
                this.cbProductColor.Items.Add(c.Name);
            }
            //addUcMenuGroup();
            //addButton();
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
       
      


    }
}
