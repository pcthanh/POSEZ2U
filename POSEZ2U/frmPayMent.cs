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
using POSEZ2U.UC;
using ServicePOS.Model;
using ServicePOS;
using SystemLog;
using Printer;

namespace POSEZ2U
{
    public partial class frmPayMent : Form
    {
        public frmPayMent()
        {
            InitializeComponent();
            ucKeyPadOrder1.txtResult = txtTender;
        }
        private int animationTime;
        private int flags;
        double balancetemp;
        POSEZ2U.Class.MoneyFortmat money = new POSEZ2U.Class.MoneyFortmat(POSEZ2U.Class.MoneyFortmat.AU_TYPE);
        public OrderDateModel OrderMain;
        List<PayMentModel> lstPayment = new List<PayMentModel>();
        List<PayMentModel> lstPaymentSplitBill = new List<PayMentModel>();
        List<InvoiceByCardModel> lstInvoiceByCard = new List<InvoiceByCardModel>();
        List<InvoiceByCardModel> lstInvoiceByCardSplitBill = new List<InvoiceByCardModel>();
        CardModel cardTemp = new CardModel();
        DiscountModel Discount = new DiscountModel();
        bool lockTextChange = false;
        bool RemoveUc = false;
        Double txtTempBalnces = 0;
        private IInvoiceService _invoiceService;
        private IInvoiceService InvoiceService
        {
            get { return _invoiceService ?? (_invoiceService = new InvoiceService()); }
            set { _invoiceService = value; }
        }

        public frmPayMent(OrderDateModel _OrderMain, int AnimationTime, int Flags)
        {
            //animationTime = AnimationTime;
            //flags = Flags;
            animationTime = AnimationTime;
            flags = Flags;
           
            InitializeComponent();
            OrderMain = _OrderMain;
            txtTender.Focus();
            ucKeyPadOrder1.txtResult = txtTender;
            this.Location = new Point(0, 100);
        }
        private void EnableButton()
        {
            btnCash.Enabled = true;
            btnCard.Enabled = true;
            btnCheque.Enabled = true;
            btnGiftCard.Enabled = true;
            btnAccount.Enabled = true;
        }

        private void DisEnableButton()
        {
            btnCash.Enabled = false;
            btnCard.Enabled = false;
            btnCheque.Enabled = false;
            btnGiftCard.Enabled = false;
            btnAccount.Enabled = false;
        }
        private void frmPayMent_Load(object sender, EventArgs e)
        {
            //var screen = Screen.FromPoint(this.Location);
            //this.Width = screen.WorkingArea.Width;
            //this.Height = screen.WorkingArea.Height-50;
            ////this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
            //this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
            //WinAPI.AnimateWindow(this.Handle, animationTime, flags);
           
            lblTotalDue.Text = "$" + money.Format2(Convert.ToDouble(OrderMain.SubTotal()));
            txtBalance.Text = "$" + money.Format2(Convert.ToDouble(OrderMain.SubTotal()));
            txtBalancetemp.Text = OrderMain.SubTotal().ToString();
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckTotal() == 1)
            {
                OrderMain.ListPayment = lstPayment;
                OrderMain.ListInvoiceByCard = lstInvoiceByCard;
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                frmMessager frm = new frmMessager("Payment", "money not enought");
                frm.ShowDialog();
            }

        }
        private double TotalListPayMent()
        {
            double total = 0;
            if (lstPayment.Count > 0)
            {
                for (int i = 0; i < lstPayment.Count; i++)
                {
                    total = total + lstPayment[i].Total;
                }
            }
            return total;
        }

