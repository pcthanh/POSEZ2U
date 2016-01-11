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
    public partial class frmTool : Form
    {
        public frmTool(Button btn)
        {
            InitializeComponent();
            btnMani = btn;
            Point positionInForm = this.GetPositionInForm(btn);
            if ((positionInForm.X + base.Width) > Screen.PrimaryScreen.Bounds.Width)
            {
                positionInForm.X = Screen.PrimaryScreen.Bounds.Width - base.Width;
            }
            Point p = new Point(positionInForm.X+1, positionInForm.Y-108);
            //789,758;
            base.Location = p;
        }
        Button btnMani;
        public frmFloor.AfterJoinTable AfterJoinTable;
        public static int chk = 0;
        public Point GetPositionInForm(Control ctrl)
        {

            Point point = new Point();
            point = ctrl.Parent.PointToScreen(ctrl.Location);
            if (chk == 0)
            {
                point.X += (ctrl.Width - base.Width) /2;
            }
            else
            {
                point.X += ctrl.Width - base.Width;
            }
            point.Y += ctrl.Height;
            return point;

        }

        private void btnJoinTable_Click(object sender, EventArgs e)
        {
            frmJoinTable frm = new frmJoinTable();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                AfterJoinTable();
            }

        }

        private void btnTranferTable_Click(object sender, EventArgs e)
        {
            frmTransferTable frm = new frmTransferTable();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                AfterJoinTable();
            }
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            frmSeat frm = new frmSeat();
            frm.ShowDialog();
        }

    }

}
