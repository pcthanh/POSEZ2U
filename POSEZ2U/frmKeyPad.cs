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
    public partial class frmKeyPad : Form
    {
        public frmKeyPad(TextBox textBox)
        {
            InitializeComponent();
            mTextBox = textBox;
            Point positionInForm = this.GetPositionInForm(textBox);
            if ((positionInForm.X + base.Width) > Screen.PrimaryScreen.Bounds.Width)
            {
                positionInForm.X = Screen.PrimaryScreen.Bounds.Width - base.Width;
            }
            base.Location = positionInForm;
        }
        private TextBox mTextBox;
        private bool mIsFirstLoad = true;
        public bool IsNegative { get; set; }
        public static int chk = 0;
        private string mInitText = "";
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
        private void btn0_Click(object sender, EventArgs e)
        {
            if (mIsFirstLoad)
            {
                mIsFirstLoad = false;
                mTextBox.Text = "";
            }
            Button btn = (Button)sender;
            mTextBox.Text += btn.Text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            mTextBox.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (mTextBox.Text.Length > 0)
            {
                string text = mTextBox.Text;
                mTextBox.Text = text.Remove(text.Length - 1, 1);
            }
        }
    }
}
