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
    public partial class frmKeyBoard : Form
    {
        public frmKeyBoard(TextBox txt)
        {
            InitializeComponent();
            mTextBox = txt;
            txtresult.PasswordChar = txt.PasswordChar;
            capslock = false;
            IsShift = true;
            ChangerCaplock(!capslock);
            Point positionInForm = this.GetPositionInForm(txt);
            if ((positionInForm.X + base.Width) > Screen.PrimaryScreen.Bounds.Width)
            {
                positionInForm.X = Screen.PrimaryScreen.Bounds.Width - base.Width;
            }
            base.Location = positionInForm;
        }
        public static int chk = 0;
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
        private void ChangerCaplock(bool key)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null)
                {
                    char ch = '.';
                    try
                    {
                        ch = Convert.ToChar(control.Tag);
                    }
                    catch (Exception)
                    { }
                    if (ch <= 'z' && ch >= 'a')
                    {
                        if (key)
                        {
                            control.Text = (char)(ch - 'a' + 'A') + "";
                        }
                        else
                        {
                            control.Text = ch + "";
                        }
                    }
                }
            }
        }
        private bool capslock;

        private bool IsShift;
        private TextBox mTextBox;

        private void btnthan_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnthan.Text);
        }

        private void btnacong_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnacong.Text);
        }

        private void btnthang_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnthang.Text);
        }

        private void btndola_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btndola.Text);
        }

        private void btnphantram_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnphantram.Text);
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnbang.Text);
        }

        private void btnmu_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("{" + btnmu.Text + "}");
        }

        private void btnsao_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnsao.Text);
        }

        private void btntronmo_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("{" + btntronmo.Text + "}");
        }

        private void btntrondong_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("{" + btntrondong.Text + "}");
        }

        private void btnnhonmo_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("{LEFT}");
        }

        private void btnnhondong_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("{RIGHT}");
        }

        private void btnnhohon_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("{HOME}");
        }

        private void btnhoac_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("{END}");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
            //ktdot = false;
            if (!capslock)
            {
                IsShift = true;
                ChangerCaplock(!capslock);
            }
        }

        private void btncapslock_Click(object sender, EventArgs e)
        {
            if (capslock == true)
            {
                capslock = false;
                ChangerCaplock(capslock);
            }
            else
            {
                capslock = true;
                ChangerCaplock(capslock);
            }
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            try
            {
                mTextBox.Text = txtresult.Text;
                this.DialogResult = DialogResult.OK;
                //btnexit_Click(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
             int l = txtresult.Text.Length;
            if (l > 0)
            {
                //txtresult.Text = txtresult.Text.Remove(l - 1);
                if (txtresult == null)
                {
                    return;
                }
                txtresult.Focus();
                SendKeys.Send("{BS}");
                //if (txtresult.Text.Contains("."))
                //{
                //    ktdot = true;
                //}
                //else
                //{
                //    ktdot = false;
                //}
        }

    }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("3");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("0");
        }

        private void btnchamphay_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnhaicham.Text);
        }

        private void btnhaicham_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnhaicham.Text);
        }

        private void btnvuongdong_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnvuongdong.Text);
        }

        private void btndauhoi_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btndauhoi.Text);
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnchia.Text);
        }

        private void btnphay_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnphay.Text);
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send("{add}");
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btntru.Text);
        }

        private void btnvuongmo_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btnvuongmo.Text);
        }

        private void btnshift_Click(object sender, EventArgs e)
        {
            IsShift = true;
            ChangerCaplock(!capslock);
        }

        private void btnspace_Click(object sender, EventArgs e)
        {
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(" ");
            if (!capslock)
            {
                IsShift = true;
                ChangerCaplock(!capslock);
            }
        }
        private void btnKey_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //txtresult.Text += btn.Text;
            if (txtresult == null)
            {
                return;
            }
            txtresult.Focus();
            SendKeys.Send(btn.Text);
            if (IsShift)
            {
                ChangerCaplock(capslock);
                IsShift = false;
            }
        }
        }
}
