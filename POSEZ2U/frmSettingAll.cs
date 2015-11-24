<<<<<<< HEAD
﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuSetting frm = new frmMenuSetting();
            frm.ShowDialog();
        }

        
    }
}
=======
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

        
    }
}
>>>>>>> e64bb0deb30162f176f3a2a6a376811b622b9394
