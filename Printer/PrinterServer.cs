﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicePOS.Model;
using System.Drawing.Printing;
using System.Drawing;


namespace Printer
{
   public class PrinterServer
    {
       Printer printer = new Printer();
       POSPrinter posPrinter = new POSPrinter();
       OrderDateModel OrderMain;
       MoneyFortmat money = new MoneyFortmat(MoneyFortmat.AU_TYPE);
       int Function;
       int PRINTBAR = 1;
       int PRINTBILL = 2;
       OrderDateModel OrderPrint;
       public PrinterServer()
       {
        
       }
       private void GetListPrinter()
       { 
                   
       }
       public void PrintData(OrderDateModel _OrderMain,List<PrinterModel> printData)
       {
           OrderMain = _OrderMain;
           if (OrderMain.PrintType == this.PRINTBAR)
           {

               for (int i = 0; i < printData.Count; i++)
               {
                   if (OrderMain.IsLoadFromData)
                   {
                       OrderPrint = new OrderDateModel();
                       for (int j = 0; j < OrderMain.ListOrderDetail.Count; j++)
                       {
                           if (OrderMain.ListOrderDetail[j].ChangeStatus == 1 || OrderMain.ListOrderDetail[j].ChangeStatus == 2)
                           {
                               if (OrderMain.ListOrderDetail[j].Printer == printData[i].ID)
                               {

                                   OrderPrint.ListOrderDetail.Add(OrderMain.ListOrderDetail[j]);
                               }
                           }
                           for (int k = 0; k < OrderMain.ListOrderDetail[j].ListOrderDetailModifire.Count; k++)
                           {
                               if (OrderMain.ListOrderDetail[j].ListOrderDetailModifire[k].ChangeStatus == 1 || OrderMain.ListOrderDetail[j].ListOrderDetailModifire[k].ChangeStatus == 2)
                               {
                                   if (OrderMain.ListOrderDetail[j].Printer == printData[i].ID)
                                   {

                                       OrderPrint.ListOrderDetail.Add(OrderMain.ListOrderDetail[j]);
                                   }
                               }
                           }
                       }
                   }
                   else
                   {
                       OrderPrint = new OrderDateModel();
                       for (int j = 0; j < OrderMain.ListOrderDetail.Count; j++)
                       {

                           if (OrderMain.ListOrderDetail[j].Printer == printData[i].ID)
                           {

                               OrderPrint.ListOrderDetail.Add(OrderMain.ListOrderDetail[j]);
                           }
                       }
                   }
                   if(OrderPrint.ListOrderDetail.Count>0)
                        Print(OrderPrint, printData[i]);
               }
           }
           else
           {
               if (OrderMain.PrintType == this.PRINTBILL)
               {
                   if(printData.Count>0)
                        Print(OrderMain, printData[0]);
               }
           }
       }
       public void Print(OrderDateModel _OrderMain,PrinterModel data)
       {
           
           
               posPrinter.SetPrinterName(data.PrinterName);
               posPrinter.printDocument.PrintPage += printDocument_PrintPage;
               posPrinter.Print();
           
           //if (Function==1)
           //{
               
           //     //Dataprint 80mm Series Printer//
           //    //Microsoft XPS Document Writer
           //    for (int i = 0; i <= 1; i++)
           //    {
           //        posPrinter.SetPrinterName("80 Printer");
           //        posPrinter.printDocument.PrintPage += printDocument_PrintPage;
           //        posPrinter.Print();
           //    }
           //}
           //if (Function == 2)
           //{
           //    posPrinter.SetPrinterName("80 Printer");
           //    posPrinter.printDocument.PrintPage += printDocument_PrintPage;
           //    posPrinter.Print();
           //}
           //if (Function == 3)
           //{
           //    posPrinter.SetPrinterName("80 Printer");
           //    posPrinter.printDocument.PrintPage += printDocument_PrintPage;
           //    posPrinter.Print();
           //}
       }
       void printDocument_PrintPage(object sender, PrintPageEventArgs e)
       {

           if (OrderMain.PrintType == this.PRINTBAR)
           {
               if(OrderPrint.ListOrderDetail.Count>0)
                    PrintOrderToKitchenOrBar(OrderPrint, e);
           }
           else
           {
               if (OrderMain.PrintType == this.PRINTBILL)
               {
                   PrintBill(e);
               }

           }
              
       }
       public float PrintOrderToKitchenOrBar(OrderDateModel Order, PrintPageEventArgs e)
       {
           float l_y = 0;
           l_y = posPrinter.DrawString("Kitchen", e, new Font("Arial", 14, FontStyle.Italic), l_y, 2);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           l_y=posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y = posPrinter.DrawString(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           l_y = posPrinter.DrawString("OPERATOR#MANAGER", e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
           posPrinter.DrawString("Table# " + OrderMain.FloorID, e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("Order#" + OrderMain.OrderID, e, new Font("Arial", 14), l_y, 3);
           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           int countItem =0;
           for (int i = 0; i < Order.ListOrderDetail.Count; i++)
           {
               float yStart  = l_y;

               if (Order.ListOrderDetail[i].ChangeStatus == 2)
               {
                   l_y = posPrinter.DrawString("--Remove  " + Order.ListOrderDetail[i].ProductName, e, new Font("Arial", 14), l_y, 1);
               }
               else
               {
                   if (Order.ListOrderDetail[i].ChangeStatus == 1)
                   {
                       l_y = posPrinter.DrawString("--Add  " + Order.ListOrderDetail[i].ProductName, e, new Font("Arial", 14), l_y, 1);
                   }
                   else
                   {
                       countItem++;
                       l_y = posPrinter.DrawString(Order.ListOrderDetail[i].Qty.ToString() + " " + Order.ListOrderDetail[i].ProductName, e, new Font("Arial", 14), l_y, 1);
                   }
               }
               //l_y = posPrinter.DrawString(OrderMain.ListOrderDetail[i].Qty.ToString(), e, new Font("Arial", 14), l_y, 2);
               //posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].Price.ToString()), e, new Font("Arial", 14), yStart, 3);

               if (Order.ListOrderDetail[i].ListOrderDetailModifire.Count > 0)
               {
                   for (int j = 0; j < Order.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                   {
                       if (Order.ListOrderDetail[i].ListOrderDetailModifire[j].ChangeStatus == 2)
                       {
                           l_y = posPrinter.DrawString("---Remove  " + Order.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 14), l_y, 1);
                       }
                       else
                       {
                           l_y = posPrinter.DrawString("--" + Order.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);

                       }
                       //l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].Price.ToString()), e, new Font("Arial", 14), l_y, 3);
                   }
               }
           }
           l_y += posPrinter.GetHeightPrinterLine() / 10;

           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y = posPrinter.DrawString("", e, new Font("Arial", 14), l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           posPrinter.DrawString("Total item: "+countItem, e, new Font("Arial", 14, FontStyle.Bold), l_y, 1);
           //l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.SubTotal()), e, new Font("Arial", 14, FontStyle.Bold), l_y, 3);
           l_y += posPrinter.GetHeightPrinterLine()/2;
           return l_y;
       }

       private void PrintReceipt(PrintPageEventArgs e)
       {
           float l_y = 0;
           l_y = posPrinter.DrawString("BI RESTAURANT", e, new Font("Arial", 10, FontStyle.Bold), l_y, 2);
           l_y = posPrinter.DrawString("ABN:45 134918497", e, new Font("Arial", 10, FontStyle.Bold), l_y, 2);
           l_y = posPrinter.DrawString("233A Canley Vale Rd Canley Heights NSW 2166", e, new Font("Arial", 10, FontStyle.Italic), l_y, 2);
           l_y = posPrinter.DrawString("Tel: 9727 7585", e, new Font("Arial", 10, FontStyle.Italic), l_y, 2);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           l_y = posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y = posPrinter.DrawString(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("Tranx #", e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("Table# "+OrderMain.FloorID, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("OPERATOR#MANAGER", e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           l_y = posPrinter.DrawString("TAX INVOICE", e, new Font("Arial", 10, FontStyle.Bold), l_y, 2);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
           {
               float yStart = l_y;
               posPrinter.DrawString(OrderMain.ListOrderDetail[i].ProductName, e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
               l_y = posPrinter.DrawString(OrderMain.ListOrderDetail[i].Qty.ToString(), e, new Font("Arial", 10, FontStyle.Bold), l_y, 2);
               posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].Price.ToString()), e, new Font("Arial", 10, FontStyle.Bold), yStart, 3);
               if (OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count > 0)
               {
                   for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                   {
                       l_y=posPrinter.DrawString("__"+OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 10), l_y, 1);
                   }
               }
           }
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
            posPrinter.DrawString("SubTotal:", e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
            l_y = posPrinter.DrawString("$" + money.Format2(Convert.ToDouble(OrderMain.TotalAmount)), e, new Font("Arial", 10), l_y, 3);
           if (OrderMain.Discount > 0)
           {
               posPrinter.DrawString("Discount:", e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
               l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.Discount), e, new Font("Arial", 10), l_y, 3);

               posPrinter.DrawString("Total:", e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
               l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.SubTotal() - OrderMain.Discount), e, new Font("Arial", 10), l_y, 3);
           }
           else
           {
               posPrinter.DrawString("Total:", e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
               l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.SubTotal()), e, new Font("Arial", 10), l_y, 3);
           }
            posPrinter.DrawString("GST(Include in total):", e, new Font("Arial", 10), l_y, 1);
            l_y = posPrinter.DrawString("$1.0", e, new Font("Arial", 10), l_y, 3);
           if (OrderMain.ListPayment.Count > 0)
           {
               for (int j = 0; j < OrderMain.ListPayment.Count; j++)
               {
                   if (OrderMain.ListPayment[j].PaymentTypeID == 1)
                   {
                       posPrinter.DrawString("Cash:", e, new Font("Arial", 10), l_y, 1);
                       l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListPayment[j].Total*1000), e, new Font("Arial", 10), l_y, 3);
                   }
                   if (OrderMain.ListPayment[j].PaymentTypeID == 2)
                   {
                        posPrinter.DrawString("Card:", e, new Font("Arial", 10), l_y, 1);
                        l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListPayment[j].Total*1000), e, new Font("Arial", 10), l_y, 3);
                        if (OrderMain.ListInvoiceByCard.Count > 0)
                        {
                            for (int i = 0; i < OrderMain.ListInvoiceByCard.Count; i++)
                            {
                                posPrinter.DrawString("--"+OrderMain.ListInvoiceByCard[i].NameCard, e, new Font("Arial", 10), l_y, 1);
                                l_y = posPrinter.DrawString("$" + money.Format2(Convert.ToDouble(OrderMain.ListInvoiceByCard[i].Total)), e, new Font("Arial", 10), l_y, 3);
                            }
                        }
                   }
               }
           }
           if (OrderMain.Change > 0)
           {
               posPrinter.DrawString("Change:", e, new Font("Arial", 10), l_y, 1);
               l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.Change), e, new Font("Arial", 10), l_y, 3);
 
           }
           l_y += posPrinter.GetHeightPrinterLine() / 2;
           l_y = posPrinter.DrawString("www.bires.com.au", e, new Font("Arial", 10), l_y, 2);
           l_y = posPrinter.DrawString("Eat.Drink.Laugh-A touch of Laos", e, new Font("Arial", 10), l_y, 2);
           l_y = posPrinter.DrawString("Thank you,see you soon", e, new Font("Arial", 10), l_y, 2);

       }

       //FUNCTION PRINT BILL
       private void PrintBill(PrintPageEventArgs e)
       {
           float l_y = 0;
           l_y = posPrinter.DrawString("BI RESTAURANT", e, new Font("Arial", 10, FontStyle.Bold), l_y, 2);
           l_y = posPrinter.DrawString("ABN:45 134918497", e, new Font("Arial", 10, FontStyle.Bold), l_y, 2);
           l_y = posPrinter.DrawString("233A Canley Vale Rd Canley Heights NSW 2166", e, new Font("Arial", 10, FontStyle.Italic), l_y, 2);
           l_y = posPrinter.DrawString("Tel: 9727 7585", e, new Font("Arial", 10, FontStyle.Italic), l_y, 2);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           l_y = posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y = posPrinter.DrawString(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("Tranx #", e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("Table# " + OrderMain.FloorID, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("OPERATOR#MANAGER", e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           l_y = posPrinter.DrawString("BILL", e, new Font("Arial", 10, FontStyle.Bold), l_y, 2);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
           {
               float yStart = l_y;
               posPrinter.DrawString(OrderMain.ListOrderDetail[i].ProductName, e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
               l_y = posPrinter.DrawString(OrderMain.ListOrderDetail[i].Qty.ToString(), e, new Font("Arial", 10, FontStyle.Bold), l_y, 2);
               posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].Price.ToString()), e, new Font("Arial", 10, FontStyle.Bold), yStart, 3);
               if (OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count > 0)
               {
                   for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                   {
                       l_y = posPrinter.DrawString("__" + OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 10), l_y, 1);
                   }
               }
           }
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           posPrinter.DrawString("SubTotal:", e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
           l_y = posPrinter.DrawString("$" + money.Format2(Convert.ToDouble(OrderMain.TotalAmount)), e, new Font("Arial", 10), l_y, 3);
           if (OrderMain.Discount > 0)
           {
               posPrinter.DrawString("Discount:", e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
               l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.Discount), e, new Font("Arial", 10), l_y, 3);

               posPrinter.DrawString("Total:", e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
               l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.SubTotal() - OrderMain.Discount), e, new Font("Arial", 10), l_y, 3);
           }
           else
           {
               //posPrinter.DrawString("Total:", e, new Font("Arial", 10, FontStyle.Bold), l_y, 1);
               //l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.SubTotal()), e, new Font("Arial", 10), l_y, 3);
           }
           //posPrinter.DrawString("GST(Include in total):", e, new Font("Arial", 10), l_y, 1);
           //l_y = posPrinter.DrawString("$1.0", e, new Font("Arial", 10), l_y, 3);
           if (OrderMain.ListPayment.Count > 0)
           {
               for (int j = 0; j < OrderMain.ListPayment.Count; j++)
               {
                   if (OrderMain.ListPayment[j].PaymentTypeID == 1)
                   {
                       posPrinter.DrawString("Cash:", e, new Font("Arial", 10), l_y, 1);
                       l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListPayment[j].Total * 1000), e, new Font("Arial", 10), l_y, 3);
                   }
                   if (OrderMain.ListPayment[j].PaymentTypeID == 2)
                   {
                       posPrinter.DrawString("Card:", e, new Font("Arial", 10), l_y, 1);
                       l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListPayment[j].Total*1000), e, new Font("Arial", 10), l_y, 3);
                       if (OrderMain.ListInvoiceByCard.Count > 0)
                       {
                           for (int i = 0; i < OrderMain.ListInvoiceByCard.Count; i++)
                           {
                               posPrinter.DrawString("--" + OrderMain.ListInvoiceByCard[i].NameCard, e, new Font("Arial", 10), l_y, 1);
                               l_y = posPrinter.DrawString("$" + money.Format2(Convert.ToDouble(OrderMain.ListInvoiceByCard[i].Total)), e, new Font("Arial", 10), l_y, 3);
                           }
                       }
                   }
               }
           }
           if (OrderMain.Change > 0)
           {
               posPrinter.DrawString("Change:", e, new Font("Arial", 10), l_y, 1);
               l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.Change), e, new Font("Arial", 10), l_y, 3);

           }
           l_y += posPrinter.GetHeightPrinterLine() / 2;
           l_y = posPrinter.DrawString("www.bires.com.au", e, new Font("Arial", 10), l_y, 2);
           l_y = posPrinter.DrawString("Eat.Drink.Laugh-A touch of Laos", e, new Font("Arial", 10), l_y, 2);
           l_y = posPrinter.DrawString("Thank you,see you soon", e, new Font("Arial", 10), l_y, 2);

       }
    }
}
  