        private void CalTotal()
        {
            try
            {
                lblTender.Text = txtTender.Text;
                double tender = 0;
                double totaldiscount;
                double total = OrderMain.SubTotal();
                double totalPaymet = 0;
                double totaltemp1 = 0;
                this.EnableButton();
                if (txtTender.Text != string.Empty)
                {
                    tender = Convert.ToDouble(txtTender.Text) * 1000;
                }
                if (OrderMain.DiscountType > 0)
                {
                    totaldiscount = OrderMain.Discount;
                    totalPaymet = TotalListPayMent() * 1000;
                    double totaltemp = total - totaldiscount - tender - totalPaymet;

                    if (totaltemp > 0)
                        txtBalance.Text = "$" + money.Format2(totaltemp);
                    else
                    {
                        txtBalance.Text = "$0.00";
                        lblChange.Text = "$" + money.Format2(totaltemp * -1);
                    }
                }
                else
                {
                    if (tender > total)
                    {
                        lblChange.Text = "$" + money.Format2((total - tender) * -1);
                        txtBalance.Text = "$0.00";
                    }
                    else
                    {
                        if (lstPayment.Count > 0)
                        {
                            for (int i = 0; i < lstPayment.Count; i++)
                            {
                                totaltemp1 = totaltemp1 + lstPayment[i].Total;
                            }
                            if (total - (totaltemp1 * 1000 + tender) < 0)
                            {
                                txtBalance.Text = "$0.00";
                            }
                            else
                                txtBalance.Text = "$" + money.Format2(total - (totaltemp1 * 1000 + tender));
                        }
                        else
                            txtBalance.Text = "$" + money.Format2(total - tender);
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent::::::::::::::::::::::::::::::txtTender_TextChanged:::::::::::::::::;" + ex.Message);
            }
        }
        private void txtTender_TextChanged(object sender, EventArgs e)
        {
            
            CalTotal();
        }
        private int CountUcPayMent()
        {
            return flpPaymentType.Controls.Count +1;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTender.Text != string.Empty && Convert.ToDouble(txtTender.Text)>0)
                {
                    lockTextChange = true;
                    CashModel item = new CashModel();
                    item.PaymentID = 1;
                    item.Total = Convert.ToDouble(txtTender.Text);
                    addCash(item);
                    addPayment(item);
                    CheckTotal();
                    lockTextChange = false;
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent::::::btnCash_Click:::::::::::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void addCash(CashModel item)
        {
            UCAllPayMent ucPayment = new UCAllPayMent();
            item.PaymentID = 1;
            ucPayment.lblStt.Text ="#"+ CountUcPayMent().ToString();
            ucPayment.lblMethodType.Text = btnCash.Text;
            ucPayment.lblTotal.Text = "$" + money.Format2(item.Total * 1000);
            ucPayment.Tag = item;
            ucPayment.Click += ucPayment_Click;
            flpPaymentType.Controls.Add(ucPayment);
        }

        void ucPayment_Click(object sender, EventArgs e)
        {
            UCAllPayMent ucCash = (UCAllPayMent)sender;
            try
            {
                CashModel data = (CashModel)ucCash.Tag;
                for (int i = 0; i < lstPayment.Count; i++)
                {
                    if (lstPayment[i].PaymentTypeID == data.PaymentID)
                    {
                        lstPayment[i].Total = lstPayment[i].Total - data.Total;
                    }
                }
                flpPaymentType.Controls.Remove(ucCash);
                RemoveUc = true;
                CheckTotal();
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayment:::::::::::::::::::::ucPayment_Click::::::::::::::::::::::" + ex.Message);
            }

        }
        private void btnCard_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTender.Text != string.Empty && Convert.ToDouble(txtTender.Text)>0)
                {
                    lockTextChange = true;
                    frmChooseCard frm = new frmChooseCard(cardTemp);
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                    {
                        cardTemp = frm.Card;
                        cardTemp.PayMenyID = 2;
                        cardTemp.SubTotal = Convert.ToDouble(txtTender.Text);
                        addCard(cardTemp);
                        addPayment(cardTemp);
                        InvoiceByCardModel item = new InvoiceByCardModel();
                        item.CardID = cardTemp.CardID;
                        item.Total = cardTemp.SubTotal * 1000;
                        item.NameCard = cardTemp.CardName;
                        lstInvoiceByCard.Add(item);
                        lstInvoiceByCardSplitBill.Add(item);
                        CheckTotal();
                        lockTextChange = false;
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent:::::::::::::::::::::::::::::::::;btnCard_Click::::::::::::::::::::::::::;;" + ex.Message);
            }
        }
        private int CheckPayment(CashModel item)
        {
            int index = -1;
            try
            {
                if (lstPayment.Count > 0)
                {
                    for (int i = 0; i < lstPayment.Count; i++)
                    {
                        if (lstPayment[i].PaymentTypeID == item.PaymentID)
                        {
                            index = i;
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent::::::::CheckPayment::::::::::::::::::::CashModel::::::::::::::::" + ex.Message);
            }
            return index;
        }
        private int CheckPayment( AccountModel item)
        {
            int index = -1;
            try
            {
                if (lstPayment.Count > 0)
                {
                    for (int i = 0; i < lstPayment.Count; i++)
                    {
                        if (lstPayment[i].PaymentTypeID == item.PaymentID)
                        {
                            index = i;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent::::::::CheckPayment::::::::::::::::::::AccountModel::::::::::::::::" + ex.Message);
            }
            return index;
        }
        private int CheckPaymentSplitBill(CashModel item)
        {
            int index = -1;
            try
            {
                if (lstPaymentSplitBill.Count > 0)
                {
                    for (int i = 0; i < lstPaymentSplitBill.Count; i++)
                    {
                        if (lstPaymentSplitBill[i].PaymentTypeID == item.PaymentID)
                        {
                            index = i;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent::::::::CheckPayment::::::::::::::::::::CashModel::::::::::::::::" + ex.Message);
            }
            return index;
        }

        private int CheckPaymentSplitBill(AccountModel item)
        {
            int index = -1;
            try
            {
                if (lstPaymentSplitBill.Count > 0)
                {
                    for (int i = 0; i < lstPaymentSplitBill.Count; i++)
                    {
                        if (lstPaymentSplitBill[i].PaymentTypeID == item.PaymentID)
                        {
                            index = i;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent::::::::CheckPayment::::::::::::::::::::CashModel::::::::::::::::" + ex.Message);
            }
            return index;
        }
        private void addPayment(CashModel item)
        {
            try
            {
                int result = CheckPayment(item);
                int resulSplit=CheckPaymentSplitBill(item);
                if (result != -1)
                {
                    lstPayment[result].Total = lstPayment[result].Total + item.Total;
                    
                }
                else
                {
                    PayMentModel pay = new PayMentModel();
                    pay.PaymentTypeID = item.PaymentID;
                    pay.Total = item.Total;
                    lstPayment.Add(pay);
                   
                }
                /////////////
                if (resulSplit != -1)
                {
                    lstPaymentSplitBill[result].Total = lstPaymentSplitBill[result].Total + item.Total;

                }
                else
                {
                    PayMentModel pay = new PayMentModel();
                    pay.PaymentTypeID = item.PaymentID;
                    pay.Total = item.Total;
                    
                    lstPaymentSplitBill.Add(pay);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent::::::::addPayment:::::::::::::::::::::::::::CashModel::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private void addPayment(AccountModel item)
        {
            try
            {
                int result = CheckPayment(item);
                int resulSplit = CheckPaymentSplitBill(item);
                if (result != -1)
                {
                    lstPayment[result].Total = lstPayment[result].Total + item.Total;

                }
                else
                {
                    PayMentModel pay = new PayMentModel();
                    pay.PaymentTypeID = item.PaymentID;
                    pay.Total = item.Total;
                    lstPayment.Add(pay);

                }
                /////////////
                if (resulSplit != -1)
                {
                    lstPaymentSplitBill[result].Total = lstPaymentSplitBill[result].Total + item.Total;

                }
                else
                {
                    PayMentModel pay = new PayMentModel();
                    pay.PaymentTypeID = item.PaymentID;
                    pay.Total = item.Total;

                    lstPaymentSplitBill.Add(pay);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent::::::::addPayment:::::::::::::::::::::::::::CashModel::::::::::::::::::::::::::" + ex.Message);
            }
        }
        private int CheckPayment(CardModel item)
        {
            int index = -1;
            try
            {
                if (lstPayment.Count > 0)
                {
                    for (int i = 0; i < lstPayment.Count; i++)
                    {
                        if (lstPayment[i].PaymentTypeID == item.PayMenyID)
                        {
                            index = i;
                        }
                    }
                }

               
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent:::::::::CheckPayment:::::::::::::::::::::::::" + ex.Message);
            }
            return index;
        }


        private int CheckPaymentSplitBill(CardModel item)
        {
            int index = -1;
            try
            {
                if (lstPaymentSplitBill.Count > 0)
                {
                    for (int i = 0; i < lstPaymentSplitBill.Count; i++)
                    {
                        if (lstPaymentSplitBill[i].PaymentTypeID == item.PayMenyID)
                        {
                            index = i;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent:::::::::CheckPayment:::::::::::::::::::::::::" + ex.Message);
            }
            return index;
        }
        private void addPayment(CardModel item)
        {
            try
            {
                int result = CheckPayment(item);
                int resultSplitBill = CheckPaymentSplitBill(item);
                if (result != -1)
                {
                    lstPayment[result].Total = lstPayment[result].Total + item.SubTotal;
                    lstPaymentSplitBill[result].Total = lstPaymentSplitBill[result].Total;
                }
                else
                {
                    PayMentModel pay = new PayMentModel();
                    pay.PaymentTypeID = item.PayMenyID;
                    pay.Total = item.SubTotal;
                    lstPayment.Add(pay);
                    
                }

                //////////////
                if (resultSplitBill != -1)
                {
                    lstPaymentSplitBill[result].Total = lstPaymentSplitBill[result].Total + item.SubTotal;
                    
                }
                else
                {
                    PayMentModel pay = new PayMentModel();
                    pay.PaymentTypeID = item.PayMenyID;
                    pay.Total = item.SubTotal;
                   
                    lstPaymentSplitBill.Add(pay);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayMent:::::::::::::::::addPayment:::::::::::::::::::::::::::::" + ex.Message);
            }
        }

        private void InsertInvoie()
        {

            OrderMain.ListPayment = lstPayment;
            OrderMain.ListInvoiceByCard = lstInvoiceByCard;
            int result = InvoiceService.InsertInvoice(OrderMain);

        }
        private void addCard(CardModel item)
        {
            try
            {
                UCPaymentCard ucCard = new UCPaymentCard();
                item.PayMenyID = 2;
                ucCard.lblStt.Text ="#"+ CountUcPayMent().ToString();
                ucCard.lblMethodType.Text = item.CardName;
                ucCard.lblTotal.Text = "$" + money.Format2(item.SubTotal * 1000);
                ucCard.Tag = item;
                ucCard.Click += ucCard_Click;
                flpPaymentType.Controls.Add(ucCard);
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayment::::::::::::::::::::::::::::addCard::::::::::::::::::::" + ex.Message);
            }
        }

        void ucCard_Click(object sender, EventArgs e)
        {
            UCPaymentCard ucCard = (UCPaymentCard)sender;
            try
            {
                CardModel data = (CardModel)ucCard.Tag;
                for (int i = 0; i < lstPayment.Count; i++)
                {
                    if (lstPayment[i].PaymentTypeID == data.PayMenyID)
                    {
                        lstPayment[i].Total = lstPayment[i].Total - data.SubTotal;
                    }
                }
                flpPaymentType.Controls.Remove(ucCard);
                RemoveUc = true;
                CheckTotal();

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayment:::::::::::::::::::::ucCard_Click::::::::::::::::::::::" + ex.Message);
            }
        }

        private int CheckDiscount()
        {
            int resul = 0;
            for (int i = 0; i < flpPaymentType.Controls.Count; i++)
            {
                if (flpPaymentType.Controls[i] is UCDiscount)
                    resul = 1;
            }
            return resul;
        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckDiscount() == 1)
                {
                    frmMessager frm = new frmMessager("Discount", "Exitst discount");
                    frm.ShowDialog();
                }
                else
                {
                    double totalDiscount ;
                    frmDiscount frm = new frmDiscount(Discount);
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Discount = frm.Discount;
                        UCDiscount ucDiscount = new UCDiscount();

                        if (Discount.DiscountType == 1)
                        {
                            ucDiscount.lblMethodType.Text = Discount.DiscountName + "%";
                            totalDiscount = (OrderMain.SubTotal() * (Convert.ToDouble(Discount.Total / 100.0)) / 100);
                            ucDiscount.lblTotal.Text = "$" + money.Format2(totalDiscount);
                        }
                        else
                        {
                            ucDiscount.lblTotal.Text = "$" + money.Format2(Discount.Total);
                            totalDiscount = Discount.Total;
                            ucDiscount.lblMethodType.Text = Discount.DiscountName;
                        }
                        
                        ucDiscount.Click += ucDiscount_Click;

                        OrderMain.DiscountType = Discount.DiscountType;
                        OrderMain.Discount =Convert.ToInt32(totalDiscount);
                        flpPaymentType.Controls.Add(ucDiscount);
                        CheckTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayment::::::::::::::::::::::::::btnDiscount_Click:::::::::::::" + ex.Message);
            }
        }

        void ucDiscount_Click(object sender, EventArgs e)
        {
            UCDiscount ucDiscount = (UCDiscount)sender;
            OrderMain.DiscountType = 0;
            OrderMain.Discount = 0;
            txtBalance.Text = "$" + money.Format2(OrderMain.SubTotal());
            flpPaymentType.Controls.Remove(ucDiscount);
        }
        private int CheckTotal()
        {
                int result = 0;
                try
                {
                    double totalPayment = 0;
                    double total = Convert.ToDouble(OrderMain.TotalAmount);
                    if (lstPayment.Count > 0)
                    {
                        for (int i = 0; i < lstPayment.Count; i++)
                        {
                            totalPayment = (totalPayment + lstPayment[i].Total);
                        }
                        totalPayment = (totalPayment *100)*10;
                        if (totalPayment >= total)
                        {
                            lblChange.Text = "$" + money.Format2(totalPayment  - total);
                            result = 1;
                            OrderMain.Payment = Convert.ToInt32(totalPayment);
                            OrderMain.Change = Convert.ToInt32(totalPayment - total);
                            txtTender.Text = string.Empty;
                            lblTender.Text = string.Empty;
                            lockTextChange = true;
                        }
                        else
                        {
                            lblChange.Text = "$0.00";
                            txtTender.Text = string.Empty;
                            lblTender.Text = string.Empty;
                            if(RemoveUc)
                                txtBalance.Text = "$" + money.Format2(total - totalPayment);
                            RemoveUc = false;
                        }
                    }
                    if (OrderMain.DiscountType > 0)
                    {
                        double totaltemp = total - OrderMain.Discount - totalPayment;
                        if (OrderMain.Discount + totalPayment >= total)
                        {
                            lblChange.Text = "$" + money.Format2((OrderMain.Discount + totalPayment) - total);
                            result = 1;
                            OrderMain.Payment = Convert.ToInt32(OrderMain.Discount + totalPayment);
                            OrderMain.Change = Convert.ToInt32((OrderMain.Discount + totalPayment) - total);
                            txtTender.Text = string.Empty;
                            lblTender.Text = string.Empty;
                        }
                        if (totaltemp > 0)
                            txtBalance.Text = "$" + money.Format2(totaltemp);
                        else
                        {
                            txtBalance.Text = "$0.00";
                            lblChange.Text = "$" + money.Format2(totaltemp * -1);
                        }
                    }

                }
                catch (Exception ex)
                {
                    LogPOS.WriteLog("frmPayMent::::::::::::::::::::::::CheckTotal::::::::::::::::::::;;" + ex.Message);
                }
            
            return result;
        }

        private void btnExact_Click(object sender, EventArgs e)
        {
            string []arrBalance = txtBalance.Text.Split('$');
            string tempBalance = arrBalance[1];
            double balance = Convert.ToDouble(tempBalance)*1000;
            double exact = balance / 1000.0;
            txtTender.Text = exact.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTender.Text = "5";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtTender.Text = "10";
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txtTender.Text = "20";
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            txtTender.Text = "50";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            txtTender.Text = "100";
        }

        private void btnPrintnoBill_Click(object sender, EventArgs e)
        {
            if (CheckTotal() == 1)
            {
                OrderMain.ListPayment = lstPayment;
                OrderMain.ListInvoiceByCard = lstInvoiceByCard;
                OrderMain.isNoPrintBill = 1;
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                frmMessager frm = new frmMessager("Payment", "money not enought");
                frm.ShowDialog();
            }

        }

        private void btnSplitBill_Click(object sender, EventArgs e)
        {
            UCSplitBill ucSplitBill = new UCSplitBill();
            ucSplitBill.lblMethodType.Text = "Split Bill";
            flpPaymentType.Controls.Add(ucSplitBill);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OrderMain.ListPayment = lstPaymentSplitBill;
            OrderMain.ListInvoiceByCard = lstInvoiceByCardSplitBill;
            //PrinterServer printServer = new PrinterServer(2);
            //printServer.Print(OrderMain);
            lstInvoiceByCardSplitBill = new List<InvoiceByCardModel>();
            lstPaymentSplitBill = new List<PayMentModel>();
        }
        private bool IsCheckCashOut()
        {
            foreach (Control ctr in flpPaymentType.Controls)
            {
                if (ctr is UCPayment)
                    return false;
            }
            return true;
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            
            try
            {
                //if (IsCheckCashOut())
                //{
                MessageBox.Show(txtTender.Text);
                //}
            }
            catch (Exception ex)
            {
 
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTender.Text != string.Empty&& Convert.ToDouble(txtTender.Text)>0)
                {
                    frmPaymentAcc frm = new frmPaymentAcc();
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        AccountModel accItem = new AccountModel();
                        accItem.PaymentID = 3;
                        accItem.Total = Convert.ToDouble(txtTender.Text);
                        UCAccPayment acc = new UCAccPayment();
                        acc.lblStt.Text = "#" + CountUcPayMent().ToString();
                        acc.lblMethodType.Text = btnAccount.Text;
                        acc.lblTotal.Text = "$" + money.Format2((Convert.ToDouble(txtTender.Text)) * 1000);
                        acc.Tag = accItem;
                        acc.Click += acc_Click;
                        OrderMain.CusItem = frm.itemS;
                        OrderMain.Account = Convert.ToInt32(Convert.ToDouble(txtTender.Text) * 1000);
                        addPayment(accItem);
                        flpPaymentType.Controls.Add(acc);
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPayment::::::::::::::::::::btnAccount_Click:::::::::::::::::" + ex.Message);
            }
        }

        void acc_Click(object sender, EventArgs e)
        {
            UCAccPayment ucCash = (UCAccPayment)sender;
            try
            {
                AccountModel data = (AccountModel)ucCash.Tag;
                for (int i = 0; i < lstPayment.Count; i++)
                {
                    if (lstPayment[i].PaymentTypeID == data.PaymentID)
                    {
                        lstPayment[i].Total = lstPayment[i].Total - data.Total;
                    }
                }
                OrderMain.Account = 0;
                flpPaymentType.Controls.Remove(ucCash);
                RemoveUc = true;
                CheckTotal();
            }
            catch (Exception ex)
            {
 
            }
        }
    }
}
