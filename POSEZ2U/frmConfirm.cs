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
    public partial class frmConfirm : Form
    {
        private string Title;
        private string Description;
        public frmConfirm(string _Title, string _Descsription)
        {
            InitializeComponent();
            Title = _Title;
            Description = _Descsription;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            groupBox1.Text = Title;
            lblDescsription.Text = Description;
        }
    }
}
