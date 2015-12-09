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
       int InsertOrder(OrderDateModel itemOrder);
       int CheckOrderComplete(OrderDateModel idOrder);
       IEnumerable<OrderDateModel> LoadOrder(OrderDateModel idOrder);
       int UpdateOrder(OrderDateModel idOrder);
       IEnumerable<OrderDateModel> GetOrderByTable(int idTable, int idOrder);
       int CountOrder();
        IEnumerable< StatusTable> GetStatusTable(string TableID);
    }
}
