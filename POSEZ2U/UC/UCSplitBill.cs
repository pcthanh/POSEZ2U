﻿using System;
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
    public partial class UCSplitBill : UserControl
    {
        public UCSplitBill()
        {
            InitializeComponent();
        }

        private void UCSplitBill_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
