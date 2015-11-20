using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using POSEZ2U.UC;
namespace POSEZ2U.UC
{
    public partial class UCMenu : UserControl
    {
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
            addUcMenuGroup();
            addButton();
        }
        private void addUcMenuGroup()
        {
          
            string[] array = { "Coffee", "Smoothie", "Juice" };

            List<string> lst = new List<string>();
            foreach (string str in array)
            {
                lst.Add(str);
            }
            UCGroup[] ucGroup = new UCGroup[lst.Count];
            for (int i = 0; i <lst.Count; i++)
            {
                ucGroup[i]= new UCGroup();
                ucGroup[i].lblNameGroup.Text = lst[i].ToString();
                ucGroup[i].Tag = lst[i];
                ucGroup[i].Click += new EventHandler(UCGroup_Click);
                flpIncludesGroup.Controls.AddRange(ucGroup);
            }
            
        }
        private void addButton()
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
            flpIncludesGroup.Controls.Add(btn);

        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnAdd");
        }
       private void UCGroup_Click(object sender, EventArgs e)
        {
            UCGroup ucGroup = (UCGroup)sender;
            MessageBox.Show(ucGroup.Tag.ToString());
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
