using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSEZ2U
{
    public partial class UCCustomerItem : UserControl
    {
        public UCCustomerItem()
        {
            InitializeComponent();
        }

        private void UCCustomerItem_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
