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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ucKeypadLogin.txtResult = textBox1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i <= 8; i++)
            {
                Button btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Text = i.ToString();
                btn.Name = i.ToString();
                btn.Width = 155;
                btn.Height = 65;
                btn.Tag = i;
                btn.BackColor = Color.FromArgb(153, 153, 153);
                btn.ForeColor = Color.White;
                if (i == 8)
                {
                    btn.Text = ">";
                }
                btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Tag.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "123456")
            {
                frmMain frm = new frmMain();
                frm.ShowDialog();
                this.Hide();
            }

        }


    }
}