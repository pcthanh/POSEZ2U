
﻿using POSEZ2U.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSEZ2U
{
    public partial class frmSettingAll : Form
    {
        public frmSettingAll()
        {
            InitializeComponent();
           
        }

        

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmMenuSetting frm = new frmMenuSetting();
            frm.ShowDialog();
        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            frmUserSetting frm = new frmUserSetting();
            frm.ShowDialog();
        }

        
    }
}
