using System;
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
       public PrinterServer(int _Function)
       {
           
           
           Function = _Function;
        
       }

       public void Print(OrderDateModel _OrderMain)
       {
           OrderMain = _OrderMain;
           if (Function==1)
           {
               posPrinter.SetPrinterName("Microsoft XPS Document Writer");
               posPrinter.printDocument.PrintPage += printDocument_PrintPage;
               posPrinter.Print();
           }
       }

       void printDocument_PrintPage(object sender, PrintPageEventArgs e)
       {
           if (Function == 1)
           {
               PrintOrderToKitchenOrBar(e);
           }
       }
       public float PrintOrderToKitchenOrBar(PrintPageEventArgs e)
       {
           float l_y = 0;
           l_y = posPrinter.DrawString("Date :" + DateTime.Now.ToShortDateString(), e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("Table:" + OrderMain.FloorID, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);
           l_y = posPrinter.DrawString("No # Seat:" + OrderMain.Seat, e, new Font("Arial", 10, FontStyle.Italic), l_y, 1);

           l_y += posPrinter.GetHeightPrinterLine() / 10;

           for (int i = 0; i < OrderMain.ListOrderDetail.Count; i++)
           {
               float yStart = l_y;
               if (OrderMain.ListOrderDetail[i].ChangeStatus == 2)
               {
                   posPrinter.DrawString("--Remove  " + OrderMain.ListOrderDetail[i].ProductName, e, new Font("Arial", 14), l_y, 1);
               }
               else
               {
                   posPrinter.DrawString(OrderMain.ListOrderDetail[i].ProductName, e, new Font("Arial", 14), l_y, 1);
               }
               l_y = posPrinter.DrawString(OrderMain.ListOrderDetail[i].Qty.ToString(), e, new Font("Arial", 14), l_y, 2);
               posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].Price.ToString()), e, new Font("Arial", 14), yStart, 3);

               if (OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count > 0)
               {
                   for (int j = 0; j < OrderMain.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                   {
                       if (OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ChangeStatus == 2)
                       {
                           posPrinter.DrawString("---Remove  " + OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 14), l_y, 1);
                       }
                       else
                       {
                           posPrinter.DrawString("--" + OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireName, e, new Font("Arial", 14, FontStyle.Italic), l_y, 1);

                       }
                       l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.ListOrderDetail[i].ListOrderDetailModifire[j].Price.ToString()), e, new Font("Arial", 14), l_y, 3);
                   }
               }
           }
           posPrinter.DrawLine("", new Font("Arial", 14), e, System.Drawing.Drawing2D.DashStyle.Dot, l_y, 1);
           l_y = posPrinter.DrawString("", e, new Font("Arial", 14), l_y, 1);
           l_y += posPrinter.GetHeightPrinterLine() / 10;
           posPrinter.DrawString("Total:", e, new Font("Arial", 14, FontStyle.Bold), l_y, 1);
           l_y = posPrinter.DrawString("$" + money.Format2(OrderMain.SubTotal()), e, new Font("Arial", 14, FontStyle.Bold), l_y, 3);
           l_y += posPrinter.GetHeightPrinterLine();
           return l_y;
       }
    }
}
 