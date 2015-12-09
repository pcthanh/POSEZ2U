using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using ModelPOS.ModelEntity;
using SystemLog;
using ServicePOS.Model;
namespace ServicePOS
{
   public class OrderService:IOrderService
    {

        private POSEZ2UEntities _context;
        ORDER_DATE orderDate = new ORDER_DATE();
        public OrderService()
        {
            _context = new POSEZ2UEntities();
        }

        public OrderService(POSEZ2UEntities context)
        {
            _context = context;
        }

        public void SetProxyCreationEnabled(bool proxyCreationEnabled)
        {
            _context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }
        private ORDER_DATE CopyOrder(OrderModel itemOrder)
        {
            ORDER_DATE orderDate = new ORDER_DATE();
           
            orderDate.FloorID = itemOrder.FloorID;
            orderDate.OrderNumber = itemOrder.OrderNumber ?? "";
            orderDate.TotalAmount = itemOrder.TotalAmount ?? 0;
            orderDate.Status = itemOrder.Status;
            orderDate.ClientID = itemOrder.ClientID ?? 0;
            orderDate.CreateBy = itemOrder.CreateBy ?? 0;
            orderDate.CreateDate = DateTime.Now;
            orderDate.UpdateBy = itemOrder.UpdateBy ?? 0;
            orderDate.UpdateDate = DateTime.Now;
            orderDate.Note = itemOrder.Note ?? "";
            return orderDate;
        }

        public int InsertOrder(Model.OrderModel itemOrder)
        {
            int flag = 0;
            try
            {
                ORDER_DATE tempDate = new ORDER_DATE();
                tempDate = CopyOrder(itemOrder);
                //_context.ORDER_DATE.Add(tempDate);
                _context.Entry(tempDate).State = System.Data.Entity.EntityState.Added;
               
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("InsertOrder::::::::::::::::::::::::::::::::::" + ex.Message);
            }
            return flag;
        }

        public int InsertOrderDetail(Model.OrderDetailModel itemOrderDetail)
        {
            throw new NotImplementedException();
        }

        public int CheckOrderComplete(Model.OrderModel idOrder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.OrderModel> LoadOrder(Model.OrderModel idOrder)
        {
            throw new NotImplementedException();
        }

        public int UpdateOrder(Model.OrderModel idOrder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.OrderModel> GetOrderByTable(int idTable, int idOrder)
        {
            throw new NotImplementedException();
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
    }
}
