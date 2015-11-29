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
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U.UC
{
    public partial class UCModifier : UserControl
    {
        public UCModifier()
        {
            InitializeComponent();
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
        private void UCModifier_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cbColor.Items.Add(c.Name);
            }
        }
    }
}
