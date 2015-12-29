using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicePOS.Model;
namespace ServicePOS
{
    public interface IPrinterService:IDisposable
    {
        int InsertPrinter(PrinterModel Printer);
        IEnumerable<PrinterModel> GetListPrinter();
        int UpdatePrinter(PrinterModel Printer);
    }
}
