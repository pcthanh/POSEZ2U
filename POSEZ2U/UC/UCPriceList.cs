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
    public partial class UCPriceList : UserControl
    {
        public UCPriceList()
        {
            InitializeComponent();
        }

        private void UCPriceList_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void UCPriceList_Load(object sender, EventArgs e)
        {
            int NewWidthPn2 = Screen.PrimaryScreen.WorkingArea.Width - 400;
            this.MaximumSize = new Size(NewWidthPn2, this.Height);
            this.Size = new Size(NewWidthPn2, this.Height);
        }
    }
}
