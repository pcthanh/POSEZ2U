using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.UC;
namespace POSEZ2U
{
    public partial class frmMenu : Form
    {
        public frmMenu()
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
           
            for (int i = 0; i < lst.Count; i++)
            {
                UCGroup ucGroup = new UCGroup();
                ucGroup.lblNameGroup.Text = lst[i].ToString();
                ucGroup.Tag = lst[i];
                ucGroup.Click += ucGroup_Click;
                flpIncludesGroup.Controls.Add(ucGroup);
            }
            
        }

        void ucGroup_Click(object sender, EventArgs e)
        {
            
        }

        
        private void frmMenu_Load(object sender, EventArgs e)
        {
            addUcMenuGroup();
        }

    }
}
