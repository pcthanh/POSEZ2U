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
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public int InsertOrder(Model.Order itemOrder)
        {
            int flag = 0;
            try
            {
                Order itemInsert = new Order();
                itemInsert.FloorID = itemOrder.FloorID;
                itemInsert.OrderID = itemOrder.OrderID;
                itemInsert.OrderNumber = itemOrder.OrderNumber;
                itemInsert.TotalAmount = itemOrder.TotalAmount;
                itemInsert.Status = itemOrder.Status;
                itemInsert.Seat = itemOrder.Seat;
                
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("InsertOrder::::::::::::::::::::::::::::::::::" + ex.Message);
            }
            return flag;
        }

        public int InsertOrderDetail(Model.OrderDetail itemOrderDetail)
        {
            throw new NotImplementedException();
        }

        public int CheckOrderComplete(Model.Order idOrder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Order> LoadOrder(Model.Order idOrder)
        {
            throw new NotImplementedException();
        }

        public int UpdateOrder(Model.Order idOrder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Order> GetOrderByTable(int idTable, int idOrder)
        {
            throw new NotImplementedException();
        }
    }
}
