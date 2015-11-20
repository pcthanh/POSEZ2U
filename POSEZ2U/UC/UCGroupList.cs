using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSEZ2U.UC
{
    public partial class UCGroupList : UserControl
    {
        public UCGroupList()
        {
            InitializeComponent();
        }
        private void addUcMenuGroup()
        {

            string[] array = { "Coffee", "Smoothie", "Juice" };

            List<string> lst = new List<string>();
            foreach (string str in array)
            {
                lst.Add(str);
            }
            UCProductIncl[] ucProductIncl = new UCProductIncl[lst.Count];
            for (int i = 0; i < lst.Count; i++)
            {
                ucProductIncl[i] = new UCProductIncl();
                ucProductIncl[i].lblNameGroupIncl.Text = lst[i].ToString();
                ucProductIncl[i].Tag = lst[i];
                ucProductIncl[i].Click += UCGroupList_Click;
                flpGroup.Controls.AddRange(ucProductIncl);
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
            flpGroup.Controls.Add(btn);

        }
        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnAdd");
        }
        void UCGroupList_Click(object sender, EventArgs e)
        {
            UCProductIncl ucProduct = (UCProductIncl)sender;
            MessageBox.Show(ucProduct.Tag.ToString());
        }

        private void UCGroupList_Load(object sender, EventArgs e)
        {
            addUcMenuGroup();
            addButton();
        }
    }
}
