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
    public partial class frmOpacity : Form
    {
        public frmOpacity()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           // this.Name = "MaskedDialog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }
        private Form dialog;
        private frmOpacity(Form parent, Form dialog)
        {
            this.dialog = dialog;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.BackColor = System.Drawing.Color.Black;
            //this.Opacity = 0.50;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = parent.ClientSize;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            parent.Move += AdjustPosition;
            parent.SizeChanged += AdjustPosition;
        }
        private void AdjustPosition(object sender, EventArgs e)
        {
            Form parent = sender as Form;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            this.ClientSize = parent.ClientSize;
        }
        public static DialogResult ShowDialog(Form parent, Form dialog)
        {
            //Enabled = false;
            Form shadow = new Form();
            shadow.MinimizeBox = false;
            shadow.MaximizeBox = false;
            shadow.ControlBox = false;

            shadow.Text = "";
            shadow.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //shadow.Size = Size;
            shadow.BackColor = Color.Black;
            shadow.Opacity = 0.3;
            shadow.ShowInTaskbar = false;
            shadow.WindowState = FormWindowState.Maximized;
            shadow.Show();
            //shadow.Location = Location;
            shadow.Enabled = false;

            var mask = new frmOpacity(parent, dialog);
            dialog.StartPosition = FormStartPosition.CenterParent;
            //mask.Show();
            var result = dialog.ShowDialog(mask);
            mask.Close();
            shadow.Close();
            return result;
        }
    }
}
