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
    public partial class frmProcessing : Form
    {
       
       
        public bool IsStoped { get; set; }
        frmFloor frmFlorr;
        public frmProcessing(frmFloor f)
        {
            this.components = null;
            this.IsStoped = false;
            InitializeComponent();
            frmFlorr = f;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.pbAboutBar.Value < 100)
            {
                this.pbAboutBar.Value++;
            }
            else if (this.IsStoped)
            {
                this.timer1.Stop();
                if (this.frmFlorr != null)
                {
                    this.Close();
                    this.frmFlorr.Visible = true;
                }
                else if (this.pbAboutBar != null)
                {
                    this.pbAboutBar.Visible = true;
                }
               
            }
            
        }

        private void frmProcessing_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
