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
    public partial class UCPrinterJobDetail : UserControl
    {
        public UCPrinterJobDetail()
        {
            InitializeComponent();
        }
        public void LoadPriterMapp()
        {
            UCPrinterMapping map = new UCPrinterMapping();
            map.Width = flpPriterMap.Width;
            flpPriterMap.Controls.Add(map);
        }

        private void UCPrinterJobDetail_Load(object sender, EventArgs e)
        {
            //LoadPriterMapp();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            MessageBox.Show(flpPriterMap.Width + "");
        }
    }
}
