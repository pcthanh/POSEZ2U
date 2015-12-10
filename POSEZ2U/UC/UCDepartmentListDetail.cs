using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSEZ2U.UC
{
    public partial class UCDepartmentListDetail : UserControl
    {
        public UCDepartmentListDetail()
        {
            InitializeComponent();
        }
        public void addButton(int departmentid)
        {
            Button btn = new Button();
            btn.Width = 107;
            btn.Height = 44;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(0, 153, 0);
            btn.ForeColor = Color.White;
            btn.Name = "btnAdd";
            btn.Text = "Add";
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Tag = departmentid;
            //btn.Click += btn_Click;
            flpPermission.Controls.Add(btn);

        }

        private void UCDepartmentListDetail_Load(object sender, EventArgs e)
        {
            //addButton();
        }
       
    }
}
