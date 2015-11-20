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
    public partial class UCTextBoxKeyPad : TextBox
    {
        public UCTextBoxKeyPad()
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.Font = new System.Drawing.Font(this.Font.FontFamily, 12);
        }
        protected override void OnEnter(EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            base.OnLeave(e);
        }

        protected override void OnClick(EventArgs e)
        {
            frmKeyPad frm = new frmKeyPad(this);

            frm.ShowDialog();
            base.OnClick(e);
        }
    }
}
