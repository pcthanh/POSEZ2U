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
            orderDate.FloorID = itemOrder.FloorID.ToString();
            orderDate.OrderNumber = itemOrder.OrderID.ToString()??"";
            orderDate.OrderID = itemOrder.OrderID;
            orderDate.TotalAmount = itemOrder.TotalAmount ?? 0;
            orderDate.Status = itemOrder.Status;
            orderDate.ClientID = itemOrder.ClientID ?? 0;
            orderDate.CreateBy = itemOrder.CreateBy ?? 0;
            orderDate.CreateDate = DateTime.Now;
            orderDate.UpdateBy = itemOrder.UpdateBy ?? 0;
            orderDate.UpdateDate = DateTime.Now;
            orderDate.Note = itemOrder.Note ?? "";
            orderDate.Seat = itemOrder.Seat;
            orderDate.ShiftID = itemOrder.ShiftID;
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
                    if (itemOrder.ListOrderDetail[i].ChangeStatus != 2)
                    {
                        ORDER_DETAIL_DATE orderDetaiDate = new ORDER_DETAIL_DATE();
                        orderDetaiDate.OrderID = itemOrder.ListOrderDetail[i].OrderID;
                        orderDetaiDate.OrderDetailID = itemOrder.ListOrderDetail[i].OrderDetailID;
                        orderDetaiDate.ProductID = itemOrder.ListOrderDetail[i].ProductID;
                        orderDetaiDate.KeyItem = itemOrder.ListOrderDetail[i].KeyItem;
                        orderDetaiDate.Qty = itemOrder.ListOrderDetail[i].Qty;
                        orderDetaiDate.Total = itemOrder.ListOrderDetail[i].Total;
                        orderDetaiDate.Price = itemOrder.ListOrderDetail[i].Price;
                        orderDetaiDate.Satust = itemOrder.ListOrderDetail[i].Satust;
                        orderDetaiDate.Note = itemOrder.ListOrderDetail[i].Note;
                        orderDetaiDate.Seat = itemOrder.ListOrderDetail[i].Seat;
                        orderDetaiDate.DynId = itemOrder.ListOrderDetail[i].DynID;
                        orderDetaiDate.CreateBy = itemOrder.ListOrderDetail[i].CreateBy ?? 0;
                        orderDetaiDate.CreateDate = itemOrder.ListOrderDetail[i].CreateDate ?? DateTime.Now;
                        orderDetaiDate.UpdateBy = itemOrder.ListOrderDetail[i].UpdateBy ?? 0;
                        orderDetaiDate.UpdateDate = itemOrder.ListOrderDetail[i].UpdateDate ?? DateTime.Now;
                        lstorderDetailDate.Add(orderDetaiDate);
                    }
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
                        if (itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].ChangeStatus != 2)
                        {
                            ORDER_DETAIL_MODIFIRE_DATE orderDetailModifire = new ORDER_DETAIL_MODIFIRE_DATE();
                            orderDetailModifire.ModifireID = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].ModifireID;
                            orderDetailModifire.OrderDetailID = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].OrderDetailID;
                            orderDetailModifire.OrderModifireID = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].OrderModifireID;
                            orderDetailModifire.OrderID = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].OrderID;
                            orderDetailModifire.ProductID = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].ProductID;
                            orderDetailModifire.KeyModi = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].KeyModi;
                            orderDetailModifire.Price = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].Price;
                            orderDetailModifire.Qty = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].Qty;
                            orderDetailModifire.Total = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].Total;
                            orderDetailModifire.Satust = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].Satust;
                            orderDetailModifire.Seat = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].Seat;
                            orderDetailModifire.DynId = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].DynID;
                            orderDetailModifire.CreateBy = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].CreateBy ?? 0;
                            orderDetailModifire.CreateDate = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].CreateDate ?? DateTime.Now;
                            orderDetailModifire.UpdateBy = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].UpdateBy ?? 0;
                            orderDetailModifire.UpdateDate = itemOrder.ListOrderDetail[i].ListOrderDetailModifire[j].UpdateDate ?? DateTime.Now;
                            lstOrderModifreDate.Add(orderDetailModifire);
                        }
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
               // ORDER_DETAIL_DATE orderDetailTemp = new ORDER_DETAIL_DATE();
                //ORDER_DETAIL_MODIFIRE_DATE orderDetailModofireDate = new ORDER_DETAIL_MODIFIRE_DATE();
                OrderDateModel orderDateMoldeTemp = new OrderDateModel();
                orderDateMoldeTemp= GetOrderByTable(itemOrder.FloorID,0);
               
                if (orderDateMoldeTemp.ListOrderDetail.Count > 0)
                {
                    using (var transaciton = _context.Database.BeginTransaction())
                    {
                        orderDateTemp = CopyOrder(itemOrder);
                        //_context.Entry(orderDateTemp).State = System.Data.Entity.EntityState.Modified;
                        _context.Database.ExecuteSqlCommand("update ORDER_DATE set TotalAmount='" + orderDateTemp.TotalAmount + "',Seat='"+ itemOrder.Seat+"' where OrderID='"+ orderDateTemp.OrderID+"'");
                        lstOrderDetaiDate = CopyOrderDetailDate(orderDateMoldeTemp);
                        foreach (ORDER_DETAIL_DATE item in lstOrderDetaiDate)
                        {

                            _context.Database.ExecuteSqlCommand("delete from ORDER_DETAIL_DATE where OrderDetailID='" + item.OrderDetailID + "'");

                        }
                        lstOrderDetaiDate = CopyOrderDetailDate(itemOrder);
                        foreach (ORDER_DETAIL_DATE item in lstOrderDetaiDate)
                        {
                            // _context.Entry(item).State = System.Data.Entity.EntityState.Added;;

                            _context.Database.ExecuteSqlCommand("insert into ORDER_DETAIL_DATE(OrderID,ProductID,KeyItem,Satust,Price,Qty,Total,Seat,DynId)values" +
                                "('" + item.OrderID + "','" + item.ProductID + "','" + item.KeyItem + "','" + item.Satust + "','" + item.Price + "','" + item.Qty + "','" + item.Total + "','" + item.Seat + "','"+item.DynId+"')");

                        }
                        lstOrderDetailModifire = CopyOrderMidifireDate(orderDateMoldeTemp);
                        foreach (ORDER_DETAIL_MODIFIRE_DATE item in lstOrderDetailModifire)
                        {
                            //_context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                            // _context.ORDER_DETAIL_MODIFIRE_DATE.Remove(item);
                            _context.Database.ExecuteSqlCommand("delete ORDER_DETAIL_MODIFIRE_DATE where OrderModifireID='" + item.OrderModifireID + "'");
                        }
                        lstOrderDetailModifire = CopyOrderMidifireDate(itemOrder);
                        foreach (ORDER_DETAIL_MODIFIRE_DATE item in lstOrderDetailModifire)
                        {
                            // _context.Entry(item).State = System.Data.Entity.EntityState.Added;
                            _context.Database.ExecuteSqlCommand("insert into ORDER_DETAIL_MODIFIRE_DATE (OrderDetailID,OrderID,ProductID,KeyModi,ModifireID,Satust,Price,Qty,Total,Seat,DynID)values" +
                                "('" + item.OrderDetailID + "','" + item.OrderID + "','" + item.ProductID + "','" + item.KeyModi + "','" + item.ModifireID + "','" + item.Satust + "','" + item.Price + "','" + item.Qty + "','" + item.Total + "','" + item.Seat + "','"+ item.DynId+"')");

                        }
                        transaciton.Commit();
                        flag = 1;
                    }
                    
                }
                else
                {
                    using (var Tranx = _context.Database.BeginTransaction())
                    {
                        orderDateTemp = CopyOrder(itemOrder);
                        _context.Entry(orderDateTemp).State = System.Data.Entity.EntityState.Added;
                        _context.SaveChanges();
                        int i = orderDateTemp.OrderID;
                        lstOrderDetaiDate = CopyOrderDetailDate(itemOrder);
                        foreach (ORDER_DETAIL_DATE item in lstOrderDetaiDate)
                        {
                            item.OrderID = i;
                            _context.Entry(item).State = System.Data.Entity.EntityState.Added;

                        }

                        lstOrderDetailModifire = CopyOrderMidifireDate(itemOrder);
                        foreach (ORDER_DETAIL_MODIFIRE_DATE item in lstOrderDetailModifire)
                        {
                            item.OrderID = i;
                            
                            _context.Entry(item).State = System.Data.Entity.EntityState.Added;

                        }
                        _context.SaveChanges();
                        flag = 1;
                        Tranx.Commit();
                    }
                }
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
            OrderId = _context.ORDER_DATE.Count() + 1;
           // _context.Database.ExecuteSqlCommand()
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
            int result = 0;
            try
            {
                using (var Tranx = _context.Database.BeginTransaction())
                {
                    _context.Database.ExecuteSqlCommand("update ORDER_DATE set Status=2 where OrderID='" + idOrder.OrderID + "'");
                    _context.SaveChanges();
                    Tranx.Commit();
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("OrderService:::::::::::::::::::::::UpdateOrder::::::::::::::::;" + ex.Message);
            }
            return result;
        }

       

        StatusTable IOrderService.GetStatusTable(string TableID)
        {
            StatusTable st = new StatusTable();
            st.Complete = -1;
           
            var status =_context.ORDER_DATE.Where(x => x.FloorID == TableID && x.Status!=1).SingleOrDefault();
            if (status != null)
            {
                st.Complete = status.Status;
                st.OrderID = status.OrderID;
                st.TableID = status.FloorID.ToString();
                st.SubTotal = status.TotalAmount.ToString();
                st.Time = status.CreateDate.ToString();
            }
            return st;
        }

        public OrderDateModel GetOrderByTable(string idTable, int idOrder)
        {
            OrderDateModel OrderMain = new OrderDateModel();
            var dataOrder = _context.ORDER_DATE.Where(x => x.FloorID == idTable && x.Status!=1).SingleOrDefault();
            
          
            if (dataOrder != null)
            {
                OrderMain.Seat = dataOrder.Seat ?? 0;
                OrderMain.FloorID = dataOrder.FloorID;
                OrderMain.OrderID = dataOrder.OrderID;
                OrderMain.TotalAmount = dataOrder.TotalAmount;
                OrderMain.ShiftID = dataOrder.ShiftID ?? 0;
                OrderMain.CreateBy = dataOrder.CreateBy;
                OrderMain.UpdateBy = dataOrder.UpdateBy;
                var data = _context.ORDER_DATE.Join(_context.ORDER_DETAIL_DATE, order => order.OrderID,
                 item => item.OrderID, (order, item) => new { order, item })
                 .Join(_context.PRODUCTs, pro => pro.item.ProductID, c => c.ProductID, (pro, c) => new { pro, c })
                 .Where(x => x.pro.order.FloorID == dataOrder.FloorID && x.pro.order.OrderID == x.pro.item.OrderID && x.pro.order.OrderID == dataOrder.OrderID && x.pro.item.OrderID == dataOrder.OrderID && x.pro.item.ProductID==x.c.ProductID)
                 .Select(x => new OrderDetailModel()
                 {
                     ProductID = x.pro.item.ProductID,
                     Price = x.pro.item.Price,
                     Qty = x.pro.item.Qty,
                     Total = x.pro.item.Qty * x.pro.item.Price,
                     OrderID = x.pro.item.OrderID,
                     Satust = x.pro.item.Satust,
                     ProductName = x.c.ProductNameSort,
                     KeyItem =x.pro.item.KeyItem??0,
                     Seat=x.pro.item.Seat??0,
                     DynID=x.pro.item.DynId??0,
                     OrderDetailID =x.pro.item.OrderDetailID
                     

                 });
                var openitems = _context.ORDER_DETAIL_DATE.Join(_context.ORDER_OPEN_ITEM, x => x.DynId, openitem => openitem.dynID, (x, openitem) => new { x, openitem })
                            .Where(a => a.x.DynId == a.openitem.dynID && a.x.OrderID==dataOrder.OrderID)
                            .Select(a => new OrderDetailModel()
                            {
                                ProductName = a.openitem.ItemNameShort,
                                Qty = a.x.Qty,
                                Price = a.openitem.UnitPrice,
                                ProductID = a.x.ProductID,
                                Total = a.x.Qty * a.x.Price,
                                OrderID = a.x.OrderID,
                                Satust = a.x.Satust,
                                KeyItem = a.x.KeyItem ?? 0,
                                Seat = a.x.Seat ?? 0,
                                DynID = a.x.DynId ?? 0,
                                OrderDetailID = a.x.OrderDetailID
                            });
                foreach (OrderDetailModel openItem in openitems)
                {
                    OrderMain.addItemToList(openItem);
                }
                foreach(OrderDetailModel item in data)
                {
                    int keyItemOld = item.KeyItem;
                    OrderMain.addItemToList(item);
                    var dataOrderModifire = _context.ORDER_DETAIL_DATE.Join(_context.ORDER_DETAIL_MODIFIRE_DATE, pro => pro.ProductID,
                       modifire => modifire.ProductID, (pro, modifire) => new { pro, modifire })
                       .Join(_context.MODIFIREs, modi => modi.modifire.ModifireID, c => c.ModifireID, (modi, c) => new { modi, c })
                       .Where(x => x.modi.pro.OrderID == item.OrderID && x.modi.modifire.OrderID == item.OrderID && x.modi.pro.ProductID == item.ProductID && x.modi.modifire.ProductID == item.ProductID && x.modi.modifire.ModifireID == x.c.ModifireID && x.modi.modifire.KeyModi == keyItemOld && x.modi.pro.KeyItem ==keyItemOld)
                       .Select(x => new OrderDetailModifireModel()
                       {
                           ModifireID = x.modi.modifire.ModifireID,
                           Price = x.modi.modifire.Price,
                           Qty = x.modi.modifire.Qty,
                           ModifireName = x.c.ModifireName,
                           Total = x.modi.modifire.Price * x.modi.modifire.Qty,
                           Seat = x.modi.modifire.Seat ?? 0,
                           OrderModifireID = x.modi.modifire.OrderModifireID,
                           OrderID = x.modi.pro.OrderID,
                           DynID = x.modi.modifire.DynId ?? 0
                       });
                    foreach (OrderDetailModifireModel itemmodifire in dataOrderModifire)
                    {
                        OrderMain.addModifierToList(itemmodifire, item.KeyItem);
                    }
                    var openItemModiier = _context.ORDER_DETAIL_MODIFIRE_DATE.Join(_context.ORDER_OPEN_ITEM,modi=>modi.DynId,open=>open.dynID,(modi,open)=>new{modi,open})
                        .Where(x=>x.modi.DynId ==x.open.dynID && x.modi.ProductID ==item.ProductID && x.modi.OrderID == item.OrderID && x.modi.KeyModi==keyItemOld)
                        .Select(x=>new OrderDetailModifireModel()
                        {
                            ModifireID = x.modi.ModifireID,
                            Price = x.modi.Price,
                            Qty = x.modi.Qty,
                            ModifireName = x.open.ItemNameShort,
                            Total = x.modi.Price * x.modi.Qty,
                            Seat = x.modi.Seat ?? 0,
                            OrderModifireID = x.modi.OrderModifireID,
                            OrderID = x.modi.OrderID??0,
                            DynID = x.modi.DynId??0
                        });
                    foreach (OrderDetailModifireModel Openitem in openItemModiier)
                    {
                        OrderMain.addModifierToList(Openitem, item.KeyItem);
                    }
                    
                }
            }
            return OrderMain;
        }


        public int CountOrderModifire()
        {
            int OrderModifireID = _context.ORDER_DETAIL_DATE.Count();
            return OrderModifireID;
        }


        public IEnumerable<CardModel> LoadCard()
        {
            var data = _context.Cards.Where(x => x.Status == 0)
                .Select(c => new CardModel { 
                    CardID = c.CardID,
                    CardName = c.CardName,
                    Status = c.Status,
                    SurChart = c.SurChart
                }
                );
            return data;
           
        }

        private ORDER_OPEN_ITEM CopyOpenItem(OrderOpenItemModel item)
        {
            ORDER_OPEN_ITEM items = new ORDER_OPEN_ITEM();
            items.dynID = _context.ORDER_OPEN_ITEM.Count() + 1;
            items.ItemNameShort = item.ItemNameShort;
            items.ItemNameDesc = item.ItemNameDesc;
            items.UnitPrice = item.UnitPrice;
            items.PrintType = item.PrintType;
            items.CreateBy = items.CreateBy;
            items.CreateDate = item.CreateDate;
            items.UpdateBy = item.UpdateBy;
            items.UpdateDate = item.UpdateDate;
            return items;
        }
        public int InsertOpenItem(OrderOpenItemModel OpenItem)
        {
            int flag = 0;
            try
            {
                using (var trans = _context.Database.BeginTransaction())
                {
                    
                    ORDER_OPEN_ITEM item = CopyOpenItem(OpenItem);
                    _context.Entry(item).State = System.Data.Entity.EntityState.Added;
                    _context.SaveChanges();
                    trans.Commit();
                    flag = 1;
                }

            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("OrderService::::::::::::::::::::::InsertOpenItem:::::::::::::::::" + ex.Message);
            }
            return flag;
        }


        public int GetIDLastInsertOpenItem()
        {
            return _context.ORDER_OPEN_ITEM.Count();
           
        }


        public OrderDateModel GetOrderByTKA(string tkaID, string ClientID)
        {
            OrderDateModel OrderTKA = new OrderDateModel();
            try
            {
                var dataOrder = _context.ORDER_DATE.Where(x => x.FloorID == tkaID && x.Status != 1).SingleOrDefault();


                if (dataOrder != null)
                {
                    OrderTKA.Seat = dataOrder.Seat ?? 0;
                    OrderTKA.FloorID = dataOrder.FloorID;
                    OrderTKA.OrderID = dataOrder.OrderID;
                    OrderTKA.TotalAmount = dataOrder.TotalAmount;
                    OrderTKA.ShiftID = dataOrder.ShiftID ?? 0;
                    OrderTKA.CreateBy = dataOrder.CreateBy;
                    OrderTKA.UpdateBy = dataOrder.UpdateBy;
                    var data = _context.ORDER_DATE.Join(_context.ORDER_DETAIL_DATE, order => order.OrderID,
                     item => item.OrderID, (order, item) => new { order, item })
                     .Join(_context.PRODUCTs, pro => pro.item.ProductID, c => c.ProductID, (pro, c) => new { pro, c })
                     .Where(x => x.pro.order.FloorID == dataOrder.FloorID && x.pro.order.OrderID == x.pro.item.OrderID && x.pro.order.OrderID == dataOrder.OrderID && x.pro.item.OrderID == dataOrder.OrderID && x.pro.item.ProductID == x.c.ProductID)
                     .Select(x => new OrderDetailModel()
                     {
                         ProductID = x.pro.item.ProductID,
                         Price = x.pro.item.Price,
                         Qty = x.pro.item.Qty,
                         Total = x.pro.item.Qty * x.pro.item.Price,
                         OrderID = x.pro.item.OrderID,
                         Satust = x.pro.item.Satust,
                         ProductName = x.c.ProductNameSort,
                         KeyItem = x.pro.item.KeyItem ?? 0,
                         Seat = x.pro.item.Seat ?? 0,
                         DynID = x.pro.item.DynId ?? 0,
                         OrderDetailID = x.pro.item.OrderDetailID,
                         
                     });
                    var openitems = _context.ORDER_DETAIL_DATE.Join(_context.ORDER_OPEN_ITEM, x => x.DynId, openitem => openitem.dynID, (x, openitem) => new { x, openitem })
                                .Where(a => a.x.DynId == a.openitem.dynID && a.x.OrderID == dataOrder.OrderID)
                                .Select(a => new OrderDetailModel()
                                {
                                    ProductName = a.openitem.ItemNameShort,
                                    Qty = a.x.Qty,
                                    Price = a.openitem.UnitPrice,
                                    ProductID = a.x.ProductID,
                                    Total = a.x.Qty * a.x.Price,
                                    OrderID = a.x.OrderID,
                                    Satust = a.x.Satust,
                                    KeyItem = a.x.KeyItem ?? 0,
                                    Seat = a.x.Seat ?? 0,
                                    DynID = a.x.DynId ?? 0,
                                    OrderDetailID = a.x.OrderDetailID
                                });
                    foreach (OrderDetailModel openItem in openitems)
                    {
                        OrderTKA.addItemToList(openItem);
                    }
                    foreach (OrderDetailModel item in data)
                    {
                        int keyItemOld = item.KeyItem;
                        OrderTKA.addItemToList(item);
                        var dataOrderModifire = _context.ORDER_DETAIL_DATE.Join(_context.ORDER_DETAIL_MODIFIRE_DATE, pro => pro.ProductID,
                           modifire => modifire.ProductID, (pro, modifire) => new { pro, modifire })
                           .Join(_context.MODIFIREs, modi => modi.modifire.ModifireID, c => c.ModifireID, (modi, c) => new { modi, c })
                           .Where(x => x.modi.pro.OrderID == item.OrderID && x.modi.modifire.OrderID == item.OrderID && x.modi.pro.ProductID == item.ProductID && x.modi.modifire.ProductID == item.ProductID && x.modi.modifire.ModifireID == x.c.ModifireID && x.modi.modifire.KeyModi == keyItemOld && x.modi.pro.KeyItem == keyItemOld)
                           .Select(x => new OrderDetailModifireModel()
                           {
                               ModifireID = x.modi.modifire.ModifireID,
                               Price = x.modi.modifire.Price,
                               Qty = x.modi.modifire.Qty,
                               ModifireName = x.c.ModifireName,
                               Total = x.modi.modifire.Price * x.modi.modifire.Qty,
                               Seat = x.modi.modifire.Seat ?? 0,
                               OrderModifireID = x.modi.modifire.OrderModifireID,
                               OrderID = x.modi.pro.OrderID,
                               DynID = x.modi.modifire.DynId ?? 0
                           });
                        foreach (OrderDetailModifireModel itemmodifire in dataOrderModifire)
                        {
                            OrderTKA.addModifierToList(itemmodifire, item.KeyItem);
                        }
                        var openItemModiier = _context.ORDER_DETAIL_MODIFIRE_DATE.Join(_context.ORDER_OPEN_ITEM, modi => modi.DynId, open => open.dynID, (modi, open) => new { modi, open })
                            .Where(x => x.modi.DynId == x.open.dynID && x.modi.ProductID == item.ProductID && x.modi.OrderID == item.OrderID && x.modi.KeyModi == keyItemOld)
                            .Select(x => new OrderDetailModifireModel()
                            {
                                ModifireID = x.modi.ModifireID,
                                Price = x.modi.Price,
                                Qty = x.modi.Qty,
                                ModifireName = x.open.ItemNameShort,
                                Total = x.modi.Price * x.modi.Qty,
                                Seat = x.modi.Seat ?? 0,
                                OrderModifireID = x.modi.OrderModifireID,
                                OrderID = x.modi.OrderID ?? 0,
                                DynID = x.modi.DynId ?? 0
                            });
                        foreach (OrderDetailModifireModel Openitem in openItemModiier)
                        {
                            OrderTKA.addModifierToList(Openitem, item.KeyItem);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
 
            }
            return OrderTKA;
        }

        public List<OrderTKAModel> GetStatusOrderTKA()
        {
            List<OrderTKAModel> lst = new List<OrderTKAModel>();
            try
            {
                var ListTKA = _context.ORDER_DATE.Join(_context.CLIENTs, order => order.ClientID, client => client.ClientID, (order, client) => new { order, client })
                    .Where(x => x.order.FloorID.Contains("TKA-") && x.order.Status != 1 && x.order.ClientID == x.client.ClientID).ToList();
                foreach (var item in ListTKA)
                {
                    OrderTKAModel items= new OrderTKAModel();
                    items.CusName = item.client.Fname + " " + item.client.Lname;
                    items.CusPhone = item.client.Phone;
                    items.Total = item.order.TotalAmount??0;
                    items.Waiting = item.order.CreateDate ?? DateTime.Now;
                    items.TKAID = item.order.FloorID;
                    lst.Add(items);
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("OrderService::::::::::::::::::::::::GetStatusOrderTKA::::::::::::::::" + ex.Message);
            }
            return lst;
        }


        public int CountTotalEaIn()
        {
            return _context.ORDER_DATE.Where(x => x.Status != 1 &&!x.FloorID.Contains("TKA-")).Count();
        }

        public int CountTotalTKA()
        {
            return _context.ORDER_DATE.Where(x => x.Status != 1 && x.FloorID.Contains("TKA-")).Count();
        }


        public int JoinTable(List<OrderJoinTableModel> OrderJoin)
        {
            int result = 0;
            //update ORDER_DATE set TotalAmount
            try
            {
                int TableNew = OrderJoin[0].TableIDNew;
                double toal=0;
                int OrderIDNew;
                using (var tranJoinTable = _context.Database.BeginTransaction())
                {
                     for (int i = 0; i < OrderJoin.Count; i++)
                     {
                         toal = toal+ OrderJoin[i].SubTotalTable;
                     }
                    ORDER_DATE OrderJoinNew = new ORDER_DATE();
                    OrderJoinNew.FloorID = TableNew.ToString();
                    OrderJoinNew.Seat = 0;
                    OrderJoinNew.TotalAmount = toal;
                    OrderJoinNew.CreateBy = 0;
                    OrderJoinNew.CreateDate = DateTime.Now;
                    OrderJoinNew.UpdateBy = 0;
                    OrderJoinNew.UpdateDate = DateTime.Now;
                    OrderJoinNew.OrderNumber = CountOrder().ToString();
                    OrderJoinNew.ClientID = 0;
                    _context.Entry(OrderJoinNew).State = System.Data.Entity.EntityState.Added;
                    _context.SaveChanges();
                    OrderIDNew = OrderJoinNew.OrderID;
                    for (int j = 0; j < OrderJoin.Count; j++)
                    {
                        _context.Database.ExecuteSqlCommand("update  ORDER_DETAIL_DATE set OrderID='" + OrderIDNew + "',Seat=0 where OrderID='" +OrderJoin[j].OrderID+ "'");
                    }
                    for (int j = 0; j < OrderJoin.Count; j++)
                    {
                        _context.Database.ExecuteSqlCommand("update  ORDER_DETAIL_MODIFIRE_DATE set OrderID='" + OrderIDNew + "',Seat=0 where OrderID='" + OrderJoin[j].OrderID + "'");
                    }
                    for (int i = 0; i < OrderJoin.Count; i++)
                    {
                        
                            _context.Database.ExecuteSqlCommand("delete  ORDER_DATE where OrderID='" + OrderJoin[i].OrderID + "'");
                    }
                    
                    tranJoinTable.Commit();
                    result = 1;
                    
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("OrderService::::::::::::::::::::JoinTable::::::::::::::" + ex.Message);
            }
            return result;
        }



        public int DeleteJoinTableAll(OrderDateModel itemOrder)
        {
            int result = 0;
            try
            {
                ORDER_DATE orderDateTemp = new ORDER_DATE();
                List<ORDER_DETAIL_DATE> lstOrderDetaiDate = new List<ORDER_DETAIL_DATE>();
                List<ORDER_DETAIL_MODIFIRE_DATE> lstOrderDetailModifire = new List<ORDER_DETAIL_MODIFIRE_DATE>();
               
                OrderDateModel orderDateMoldeTemp = new OrderDateModel();
                orderDateMoldeTemp = GetOrderByTable(itemOrder.FloorID, 0);

                if (itemOrder.ListOrderDetail.Count > 0)
                {
                    using (var transaciton = _context.Database.BeginTransaction())
                    {
                        orderDateTemp = CopyOrder(itemOrder);
                        //_context.Entry(orderDateTemp).State = System.Data.Entity.EntityState.Modified;
                        _context.Database.ExecuteSqlCommand("delete from ORDER_DATE  where OrderID='" + itemOrder.OrderID + "'");
                        lstOrderDetaiDate = CopyOrderDetailDate(itemOrder);
                        foreach (ORDER_DETAIL_DATE item in lstOrderDetaiDate)
                        {

                            _context.Database.ExecuteSqlCommand("delete from ORDER_DETAIL_DATE where OrderDetailID='" + item.OrderDetailID + "'");

                        }
                        
                        lstOrderDetailModifire = CopyOrderMidifireDate(itemOrder);
                        foreach (ORDER_DETAIL_MODIFIRE_DATE item in lstOrderDetailModifire)
                        {
                            //_context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                            // _context.ORDER_DETAIL_MODIFIRE_DATE.Remove(item);
                            _context.Database.ExecuteSqlCommand("delete ORDER_DETAIL_MODIFIRE_DATE where OrderModifireID='" + item.OrderModifireID + "'");
                        }
                        _context.SaveChanges();
                        transaciton.Commit();
                        result = 1;
                    }

                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("OrderService::::::::::::::::::::DeleteJoinTableAll::::::::::::::" + ex.Message);
            }
            return result;
        }
    }
}
