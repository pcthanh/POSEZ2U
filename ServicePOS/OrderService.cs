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
        private ORDER_DATE CopyOrder(OrderDateModel itemOrder)
        {
            ORDER_DATE orderDate = new ORDER_DATE();
            orderDate.FloorID = itemOrder.FloorID;
            orderDate.OrderNumber = itemOrder.OrderID.ToString()??"";
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
        private List<ORDER_DETAIL_DATE> CopyOrderDetailDate(OrderDateModel itemOrder)
        {
            List<ORDER_DETAIL_DATE> lstorderDetailDate = new List<ORDER_DETAIL_DATE>();
            lstorderDetailDate.Clear();
            try
            {
               
                for (int i = 0; i < itemOrder.ListOrderDetail.Count; i++)
                {
                    ORDER_DETAIL_DATE orderDetaiDate = new ORDER_DETAIL_DATE();
                    orderDetaiDate.OrderID = itemOrder.ListOrderDetail[i].OrderID;
                    orderDetaiDate.ProductID = itemOrder.ListOrderDetail[i].ProductID;
                    orderDetaiDate.Qty = itemOrder.ListOrderDetail[i].Qty;
                    orderDetaiDate.Total = itemOrder.ListOrderDetail[i].Total;
                    orderDetaiDate.Price = itemOrder.ListOrderDetail[i].Price;
                    orderDetaiDate.Satust = itemOrder.ListOrderDetail[i].Satust;
                    orderDetaiDate.Note = itemOrder.ListOrderDetail[i].Note;
                    orderDetaiDate.CreateBy = itemOrder.ListOrderDetail[i].CreateBy ?? 0;
                    orderDetaiDate.CreateDate = itemOrder.ListOrderDetail[i].CreateDate ?? DateTime.Now;
                    orderDetaiDate.UpdateBy = itemOrder.ListOrderDetail[i].UpdateBy ?? 0;
                    orderDetaiDate.UpdateDate = itemOrder.ListOrderDetail[i].UpdateDate ?? DateTime.Now;
                    lstorderDetailDate.Add(orderDetaiDate);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("CopyOrderDetailDate:::::::::::::::::::::::::" + ex.Message);
            }
            return lstorderDetailDate;
        }
        private List<ORDER_DETAIL_MODIFIRE_DATE> CopyOrderMidifireDate(OrderDateModel itemOrder)
        {
            List<ORDER_DETAIL_MODIFIRE_DATE> lstOrderModifreDate = new List<ORDER_DETAIL_MODIFIRE_DATE>();
            lstOrderModifreDate.Clear();
            try
            {
                for (int i = 0; i < itemOrder.ListOrderDetail.Count; i++)
                { 
                    for (int j = 0; j < itemOrder.ListOrderDetail[i].ListOrderDetailModifire.Count; j++)
                    {
                        ORDER_DETAIL_MODIFIRE_DATE orderDetailModifire = new ORDER_DETAIL_MODIFIRE_DATE();
                        orderDetailModifire.ModifireID = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireID;
                        orderDetailModifire.OrderDetailID = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].OrderDetailID;
                        orderDetailModifire.OrderID = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].OrderID;
                        orderDetailModifire.ProductID = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].ProductID;
                        orderDetailModifire.Price = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].Price;
                        orderDetailModifire.Qty = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].Qty;
                        orderDetailModifire.Total = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].Total;
                        orderDetailModifire.Satust = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].Satust;
                        orderDetailModifire.CreateBy = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].CreateBy ?? 0;
                        orderDetailModifire.CreateDate = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].CreateDate ?? DateTime.Now;
                        orderDetailModifire.UpdateBy = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].UpdateBy ?? 0;
                        orderDetailModifire.UpdateDate = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].UpdateDate ?? DateTime.Now;
                        lstOrderModifreDate.Add(orderDetailModifire);
                    }

                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("CopyOrderMidifireDate:::::::::::::::::::::::::::::::::" + ex.Message);
            }
            return lstOrderModifreDate;
        }

        public int InsertOrder(OrderDateModel itemOrder)
        {
            int flag = 0;
            try
            {
                ORDER_DATE orderDateTemp = new ORDER_DATE();
                List<ORDER_DETAIL_DATE> lstOrderDetaiDate = new List<ORDER_DETAIL_DATE>();
                List<ORDER_DETAIL_MODIFIRE_DATE> lstOrderDetailModifire = new List<ORDER_DETAIL_MODIFIRE_DATE>();
                ORDER_DETAIL_DATE orderDetailTemp = new ORDER_DETAIL_DATE();
                ORDER_DETAIL_MODIFIRE_DATE orderDetailModofireDate = new ORDER_DETAIL_MODIFIRE_DATE();
                orderDateTemp = CopyOrder(itemOrder);
                _context.Entry(orderDateTemp).State = System.Data.Entity.EntityState.Added;
                lstOrderDetaiDate = CopyOrderDetailDate(itemOrder);
                foreach (ORDER_DETAIL_DATE item in lstOrderDetaiDate)
                {
                    _context.Entry(item).State = System.Data.Entity.EntityState.Added;
                }

                lstOrderDetailModifire = CopyOrderMidifireDate(itemOrder);
                foreach (ORDER_DETAIL_MODIFIRE_DATE item in lstOrderDetailModifire)
                {
                    _context.Entry(item).State = System.Data.Entity.EntityState.Added;
                }
                _context.SaveChanges();
                flag = 1;
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("InsertOrder::::::::::::::::::::::::::::::::::" + ex.Message);
            }
            return flag;
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


        public int CountOrder()
        {
            int OrderId = 0;
            OrderId= _context.ORDER_DATE.Count();
            return OrderId;
        }


        public int CheckOrderComplete(OrderDateModel idOrder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDateModel> LoadOrder(OrderDateModel idOrder)
        {
            throw new NotImplementedException();
        }

        public int UpdateOrder(OrderDateModel idOrder)
        {
            throw new NotImplementedException();
        }

        IEnumerable<OrderDateModel> IOrderService.GetOrderByTable(int idTable, int idOrder)
        {
            throw new NotImplementedException();
        }

       public IEnumerable<StatusTable> IOrderService.GetStatusTable(string TableID)
        {
            var status = _context.ORDER_DATE.Where(x => x.Status != 1 && x.FloorID == Convert.ToInt32(TableID)).Select(x => new StatusTable
            {
                OrderID = x.OrderID,
                Complete = x.Status,
                SubTotal = x.TotalAmount.ToString(),
                TableID = x.FloorID.ToString()

            });
            return status;
        }
    }
}
