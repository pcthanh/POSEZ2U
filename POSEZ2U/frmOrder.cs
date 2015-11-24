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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadMenuGroup();
        }
        private void LoadMenuGroup()
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
        }

        void ucMenuOrder_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            UCMenuOrdercs ucGroup = (UCMenuOrdercs)sender;
            MessageBox.Show(ucGroup.Tag.ToString());
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
