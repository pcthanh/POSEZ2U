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
    public partial class frmShift : Form
    {
        public frmShift()
        {
            InitializeComponent();
        }
        /// <summary>
        /// su dung control UCShiftItem de add chi tiet cho tung shift
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            frmEndShift frm = new frmEndShift();
            frm.ShowDialog();
        }
    }
}
