using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOS.ModelEntity;
using ServicePOS.Model;
using ModelPOS;
using SystemLog;

namespace ServicePOS
{
   public class PrinterService:IPrinterService
    {
       public string className="PrinterService:::::::::::::::::::::::";
        private POSEZ2UEntities _context;
        public PrinterService()
        {
            _context = new POSEZ2UEntities();
          
        }

        public PrinterService(POSEZ2UEntities context)
        {
            _context = context;
        }
        public void SetProxyCreationEnabled(bool proxyCreationEnabled)
        {
            _context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }
        public int InsertPrinter(Model.PrinterModel Printer)
        {
            int result = 0;
            try
            {
                if (Printer != null)
                {
                    var item = new PRINTER();
                    item.PrinterName = Printer.PrinterName;
                    item.PrintName = Printer.PrintName;
                    item.PrinterType = Printer.PrinterType;
                    item.Status = Printer.Status;
                    item.CreateBy = Printer.CreateBy ?? 0;
                    item.CreateDate = DateTime.Now;
                    item.UpdateBy = Printer.UpdateBy ?? 0;
                    item.UpdateDate = DateTime.Now;
                    _context.Entry(item).State = System.Data.Entity.EntityState.Added;
                    _context.SaveChanges();
                    result = 1;
                }
            }
            catch (Exception ex) 
            {
                LogPOS.WriteLog(className+"InsertPrinter:::::::::::::::::::;;"+ ex.Message);
            }
            return result;
        }

        public IEnumerable<Model.PrinterModel> GetListPrinter()
        {
            
            try
            {
               var data= _context.PRINTERs.Where(x=>x.Status==1).Select
                   (x=>new PrinterModel()
                   {
                       ID = x.ID,
                       PrinterName = x.PrinterName,
                       PrintName =x.PrintName,
                       PrinterType=x.PrinterType,
                       Status=x.Status,
                       CreateBy=x.CreateBy,
                       CreateDate=x.CreateDate,
                       UpdateBy=x.UpdateBy,
                       UpdateDate=x.UpdateDate
                   }
                   );
                 return data;
            }
             
            catch(Exception ex)
            {

            }
            return null;
        }

        #region Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // code is here
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


        public int UpdatePrinter(PrinterModel Printer)
        {
           int result = 0;
            try
            {
                if (Printer != null)
                {
                    var item = _context.PRINTERs.Find(Printer.ID);
                    if (item != null)
                    {
                        item.ID = Printer.ID;
                        item.PrinterName = Printer.PrinterName;
                        item.PrintName = Printer.PrintName;
                        item.PrinterType = Printer.PrinterType;
                        item.Status = Printer.Status;
                        //item.CreateBy = Printer.CreateBy ?? 0;
                        //item.CreateDate = DateTime.Now;
                        item.UpdateBy = Printer.UpdateBy ?? 0;
                        item.UpdateDate = DateTime.Now;
                        _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        _context.SaveChanges();
                        result = 1;
                    }
                }
            }
            catch (Exception ex) 
            {
                LogPOS.WriteLog(className+"InsertPrinter:::::::::::::::::::;;"+ ex.Message);
            }
            return result;
        }
    }
}
