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
    public partial class frmMenuSetting : Form
    {
        public frmMenuSetting()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnDetail.Controls.Clear();
            //frmMenu frm = new frmMenu();
            //frm.Dock = DockStyle.Fill;
            //frm.TopLevel = false;
            //frm.AutoScroll = true;
            //pnDetail.Controls.Add(frm);
            //frm.Show();
            UCMenu ucMenu = new UCMenu();
            ucMenu.Dock = DockStyle.Fill;
            pnDetail.Controls.Add(ucMenu);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
