using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.Class;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class Form1 : Form
    {

        #region Variables & Constructors

        private IUserService _userService;
        private IUserService UserService
        {
            get { return _userService ?? (_userService = new UserService()); }
            set { _userService = value; }
        }


        #endregion

        private StaffModel usermodel = new StaffModel();
        private List<StaffModel> listUser = new List<StaffModel>();
        private int Page = 0;
        public Form1()
        {
            InitializeComponent();
            ucKeypadLogin.txtResult = textBox1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Visible=false;
            flowLayoutPanel1.Controls.Clear();

            listUser = UserService.GetListStaff().ToList();

            var ord = 1;
            for (int i = Page; i < listUser.Count; i++)
            {
                if (ord < 8)
                {
                    Button btn = new Button();
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.Text = listUser[i].UserName;
                    btn.Name = listUser[i].UserName;
                    btn.Width = 155;
                    btn.Height = 65;
                    btn.Tag = listUser[i];
                    btn.BackColor = Color.FromArgb(153, 153, 153);
                    btn.ForeColor = Color.White;
                    btn.Click += btn_Click;
                    flowLayoutPanel1.Controls.Add(btn);
                }
                if (ord == 8 && Page <= listUser.Count)
                {
                    Button btnpage = new Button();
                    btnpage.FlatStyle = FlatStyle.Flat;
                    btnpage.FlatAppearance.BorderSize = 0;
                    btnpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnpage.Text = ">>";
                    btnpage.Name = Page.ToString();
                    btnpage.Width = 155;
                    btnpage.Height = 65;
                    btnpage.BackColor = Color.FromArgb(153, 153, 153);
                    btnpage.ForeColor = Color.White;
                    btnpage.Click += btnPage_Click;
                    flowLayoutPanel1.Controls.Add(btnpage);
                    Page = Page + 6;
                    if (Page >= listUser.Count)
                    {
                        Page = 0;
                    }
                }
                ord = ord + 1;

            }
        }


        void btnPage_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var ord = 1;
            for (int i = Page; i < listUser.Count; i++)
            {
                if (ord < 8)
                {
                    if (i == listUser.Count - 1)
                    {
                        Button btnpage = new Button();
                        btnpage.FlatStyle = FlatStyle.Flat;
                        btnpage.FlatAppearance.BorderSize = 0;
                        btnpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnpage.Text = ">>";
                        btnpage.Name = Page.ToString();
                        btnpage.Width = 155;
                        btnpage.Height = 65;
                        btnpage.BackColor = Color.FromArgb(153, 153, 153);
                        btnpage.ForeColor = Color.White;
                        btnpage.Click += btnPage_Click;
                        flowLayoutPanel1.Controls.Add(btnpage);
                        Page = 0;
                    }
                    else
                    {
                        Button btn = new Button();
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btn.Text = listUser[i].UserName;
                        btn.Name = listUser[i].UserName;
                        btn.Width = 155;
                        btn.Height = 65;
                        btn.Tag = listUser[i];
                        btn.BackColor = Color.FromArgb(153, 153, 153);
                        btn.ForeColor = Color.White;
                        btn.Click += btn_Click;
                        flowLayoutPanel1.Controls.Add(btn);
                    }

                 
                }
                if (ord == 8 && Page <= listUser.Count)
                {
                    Button btnpage = new Button();
                    btnpage.FlatStyle = FlatStyle.Flat;
                    btnpage.FlatAppearance.BorderSize = 0;
                    btnpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnpage.Text = ">>";
                    btnpage.Name = Page.ToString();
                    btnpage.Width = 155;
                    btnpage.Height = 65;
                    btnpage.BackColor = Color.FromArgb(153, 153, 153);
                    btnpage.ForeColor = Color.White;
                    btnpage.Click += btnPage_Click;
                    flowLayoutPanel1.Controls.Add(btnpage);
                    Page = Page + 6;
                    if (Page >= listUser.Count)
                    {
                        Page = 0;
                    }
                }
                ord = ord + 1;

            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            Button btnUserName = (Button)sender;
            foreach (Button ctr in flowLayoutPanel1.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(12, 120, 120))
                {
                    ctr.ForeColor = Color.White;
                    ctr.BackColor = Color.FromArgb(153, 153, 153);
                }
            }
            btnUserName.BackColor = Color.FromArgb(12, 120, 120);
            btnUserName.ForeColor = Color.White;

            usermodel = (StaffModel)(btnUserName.Tag);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (usermodel.StaffID > 0)
            {
                var passcheck = StaffModel.Decrypt(usermodel.Password);
                var passinput = textBox1.Text;
                SetImgLogin(passinput);
                if (passinput.Count() == 4)
                {
                    if (passinput == passcheck)
                    {
                        UserLoginModel.UserLoginInfo = usermodel;
                        frmMain frm = new frmMain();
                        frm.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        var passshow = textBox1.Text;
                        if (passshow.Count() > 0)
                        {
                            this.lblMessger.Visible = true;
                            //frmMessager frm = new frmMessager("Messenger", "Pin code isn't correct.");
                            //frm.ShowDialog();
                            textBox1.Text = "";
                        }

                    }
                }

            }
            else
            {
                var passshow = textBox1.Text;
                if (passshow.Count() > 0)
                {
                    frmMessager frm = new frmMessager("Messenger", "Please chose user name");
                    frm.ShowDialog();
                    textBox1.Text = "";
                }


            }

        }

        void SetImgLogin(string pass)
        {
            if (pass != "")
            {
                var i = pass.Count();
                Image image = Properties.Resources.CheckedPass;

                switch (i)
                {
                    case 1:
                        CheckPass1.Image = image;
                        break;
                    case 2:
                        CheckPass2.Image = image;
                        break;
                    case 3:
                        CheckPass3.Image = image;
                        break;
                    case 4:
                        CheckPass4.Image = image;
                        break;
                }
            }
            if (pass == "" || pass.Count() > 4 || pass.Count() < 0)
            {
                Image image = Properties.Resources.u68;
                CheckPass1.Image = image;
                CheckPass2.Image = image;
                CheckPass3.Image = image;
                CheckPass4.Image = image;
            }

        }


    }
}
