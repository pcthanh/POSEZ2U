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
    public partial class frmMessager : Form
    {
        private string Title;
        private string Descsription;
        public frmMessager(string _Title,string _Descsription)
        {
            InitializeComponent();
            Title = _Title;
            Descsription = _Descsription;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmMessager_Load(object sender, EventArgs e)
        {
            this.groupBox1.Text = Title;
            this.lblDescsription.Text = Descsription;
        }
    }
}
