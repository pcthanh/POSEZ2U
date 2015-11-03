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
    public partial class frmFloor : Form
    {
        public frmFloor()
        {
            InitializeComponent();
        }
        private void paintFloor()
        {
            for (int i = 1; i < 60; i++)
            {
                UC.UCTable ucTable = new UC.UCTable();
                ucTable.lbTableNo.Text = i.ToString();
                ucTable.lbTime.Text = "03/11/2015";
                ucTable.lbSubTotal.Text = "20,000";
                //ftpEatIn.Controls.Add(ucTable);
                flowLayoutPanel1.Controls.Add(ucTable);
            }
        }

        private void frmFloor_Load(object sender, EventArgs e)
        {
            this.paintFloor();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
