using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicePOS;
using ServicePOS.Model;
namespace POSEZ2U
{
    public partial class frmChooseCard : Form
    {
        public frmChooseCard()
        {
            InitializeComponent();
        }
        public CardModel Card;
        public frmChooseCard(CardModel _Card)
        {
            InitializeComponent();
            Card = _Card;
        }
        private IOrderService _orderService;
        private IOrderService OrderService
        {
            get { return _orderService ?? (_orderService = new OrderService()); }
            set { _orderService = value; }
        }
        private void LoadCard()
        {
            var data = OrderService.LoadCard();
            foreach (CardModel item in data)
            {
                Button btn = new Button();
                btn.Width = 173;
                btn.Height = 61;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Text = item.CardName;
                btn.Tag = item;
                btn.BackColor = Color.FromArgb(153, 153, 153);
                btn.ForeColor = Color.White;
                flpCard.Controls.Add(btn);
                btn.Click += btn_Click;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CardModel CardTemp = (CardModel)btn.Tag;
            Card = CardTemp;
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void frmChooseCard_Load(object sender, EventArgs e)
        {
            LoadCard();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
