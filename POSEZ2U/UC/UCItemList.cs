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
    public partial class UCItemList : UserControl
    {
        public UCItemList()
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
            UCItemListButton[] ucItemListButton = new UCItemListButton[lst.Count];
            for (int i = 0; i < lst.Count; i++)
            {
                ucItemListButton[i] = new UCItemListButton();
                ucItemListButton[i].lblItemListButton.Text = lst[i].ToString();
                ucItemListButton[i].Tag = lst[i];
                ucItemListButton[i].Click += UCItemList_Click;
                flpItemList.Controls.AddRange(ucItemListButton);
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
            flpItemList.Controls.Add(btn);

        }
        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnAdd");
        }
        void UCItemList_Click(object sender, EventArgs e)
        {
            UCItemListButton ucItemListButton = (UCItemListButton)sender;
            MessageBox.Show(ucItemListButton.Tag.ToString());
        }

        private void UCItemList_Load(object sender, EventArgs e)
        {
            addUcMenuGroup();
            addButton();
        }
    }
}
