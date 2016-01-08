
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
    public partial class frmKeyPadTransferTable : Form
    {
        public frmKeyPadTransferTable(Label lbl)
        {
            InitializeComponent();
            lblMAin = lbl;
            Point positionInForm = this.GetPositionInForm(lblMAin);
            if ((positionInForm.X + base.Width) > Screen.PrimaryScreen.Bounds.Width)
            {
                positionInForm.X = Screen.PrimaryScreen.Bounds.Width - base.Width;
            }
            Point p = new Point(positionInForm.X -62, positionInForm.Y -1);
            //789,758;
            //512,176
            base.Location = p;
        }
        
        Label lblMAin;
        public static int chk = 0;
        public frmTransferTable.SendTableNO SendTable;
        public Point GetPositionInForm(Control ctrl)
        {

            Point point = new Point();
            point = ctrl.Parent.PointToScreen(ctrl.Location);
            if (chk == 0)
            {
                point.X += (ctrl.Width - base.Width) / 2;
            }
            else
            {
                point.X += ctrl.Width - base.Width;
            }
            point.Y += ctrl.Height;
            return point;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void GetText(Button btn)
        {
            SendTable(Convert.ToInt32(btn.Text));
        }
        private void GetText( int del)
        {
            SendTable(del);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GetText(btn);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            GetText(-1);
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
