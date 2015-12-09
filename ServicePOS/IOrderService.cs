using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicePOS.Model;
using System.Collections;
namespace ServicePOS
{
   public interface IOrderService:IDisposable
    {
       int InsertOrder(OrderModel itemOrder);
       int InsertOrderDetail(OrderDetailModel itemOrderDetail);
       int CheckOrderComplete(OrderModel idOrder);
       IEnumerable<OrderModel> LoadOrder(OrderModel idOrder);
       int UpdateOrder(OrderModel idOrder);
       IEnumerable<OrderModel> GetOrderByTable(int idTable,int idOrder);
    }
}
