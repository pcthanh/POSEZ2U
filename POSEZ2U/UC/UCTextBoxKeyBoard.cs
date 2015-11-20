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
    public partial class UCTextBoxKeyBoard : TextBox
    {
        public UCTextBoxKeyBoard()
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.Font = new System.Drawing.Font(this.Font.FontFamily, 12);

        }
        protected override void OnEnter(EventArgs e)
        {
            this.InitForcus();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            base.OnLeave(e);
        }

        protected override void OnClick(EventArgs e)
        {
            this.InitForcus();
            base.OnClick(e);
        }

        private void InitForcus()
        {
            frmKeyBoard frm = new frmKeyBoard(this);
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            frm.ShowDialog();
        }

        public void SetForcus()
        {
            //this.InitForcus();
            this.Focus();
        }
    }
}
