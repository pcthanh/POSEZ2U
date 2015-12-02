using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.Class;
namespace POSEZ2U
{
    public partial class frmPayMent : Form
    {
        public frmPayMent()
        {
            InitializeComponent();
        }
        private int animationTime;
        private int flags;
        public frmPayMent(int AnimationTime, int Flags)
        {
            animationTime = AnimationTime;
            flags = Flags;
            InitializeComponent();
        }

        private void frmPayMent_Load(object sender, EventArgs e)
        {
            var screen = Screen.FromPoint(this.Location);
            this.Width = screen.WorkingArea.Width;
            this.Height = screen.WorkingArea.Height-50;
            //this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
            this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
            WinAPI.AnimateWindow(this.Handle, animationTime, flags);
            
        }
    }
}
