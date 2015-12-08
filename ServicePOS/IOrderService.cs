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
       int InsertOrder(Order itemOrder);
       int InsertOrderDetail(OrderDetail itemOrderDetail);
       int CheckOrderComplete(Order idOrder);
       IEnumerable<Order> LoadOrder(Order idOrder);
       int UpdateOrder(Order idOrder);
       IEnumerable<Order> GetOrderByTable(int idTable,int idOrder);
    }
}
